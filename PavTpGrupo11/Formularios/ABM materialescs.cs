using PavTpGrupo11.AccesoADatos;
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
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.Formularios
{
    public partial class ABM_materialescs : Form
    {

        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_materialescs()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void ABM_materialescs_Load(object sender, EventArgs e)
        {
            grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
            this.cargarCombos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text.Equals("") || txtCodigo.Text.Equals("") || cmbProvedores.SelectedIndex==-1 || txtPrecio.Text.Equals("") || txtUnidadMedida.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta del Material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Material mat = new Material(int.Parse(txtCodigo.Text), int.Parse(txtCantidad.Text), int.Parse(txtUnidadMedida.Text), (int)cmbProvedores.SelectedValue, DateTime.Now, int.Parse(txtPrecio.Text));
                    int resultado = cn.InsertarMaterial(mat); 
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el material con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.borrarCampos();
                        txtCodigo.Focus();
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
                grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
            }
        grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Equals("") || txtCodigo.Text.Equals("") || cmbProvedores.SelectedIndex == -1 || txtPrecio.Text.Equals("") || txtUnidadMedida.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar el Material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Material mat = new Material(int.Parse(txtCodigo.Text), int.Parse(txtCantidad.Text), int.Parse(txtUnidadMedida.Text), (int)cmbProvedores.SelectedValue, DateTime.Now, int.Parse(txtPrecio.Text));
                    int resultado = cn.ModificarMaterial(mat);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado el Material con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.borrarCampos();
                        txtCodigo.Focus();
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
                grillaMateriales.DataSource = cn.ConsultarMaterialesDG();                   
            }
            grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo del Material que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.eliminarMaterial(txtCodigo.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el Material seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.borrarCampos();
                        txtCodigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ese Material no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    throw;
                }
                grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
            }
        grillaMateriales.DataSource = cn.ConsultarMaterialesDG();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.borrarCampos();
            
        }
        private void cargarCombos()
        {
            cmbProvedores.DataSource = cn.ConsultarProveedoresDG();
            cmbProvedores.DisplayMember = "Nombre";
            cmbProvedores.ValueMember = "Cod_Proveedor";
            cmbProvedores.SelectedIndex = -1;
        }
        private void borrarCampos()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            cmbProvedores.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtUnidadMedida.Text = "";
        }
    }
}
