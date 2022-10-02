using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavTpGrupo11.Entidades;
using System.Data;
namespace PavTpGrupo11.AccesoADatos

{
    public class AD_Respuestos
    {
        ConexionSQL cn = new ConexionSQL();


        public DataTable ObtenerRepuestos()
        {
            return cn.ObtenerRepuestos();
        }

        public int InsertarRespuesto(Repuesto repuesto)
        {
            return cn.InsertarRepuesto(repuesto);

        }
        public int EliminarRespuesto(Repuesto repuesto)
        {
            return cn.EliminarRespuesto(repuesto.Codigo);
        }
        public int ModificarRepuesto(Repuesto repuesto)
        {
            return cn.ModificarRepuesto(repuesto);
        }
       
    }
}
