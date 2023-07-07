using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio04
{
    public class Cerveza
    {
        private string _tipo;
        private float _precio; // precio por litro
        private float _recaudacion;
        private int _ventas;
        private float _cantidadVendida = 0;

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

        public float CantidadVendida
        {
            get { return _cantidadVendida; }
        }

        public Cerveza(string tipo, float precio)
        {
            this._tipo = tipo;
            this._precio = precio;
            this._recaudacion = 0;
            this._ventas = 0;
        }

        public void AgregarVenta(float total, float litrosVendidos)
        {
            this._recaudacion += total;
            this._cantidadVendida += litrosVendidos;
            this._ventas++;
        }

        public override string ToString()
        {
            return string.Format("{0} ${1:0.00}", this._tipo, this._precio);
        }
    }
}
