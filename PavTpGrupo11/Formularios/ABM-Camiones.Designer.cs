
namespace PavTpGrupo11.Formularios
{
    partial class ABM_Camiones
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
            this.txtCapacidad = new System.Windows.Forms.MaskedTextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.GrillaCamiones = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.bD3K3G11_2022DataSet = new PavTpGrupo11.BD3K3G11_2022DataSet();
            this.camionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camionesTableAdapter = new PavTpGrupo11.BD3K3G11_2022DataSetTableAdapters.CamionesTableAdapter();
            this.camionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G11_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(645, 220);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacidad.Mask = "99999";
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(172, 22);
            this.txtCapacidad.TabIndex = 3;
            this.txtCapacidad.ValidatingType = typeof(int);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(644, 172);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(173, 22);
            this.txtAño.TabIndex = 2;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(644, 71);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(173, 22);
            this.txtPatente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "Capacidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Año del Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Marca del Camion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Patente:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(859, 252);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(129, 32);
            this.btnLimpiarCampos.TabIndex = 7;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(872, 526);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 43);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(644, 123);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(173, 22);
            this.TxtMarca.TabIndex = 1;
            // 
            // GrillaCamiones
            // 
            this.GrillaCamiones.AllowUserToAddRows = false;
            this.GrillaCamiones.AllowUserToDeleteRows = false;
            this.GrillaCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCamiones.Location = new System.Drawing.Point(85, 271);
            this.GrillaCamiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrillaCamiones.Name = "GrillaCamiones";
            this.GrillaCamiones.ReadOnly = true;
            this.GrillaCamiones.RowHeadersWidth = 51;
            this.GrillaCamiones.RowTemplate.Height = 24;
            this.GrillaCamiones.Size = new System.Drawing.Size(557, 217);
            this.GrillaCamiones.TabIndex = 80;
            this.GrillaCamiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaCamiones_CellClick);
            this.GrillaCamiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaCamiones_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PavTpGrupo11.Properties.Resources.transporte_de_camiones_con_materiales_de_construccion;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::PavTpGrupo11.Properties.Resources.boton_eliminar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(484, 532);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 36);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::PavTpGrupo11.Properties.Resources.editar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(277, 532);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 36);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::PavTpGrupo11.Properties.Resources.agregar_usuario;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(85, 532);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bD3K3G11_2022DataSet
            // 
            this.bD3K3G11_2022DataSet.DataSetName = "BD3K3G11_2022DataSet";
            this.bD3K3G11_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camionesBindingSource
            // 
            this.camionesBindingSource.DataMember = "Camiones";
            this.camionesBindingSource.DataSource = this.bD3K3G11_2022DataSet;
            // 
            // camionesTableAdapter
            // 
            this.camionesTableAdapter.ClearBeforeFill = true;
            // 
            // camionesBindingSource1
            // 
            this.camionesBindingSource1.DataMember = "Camiones";
            this.camionesBindingSource1.DataSource = this.bD3K3G11_2022DataSet;
            // 
            // ABM_Camiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(997, 601);
            this.Controls.Add(this.GrillaCamiones);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABM_Camiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Camiones";
            this.Load += new System.EventHandler(this.ABM_Camiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G11_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camionesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.DataGridView GrillaCamiones;
        private BD3K3G11_2022DataSet bD3K3G11_2022DataSet;
        private System.Windows.Forms.BindingSource camionesBindingSource;
        private BD3K3G11_2022DataSetTableAdapters.CamionesTableAdapter camionesTableAdapter;
        private System.Windows.Forms.BindingSource camionesBindingSource1;
    }
}