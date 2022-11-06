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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PavTpGrupo11
{
    public partial class ListadoBarrios : Form
    {
        public ListadoBarrios()
        {
            InitializeComponent();
        }

        private void ListadoBarrios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            AD_EMPLEADOS ee = new AD_EMPLEADOS();
            DataTable dataTable = new DataTable();
            dataTable = ee.ConsultarBarriosDG();


            ReportDataSource ds = new ReportDataSource("listadoBarrios", dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
