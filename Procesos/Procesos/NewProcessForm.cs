using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos
{
    public partial class NewProcessForm : Form
    {
        //Atributos
        MainForm mainForm;

        //Constructor
        public NewProcessForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

            mainForm.canUpdate = false;

            textBoxNombreProceso.Focus();
            textBoxNombreProceso.Select();
            textBoxNombreProceso.SelectionStart = 0;
        }

        // |---------------Métodos---------------|

        void StartProcess()
        {
            try
            {
                Process process = new Process();

                process.StartInfo.FileName = textBoxNombreProceso.Text;
                process.StartInfo.Arguments = "-n";
                process.Start();
                Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se pudo iniciar el proceso.", "Advertencia");
            }
        }

        // |---------------Eventos---------------|

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (textBoxNombreProceso.Text != String.Empty)
                StartProcess();

            else
                MessageBox.Show("Ingrese el nombre del proceso a iniciar.", "Advertencia");
        }

        private void NewProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.canUpdate = true;
        }

        private void textBoxNombreProceso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                StartProcess();
        }
    }
}
