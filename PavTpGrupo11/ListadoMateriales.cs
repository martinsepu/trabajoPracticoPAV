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
    public partial class ListadoMateriales : Form
    {
        public ListadoMateriales()
        {
            InitializeComponent();
        }

        private void ListadoMateriales_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
            DataTable tabla = new DataTable();
            tabla = AD_Materiales.ConsultarMaterialesDG();

            ReportDataSource ds = new ReportDataSource("DatosMateriales", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!rdbCod.Checked && !rdbProveedores.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Materiales.ConsultarMaterialesDG();

                ReportDataSource ds = new ReportDataSource("DatosMateriales", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            if (rdbCod.Checked && !txtCod.Text.Equals(""))
            {
                try
                {
                    int cod = int.Parse(txtCod.Text);
                    DataTable tabla = new DataTable();
                    tabla = AD_Materiales.ObtenerMaterialxCod(cod);

                    ReportDataSource ds = new ReportDataSource("DatosMateriales", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbCod.Checked = false;
                    txtCod.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            if(rdbProveedores.Checked && !txtProv.Text.Equals(""))
            {
                try
                {
                    int cod = int.Parse(txtProv.Text);
                    DataTable tabla = new DataTable();
                    tabla = AD_Materiales.ObtenerMaterialesxProv(cod);

                    ReportDataSource ds = new ReportDataSource("DatosMateriales", tabla);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbProveedores.Checked = false;
                    txtProv.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            
        }

        private void rdbCod_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCod.Checked)
            {
                txtCod.Enabled=true;
            }
            else
            {
                txtCod.Text = "";
                txtCod.Enabled=false;
            }
        }

        private void rdbProveedores_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProveedores.Checked)
            {
                txtProv.Enabled = true;
            }
            else
            {
                txtProv.Text = "";
                txtProv.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbCod.Checked = false;
            txtCod.Enabled = false;
            rdbProveedores.Checked=false;
            txtProv.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
