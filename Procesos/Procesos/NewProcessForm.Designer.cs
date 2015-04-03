namespace Procesos
{
    partial class NewProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.textBoxNombreProceso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(117, 38);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // textBoxNombreProceso
            // 
            this.textBoxNombreProceso.Location = new System.Drawing.Point(80, 12);
            this.textBoxNombreProceso.Name = "textBoxNombreProceso";
            this.textBoxNombreProceso.Size = new System.Drawing.Size(152, 20);
            this.textBoxNombreProceso.TabIndex = 1;
            this.textBoxNombreProceso.Text = ".exe";
            this.textBoxNombreProceso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombreProceso_KeyDown);
            // 
            // NewProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(325, 73);
            this.Controls.Add(this.textBoxNombreProceso);
            this.Controls.Add(this.buttonIniciar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Proceso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewProcessForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TextBox textBoxNombreProceso;
    }
}