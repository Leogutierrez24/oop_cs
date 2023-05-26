using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    public class Vaso
    {
        private string _tipo;
        private float _cantidad;
        private int _ventas;

        public string Tipo
        {
            get { return _tipo; }
        }

        public float Cantidad
        {
            get { return _cantidad; }
        }

        public int Ventas
        {
            get { return _ventas;  }
        }

        public Vaso(string tipo, float cantidad)
        {
            this._tipo = tipo;
            this._cantidad = cantidad;
            this._ventas = 0;
        }

        public void Solicitar()
        {
            this._ventas++;
        }

        public override string ToString()
        {
            return string.Format("{0} {1:0.000} Litros", this._tipo, this._cantidad);
        }
    }
}
