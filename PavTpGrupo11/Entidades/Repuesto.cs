using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
   public class Repuesto
    {
        public int Codigo { get; set; }

        public string nombre { get; set; }

        public Repuesto(int cod, string nom)
        {
            this.Codigo = cod;
            this.nombre = nom;
        }
        public Repuesto()
        {

        }
    }
}
