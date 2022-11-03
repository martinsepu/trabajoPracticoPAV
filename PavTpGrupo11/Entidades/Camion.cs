using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Camion
    {
        public string patente { get; set; }

        public string Marca { get; set; }

        public int Anio_modelo { get; set; }


        public int Capacidad { get; set; }
        public Camion(string patente, string marca, int anio_modelo, int capacidad)
        {
            this.patente = patente;
            Marca = marca;
            Anio_modelo = anio_modelo;
            Capacidad = capacidad;
        }
        public Camion()
        {

        }
    }

}
