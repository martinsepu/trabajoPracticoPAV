using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_EMPLEADOS
    {
        ConexionSQL cn = new ConexionSQL();

        
        public static DataTable ConsultarUsuariosDG()
        {
            return ConexionSQL.ConsultarUsuariosDG();


        }

          public int InsertarEmpleado(Empleado emp)
        {
            return cn.InsertarEmpleado(emp);
        }
        public int EliminarEmpleado(string cod)
        {
            return cn.EliminarEmpleado(cod);
        }

        public int ModificarEmpleado(Empleado emp)
        {
            return cn.ModificarEmpleado(emp);
        }



        public DataTable ConsultarBarriosDG()
        {
            return cn.ConsultarBarriosDG();
        }

        public bool InsertarBarrio(Barrio ba)
        {
            return cn.InsertarBarrio(ba);
        }

        public int ModificarBarrio(Barrio ba)
        {
            return cn.ModificarBarrio(ba);
        }

        public int EliminarBarrio(string id)
        {
            return cn.EliminarBarrio(id);
        }
    }
}
