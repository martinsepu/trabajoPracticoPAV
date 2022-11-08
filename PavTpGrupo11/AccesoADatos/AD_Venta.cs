using PavTpGrupo11.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Venta
    {
        public static int obtenerUltimoIDVenta()
        {
            return ConexionSQL.obtenerUltimoIDVenta();
        }
        public static bool RegistrarVenta(Venta venta, List<Objeto_de_Venta> listaMateriales, List<Objeto_de_Venta> listaHerramienta)
        {
            return ConexionSQL.RegistrarVenta(venta, listaMateriales, listaHerramienta);
        }
        public static DataTable ObtenerVentas()
        {
            return ConexionSQL.ObtenerVentas();
        }
        public static DataTable ObtenerVentasxNum(int num)
        {
            return ConexionSQL.ObtenerVentaxNum(num);
        }
        public static DataTable ObtenerVentasxObra(int num)
        {
            return ConexionSQL.ObtenerVentaxObra(num);
        }
        public static DataTable ObtenerVentasxCamion(string patente)
        {
            return ConexionSQL.ObtenerVentaxCamion(patente);
        }
        public static DataTable ObtenerHerramientasxVenta()
        {
            return ConexionSQL.ObtenerHerramientasxVenta();
        }
        public static DataTable ObtenerVentasxCamion()
        {
            return ConexionSQL.ObtenerVentasxCamion();
        }

    }
}
