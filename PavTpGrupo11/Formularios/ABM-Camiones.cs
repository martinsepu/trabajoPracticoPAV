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
    public partial class ABM_Camiones : Form
    {
        AD_Camion camion = new AD_Camion();
        public ABM_Camiones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.Show();
            this.Hide();
        }

        private void ABM_Camiones_Load(object sender, EventArgs e)
        {
            GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtPatente.Text.Equals("") || TxtMarca.Text.Equals("") || txtAño.Text.Equals("") || txtCapacidad.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta a la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Camion cam = new Camion(txtPatente.Text,TxtMarca.Text,int.Parse(txtAño.Text),int.Parse(txtCapacidad.Text));
                    int resultado = camion.InsertarCamion(cam);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el camion", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtPatente.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ese camion ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
            }
            GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo de la Obra que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = camion.eliminarCamion(txtPatente.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el camion seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtPatente.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Ese camion no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Ese camion no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
            }
            GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text.Equals("") || TxtMarca.Text.Equals("") || txtAño.Text.Equals("") || txtCapacidad.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Camion cam = new Camion(txtPatente.Text, TxtMarca.Text, int.Parse(txtAño.Text), int.Parse(txtCapacidad.Text));
                    int resultado = camion.ModificarCamion(cam);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado el camion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtPatente.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
                GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
            }
            GrillaCamiones.DataSource = AD_Camion.ObtenerCamiones();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }
        private void limpiarCampos()
        {
            txtPatente.Text = "";
            TxtMarca.Text = "";
            txtAño.Text = "";
            txtCapacidad.Text = "";
        }

        private void GrillaCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSelect = GrillaCamiones.Rows[indice];
            string patente = filaSelect.Cells["Patente"].Value.ToString();
            Camion ca = camion.ObtenerCamion(patente);
            limpiarCampos();
            cargarCampos(ca);
        }
        private void cargarCampos(Camion ca)
        {
            txtPatente.Text=ca.patente;
            TxtMarca.Text=ca.Marca;
            txtAño.Text = ca.Anio_modelo.ToString();
            txtCapacidad.Text = ca.Capacidad.ToString();
        }
    }
}
