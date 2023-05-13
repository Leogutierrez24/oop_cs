using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public class Venta
    {
        private float _total;
        private CafePreparado _producto;

        public float Total
        {
            get { return _total; }
        }

        public CafePreparado Productos
        {
            get { return _producto; }
        }

        public Venta(float totalVendido, CafePreparado cafeVendido)
        {
            this._total = totalVendido;
            this._producto = cafeVendido;
        }
    }
}
