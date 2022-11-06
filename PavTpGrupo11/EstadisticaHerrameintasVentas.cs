using Microsoft.Reporting.WinForms;
using PavTpGrupo11.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavTpGrupo11
{
    public partial class EstadisticaHerrameintasVentas : Form
    {
        public EstadisticaHerrameintasVentas()
        {
            InitializeComponent();
        }

        private void EstadisticaHerrameintasVentas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
    
            DataTable tabla = new DataTable();
            tabla = AD_Venta.ObtenerHerramientasxVenta();

            ReportDataSource ds = new ReportDataSource("DatosHerramientaVenta", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
