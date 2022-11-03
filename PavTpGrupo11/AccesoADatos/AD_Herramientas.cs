using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Herramientas
    {
        public static DataTable ConsultarHerramientas()
        {
            return ConexionSQL.ConsultarHerramientas();
        }
        public static DataTable ObtenerHerramientaxCod(int cod)
        {
            return ConexionSQL.ObtenerHerramientaxCod(cod);
        }
    }
}
