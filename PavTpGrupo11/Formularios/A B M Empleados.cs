using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.AccesoADatos;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.Formularios
{
    public partial class frmABM_EMPLEADOS : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();

        public frmABM_EMPLEADOS()
        {
            InitializeComponent();
        }

        private void frmABM_EMPLEADOS_Load(object sender, EventArgs e)
        {
            GrillaEmpleados.DataSource = AD_EMPLEADOS.ConsultarUsuariosDG();
            cargarCombo();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigoEMPLEADO.Text.Equals("") || cmbBarrios.SelectedIndex==-1 || txtCalle.Text.Equals("") || txtCalleNRO.Text.Equals("") || txttelefonoE.Text.Equals("") ||
                txtDocumento.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Empleado emp = new Empleado(int.Parse(txtCodigoEMPLEADO.Text), txtNombre.Text, int.Parse(txttelefonoE.Text), txtCalle.Text, int.Parse(txtCalleNRO.Text), int.Parse(txtDocumento.Text), (int)cmbBarrios.SelectedValue);
                    int resultado = cn.InsertarEmpleado(emp);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el empleado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ese empleado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }


                GrillaEmpleados.DataSource = AD_EMPLEADOS.ConsultarUsuariosDG();
            }
            
            GrillaEmpleados.DataSource = AD_EMPLEADOS.ConsultarUsuariosDG();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEMPLEADO.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo del empleado que desee elimanar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.EliminarEmpleado(txtCodigoEMPLEADO.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el empleado seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ese empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }




            }
            GrillaEmpleados.DataSource = AD_EMPLEADOS.ConsultarUsuariosDG();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEMPLEADO.Text.Equals("") || cmbBarrios.SelectedIndex == -1 || txtCalle.Text.Equals("") || txtCalleNRO.Text.Equals("") || txttelefonoE.Text.Equals("") ||
                txtDocumento.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Empleado emp = new Empleado(int.Parse(txtCodigoEMPLEADO.Text), txtNombre.Text, int.Parse(txttelefonoE.Text), txtCalle.Text, int.Parse(txtCalleNRO.Text), int.Parse(txtDocumento.Text), (int)cmbBarrios.SelectedValue);
                    int resultado = cn.ModificarEmpleado(emp);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha modificado el empleado seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ese empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }


                GrillaEmpleados.DataSource = AD_EMPLEADOS.ConsultarUsuariosDG();
            }
        }

            private void btnSalir_Click(object sender, EventArgs e)
            {
            Principal frm = new Principal();
            frm.Show();
            this.Hide();
            }

            private void BtnLimpiarCampos_Click(object sender, EventArgs e)
            {
            limpiarCampos();
            }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            cmbBarrios.SelectedIndex = -1;
            txtCalleNRO.Text = "";
            txtCodigoEMPLEADO.Text = "";
            txttelefonoE.Text = "";
            txtDocumento.Text = "";
            txtCalle.Text = "";
        }
        private void cargarCombo()
        {
            cmbBarrios.DataSource = cn.ConsultarBarriosDG();
            cmbBarrios.DisplayMember = "nombre_barrio";
            cmbBarrios.ValueMember = "id_barrio";
            cmbBarrios.SelectedIndex = -1;
            
        }

        private void GrillaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSelect = GrillaEmpleados.Rows[indice];
            int cod = int.Parse(filaSelect.Cells["Cod_Empleado"].Value.ToString());
            Empleado em = cn.obtenerEmpleado(cod);
            limpiarCampos();
            cargarCampos(em);
        }
        private void cargarCampos(Empleado e)
        {
            txtNombre.Text=e.Nombre;
            txtDocumento.Text = e.NroTipoDocumento.ToString();
            txtCodigoEMPLEADO.Text=e.CodigoEmpleado.ToString();
            txtCalle.Text=e.calle.ToString();
            txtCalleNRO.Text=e.NroCalle.ToString();
            txttelefonoE.Text = e.telefono.ToString();
            cmbBarrios.SelectedValue = e.IdBarrio; 
        }
    }
    }

    