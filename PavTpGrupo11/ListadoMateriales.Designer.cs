namespace PavTpGrupo11
{
    partial class ListadoMateriales
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
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCod = new System.Windows.Forms.RadioButton();
            this.rdbProveedores = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PavTpGrupo11.ReporteListadoMateriales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 344);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.txtProv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbCod);
            this.groupBox1.Controls.Add(this.rdbProveedores);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Materiales";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(658, 57);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 27);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Listado";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(658, 25);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 26);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(386, 65);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(130, 23);
            this.txtCod.TabIndex = 6;
            // 
            // txtProv
            // 
            this.txtProv.Enabled = false;
            this.txtProv.Location = new System.Drawing.Point(386, 38);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(130, 23);
            this.txtProv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cod. Material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cod. Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicar Filtros";
            // 
            // rdbCod
            // 
            this.rdbCod.AutoSize = true;
            this.rdbCod.Location = new System.Drawing.Point(13, 66);
            this.rdbCod.Name = "rdbCod";
            this.rdbCod.Size = new System.Drawing.Size(199, 21);
            this.rdbCod.TabIndex = 1;
            this.rdbCod.TabStop = true;
            this.rdbCod.Text = "Filtro de Codigo de Material";
            this.rdbCod.UseVisualStyleBackColor = true;
            this.rdbCod.CheckedChanged += new System.EventHandler(this.rdbCod_CheckedChanged);
            // 
            // rdbProveedores
            // 
            this.rdbProveedores.AutoSize = true;
            this.rdbProveedores.Location = new System.Drawing.Point(13, 39);
            this.rdbProveedores.Name = "rdbProveedores";
            this.rdbProveedores.Size = new System.Drawing.Size(147, 21);
            this.rdbProveedores.TabIndex = 0;
            this.rdbProveedores.TabStop = true;
            this.rdbProveedores.Text = "Filtro de Proveedor";
            this.rdbProveedores.UseVisualStyleBackColor = true;
            this.rdbProveedores.CheckedChanged += new System.EventHandler(this.rdbProveedores_CheckedChanged);
            // 
            // ListadoMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ListadoMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Materiales";
            this.Load += new System.EventHandler(this.ListadoMateriales_Load);
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
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCod;
        private System.Windows.Forms.RadioButton rdbProveedores;
    }
}