using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos
{
    public partial class MainForm : Form
    {
        //Atributos

        //Constantes
        Size MINFORMSIZE = new Size(935, 500);
        Int64 TOTALRAM = (Int64)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;

        //Privados
        List<MyProcess> myProcesses;
        Process[] actualProcesses;
        Int64 unitDivisor;
        NewProcessForm npf;

        //Públicos
        public Boolean canUpdate;

        //Constructor
        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            MinimumSize = MINFORMSIZE;

            canUpdate = true;

            myProcesses = new List<MyProcess>();
            actualProcesses = Process.GetProcesses();

            DGV.Columns.Add("ID", "ID");
            DGV.Columns.Add("Nombre del proceso", "Nombre del proceso");
            DGV.Columns.Add("Memoria", "Memoria");
            DGV.Columns.Add("Prioridad", "Prioridad");

            UpdateUnitDivisor();

            UpdateProcesses();
        }

        // |-------------Mis métodos-----------------|

        /* Actualiza la lista de procesos, agregando o eliminando
         * de la lsita myProcesses
         * */
        void UpdateProcesses()
        {
            if (canUpdate)
            {
                //Actualiza los procesos del sistema operativo
                actualProcesses = Process.GetProcesses();

                UpdateNewProcess(actualProcesses);

                UpdateKilledProcess(actualProcesses);

                UpdateMemoryProcesses(actualProcesses);

                UpdateLabels();

                PaintRows();
            }
        }



        /* Actualiza la lista de procesos, agregando o eliminando
         * de la lsita myProcesses
         * */
        void UpdateNewProcess(Process[] actualProcesses)
        {
            for (int i = 0; i < actualProcesses.Length; i++)
            {

                if (!ExistsOnMyProcesses(actualProcesses[i].Id))
                {
                    int id = actualProcesses[i].Id;
                    String name = actualProcesses[i].ProcessName;
                    Int64 memory = actualProcesses[i].WorkingSet64;
                    String category = "Seguro";
                    String priority;
                    try
                    {
                        priority = actualProcesses[i].PriorityClass.ToString();
                    }
                    catch { priority = ""; }
                    MyProcess mp = new MyProcess(id, name, memory, category, priority);
                    myProcesses.Add(mp);
                    DGV.Rows.Add(mp.iD, mp.name, mp.memory, mp.priority);
                }
            }
        }

        /* Actualiza la lista de procesos, agregando o eliminando
         * de la lsita myProcesses
         * */
        void UpdateKilledProcess(Process[] actualProcesses)
        {
            Boolean keepRemoving;

            do
            {
                keepRemoving = false;
                try
                {
                    foreach (MyProcess mp in myProcesses)
                    {
                        if (!ExistsOnActualProcesses(mp.iD))
                        {
                            myProcesses.Remove(mp);
                            DGV.Rows.RemoveAt(GetIndexByID(mp.iD));
                        }
                    }
                }
                catch (InvalidOperationException)
                {
                    keepRemoving = true;
                }
            } while (keepRemoving);
        }

        /* Se encarga de revisar la lista myProcesses
         * y comprobar si un proceso pasado por parámetro
         * existe en la lista usando su ID como comparación
         * */
        Boolean ExistsOnMyProcesses(Int32 ID)
        {
            foreach (MyProcess mp in myProcesses)
            {
                if (ID == mp.iD)
                    return true;
            }

            return false;
        }

        /* Se encarga de revisar el array actualProcesses
         * y comprobar si un proceso pasado por parámetro
         * existe en el array usando su ID como comparación
         * */
        Boolean ExistsOnActualProcesses(Int32 ID)
        {
            for (int i = 0; i < actualProcesses.Length; i++)
            {
                if (ID == actualProcesses[i].Id)
                    return true;
            }

            return false;
        }

        /* Devuelve un proceso de myProcesses con la ID especificada,
         * 
         * Usar solo si existe, sino devuelve null
         * */
        MyProcess GetMyProcessByID(int ID)
        {
            foreach (MyProcess mp in myProcesses)
            {
                if (mp.iD == ID)
                    return mp;
            }

            return null;
        }

        /* Devuelve un de actualProcesses proceso con la ID especificada,
         * 
         * Usar solo si existe, sino devuelve null
         * */
        Process GetProcessByID(int ID)
        {
            for (int i = 0; i < actualProcesses.Length; i++)
            {
                if (actualProcesses[i].Id == ID)
                    return actualProcesses[i];
            }

            return null;
        }

        /* Devuelve el index de un row de DGV dependiendo
         * del ID pasado por parámetro.
         * 
         * Compruebe antes que ese proceso exista, sino devuelve -1
         * */
        Int32 GetIndexByID(Int32 ID)
        {
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                if (Convert.ToInt32(DGV.Rows[i].Cells["ID"].Value) == ID)
                {
                    return i;
                }
            }

            return -1;
        }

        /* Se ecnarga de actualizar la memoria que usa
         * cada proceso en tiempo real
         * */
        void UpdateMemoryProcesses(Process[] actualProcesses)
        {
            foreach (MyProcess mp in myProcesses)
            {
                GetMyProcessByID(mp.iD).memory = GetProcessByID(mp.iD).WorkingSet64;

                //Hace la división de unitDivisor sólo en la DGV.
                DGV.Rows[GetIndexByID(mp.iD)].Cells["Memoria"].Value = mp.memory / unitDivisor;
            }
        }

        /* Actualiza los labeles de cantidad
         * de procesos.
         * */
        void UpdateLabels()
        {
            labelProcesosTotatales.Text = DGV.Rows.Count.ToString();

            int seguros, inseguros, desconocidos;
            Int64 totalRamUsage;
            seguros = inseguros = desconocidos = 0;
            totalRamUsage = 0;

            foreach (MyProcess mp in myProcesses)
            {
                if (mp.category.Equals("Seguro"))
                    seguros++;

                else if (mp.category.Equals("Inseguro"))
                    inseguros++;

                else if (mp.category.Equals("Desconocido"))
                    desconocidos++;

                totalRamUsage += (Int64)mp.memory;
            }

            labelProcesosSeguros.Text = seguros.ToString();
            labelProcesosInseguros.Text = inseguros.ToString();
            labelProcesosDesconocidos.Text = desconocidos.ToString();

            //No sé por qué a veces aparece como negativo :v
            //if (totalRamUsage < 0)
            //  totalRamUsage *= -1;

            labelTotalRam.Text = (totalRamUsage / unitDivisor).ToString() + "/" + TOTALRAM / unitDivisor;

            labelRAMPorcentaje.Text = (totalRamUsage * 100 / (TOTALRAM)).ToString() + " %";
        }

        /* Se encarga de calcular el factor unidad que va
         * a dividir a un valor dependiendo del radioButtonUnit
         * */
        void UpdateUnitDivisor()
        {
            if (radioButtonByte.Checked)
                unitDivisor = 1;

            else if (radioButtonKByte.Checked)
                unitDivisor = 1024;

            else if (radioButtonMByte.Checked)
                unitDivisor = 1024 * 1024;

            else if (radioButtonGByte.Checked)
                unitDivisor = 1024 * 1024 * 1024;
        }

        /* Pinta las filas según su categoría
         * */
        void PaintRows()
        {
            foreach (MyProcess mp in myProcesses)
            {
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    if (mp.iD == Convert.ToInt32(DGV.Rows[i].Cells["ID"].Value))
                    {
                        if (mp.category.Equals("Seguro"))
                            DGV.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;

                        else if (mp.category.Equals("Inseguro"))
                            DGV.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;

                        else if (mp.category.Equals("Desconocido"))
                            DGV.Rows[i].DefaultCellStyle.BackColor = Color.Gray;

                        break;
                    }

                }
            }
        }

        /* Mata al proceso seleccionado de
         * la DGV
         * */
        void KillProcess()
        {
            try
            {
                GetProcessByID(Convert.ToInt32(DGV.SelectedRows[0].Cells["ID"].Value)).Kill();
            }
            catch { MessageBox.Show("No se pudo matar el proceso.", "Advertencia"); }
        }

        // |-------------Eventos-----------------|

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateProcesses();
        }

        private void DGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DGV.SortOrder == SortOrder.Ascending)
                DGV.Sort(DGV.SortedColumn, ListSortDirection.Ascending);

            else if (DGV.SortOrder == SortOrder.Ascending)
                DGV.Sort(DGV.SortedColumn, ListSortDirection.Descending);
        }

        private void DGV_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DGV.SortOrder == SortOrder.Ascending)
                DGV.Sort(DGV.SortedColumn, ListSortDirection.Ascending);

            else if (DGV.SortOrder == SortOrder.Ascending)
                DGV.Sort(DGV.SortedColumn, ListSortDirection.Descending);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateProcesses();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea cerrar Processes protector?", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.No || result == DialogResult.Cancel)
                e.Cancel = true;

        }

        private void radioButtonByte_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonByte.Checked)
                UpdateUnitDivisor();
        }

        private void radioButtonKByte_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKByte.Checked)
                UpdateUnitDivisor();
        }

        private void radioButtonMByte_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMByte.Checked)
                UpdateUnitDivisor();
        }

        private void radioButtonGByte_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGByte.Checked)
                UpdateUnitDivisor();
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            canUpdate = false;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            canUpdate = true;
        }

        private void buttonIniciarProceso_Click(object sender, EventArgs e)
        {
            if (npf != null)
                npf.Dispose();

            npf = new NewProcessForm(this);
            npf.Show();
        }

        private void buttonTerminarProceso_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Está seguro que desea terminar el proceso " + DGV.SelectedRows[0].Cells["Nombre del proceso"].Value.ToString() + ".exe ?", "Confirmación", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    KillProcess();
            }

            else
                MessageBox.Show("Primero seleccione un proceso de la lista.");
        }
    }
}
