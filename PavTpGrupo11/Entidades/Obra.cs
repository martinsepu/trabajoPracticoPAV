using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Obra
    {
        public int Codigo_Obra { get; set; }

        public string NombreObra { get; set; }

        public string calle { get; set; }

        public int NroCalle { get; set; }

        public int IdBarrio { get; set; }
       
        public Obra(int codigo_Obra, string nombreObra, string calle, int nroCalle, int idBarrio)
        {
            Codigo_Obra = codigo_Obra;
            NombreObra = nombreObra;
            this.calle = calle;
            NroCalle = nroCalle;
            IdBarrio = idBarrio;
        }
    }
}
