using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Objeto_de_Venta
    {
        public int cod { get; set; }
        public float precio { get; set; }

        public int responsable { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }

        public Objeto_de_Venta(int cod, float precio, int responsable, DateTime fecha)
        {
            this.cod = cod;
            this.precio = precio;
            this.responsable = responsable;
            this.fecha = fecha;
            
        }
        public Objeto_de_Venta(int cod,float precio, int cantidad)
        {
            this.cod = cod;
            this.precio = precio;
            this.cantidad = cantidad;
        }

    }
}
