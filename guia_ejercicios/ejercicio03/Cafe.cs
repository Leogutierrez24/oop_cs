using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public class Cafe
    {
        private string _tipo;
        private float _precio;
        private float _recaudacion;
        private int _ventas;

        public string Tipo
        {
            get { return _tipo; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Ventas
        {
            get { return _ventas; }
        }

        public Cafe(string tipo, float precio)
        {
            this._tipo = tipo;
            this._precio = precio;
            this._recaudacion = 0;
            this._ventas = 0;
        }

        public void Vender(float precioVenta)
        {
            this._recaudacion += precioVenta;
            this._ventas++;
        }
    }
}
