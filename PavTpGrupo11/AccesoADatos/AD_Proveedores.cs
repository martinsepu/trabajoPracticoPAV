using PavTpGrupo11.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Proveedores
    {
        ConexionSQL cn = new ConexionSQL();
        public DataTable consultarProveedores()
        {
            return cn.ConsultarProveedoresDG();
        }
        public int InsertarProveedor(Proveedor pro)
        {
            return cn.InsertarProveedor(pro);
        }

        public int EliminarProvedor(string cod)
        {
            return cn.EliminarProveedor(cod);
        }
    }

    



}
