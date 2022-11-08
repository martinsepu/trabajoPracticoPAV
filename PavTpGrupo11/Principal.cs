using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;

namespace PavTpGrupo11
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void tipoDeRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedorerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrarEmpleadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABM_EMPLEADOS ventana = new frmABM_EMPLEADOS();
            ventana.Show();
            this.Hide();

        }

        private void registrarBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_BARRIOS ventana = new ABM_BARRIOS();
            ventana.Show();
            this.Hide();
        }

        private void aBMProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Proveedores ventana = new ABM_Proveedores();
            ventana.Show();
            this.Hide();
        }

        private void aBMObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Obra ventana  = new ABM_Obra();
            ventana.Show();
            this.Hide();

        }

        private void aBMCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Camiones ventana = new ABM_Camiones();
            ventana.Show();
            this.Hide();
        }

        private void aBMMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_materialescs ventana = new ABM_materialescs();
            ventana.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_usuarios ventana = new ABM_usuarios();
            ventana.Show();
            this.Hide();
        }

        private void aBMRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Respuestos v = new ABM_Respuestos();
            v.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login v = new Login();
            v.Show();
            this.Hide();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Venta v = new Registro_Venta();
            v.Show();
            this.Hide();
        }

        private void listadoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoEmpleados l = new ListadoEmpleados();
            l.ShowDialog();

        }

        private void listadoBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ListadoBarrios b = new ListadoBarrios();   
            b.ShowDialog();
        }

        private void listadoMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoMateriales ventan = new ListadoMateriales();
            ventan.ShowDialog();
        }

        private void listadoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoVentas ventana = new ListadoVentas();
            ventana.ShowDialog();
        }

        private void herramientasPorVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaHerrameintasVentas ventana = new EstadisticaHerrameintasVentas();
            ventana.ShowDialog();
        }

        private void ventasPorCamionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaVentasCamion ventana = new EstadisticaVentasCamion();
            ventana.ShowDialog();
        }

        private void empleadosPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaEmpleadosXbarrio est = new EstadisticaEmpleadosXbarrio();
            est.ShowDialog();
        }

        private void proveedoresPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticasProveedoresXbarrio ep = new EstadisticasProveedoresXbarrio();
            ep.ShowDialog();    
            
            
        }
    }
}
