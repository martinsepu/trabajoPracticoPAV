using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_usuarios
    {
        ConexionSQL cn = new ConexionSQL();

        public int login(Usuario us)
        {
            return cn.Login(us.nombre, us.contrasena);
        }

        public DataTable consultarUsuarios()
        {
            return cn.ConsultarUsuarios();
        }

        public int InsertarUsuario( Usuario us)
        {
            return cn.InsertarUsuarioU(us);
        }

        public int EliminarUsuario( Usuario us)
        {
            return cn.EliminarUsuario(us.nombre);
        }
        public int ModificarUsuario(Usuario us)
        {
            return cn.ModificarUsuario(us);
        }


    }
}
