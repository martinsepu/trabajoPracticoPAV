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
    public partial class ABM_Obra : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_Obra()
        {
            InitializeComponent();
        }
        private void ABM_Obra_Load(object sender, EventArgs e)
        {
            grillaObra.DataSource = cn.ConsultarObrasDG();
            cargarCombo();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //

        //
        private void btn_AgregarObra_Click(object sender, EventArgs e)
        {
            if (txt_CodObra.Text.Equals("") || txt_NombreObra.Text.Equals("") || txt_CalleObra.Text.Equals("") || txt_NroDeCalleObra.Text.Equals("") || cmbBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta a la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Obra ob = new Obra(int.Parse(txt_CodObra.Text),txt_NombreObra.Text,txt_CalleObra.Text,int.Parse(txt_NroDeCalleObra.Text),(int)cmbBarrios.SelectedValue);
                    int resultado = cn.InsertarObra(ob);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta la Obra con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txt_CodObra.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch(Exception)
                {
                    throw;
                }
                grillaObra.DataSource = cn.ConsultarObrasDG();
            }
            grillaObra.DataSource = cn.ConsultarObrasDG();

        }

       

        private void Btn_ModificarObra_Click(object sender, EventArgs e)
        {
            if(txt_CodObra.Text.Equals("") || txt_NombreObra.Text.Equals("") || txt_CalleObra.Text.Equals("") || txt_NroDeCalleObra.Text.Equals("") || cmbBarrios.SelectedIndex==-1)
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Obra ob = new Obra(int.Parse(txt_CodObra.Text), txt_NombreObra.Text, txt_CalleObra.Text, int.Parse(txt_NroDeCalleObra.Text), (int)cmbBarrios.SelectedValue);
                    int resultado = cn.ModificarObra(ob);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado la Obra con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txt_CodObra.Focus();
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
                grillaObra.DataSource = cn.ConsultarObrasDG();
            }
            grillaObra.DataSource = cn.ConsultarObrasDG();

        }

        private void btn_BorrarObra_Click(object sender, EventArgs e)
        {
            if (txt_CodObra.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo de la Obra que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.EliminarObra(txt_CodObra.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado la Obra seleccionada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txt_CodObra.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Esa Obra no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    throw;
                }
                grillaObra.DataSource = cn.ConsultarObrasDG();
            }
            grillaObra.DataSource = cn.ConsultarObrasDG();
        }

        private void Btn_LimpiarCamposObra_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
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
            txt_CodObra.Text = "";
            txt_CalleObra.Text = "";
            cmbBarrios.SelectedIndex = -1;
            txt_NombreObra.Text = "";
            txt_NroDeCalleObra.Text = "";
        }
    }
}
