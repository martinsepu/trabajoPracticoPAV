using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Camion
    {
        ConexionSQL cn = new ConexionSQL();

        public  DataTable ObtenerCamiones()
        {
            return cn.ObtenerCamiones();
        }


        public int InsertarCamion(Camion ca)
        {
            return cn.InsertarCamion(ca);
        }

        public int eliminarCamion(string patente)
        {
            return cn.eliminarCamion(patente);
        }
        
        public int ModificarCamion(Camion ca)
        {
            return cn.ModificarCamion( ca);
        }

    }
}
