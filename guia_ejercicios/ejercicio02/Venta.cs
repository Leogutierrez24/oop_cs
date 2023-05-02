using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    public class Venta
    {
        public Venta(string tipo, decimal cantidad, decimal total)
        {
            this.Tipo = tipo;
            this.Cantidad = cantidad;
            this.Total = total;
        }

        public string Tipo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }

    }
}
