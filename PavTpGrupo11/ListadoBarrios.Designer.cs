namespace PavTpGrupo11
{
    partial class ListadoBarrios
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdbEmpleados = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PavTpGrupo11.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 179);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1323, 389);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbCodigo);
            this.groupBox1.Controls.Add(this.rdbEmpleados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1468, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Barrios";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(877, 70);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(173, 33);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Listado";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(877, 31);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(173, 32);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(515, 80);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(172, 26);
            this.txtCod.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(515, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Barrio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod. Barrio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicar Filtros";
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(17, 81);
            this.rdbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(153, 24);
            this.rdbCodigo.TabIndex = 1;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Filtro de Codigo ";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            this.rdbCodigo.CheckedChanged += new System.EventHandler(this.rdbCodigo_CheckedChanged);
            // 
            // rdbEmpleados
            // 
            this.rdbEmpleados.AutoSize = true;
            this.rdbEmpleados.Location = new System.Drawing.Point(17, 48);
            this.rdbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEmpleados.Name = "rdbEmpleados";
            this.rdbEmpleados.Size = new System.Drawing.Size(152, 24);
            this.rdbEmpleados.TabIndex = 0;
            this.rdbEmpleados.TabStop = true;
            this.rdbEmpleados.Text = "Filtro de nombre";
            this.rdbEmpleados.UseVisualStyleBackColor = true;
            this.rdbEmpleados.CheckedChanged += new System.EventHandler(this.rdbEmpleados_CheckedChanged);
            // 
            // ListadoBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoBarrios";
            this.Text = "ListadoBarrios";
            this.Load += new System.EventHandler(this.ListadoBarrios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdbEmpleados;
    }
}