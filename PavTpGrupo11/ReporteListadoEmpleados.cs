using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PavTpGrupo11.AccesoADatos;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11
{
    public partial class ReporteListadoEmpleados : Form
    {
        public ReporteListadoEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteListadoEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BD3K3G11_2022DataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.EmpleadosTableAdapter.Fill(this.BD3K3G11_2022DataSet.Empleados);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_EMPLEADOS.ConsultarUsuariosDG();

            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla );
            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
