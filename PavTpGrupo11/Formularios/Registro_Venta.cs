using PavTpGrupo11.AccesoADatos;
using PavTpGrupo11.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavTpGrupo11.Formularios
{
    public partial class Registro_Venta : Form
    {
        bool abilitarBusqueda;
        List<Objeto_de_Venta> listaMateriales=new List<Objeto_de_Venta>();
        List<Objeto_de_Venta> listaHerramientas=new List<Objeto_de_Venta>();
        float acuHerra = 0;
        float acuMat = 0;

        public Registro_Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            abilitarBusqueda = false;
            obtenerCodVenta();
            cargarCombos();
            abilitarBusqueda = true;
            txtAcumuladoMateriales.Text = 0.ToString();
            txtAcumuladoHerra.Text = 0.ToString();
            txtMonto.Text= 0.ToString();

        }
        private void obtenerCodVenta()
        {
            int cod_venta = AD_Venta.obtenerUltimoIDVenta();
            txtNumeroVenta.Text = (cod_venta + 1).ToString();
        }
        public void cargarCombos()
        {
            cmbHerramienta.DataSource = AD_Herramientas.ConsultarHerramientas();
            cmbHerramienta.DisplayMember = "Nombre_identificador";
            cmbHerramienta.ValueMember = "Cod_herramienta";
            cmbHerramienta.SelectedIndex = -1;
            
            cmbCamion.DataSource = AD_Camion.ObtenerCamiones();
            cmbCamion.DisplayMember = "Patente";
            cmbCamion.ValueMember = "Patente";
            cmbCamion.SelectedIndex = -1;

            cmbMaterial.DataSource = AD_Materiales.ConsultarMaterialesDG();
            cmbMaterial.DisplayMember = "Codigo_Material";
            cmbMaterial.ValueMember = "Codigo_Material";
            cmbMaterial.SelectedIndex = -1;

            cmbObra.DataSource=AD_Obras.ConsultarObrasDG();
            cmbObra.DisplayMember = "nombre_Obra";
            cmbObra.ValueMember = "codigo_obra";
            cmbObra.SelectedIndex=-1;

            cmbResponsable.DataSource = AD_EMPLEADOS.ConsultarUsuariosDG();
            cmbResponsable.DisplayMember = "Cod_Empleado";
            cmbResponsable.ValueMember = "Cod_Empleado";
            cmbResponsable.SelectedIndex = -1;
        }

        private void cmbMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
            if (abilitarBusqueda)
            {
                try
                {
                    DataTable tablaResultado = AD_Materiales.ObtenerMaterialxCod(int.Parse(cmbMaterial.SelectedValue.ToString().Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        txtPrecioMat.Text = tablaResultado.Rows[0][5].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Material Inexistente");
                        cmbMaterial.Focus();
                        cmbMaterial.SelectedIndex = -1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al obtener el material");

                }
            }
        }

        private void cmbHerramienta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (abilitarBusqueda)
            {
                try
                {
                    DataTable tablaResultado = AD_Herramientas.ObtenerHerramientaxCod(int.Parse(cmbHerramienta.SelectedValue.ToString().Trim()));
                    if (tablaResultado.Rows.Count > 0)
                    {
                        txtCodHerramienta.Text = tablaResultado.Rows[0][0].ToString();
                        txtPrecioHerramienta.Text = tablaResultado.Rows[0][7].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Herramienta Inexistente");
                        cmbMaterial.Focus();
                        cmbMaterial.SelectedIndex = -1;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al obtener la herramienta");

                }
            }

        }

        private void btnAgregarMat_Click(object sender, EventArgs e)
        {
            bool tieneMat=false, tienePre=false, tieneCant=false;
            if(cmbMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Material");
                cmbMaterial.Focus();
                return;
            }
            else
            {
                tieneMat = true;
            }
            if (txtPrecioMat.Text.Equals(""))
            {
                MessageBox.Show("Se seleecionano un Material que no tiene precio");
                cmbMaterial.Focus();
                return;
            }
            else
            {
                tienePre=true;
            }
            if (txtCantidadMat.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una cantidad");
                txtCantidadMat.Focus();
                return;
            }
            else
            {
                tieneCant = true;
            }
            if(tieneCant && tienePre && tieneMat)
            {
                float preciotot = float.Parse(txtPrecioMat.Text)*int.Parse(txtCantidadMat.Text.Trim());
                int cod = int.Parse(cmbMaterial.SelectedValue.ToString().Trim());
                int cantidad = int.Parse(txtCantidadMat.Text);
                Objeto_de_Venta obj = new Objeto_de_Venta(cod, preciotot,cantidad);
                
                listaMateriales.Add(obj);
                grillaMateriales.Rows.Add(cod.ToString(), txtCantidadMat.Text, txtPrecioMat.Text, preciotot.ToString());
                
                acuMat = acuMat + preciotot;
                txtAcumuladoMateriales.Text = acuMat.ToString();
                txtMonto.Text = (acuMat + acuHerra).ToString();
                
                limpiarMateriales();
            }
            else
            {
                MessageBox.Show("Falta completar algun campo");
            }

        }
        private void limpiarMateriales()
        {
            abilitarBusqueda=false;
           
            txtPrecioMat.Text = "";
            txtCantidadMat.Text = "";
            cmbMaterial.SelectedIndex = -1;
            abilitarBusqueda = true;
        }
        private void limpiarHerramientas()
        {
            abilitarBusqueda = false;
            txtCodHerramienta.Text = "";
            txtPrecioHerramienta.Text = "";
            txtFechaDev.Text = "";
            cmbHerramienta.SelectedIndex = -1;
            cmbResponsable.SelectedIndex = -1;
            abilitarBusqueda = true;
        }
        private void limpiarVenta()
        {
            txtAtraso.Text = "";
            txtFechaEntrega.Text = "";
            cmbCamion.SelectedIndex=-1;
            cmbObra.SelectedIndex=-1;

        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            bool tieneHer = false, tienePre = false, tieneFecha = false,tieneResp=false;
            if (cmbHerramienta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Herramienta");
                cmbHerramienta.Focus();
                return;
            }
            else
            {
                tieneHer = true;
            }
            if (txtPrecioHerramienta.Text.Equals(""))
            {
                MessageBox.Show("Se seleecionano una Herramienta que no tiene precio");
                cmbHerramienta.Focus();
                return;
            }
            else
            {
                tienePre = true;
            }
            if (txtFechaDev.Text.Equals("  /  /       :") || txtFechaDev.Text.Equals(" __/__/____ __:__"))
            {
                MessageBox.Show("Debe seleccionar una fecha");
                txtFechaDev.Focus();
                return;
            }
            else
            {
                tieneFecha = true;
            }
            if(cmbResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleecionar un responsable de devolucion");
                cmbResponsable.Focus();
                return;
            }
            else
            {
                tieneResp = true;
            }
            if (tieneHer && tienePre && tieneFecha && tieneResp)
            {
                float precio = float.Parse(txtPrecioHerramienta.Text);
                int cod = int.Parse(txtCodHerramienta.Text);
                int responsable = int.Parse(cmbResponsable.SelectedValue.ToString().Trim());
                Objeto_de_Venta obj = new Objeto_de_Venta(cod, precio,responsable,DateTime.Parse(txtFechaDev.Text));
                
                listaHerramientas.Add(obj);
                grillaHerramientas.Rows.Add(cod.ToString(),responsable.ToString(),txtFechaDev.Text,precio);
                
                acuHerra = acuHerra + precio;
                txtAcumuladoHerra.Text = acuHerra.ToString();
                txtMonto.Text = (acuMat + acuHerra).ToString();

                limpiarHerramientas();
            }
            else
            {
                MessageBox.Show("Falta completar algun campo");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarVenta();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrega, fechaRegistro;
            int atraso,obra;
            string patente;
            float monto;
            bool tieneAtraso = false, tieneFechaEntrega = false, tieneCamion = false, tieneObra = false, tieneMaterialHerra = false;
            if (txtAtraso.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar los dias del atraso");
                txtAtraso.Focus();
                return;
            }
            else
            {
                tieneAtraso = true;
                atraso = int.Parse(txtAtraso.Text);
            }
            if (txtFechaEntrega.Text.Equals("  /  /       :") || txtFechaEntrega.Text.Equals(" __/__/____ __:__"))
            {
                MessageBox.Show("Debe ingresar la fecha y hora de entrega");
                txtFechaEntrega.Focus();
                return;
            }
            else
            {
                tieneFechaEntrega = true;
                fechaEntrega = DateTime.Parse(txtFechaEntrega.Text);
            }
            if(cmbCamion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un camion");
                cmbCamion.Focus();
                return;
            }
            else
            {
                tieneCamion = true;
                patente = cmbCamion.SelectedValue.ToString();
            }
            if(cmbObra.SelectedIndex== -1)
            {
                MessageBox.Show("Debe seleecionar una Obra");
                cmbObra.Focus();
                return;
            }
            else
            {
                tieneObra = true;
                obra = int.Parse(cmbObra.SelectedValue.ToString());
            }
            if(grillaHerramientas.Rows.Count==0 && grillaMateriales.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un material a comprar o una herramienta a alquilar");
                cmbHerramienta.Focus();
                return;
            }
            else
            {
                tieneMaterialHerra = true;
            }
            if(tieneAtraso && tieneFechaEntrega && tieneCamion && tieneObra && tieneMaterialHerra)
            {
                monto = float.Parse(txtMonto.Text);
                Venta venta = new Venta(int.Parse(txtNumeroVenta.Text), DateTime.Now, patente, atraso, monto, obra, fechaEntrega);
                bool resultado = AD_Venta.RegistrarVenta(venta,listaMateriales,listaHerramientas);
                if (resultado)
                {
                    MessageBox.Show("Se registro la venta correctamente");
                    listaHerramientas.Clear();
                    listaMateriales.Clear();
                    limpiarHerramientas();
                    limpiarMateriales();
                    limpiarVenta();
                    obtenerCodVenta();
                    limpiarMontos();
                    
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al registrar la venta");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal ventana = new Principal();
            ventana.Show();
            this.Hide();
        }
        private void limpiarMontos()
        {
            txtAcumuladoHerra.Text = 0.ToString();
            txtAcumuladoMateriales.Text = 0.ToString();
            txtMonto.Text = 0.ToString();
        }
    }
}
