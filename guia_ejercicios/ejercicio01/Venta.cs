using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    public class Venta
    {
        private DateTime _fecha;
        private float _total;
        private List<Producto> _productos;


        public DateTime Fecha
        {
            get {  return _fecha; }
        }

        public List<Producto> Productos {
            get { return _productos; }
        }

        public float Total
        {
            get { return _total; }
        }

        public Venta(Carrito unCarrito)
        {
            this._fecha = DateTime.Now;
            this._total = unCarrito.Subtotal;
            this._productos = unCarrito.Productos;
        }

        public override string ToString()
        {
            return $"{this.Fecha.ToShortDateString()} ${this._total}";
        }

    }
}
