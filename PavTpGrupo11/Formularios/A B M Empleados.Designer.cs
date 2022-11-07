
namespace PavTpGrupo11.Formularios
{
    partial class frmABM_EMPLEADOS
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
            this.txtCodigoEMPLEADO = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaEmpleados = new System.Windows.Forms.DataGridView();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCalleNRO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.txttelefonoE = new System.Windows.Forms.MaskedTextBox();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoEMPLEADO
            // 
            this.txtCodigoEMPLEADO.Location = new System.Drawing.Point(553, 123);
            this.txtCodigoEMPLEADO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoEMPLEADO.Name = "txtCodigoEMPLEADO";
            this.txtCodigoEMPLEADO.Size = new System.Drawing.Size(205, 22);
            this.txtCodigoEMPLEADO.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(553, 91);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // GrillaEmpleados
            // 
            this.GrillaEmpleados.AllowUserToAddRows = false;
            this.GrillaEmpleados.AllowUserToDeleteRows = false;
            this.GrillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpleados.Location = new System.Drawing.Point(68, 368);
            this.GrillaEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrillaEmpleados.Name = "GrillaEmpleados";
            this.GrillaEmpleados.ReadOnly = true;
            this.GrillaEmpleados.RowHeadersWidth = 51;
            this.GrillaEmpleados.Size = new System.Drawing.Size(843, 202);
            this.GrillaEmpleados.TabIndex = 18;
            this.GrillaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEmpleados_CellClick);
            this.GrillaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEmpleados_CellContentClick);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(553, 194);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(205, 22);
            this.txtCalle.TabIndex = 3;
            // 
            // txtCalleNRO
            // 
            this.txtCalleNRO.Location = new System.Drawing.Point(553, 226);
            this.txtCalleNRO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalleNRO.Name = "txtCalleNRO";
            this.txtCalleNRO.Size = new System.Drawing.Size(205, 22);
            this.txtCalleNRO.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Numero de Documento:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Barrio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Calle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Numero de Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefono:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(928, 596);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 43);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(887, 310);
            this.BtnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(157, 39);
            this.BtnLimpiarCampos.TabIndex = 10;
            this.BtnLimpiarCampos.Text = "Limpiar campos";
            this.BtnLimpiarCampos.UseVisualStyleBackColor = true;
            this.BtnLimpiarCampos.Click += new System.EventHandler(this.BtnLimpiarCampos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PavTpGrupo11.Properties.Resources._4903903_and_card_id_jobs_loupe_icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::PavTpGrupo11.Properties.Resources.boton_eliminar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(460, 599);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 36);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Image = global::PavTpGrupo11.Properties.Resources.editar;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(255, 599);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(144, 36);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::PavTpGrupo11.Properties.Resources.agregar_usuario;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(63, 599);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 36);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(553, 255);
            this.cmbBarrios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(205, 24);
            this.cmbBarrios.TabIndex = 5;
            // 
            // txttelefonoE
            // 
            this.txttelefonoE.Location = new System.Drawing.Point(553, 158);
            this.txttelefonoE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttelefonoE.Mask = "9999999999";
            this.txttelefonoE.Name = "txttelefonoE";
            this.txttelefonoE.Size = new System.Drawing.Size(205, 22);
            this.txttelefonoE.TabIndex = 2;
            this.txttelefonoE.ValidatingType = typeof(int);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(553, 290);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.Mask = "99999999";
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(205, 22);
            this.txtDocumento.TabIndex = 6;
            this.txtDocumento.ValidatingType = typeof(int);
            // 
            // frmABM_EMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 654);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txttelefonoE);
            this.Controls.Add(this.cmbBarrios);
            this.Controls.Add(this.BtnLimpiarCampos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtCalleNRO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrillaEmpleados);
            this.Controls.Add(this.txtCodigoEMPLEADO);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmABM_EMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmABM_EMPLEADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoEMPLEADO;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaEmpleados;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtCalleNRO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.MaskedTextBox txttelefonoE;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
    }
}