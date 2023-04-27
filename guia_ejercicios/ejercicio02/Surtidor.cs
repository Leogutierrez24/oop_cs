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
        public const decimal LIMITE = 100;

        private string _nafta;
        private decimal _precio;
        private decimal _cantidad;

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
                if (value <= LIMITE && value >= 0)
                {
                    _cantidad = value;
                }
            }
        }

        public void Descargar(decimal cantDescarga)
        {
            if (this._cantidad <= 0 || cantDescarga > this._cantidad)
            {
                MessageBox.Show("El surtidor esta vacío o no dispone esa cantidad!");
            } else
            {
                this._cantidad -= cantDescarga;
                MessageBox.Show($"Se descargaron {cantDescarga} Litros!");
            }
        }

        public void Cargar()
        {
            this._cantidad = 100;
            MessageBox.Show("Surtidos cargado!");
        }
    }
}
