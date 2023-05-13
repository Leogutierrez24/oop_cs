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
        private string _nafta;
        private float _cantidad;
        private float _total;

        public string Nafta
        {
            get { return _nafta; }
        }

        public float Cantidad
        {
            get { return _cantidad; }
        }

        public float Total
        {
            get { return _total; }
        }

        public Venta(string tipoNafta, float cantidad, float total)
        {
            this._nafta = tipoNafta;
            this._cantidad = cantidad;
            this._total = total;
        }
    }
}
