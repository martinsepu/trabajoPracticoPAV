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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbCodigo.Checked = false;
            txtCod.Enabled = false;
            rdbEmpleados.Checked = false;
            txtNombre.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!rdbCodigo.Checked && !rdbEmpleados.Checked)
            {
                DataTable tabla = new DataTable();
                AD_EMPLEADOS ee = new AD_EMPLEADOS();
                tabla = ee.ConsultarBarriosDG();

                ReportDataSource ds = new ReportDataSource("listadoBarrios", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            if (rdbCodigo.Checked && !txtCod.Text.Equals(""))
            {
                try
                {
                    int cod = int.Parse(txtCod.Text);
                    DataTable tabla = new DataTable();
                    tabla = ConexionSQL.ObtenerBarrioXCod(cod);

                    ReportDataSource ds = new ReportDataSource("listadoBarrios", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbCodigo.Checked = false;
                    txtCod.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            if (rdbEmpleados.Checked && !txtNombre.Text.Equals(""))
            {
                try
                {
                    string nom = txtNombre.Text;
                    DataTable tabla = new DataTable();
                    tabla = ConexionSQL.ObtenerBarrioXnombre(nom);

                    ReportDataSource ds = new ReportDataSource("listadoBarrios", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbCodigo.Checked = false;
                    rdbEmpleados.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
        }

        private void rdbEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEmpleados.Checked)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Text = "";
                txtNombre.Enabled = false;
            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                txtCod.Enabled = true;
            }
            else
            {
                txtCod.Text = "";
                txtCod.Enabled = false;
            }
        }



    }
}
