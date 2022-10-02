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
    public partial class ABM_BARRIOS : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_BARRIOS()
        {
            InitializeComponent();
        }
      

        private void ABM_BARRIOS_Load_1(object sender, EventArgs e)
        {
            GrillaBarrio.DataSource = cn.ConsultarBarriosDG();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TxtIDBarrio.Text.Equals("") || txtNombreB.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar de alta el barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Barrio ba = new Barrio(int.Parse(TxtIDBarrio.Text), txtNombreB.Text); 
                    bool resultado = cn.InsertarBarrio(ba);
                    if (resultado)
                    {
                        MessageBox.Show("Barrio dado de alta correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        TxtIDBarrio.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ese barrio existe", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
            }

            GrillaBarrio.DataSource = cn.ConsultarBarriosDG();
        }

        

        private void btnModificarBarrio_Click(object sender, EventArgs e)
        {
            if (TxtIDBarrio.Text.Equals("") || txtNombreB.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar de alta al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    Barrio ba = new Barrio(int.Parse(TxtIDBarrio.Text), txtNombreB.Text);
                    int resultado = cn.ModificarBarrio(ba);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha modificado el barrio", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        TxtIDBarrio.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Ese barrio no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            GrillaBarrio.DataSource = cn.ConsultarBarriosDG();
        }

        private void btnElimarB_Click(object sender, EventArgs e)
        {
            if (TxtIDBarrio.Text.Equals("") )
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios para dar de alta al Barrio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.EliminarBarrio(TxtIDBarrio.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el barrio", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        TxtIDBarrio.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ese barrio no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            
              
               
            }

            GrillaBarrio.DataSource = cn.ConsultarBarriosDG();
            

        }

        private void btnSalirB_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void TxtIDBarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_LimpiarCamposObra_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            TxtIDBarrio.Text = "";
            txtNombreB.Text = "";
        }
    }

  

       

      
    }

