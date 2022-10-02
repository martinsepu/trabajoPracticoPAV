using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Proveedor
    {
        public int cod_proveedor { get; set; }
        public string Nombre { get; set; }
        public int telefono { get; set; }
        public string calle { get; set; }

        public int NroCasa { get; set; }

        public int IdBarrio { get; set; }

        public string Mail { get; set; }
        public Proveedor(int cod_proveedor, string nombre, int telefono, string calle, int nroCasa, int idBarrio, string mail)
        {
            this.cod_proveedor = cod_proveedor;
            Nombre = nombre;
            this.telefono = telefono;
            this.calle = calle;
            NroCasa = nroCasa;
            IdBarrio = idBarrio;
            Mail = mail;
        }
    }
}
