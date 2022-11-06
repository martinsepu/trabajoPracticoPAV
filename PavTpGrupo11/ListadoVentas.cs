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
    public partial class ListadoVentas : Form
    {
        public ListadoVentas()
        {
            InitializeComponent();
        }

        private void ListadoVentas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Venta.ObtenerVentas();

            ReportDataSource ds = new ReportDataSource("DatosVenta", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rdbCamion.Checked && !rdbObra.Checked && !rdbVenta.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Venta.ObtenerVentas();

                ReportDataSource ds = new ReportDataSource("DatosVenta", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            if (rdbCamion.Checked && !txtCamion.Text.Equals(""))
            {
                try
                {
                    DataTable tabla = new DataTable();
                    tabla = AD_Venta.ObtenerVentasxCamion(txtCamion.Text);

                    ReportDataSource ds = new ReportDataSource("DatosVenta", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es Correcto");
                }
            }
            if (rdbObra.Checked && !txtObra.Text.Equals(""))
            {
                try
                {
                    int cod = int.Parse(txtObra.Text);
                    DataTable tabla = new DataTable();
                    tabla = AD_Venta.ObtenerVentasxObra(cod);

                    ReportDataSource ds = new ReportDataSource("DatosVenta", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            if(rdbVenta.Checked && !txtVenta.Text.Equals(""))
            {
                try
                {
                    int cod = int.Parse(txtVenta.Text);
                    DataTable tabla = new DataTable();
                    tabla = AD_Venta.ObtenerVentasxNum(cod);

                    ReportDataSource ds = new ReportDataSource("DatosVenta", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            limpiarCampos();
        }

        private void rdbCamion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCamion.Checked)
            {
                txtCamion.Enabled = true;
            }
            else
            {
                txtCamion.Text = "";
                txtCamion.Enabled = false;
            }
        }

        private void rdbObra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbObra.Checked)
            {
                txtObra.Enabled = true;
            }
            else
            {
                txtObra.Text = "";
                txtObra.Enabled = false;
            }
        }

        private void rdbVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVenta.Checked)
            {
                txtVenta.Enabled = true;
            }
            else
            {
                txtVenta.Text = "";
                txtVenta.Enabled = false;
            }
        }
        private void limpiarCampos()
        {
            rdbCamion.Checked = false;
            rdbObra.Checked=false;
            rdbVenta.Checked = false;
            txtCamion.Text = "";
            txtObra.Text = "";
            txtVenta.Text = "";
            txtVenta.Enabled = false;
            txtObra.Enabled = false;
            txtCamion.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
