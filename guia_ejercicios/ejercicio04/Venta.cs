using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    public class Venta
    {
        private VasoConCerveza _producto;
        private float _total;

        public VasoConCerveza Producto
        {
            get { return _producto; }
        }

        public float Total
        {
            get { return _total; }
        }

        public Venta(VasoConCerveza productoVendido)
        {
            this._producto = productoVendido;
            this._total = productoVendido.Precio;
        }
    }
}
