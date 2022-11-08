namespace PavTpGrupo11.Formularios
{
    partial class ABM_Proveedores
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
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.txt_TelefonoProv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CodProv = new System.Windows.Forms.TextBox();
            this.txt_NombreProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MailProv = new System.Windows.Forms.TextBox();
            this.txt_CalleProv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NroDeCalleProv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_LimpiarCamposProv = new System.Windows.Forms.Button();
            this.btn_BorrarProv = new System.Windows.Forms.Button();
            this.Btn_ModificarProv = new System.Windows.Forms.Button();
            this.btn_AgregarProv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.AllowUserToAddRows = false;
            this.grillaProveedores.AllowUserToDeleteRows = false;
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Location = new System.Drawing.Point(89, 246);
            this.grillaProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.RowHeadersWidth = 51;
            this.grillaProveedores.Size = new System.Drawing.Size(824, 238);
            this.grillaProveedores.TabIndex = 0;
            this.grillaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellClick);
            // 
            // txt_TelefonoProv
            // 
            this.txt_TelefonoProv.Location = new System.Drawing.Point(503, 79);
            this.txt_TelefonoProv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TelefonoProv.Name = "txt_TelefonoProv";
            this.txt_TelefonoProv.Size = new System.Drawing.Size(205, 22);
            this.txt_TelefonoProv.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Telefono:";
            // 
            // txt_CodProv
            // 
            this.txt_CodProv.Location = new System.Drawing.Point(503, 15);
            this.txt_CodProv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodProv.Name = "txt_CodProv";
            this.txt_CodProv.Size = new System.Drawing.Size(205, 22);
            this.txt_CodProv.TabIndex = 0;
            // 
            // txt_NombreProv
            // 
            this.txt_NombreProv.Location = new System.Drawing.Point(503, 47);
            this.txt_NombreProv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreProv.Name = "txt_NombreProv";
            this.txt_NombreProv.Size = new System.Drawing.Size(205, 22);
            this.txt_NombreProv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Barrio:";
            // 
            // txt_MailProv
            // 
            this.txt_MailProv.Location = new System.Drawing.Point(503, 111);
            this.txt_MailProv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MailProv.Name = "txt_MailProv";
            this.txt_MailProv.Size = new System.Drawing.Size(205, 22);
            this.txt_MailProv.TabIndex = 3;
            // 
            // txt_CalleProv
            // 
            this.txt_CalleProv.Location = new System.Drawing.Point(503, 143);
            this.txt_CalleProv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CalleProv.Name = "txt_CalleProv";
            this.txt_CalleProv.Size = new System.Drawing.Size(205, 22);
            this.txt_CalleProv.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Calle:";
            // 
            // txt_NroDeCalleProv
            // 
            this.txt_NroDeCalleProv.Location = new System.Drawing.Point(503, 175);
            this.txt_NroDeCalleProv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NroDeCalleProv.Name = "txt_NroDeCalleProv";
            this.txt_NroDeCalleProv.Size = new System.Drawing.Size(205, 22);
            this.txt_NroDeCalleProv.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nro de Calle:";
            // 
            // Btn_LimpiarCamposProv
            // 
            this.Btn_LimpiarCamposProv.Location = new System.Drawing.Point(756, 198);
            this.Btn_LimpiarCamposProv.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LimpiarCamposProv.Name = "Btn_LimpiarCamposProv";
            this.Btn_LimpiarCamposProv.Size = new System.Drawing.Size(157, 39);
            this.Btn_LimpiarCamposProv.TabIndex = 10;
            this.Btn_LimpiarCamposProv.Text = "Limpiar campos";
            this.Btn_LimpiarCamposProv.UseVisualStyleBackColor = true;
            this.Btn_LimpiarCamposProv.Click += new System.EventHandler(this.Btn_LimpiarCamposProv_Click);
            // 
            // btn_BorrarProv
            // 
            this.btn_BorrarProv.Image = global::PavTpGrupo11.Properties.Resources.boton_eliminar;
            this.btn_BorrarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BorrarProv.Location = new System.Drawing.Point(641, 503);
            this.btn_BorrarProv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BorrarProv.Name = "btn_BorrarProv";
            this.btn_BorrarProv.Size = new System.Drawing.Size(144, 36);
            this.btn_BorrarProv.TabIndex = 9;
            this.btn_BorrarProv.Text = "Borrar";
            this.btn_BorrarProv.UseVisualStyleBackColor = true;
            this.btn_BorrarProv.Click += new System.EventHandler(this.btn_BorrarProv_Click);
            // 
            // Btn_ModificarProv
            // 
            this.Btn_ModificarProv.Image = global::PavTpGrupo11.Properties.Resources.editar;
            this.Btn_ModificarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ModificarProv.Location = new System.Drawing.Point(436, 503);
            this.Btn_ModificarProv.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ModificarProv.Name = "Btn_ModificarProv";
            this.Btn_ModificarProv.Size = new System.Drawing.Size(144, 36);
            this.Btn_ModificarProv.TabIndex = 8;
            this.Btn_ModificarProv.Text = "Modificar";
            this.Btn_ModificarProv.UseVisualStyleBackColor = true;
            this.Btn_ModificarProv.Click += new System.EventHandler(this.Btn_ModificarProv_Click);
            // 
            // btn_AgregarProv
            // 
            this.btn_AgregarProv.ForeColor = System.Drawing.Color.Black;
            this.btn_AgregarProv.Image = global::PavTpGrupo11.Properties.Resources.agregar_usuario;
            this.btn_AgregarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarProv.Location = new System.Drawing.Point(244, 503);
            this.btn_AgregarProv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarProv.Name = "btn_AgregarProv";
            this.btn_AgregarProv.Size = new System.Drawing.Size(144, 36);
            this.btn_AgregarProv.TabIndex = 7;
            this.btn_AgregarProv.Text = "Agregar ";
            this.btn_AgregarProv.UseVisualStyleBackColor = true;
            this.btn_AgregarProv.Click += new System.EventHandler(this.btn_AgregarProv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PavTpGrupo11.Properties.Resources.proveedor_hotelero;
            this.pictureBox1.Location = new System.Drawing.Point(89, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(869, 500);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 43);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(503, 208);
            this.cmbBarrios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(205, 24);
            this.cmbBarrios.TabIndex = 6;
            // 
            // ABM_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbBarrios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Btn_LimpiarCamposProv);
            this.Controls.Add(this.btn_BorrarProv);
            this.Controls.Add(this.Btn_ModificarProv);
            this.Controls.Add(this.btn_AgregarProv);
            this.Controls.Add(this.txt_NroDeCalleProv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MailProv);
            this.Controls.Add(this.txt_CalleProv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TelefonoProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CodProv);
            this.Controls.Add(this.txt_NombreProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grillaProveedores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABM_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Proveedores";
            this.Load += new System.EventHandler(this.ABM_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TelefonoProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CodProv;
        private System.Windows.Forms.TextBox txt_NombreProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MailProv;
        private System.Windows.Forms.TextBox txt_CalleProv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NroDeCalleProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BorrarProv;
        private System.Windows.Forms.Button Btn_ModificarProv;
        private System.Windows.Forms.Button btn_AgregarProv;
        private System.Windows.Forms.Button Btn_LimpiarCamposProv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbBarrios;
    }
}