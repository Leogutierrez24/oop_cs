using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    public class Nafta
    {
        private string _tipo;
        private float _precio;
        private int _ventas;
        private float _recaudacion;

        public string Tipo
        {
            get { return _tipo; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public int Ventas
        {
            get { return _ventas; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public Nafta(string tipoNafta, float precioNafta)
        {
            this._tipo = tipoNafta;
            this._precio = precioNafta;
            this._ventas = 0;
            this._recaudacion = 0;
        }

        public void AgregarVenta(float total)
        {
            this._ventas++;
            this._recaudacion += total;
        }
    }
}
