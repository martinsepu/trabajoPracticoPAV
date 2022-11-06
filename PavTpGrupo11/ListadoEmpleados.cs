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

namespace PavTpGrupo11
{
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_EMPLEADOS.ConsultarUsuariosDG();

            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();




        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!rdbCodigo.Checked && !rdbEmpleados.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_EMPLEADOS.ConsultarUsuariosDG();

                ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);

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
                    tabla = ConexionSQL.ObtenerEmpleadoXcod(cod);

                    ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);

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
                    tabla = ConexionSQL.ObtenerEmpleadoXnom(nom);

                    ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbCodigo.Checked = false;
            txtCod.Enabled = false;
            rdbEmpleados.Checked = false;
            txtNombre.Enabled = false;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

