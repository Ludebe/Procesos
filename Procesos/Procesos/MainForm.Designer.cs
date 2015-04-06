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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelProcesos = new System.Windows.Forms.Panel();
            this.labelProcesosDesconocidos = new System.Windows.Forms.Label();
            this.labelProcesosInseguros = new System.Windows.Forms.Label();
            this.labelProcesosSeguros = new System.Windows.Forms.Label();
            this.labelProcesosTotatales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUnidades = new System.Windows.Forms.Panel();
            this.radioButtonGByte = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonMByte = new System.Windows.Forms.RadioButton();
            this.radioButtonKByte = new System.Windows.Forms.RadioButton();
            this.radioButtonByte = new System.Windows.Forms.RadioButton();
            this.panelRAM = new System.Windows.Forms.Panel();
            this.labelRAMPorcentaje = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalRam = new System.Windows.Forms.Label();
            this.buttonTerminarProceso = new System.Windows.Forms.Button();
            this.buttonIniciarProceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panelProcesos.SuspendLayout();
            this.panelUnidades.SuspendLayout();
            this.panelRAM.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(3, 3);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(670, 430);
            this.DGV.TabIndex = 0;
            this.DGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_RowsAdded);
            this.DGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_RowsRemoved);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 750;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.DGV);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(679, 438);
            this.mainPanel.TabIndex = 11;
            // 
            // panelProcesos
            // 
            this.panelProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProcesos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelProcesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcesos.Controls.Add(this.labelProcesosDesconocidos);
            this.panelProcesos.Controls.Add(this.labelProcesosInseguros);
            this.panelProcesos.Controls.Add(this.labelProcesosSeguros);
            this.panelProcesos.Controls.Add(this.labelProcesosTotatales);
            this.panelProcesos.Controls.Add(this.label4);
            this.panelProcesos.Controls.Add(this.label3);
            this.panelProcesos.Controls.Add(this.label2);
            this.panelProcesos.Controls.Add(this.label1);
            this.panelProcesos.Location = new System.Drawing.Point(698, 12);
            this.panelProcesos.Name = "panelProcesos";
            this.panelProcesos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelProcesos.Size = new System.Drawing.Size(209, 99);
            this.panelProcesos.TabIndex = 12;
            // 
            // labelProcesosDesconocidos
            // 
            this.labelProcesosDesconocidos.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelProcesosDesconocidos.Location = new System.Drawing.Point(130, 75);
            this.labelProcesosDesconocidos.Name = "labelProcesosDesconocidos";
            this.labelProcesosDesconocidos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProcesosDesconocidos.Size = new System.Drawing.Size(71, 13);
            this.labelProcesosDesconocidos.TabIndex = 7;
            this.labelProcesosDesconocidos.Text = "XXX";
            // 
            // labelProcesosInseguros
            // 
            this.labelProcesosInseguros.ForeColor = System.Drawing.Color.DarkRed;
            this.labelProcesosInseguros.Location = new System.Drawing.Point(130, 62);
            this.labelProcesosInseguros.Name = "labelProcesosInseguros";
            this.labelProcesosInseguros.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProcesosInseguros.Size = new System.Drawing.Size(71, 13);
            this.labelProcesosInseguros.TabIndex = 6;
            this.labelProcesosInseguros.Text = "XXX";
            // 
            // labelProcesosSeguros
            // 
            this.labelProcesosSeguros.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelProcesosSeguros.Location = new System.Drawing.Point(130, 49);
            this.labelProcesosSeguros.Name = "labelProcesosSeguros";
            this.labelProcesosSeguros.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProcesosSeguros.Size = new System.Drawing.Size(71, 13);
            this.labelProcesosSeguros.TabIndex = 5;
            this.labelProcesosSeguros.Text = "XXX";
            // 
            // labelProcesosTotatales
            // 
            this.labelProcesosTotatales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcesosTotatales.Location = new System.Drawing.Point(126, 10);
            this.labelProcesosTotatales.Name = "labelProcesosTotatales";
            this.labelProcesosTotatales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProcesosTotatales.Size = new System.Drawing.Size(75, 16);
            this.labelProcesosTotatales.TabIndex = 4;
            this.labelProcesosTotatales.Text = "XXX";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesos totales:";
            // 
            // panelUnidades
            // 
            this.panelUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUnidades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUnidades.Controls.Add(this.radioButtonGByte);
            this.panelUnidades.Controls.Add(this.label7);
            this.panelUnidades.Controls.Add(this.radioButtonMByte);
            this.panelUnidades.Controls.Add(this.radioButtonKByte);
            this.panelUnidades.Controls.Add(this.radioButtonByte);
            this.panelUnidades.Location = new System.Drawing.Point(698, 163);
            this.panelUnidades.Name = "panelUnidades";
            this.panelUnidades.Size = new System.Drawing.Size(209, 45);
            this.panelUnidades.TabIndex = 14;
            // 
            // radioButtonGByte
            // 
            this.radioButtonGByte.AutoSize = true;
            this.radioButtonGByte.Location = new System.Drawing.Point(160, 19);
            this.radioButtonGByte.Name = "radioButtonGByte";
            this.radioButtonGByte.Size = new System.Drawing.Size(39, 17);
            this.radioButtonGByte.TabIndex = 3;
            this.radioButtonGByte.Text = "Gb";
            this.radioButtonGByte.UseVisualStyleBackColor = true;
            this.radioButtonGByte.CheckedChanged += new System.EventHandler(this.radioButtonGByte_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Escala de unidades:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonMByte
            // 
            this.radioButtonMByte.AutoSize = true;
            this.radioButtonMByte.Location = new System.Drawing.Point(103, 19);
            this.radioButtonMByte.Name = "radioButtonMByte";
            this.radioButtonMByte.Size = new System.Drawing.Size(40, 17);
            this.radioButtonMByte.TabIndex = 2;
            this.radioButtonMByte.Text = "Mb";
            this.radioButtonMByte.UseVisualStyleBackColor = true;
            this.radioButtonMByte.CheckedChanged += new System.EventHandler(this.radioButtonMByte_CheckedChanged);
            // 
            // radioButtonKByte
            // 
            this.radioButtonKByte.AutoSize = true;
            this.radioButtonKByte.Checked = true;
            this.radioButtonKByte.Location = new System.Drawing.Point(50, 19);
            this.radioButtonKByte.Name = "radioButtonKByte";
            this.radioButtonKByte.Size = new System.Drawing.Size(38, 17);
            this.radioButtonKByte.TabIndex = 1;
            this.radioButtonKByte.TabStop = true;
            this.radioButtonKByte.Text = "Kb";
            this.radioButtonKByte.UseVisualStyleBackColor = true;
            this.radioButtonKByte.CheckedChanged += new System.EventHandler(this.radioButtonKByte_CheckedChanged);
            // 
            // radioButtonByte
            // 
            this.radioButtonByte.AutoSize = true;
            this.radioButtonByte.Location = new System.Drawing.Point(9, 19);
            this.radioButtonByte.Name = "radioButtonByte";
            this.radioButtonByte.Size = new System.Drawing.Size(31, 17);
            this.radioButtonByte.TabIndex = 0;
            this.radioButtonByte.Text = "b";
            this.radioButtonByte.UseVisualStyleBackColor = true;
            this.radioButtonByte.CheckedChanged += new System.EventHandler(this.radioButtonByte_CheckedChanged);
            // 
            // panelRAM
            // 
            this.panelRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRAM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRAM.Controls.Add(this.labelRAMPorcentaje);
            this.panelRAM.Controls.Add(this.label6);
            this.panelRAM.Controls.Add(this.labelTotalRam);
            this.panelRAM.Location = new System.Drawing.Point(698, 117);
            this.panelRAM.Name = "panelRAM";
            this.panelRAM.Size = new System.Drawing.Size(209, 40);
            this.panelRAM.TabIndex = 13;
            // 
            // labelRAMPorcentaje
            // 
            this.labelRAMPorcentaje.AutoSize = true;
            this.labelRAMPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAMPorcentaje.Location = new System.Drawing.Point(166, 16);
            this.labelRAMPorcentaje.Name = "labelRAMPorcentaje";
            this.labelRAMPorcentaje.Size = new System.Drawing.Size(32, 16);
            this.labelRAMPorcentaje.TabIndex = 10;
            this.labelRAMPorcentaje.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "RAM total en uso:";
            // 
            // labelTotalRam
            // 
            this.labelTotalRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRam.Location = new System.Drawing.Point(11, 16);
            this.labelTotalRam.Name = "labelTotalRam";
            this.labelTotalRam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTotalRam.Size = new System.Drawing.Size(154, 16);
            this.labelTotalRam.TabIndex = 9;
            this.labelTotalRam.Text = "XXX";
            this.labelTotalRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTerminarProceso
            // 
            this.buttonTerminarProceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTerminarProceso.Location = new System.Drawing.Point(804, 214);
            this.buttonTerminarProceso.Name = "buttonTerminarProceso";
            this.buttonTerminarProceso.Size = new System.Drawing.Size(103, 23);
            this.buttonTerminarProceso.TabIndex = 15;
            this.buttonTerminarProceso.Text = "Terminar proceso";
            this.buttonTerminarProceso.UseVisualStyleBackColor = true;
            this.buttonTerminarProceso.Click += new System.EventHandler(this.buttonTerminarProceso_Click);
            // 
            // buttonIniciarProceso
            // 
            this.buttonIniciarProceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIniciarProceso.Location = new System.Drawing.Point(695, 214);
            this.buttonIniciarProceso.Name = "buttonIniciarProceso";
            this.buttonIniciarProceso.Size = new System.Drawing.Size(103, 23);
            this.buttonIniciarProceso.TabIndex = 16;
            this.buttonIniciarProceso.Text = "Iniciar proceso";
            this.buttonIniciarProceso.UseVisualStyleBackColor = true;
            this.buttonIniciarProceso.Click += new System.EventHandler(this.buttonIniciarProceso_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 462);
            this.Controls.Add(this.buttonIniciarProceso);
            this.Controls.Add(this.buttonTerminarProceso);
            this.Controls.Add(this.panelProcesos);
            this.Controls.Add(this.panelUnidades);
            this.Controls.Add(this.panelRAM);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Processes protector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panelProcesos.ResumeLayout(false);
            this.panelProcesos.PerformLayout();
            this.panelUnidades.ResumeLayout(false);
            this.panelUnidades.PerformLayout();
            this.panelRAM.ResumeLayout(false);
            this.panelRAM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelProcesos;
        private System.Windows.Forms.Label labelProcesosDesconocidos;
        private System.Windows.Forms.Label labelProcesosInseguros;
        private System.Windows.Forms.Label labelProcesosSeguros;
        private System.Windows.Forms.Label labelProcesosTotatales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUnidades;
        private System.Windows.Forms.RadioButton radioButtonGByte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonMByte;
        private System.Windows.Forms.RadioButton radioButtonKByte;
        private System.Windows.Forms.RadioButton radioButtonByte;
        private System.Windows.Forms.Panel panelRAM;
        private System.Windows.Forms.Label labelRAMPorcentaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalRam;
        private System.Windows.Forms.Button buttonTerminarProceso;
        private System.Windows.Forms.Button buttonIniciarProceso;
    }
}