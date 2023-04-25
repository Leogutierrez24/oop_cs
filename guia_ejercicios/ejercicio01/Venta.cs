using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    public class Venta
    {
        public Venta()
        {
            this.Fecha = DateTime.Now;
            this.Total = 0;
            this.Productos = new List<Producto>();
        }

        public DateTime Fecha { get; set; }

        public List<Producto> Productos { get; set; }

        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"{this.Fecha.ToShortDateString()} ${this.Total}";
        }

    }
}
