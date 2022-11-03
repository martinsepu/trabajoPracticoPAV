using PavTpGrupo11.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
