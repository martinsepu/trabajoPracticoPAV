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
    public partial class Login : Form
    {
        AD_usuarios usuarioN = new AD_usuarios(); 
        public Login()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Text, txtContrasenia.Text);
            if(usuarioN.login(usuario) > 0)
            {
                MessageBox.Show("Bienvenido");

                Principal ventana = new Principal();
                ventana.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y/o contrasena incorrecta");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
