using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    public class VasoConCerveza
    {
        private string _vaso;
        private string _cerveza;
        private float _precio;

        public string Vaso
        {
            get { return _vaso; }
        }

        public string Cerveza
        {
            get { return _cerveza; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public VasoConCerveza(Vaso vaso, Cerveza cerveza)
        {
            this._vaso = vaso.Tipo;
            this._cerveza = cerveza.Tipo;
            this._precio = (vaso.Cantidad * cerveza.Precio) * 1.05f ;
        }

        public override string ToString()
        {
            return string.Format("{0}, ${1:0.00}", this._vaso, this._precio);
        }
    }
}
