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
        List<MyProcess> myProcesses;
        Process[] actualProcesses;

        //Constructor
        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            myProcesses = new List<MyProcess>();
            actualProcesses = Process.GetProcesses();

            DGV.Columns.Add("ID", "ID");
            DGV.Columns.Add("Nombre del proceso", "Nombre del proceso");
            DGV.Columns.Add("Memoria (MB)", "Memoria (MB)");
            DGV.Columns.Add("Prioridad", "Prioridad");

            UpdateProcesses();
        }

        // |-------------Mis métodos-----------------|

        /* Actualiza la lista de procesos, agregando o eliminando
         * de la lsita myProcesses
         * */
        void UpdateProcesses()
        {
            //Actualiza los procesos del sistema operativo
            actualProcesses = Process.GetProcesses();

            UpdateNewProcess(actualProcesses);

            UpdateKilledProcess(actualProcesses);

            UpdateLabels();

            PaintRows();
        }



        /* Actualiza la lista de procesos, agregando o eliminando
         * de la lsita myProcesses
         * */
        void UpdateNewProcess(Process[] actualProcesses)
        {
            for (int i = 0; i < actualProcesses.Length; i++)
                if (!ExistsOnMyProcesses(actualProcesses[i]))
                {
                    int id = actualProcesses[i].Id;
                    String name = actualProcesses[i].ProcessName;
                    long memory = actualProcesses[i].WorkingSet64 / 1024 / 1024;
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
                        if (!ExistsOnActualProcesses(mp))
                        {
                            myProcesses.Remove(mp);
                            for (int i = 0; i < DGV.Rows.Count; i++)
                                if (Convert.ToInt32(DGV.Rows[i].Cells["ID"].Value) == mp.iD)
                                    DGV.Rows.RemoveAt(i);
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
        Boolean ExistsOnMyProcesses(Process p)
        {
            foreach (MyProcess mp in myProcesses)
            {
                if (p.Id == mp.iD)
                    return true;
            }

            return false;
        }

        /* Se encarga de revisar el array actualProcesses
         * y comprobar si un proceso pasado por parámetro
         * existe en el array usando su ID como comparación
         * */
        Boolean ExistsOnActualProcesses(MyProcess p)
        {
            for (int i = 0; i < actualProcesses.Length; i++)
            {
                if (p.iD == actualProcesses[i].Id)
                    return true;
            }

            return false;
        }

        /* Actualiza los labeles de cantidad
         * de procesos.
         * */
        void UpdateLabels()
        {
            labelProcesosTotatales.Text = DGV.Rows.Count.ToString();

            int seguros, inseguros, desconocidos;
            seguros = inseguros = desconocidos = 0;

            foreach (MyProcess mp in myProcesses)
            {
                if (mp.category.Equals("Seguro"))
                    seguros++;

                else if (mp.category.Equals("Inseguro"))
                    inseguros++;

                else if (mp.category.Equals("Desconocido"))
                    desconocidos++;


            }

            labelProcesosSeguros.Text = seguros.ToString();
            labelProcesosInseguros.Text = inseguros.ToString();
            labelProcesosDesconocidos.Text = desconocidos.ToString();
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
                            DGV.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;

                        else if (mp.category.Equals("Inseguro"))
                            DGV.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;

                        else if (mp.category.Equals("Desconocido"))
                            DGV.Rows[i].DefaultCellStyle.BackColor = Color.Gray;

                        break;
                    }

                }
            }
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

    }
}
