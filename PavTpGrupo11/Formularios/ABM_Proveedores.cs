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
    public partial class ABM_Proveedores : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_Proveedores()
        {
            InitializeComponent();
        }

        public void ABM_Proveedores_Load(object sender, EventArgs e)
        {
            grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
            cargarCombo();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.Show();
            this.Hide();
        }

        private void btn_AgregarProv_Click(object sender, EventArgs e)
        {
            if (txt_CodProv.Text.Equals("") || txt_NombreProv.Text.Equals("") || txt_TelefonoProv.Text.Equals("") || txt_MailProv.Text.Equals("") || txt_CalleProv.Text.Equals("") || txt_NroDeCalleProv.Text.Equals("") ||cmbBarrios.SelectedIndex==-1)
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta del Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                try
                {
                    Proveedor pro = new Proveedor(int.Parse(txt_CodProv.Text), txt_NombreProv.Text, int.Parse(txt_TelefonoProv.Text), txt_CalleProv.Text, int.Parse(txt_NroDeCalleProv.Text), (int)cmbBarrios.SelectedValue, txt_MailProv.Text);
                    int resultado = cn.InsertarProveedor(pro);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el Proveedor con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txt_CodProv.Focus();
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
                grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
            }

        }

        private void Btn_ModificarProv_Click(object sender, EventArgs e)
        {
            if (txt_CodProv.Text.Equals("") || txt_NombreProv.Text.Equals("") || txt_TelefonoProv.Text.Equals("") || txt_MailProv.Text.Equals("") || txt_CalleProv.Text.Equals("") || txt_NroDeCalleProv.Text.Equals("") || cmbBarrios.SelectedIndex==-1)
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar El Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Proveedor pro = new Proveedor(int.Parse(txt_CodProv.Text), txt_NombreProv.Text, int.Parse(txt_TelefonoProv.Text), txt_CalleProv.Text, int.Parse(txt_NroDeCalleProv.Text), (int)cmbBarrios.SelectedValue, txt_MailProv.Text);
                    int resultado = cn.ModificarProveedor(pro);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado el Proveedor con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txt_CodProv.Focus();
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
                grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
            }
            grillaProveedores.DataSource = cn.ConsultarProveedoresDG();

        }

        private void btn_BorrarProv_Click(object sender, EventArgs e)
        {
            if (txt_CodProv.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo del Proveedor que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.EliminarProveedor(txt_CodProv.Text);
                    if (resultado >0)
                    {
                        MessageBox.Show("Se ha eliminado el Proveedor seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txt_CodProv.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Ese Proveedor no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
                grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
            }
            grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
        }

        private void Btn_LimpiarCamposProv_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }
        private void cargarCombo()
        {
            cmbBarrios.DataSource = cn.ConsultarBarriosDG();
            cmbBarrios.DisplayMember = "nombre_barrio";
            cmbBarrios.ValueMember = "id_barrio";
            cmbBarrios.SelectedIndex = -1;

        }
        private void limpiarCampos()
        {
            txt_CodProv.Text = "";
            txt_CalleProv.Text = "";
            cmbBarrios.SelectedIndex = -1;
            txt_MailProv.Text = "";
            txt_NombreProv.Text = "";
            txt_TelefonoProv.Text = "";
            txt_NroDeCalleProv.Text = "";
        }
        private void CargarCampos(Proveedor p)
        {
            txt_NombreProv.Text = p.Nombre;
            txt_CodProv.Text = p.cod_proveedor.ToString();
            txt_CalleProv.Text = p.calle.ToString();
            txt_NroDeCalleProv.Text = p.NroCasa.ToString();
            txt_TelefonoProv.Text = p.telefono.ToString();
            cmbBarrios.SelectedValue = p.IdBarrio;
            txt_MailProv.Text = p.Mail;
        }
      

        private void grillaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSelect = grillaProveedores.Rows[indice];
            int cod = int.Parse(filaSelect.Cells["Cod_Proveedor"].Value.ToString());
            Proveedor em = cn.ObtenerProveedor(cod);
            limpiarCampos();
            CargarCampos(em);
        }
    }
    }

