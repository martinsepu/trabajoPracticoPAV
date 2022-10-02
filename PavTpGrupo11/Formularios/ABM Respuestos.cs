using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.AccesoADatos;
using PavTpGrupo11.Entidades;



namespace PavTpGrupo11.Formularios
{
    public partial class ABM_Respuestos : Form
    {
        AD_Respuestos repuestoN = new AD_Respuestos();
        public ABM_Respuestos()
        {
            InitializeComponent();
        }

        private void ABM_Respuestos_Load(object sender, EventArgs e)
        {
            GrillaRepuestos.DataSource = repuestoN.ObtenerRepuestos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") || txtNombre.Text.Equals(""))
            {

                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta el repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Repuesto repuesto = new Repuesto(int.Parse(txtCodigo.Text), txtNombre.Text);
                
                {

                    try
                    {

                        int resultado = repuestoN.InsertarRespuesto(repuesto);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Se ha dado de alta el repuesto con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            limpiarCampos();
                            txtCodigo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Ese respuesto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                    GrillaRepuestos.DataSource = repuestoN.ObtenerRepuestos();
                }
                
            }
            GrillaRepuestos.DataSource = repuestoN.ObtenerRepuestos();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar baja el repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Repuesto repuestoo = new Repuesto(int.Parse(txtCodigo.Text), txtNombre.Text);
                    int resultado = repuestoN.EliminarRespuesto(repuestoo);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el Repuesto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtCodigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ese respuesto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }



            }

            GrillaRepuestos.DataSource = repuestoN.ObtenerRepuestos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") ||txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para modificar el repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Repuesto repuesto = new Repuesto(int.Parse(txtCodigo.Text), txtNombre.Text);
                    int resultado = repuestoN.ModificarRepuesto(repuesto);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha modifcado el Repuesto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtCodigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ese respuesto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }



            }

            GrillaRepuestos.DataSource = repuestoN.ObtenerRepuestos();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            
        }
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }
    }
}
