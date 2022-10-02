using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string contrasena { get; set; }

        public Usuario(string nom, string pass)
        {
            this.nombre = nom;
            this.contrasena = pass;
        }
        public Usuario()
        {

        }
    }
}
