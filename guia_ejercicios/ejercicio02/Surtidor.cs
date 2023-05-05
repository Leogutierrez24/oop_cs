using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public class Surtidor
    {
        private string _nafta;
        private decimal _precio;
        private decimal _cantidad;
        private int _recargas;

        public string Nafta
        {
            get { return _nafta; } 
            set {  _nafta = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set 
            {
                if (value > 0)
                {
                    _precio = value;
                }
            }
        }

        public decimal Cantidad
        {
            get { return _cantidad; }
            set
            {
                    _cantidad = value;
            }
        }

        public int Recargas
        {
            get { return _recargas; }
            private set
            {
                _recargas = value;
            }
        }

        public Surtidor(string tipoNafta, decimal precio, decimal cantidad)
        {
            this._nafta = tipoNafta;
            this._precio = precio;
            this._cantidad = cantidad;
            this._recargas = 0;
        }

        public void Descargar(decimal cantDescarga)
        {
            if (this._cantidad <= 0 || cantDescarga > this._cantidad)
            {
                MessageBox.Show("El surtidor esta vacío o no dispone esa cantidad!");
            } else
            {
                this._cantidad -= cantDescarga;
            }
        }

        public void Cargar()
        {
            if (this._cantidad < 100)
            {
                this._cantidad = 100;
                this._recargas++;
                MessageBox.Show("Surtidos cargado!");
            } else
            {
                MessageBox.Show("El surtidor esta lleno!");
            }   
        }
    }
}
