namespace PavTpGrupo11.Formularios
{
    partial class Registro_Venta
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
            this.grillaHerramientas = new System.Windows.Forms.DataGridView();
            this.cod_herramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaMateriales = new System.Windows.Forms.DataGridView();
            this.cod_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAcumuladoHerra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFechaDev = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioHerramienta = new System.Windows.Forms.TextBox();
            this.cmbHerramienta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregarHerramienta = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodHerramienta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAcumuladoMateriales = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadMat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioMat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.btnAgregarMat = new System.Windows.Forms.Button();
            this.txtNumeroVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCamion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbObra = new System.Windows.Forms.ComboBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.txtFechaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAtraso = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaHerramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateriales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaHerramientas
            // 
            this.grillaHerramientas.AllowUserToAddRows = false;
            this.grillaHerramientas.AllowUserToDeleteRows = false;
            this.grillaHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaHerramientas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_herramienta,
            this.responsable_devolucion,
            this.fecha_devolucion,
            this.precio});
            this.grillaHerramientas.Location = new System.Drawing.Point(8, 201);
            this.grillaHerramientas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grillaHerramientas.Name = "grillaHerramientas";
            this.grillaHerramientas.ReadOnly = true;
            this.grillaHerramientas.RowHeadersWidth = 51;
            this.grillaHerramientas.Size = new System.Drawing.Size(597, 226);
            this.grillaHerramientas.TabIndex = 0;
            // 
            // cod_herramienta
            // 
            this.cod_herramienta.HeaderText = "Codigo de Herramienta";
            this.cod_herramienta.MinimumWidth = 6;
            this.cod_herramienta.Name = "cod_herramienta";
            this.cod_herramienta.ReadOnly = true;
            this.cod_herramienta.Width = 125;
            // 
            // responsable_devolucion
            // 
            this.responsable_devolucion.HeaderText = "Responsable de Devolucion";
            this.responsable_devolucion.MinimumWidth = 6;
            this.responsable_devolucion.Name = "responsable_devolucion";
            this.responsable_devolucion.ReadOnly = true;
            this.responsable_devolucion.Width = 125;
            // 
            // fecha_devolucion
            // 
            this.fecha_devolucion.HeaderText = "Fecha de Devolucion";
            this.fecha_devolucion.MinimumWidth = 6;
            this.fecha_devolucion.Name = "fecha_devolucion";
            this.fecha_devolucion.ReadOnly = true;
            this.fecha_devolucion.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // grillaMateriales
            // 
            this.grillaMateriales.AllowUserToAddRows = false;
            this.grillaMateriales.AllowUserToDeleteRows = false;
            this.grillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_material,
            this.cantidad,
            this.precio_material,
            this.total});
            this.grillaMateriales.Location = new System.Drawing.Point(0, 201);
            this.grillaMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grillaMateriales.Name = "grillaMateriales";
            this.grillaMateriales.ReadOnly = true;
            this.grillaMateriales.RowHeadersWidth = 51;
            this.grillaMateriales.Size = new System.Drawing.Size(603, 226);
            this.grillaMateriales.TabIndex = 1;
            // 
            // cod_material
            // 
            this.cod_material.HeaderText = "Codigo de Material";
            this.cod_material.MinimumWidth = 6;
            this.cod_material.Name = "cod_material";
            this.cod_material.ReadOnly = true;
            this.cod_material.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // precio_material
            // 
            this.precio_material.HeaderText = "Precio";
            this.precio_material.MinimumWidth = 6;
            this.precio_material.Name = "precio_material";
            this.precio_material.ReadOnly = true;
            this.precio_material.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Precio Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtAcumuladoHerra);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtFechaDev);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbResponsable);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.grillaHerramientas);
            this.groupBox1.Controls.Add(this.txtPrecioHerramienta);
            this.groupBox1.Controls.Add(this.cmbHerramienta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAgregarHerramienta);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCodHerramienta);
            this.groupBox1.Location = new System.Drawing.Point(16, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 473);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Herramientas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 438);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Precio Acumulado:";
            // 
            // txtAcumuladoHerra
            // 
            this.txtAcumuladoHerra.Enabled = false;
            this.txtAcumuladoHerra.Location = new System.Drawing.Point(445, 434);
            this.txtAcumuladoHerra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAcumuladoHerra.Name = "txtAcumuladoHerra";
            this.txtAcumuladoHerra.Size = new System.Drawing.Size(159, 22);
            this.txtAcumuladoHerra.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Fecha Devolucion:";
            // 
            // txtFechaDev
            // 
            this.txtFechaDev.Location = new System.Drawing.Point(217, 130);
            this.txtFechaDev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaDev.Mask = "00/00/0000 00:00";
            this.txtFechaDev.Name = "txtFechaDev";
            this.txtFechaDev.Size = new System.Drawing.Size(160, 22);
            this.txtFechaDev.TabIndex = 3;
            this.txtFechaDev.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cod. Responsable Devolucion:";
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(217, 167);
            this.cmbResponsable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(160, 24);
            this.cmbResponsable.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Herramienta:";
            // 
            // txtPrecioHerramienta
            // 
            this.txtPrecioHerramienta.Enabled = false;
            this.txtPrecioHerramienta.Location = new System.Drawing.Point(217, 98);
            this.txtPrecioHerramienta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioHerramienta.Name = "txtPrecioHerramienta";
            this.txtPrecioHerramienta.Size = new System.Drawing.Size(159, 22);
            this.txtPrecioHerramienta.TabIndex = 2;
            // 
            // cmbHerramienta
            // 
            this.cmbHerramienta.FormattingEnabled = true;
            this.cmbHerramienta.Location = new System.Drawing.Point(216, 33);
            this.cmbHerramienta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHerramienta.Name = "cmbHerramienta";
            this.cmbHerramienta.Size = new System.Drawing.Size(160, 24);
            this.cmbHerramienta.TabIndex = 0;
            this.cmbHerramienta.SelectedValueChanged += new System.EventHandler(this.cmbHerramienta_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Precio:";
            // 
            // btnAgregarHerramienta
            // 
            this.btnAgregarHerramienta.Location = new System.Drawing.Point(505, 165);
            this.btnAgregarHerramienta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarHerramienta.Name = "btnAgregarHerramienta";
            this.btnAgregarHerramienta.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarHerramienta.TabIndex = 5;
            this.btnAgregarHerramienta.Text = "Agregar";
            this.btnAgregarHerramienta.UseVisualStyleBackColor = true;
            this.btnAgregarHerramienta.Click += new System.EventHandler(this.btnAgregarHerramienta_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Codigo:";
            // 
            // txtCodHerramienta
            // 
            this.txtCodHerramienta.Enabled = false;
            this.txtCodHerramienta.Location = new System.Drawing.Point(217, 66);
            this.txtCodHerramienta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodHerramienta.Name = "txtCodHerramienta";
            this.txtCodHerramienta.Size = new System.Drawing.Size(159, 22);
            this.txtCodHerramienta.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtAcumuladoMateriales);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCantidadMat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPrecioMat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbMaterial);
            this.groupBox2.Controls.Add(this.btnAgregarMat);
            this.groupBox2.Controls.Add(this.grillaMateriales);
            this.groupBox2.Location = new System.Drawing.Point(637, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(616, 473);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materiales";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(307, 441);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 36;
            this.label16.Text = "Precio Acumulado:";
            // 
            // txtAcumuladoMateriales
            // 
            this.txtAcumuladoMateriales.Enabled = false;
            this.txtAcumuladoMateriales.Location = new System.Drawing.Point(443, 437);
            this.txtAcumuladoMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAcumuladoMateriales.Name = "txtAcumuladoMateriales";
            this.txtAcumuladoMateriales.Size = new System.Drawing.Size(159, 22);
            this.txtAcumuladoMateriales.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad:";
            // 
            // txtCantidadMat
            // 
            this.txtCantidadMat.Location = new System.Drawing.Point(84, 102);
            this.txtCantidadMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadMat.Name = "txtCantidadMat";
            this.txtCantidadMat.Size = new System.Drawing.Size(159, 22);
            this.txtCantidadMat.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Material:";
            // 
            // txtPrecioMat
            // 
            this.txtPrecioMat.Enabled = false;
            this.txtPrecioMat.Location = new System.Drawing.Point(85, 69);
            this.txtPrecioMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioMat.Name = "txtPrecioMat";
            this.txtPrecioMat.Size = new System.Drawing.Size(159, 22);
            this.txtPrecioMat.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Precio:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(84, 33);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(160, 24);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.SelectedValueChanged += new System.EventHandler(this.cmbMaterial_SelectedValueChanged);
            // 
            // btnAgregarMat
            // 
            this.btnAgregarMat.Location = new System.Drawing.Point(503, 167);
            this.btnAgregarMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarMat.Name = "btnAgregarMat";
            this.btnAgregarMat.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarMat.TabIndex = 4;
            this.btnAgregarMat.Text = "Agregar";
            this.btnAgregarMat.UseVisualStyleBackColor = true;
            this.btnAgregarMat.Click += new System.EventHandler(this.btnAgregarMat_Click);
            // 
            // txtNumeroVenta
            // 
            this.txtNumeroVenta.Enabled = false;
            this.txtNumeroVenta.Location = new System.Drawing.Point(488, 57);
            this.txtNumeroVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.Size = new System.Drawing.Size(132, 22);
            this.txtNumeroVenta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dias de Atraso:";
            // 
            // cmbCamion
            // 
            this.cmbCamion.FormattingEnabled = true;
            this.cmbCamion.Location = new System.Drawing.Point(728, 49);
            this.cmbCamion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(160, 24);
            this.cmbCamion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Camion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Obra:";
            // 
            // cmbObra
            // 
            this.cmbObra.FormattingEnabled = true;
            this.cmbObra.Location = new System.Drawing.Point(728, 85);
            this.cmbObra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(160, 24);
            this.cmbObra.TabIndex = 3;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(1105, 650);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(148, 28);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "Registrar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(489, 121);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaEntrega.Mask = "00/00/0000 00:00";
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(132, 22);
            this.txtFechaEntrega.TabIndex = 1;
            this.txtFechaEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Fecha Hora Entrega:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PavTpGrupo11.Properties.Resources.ventas;
            this.pictureBox1.Location = new System.Drawing.Point(24, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(949, 124);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 28);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(949, 650);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver a Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAtraso
            // 
            this.txtAtraso.Location = new System.Drawing.Point(488, 89);
            this.txtAtraso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAtraso.Mask = "99999";
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(132, 22);
            this.txtAtraso.TabIndex = 0;
            this.txtAtraso.ValidatingType = typeof(int);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(657, 656);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "Monto Total:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(771, 652);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(159, 23);
            this.txtMonto.TabIndex = 37;
            // 
            // Registro_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 700);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtAtraso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.cmbObra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCamion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro_Venta";
            this.Text = "Registro Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaHerramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateriales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaHerramientas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_herramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable_devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridView grillaMateriales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtFechaDev;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioHerramienta;
        private System.Windows.Forms.ComboBox cmbHerramienta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarHerramienta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodHerramienta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadMat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioMat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnAgregarMat;
        private System.Windows.Forms.TextBox txtNumeroVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCamion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbObra;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.MaskedTextBox txtFechaEntrega;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtAtraso;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAcumuladoHerra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAcumuladoMateriales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}