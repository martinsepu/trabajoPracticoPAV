using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        
        public int telefono { get; set; }

        public string calle { get; set; }

        public int NroCalle { get; set; }
        public int NroTipoDocumento { get; set; }

        public int IdBarrio { get; set; }


        public Empleado()
        {

        }
        public Empleado(int codigoEmpleado, string nombre, int telefono, string calle, int nroCalle, int nroTipoDocumento, int idBarrio)
        {
            CodigoEmpleado = codigoEmpleado;
            Nombre = nombre;
            this.telefono = telefono;
            this.calle = calle;
            NroCalle = nroCalle;
            NroTipoDocumento = nroTipoDocumento;
            IdBarrio = idBarrio;
        }
    }
}
