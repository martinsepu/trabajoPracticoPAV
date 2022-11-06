namespace PavTpGrupo11
{
    partial class ListadoVentas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCamion = new System.Windows.Forms.RadioButton();
            this.rdbObra = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCamion = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PavTpGrupo11.ReporteListadoVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 168);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 282);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtVenta);
            this.groupBox1.Controls.Add(this.txtObra);
            this.groupBox1.Controls.Add(this.txtCamion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbVenta);
            this.groupBox1.Controls.Add(this.rdbObra);
            this.groupBox1.Controls.Add(this.rdbCamion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Ventas";
            // 
            // rdbCamion
            // 
            this.rdbCamion.AutoSize = true;
            this.rdbCamion.Location = new System.Drawing.Point(9, 39);
            this.rdbCamion.Name = "rdbCamion";
            this.rdbCamion.Size = new System.Drawing.Size(138, 21);
            this.rdbCamion.TabIndex = 0;
            this.rdbCamion.TabStop = true;
            this.rdbCamion.Text = "Filtrar por Camion";
            this.rdbCamion.UseVisualStyleBackColor = true;
            this.rdbCamion.CheckedChanged += new System.EventHandler(this.rdbCamion_CheckedChanged);
            // 
            // rdbObra
            // 
            this.rdbObra.AutoSize = true;
            this.rdbObra.Location = new System.Drawing.Point(12, 82);
            this.rdbObra.Name = "rdbObra";
            this.rdbObra.Size = new System.Drawing.Size(123, 21);
            this.rdbObra.TabIndex = 1;
            this.rdbObra.TabStop = true;
            this.rdbObra.Text = "Filtrar por Obra";
            this.rdbObra.UseVisualStyleBackColor = true;
            this.rdbObra.CheckedChanged += new System.EventHandler(this.rdbObra_CheckedChanged);
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(12, 122);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(128, 21);
            this.rdbVenta.TabIndex = 2;
            this.rdbVenta.TabStop = true;
            this.rdbVenta.Text = "Filtrar por Venta";
            this.rdbVenta.UseVisualStyleBackColor = true;
            this.rdbVenta.CheckedChanged += new System.EventHandler(this.rdbVenta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patente Camion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cod. Obra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero Venta:";
            // 
            // txtCamion
            // 
            this.txtCamion.Enabled = false;
            this.txtCamion.Location = new System.Drawing.Point(277, 39);
            this.txtCamion.Name = "txtCamion";
            this.txtCamion.Size = new System.Drawing.Size(100, 23);
            this.txtCamion.TabIndex = 7;
            // 
            // txtObra
            // 
            this.txtObra.Enabled = false;
            this.txtObra.Location = new System.Drawing.Point(277, 81);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(100, 23);
            this.txtObra.TabIndex = 8;
            // 
            // txtVenta
            // 
            this.txtVenta.Enabled = false;
            this.txtVenta.Location = new System.Drawing.Point(277, 123);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 23);
            this.txtVenta.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Actualizar Listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(672, 54);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoVentas";
            this.Load += new System.EventHandler(this.ListadoVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.TextBox txtObra;
        private System.Windows.Forms.TextBox txtCamion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.RadioButton rdbObra;
        private System.Windows.Forms.RadioButton rdbCamion;
    }
}