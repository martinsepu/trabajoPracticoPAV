using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Venta
    {
        public int numero{ get; set; }
        public DateTime fecha { get; set; }
        public string patente { get; set; }
        public int atraso { get; set; }
        public float monto { get; set; }
        public int codObra { get; set; }
        public DateTime fechaEntrega { get; set; }

        public Venta(int numero, DateTime fecha, string patente, int atraso, float monto, int codObra, DateTime fechaEntrega)
        {
            this.numero = numero;
            this.fecha = fecha;
            this.patente = patente;
            this.atraso = atraso;
            this.monto = monto;
            this.codObra = codObra;
            this.fechaEntrega = fechaEntrega;
        }
    }
}
