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
    public partial class ABM_usuarios : Form
    {
        AD_usuarios usuarioN = new AD_usuarios();
        public ABM_usuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void ABM_usuarios_Load(object sender, EventArgs e)
        {
            grillaUsuarios.DataSource = usuarioN.consultarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContrasenia.Text.Equals(""))
            {
                
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta del Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                Usuario usuario = new Usuario(txtUsuario.Text, txtContrasenia.Text);
                if (txtContrasenia.Text == txtRepecontra.Text)
                {

                    try
                    {
                        
                        int resultado = usuarioN.InsertarUsuario(usuario);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Se ha dado de alta el Usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            limpiarCampos();
                            txtUsuario.Focus();
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
                    grillaUsuarios.DataSource = usuarioN.consultarUsuarios();
                }
                else
                {
                    MessageBox.Show("las contrasenias no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenia.Focus();
                }
            }
            grillaUsuarios.DataSource = usuarioN.consultarUsuarios();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para borrar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario usuario = new Usuario(txtUsuario.Text, txtContrasenia.Text);
                try
                {
                    int resultado = usuarioN.EliminarUsuario(usuario);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha borrado el Usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                        txtUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("ha ocurrido un problema");
                    
                }
            }
            grillaUsuarios.DataSource = usuarioN.consultarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContrasenia.Text.Equals(""))
            {

                MessageBox.Show("Debe completar todos los campos correspondientes para modificar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Usuario usuario = new Usuario(txtUsuario.Text, txtContrasenia.Text);
                if (txtContrasenia.Text == txtRepecontra.Text)
                {

                    try
                    {

                        int resultado = usuarioN.ModificarUsuario(usuario);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Se ha modificado el usuario con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            limpiarCampos();
                            txtUsuario.Focus();
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    grillaUsuarios.DataSource = usuarioN.consultarUsuarios();
                }
                else
                {
                    MessageBox.Show("las contrasenias no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenia.Focus();
                }
            }
            grillaUsuarios.DataSource = usuarioN.consultarUsuarios();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void limpiarCampos()
        {
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
            txtRepecontra.Text = "";
        }
    }
}
