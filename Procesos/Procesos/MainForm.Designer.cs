namespace Procesos
{
    partial class MainForm
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProcesosTotatales = new System.Windows.Forms.Label();
            this.labelProcesosSeguros = new System.Windows.Forms.Label();
            this.labelProcesosInseguros = new System.Windows.Forms.Label();
            this.labelProcesosDesconocidos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(21, 12);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(670, 438);
            this.DGV.TabIndex = 0;
            this.DGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_RowsAdded);
            this.DGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_RowsRemoved);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(697, 412);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 38);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesos totales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procesos seguros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Procesos inseguros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(8, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Procesos desconocidos:";
            // 
            // labelProcesosTotatales
            // 
            this.labelProcesosTotatales.AutoSize = true;
            this.labelProcesosTotatales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesosTotatales.Location = new System.Drawing.Point(169, 10);
            this.labelProcesosTotatales.Name = "labelProcesosTotatales";
            this.labelProcesosTotatales.Size = new System.Drawing.Size(32, 16);
            this.labelProcesosTotatales.TabIndex = 4;
            this.labelProcesosTotatales.Text = "XXX";
            // 
            // labelProcesosSeguros
            // 
            this.labelProcesosSeguros.AutoSize = true;
            this.labelProcesosSeguros.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelProcesosSeguros.Location = new System.Drawing.Point(169, 49);
            this.labelProcesosSeguros.Name = "labelProcesosSeguros";
            this.labelProcesosSeguros.Size = new System.Drawing.Size(28, 13);
            this.labelProcesosSeguros.TabIndex = 5;
            this.labelProcesosSeguros.Text = "XXX";
            // 
            // labelProcesosInseguros
            // 
            this.labelProcesosInseguros.AutoSize = true;
            this.labelProcesosInseguros.ForeColor = System.Drawing.Color.DarkRed;
            this.labelProcesosInseguros.Location = new System.Drawing.Point(169, 62);
            this.labelProcesosInseguros.Name = "labelProcesosInseguros";
            this.labelProcesosInseguros.Size = new System.Drawing.Size(28, 13);
            this.labelProcesosInseguros.TabIndex = 6;
            this.labelProcesosInseguros.Text = "XXX";
            // 
            // labelProcesosDesconocidos
            // 
            this.labelProcesosDesconocidos.AutoSize = true;
            this.labelProcesosDesconocidos.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelProcesosDesconocidos.Location = new System.Drawing.Point(169, 75);
            this.labelProcesosDesconocidos.Name = "labelProcesosDesconocidos";
            this.labelProcesosDesconocidos.Size = new System.Drawing.Size(28, 13);
            this.labelProcesosDesconocidos.TabIndex = 7;
            this.labelProcesosDesconocidos.Text = "XXX";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelProcesosDesconocidos);
            this.panel1.Controls.Add(this.labelProcesosInseguros);
            this.panel1.Controls.Add(this.labelProcesosSeguros);
            this.panel1.Controls.Add(this.labelProcesosTotatales);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(697, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 384);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.DGV);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProcesosTotatales;
        private System.Windows.Forms.Label labelProcesosSeguros;
        private System.Windows.Forms.Label labelProcesosInseguros;
        private System.Windows.Forms.Label labelProcesosDesconocidos;
        private System.Windows.Forms.Panel panel1;
    }
}