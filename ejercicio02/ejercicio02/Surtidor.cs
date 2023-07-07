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
        private Nafta _nafta;
        private float _cantidad;
        private float _recaudacion;
        private int _recargas;
        private List<Venta> _ventas = new List<Venta>();

        public Nafta Nafta
        {
            get { return _nafta; } 
        }

        public float Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Recargas
        {
            get { return _recargas; }
            private set {_recargas = value; }
        }

        public List<Venta> Ventas
        {
            get { return _ventas; }
        }

        public Surtidor()
        {
            this._cantidad = 0;
            this._recargas = 0;
            this._recaudacion = 0;
        }

        public void Descargar(float cantDescarga)
        {
            if (this._cantidad <= 0 || cantDescarga > this._cantidad)
            {
                MessageBox.Show("El surtidor esta vacío o no dispone esa cantidad!");
            } else
            {
                this._cantidad -= cantDescarga;
            }
        }

        public void CargaInicial(float totalCarga)
        {
            if (totalCarga <= 100 && totalCarga >= 0)
            {
                this._cantidad = totalCarga;
            } else
            {
                MessageBox.Show("¡La cantidad de carga a cargar es inválida!");
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

        public void EstablecerNafta(Nafta unaNafta)
        {
            this._nafta = unaNafta;
        }

        public void CerrarVenta(float cantCombustible)
        {
            float total = cantCombustible * this.Nafta.Precio;

            if (this.Cantidad >= cantCombustible)
            {
                this.Descargar(cantCombustible);

                Venta nuevaVenta = new Venta(this.Nafta.Tipo, cantCombustible, total);
                this._ventas.Add(nuevaVenta);

                this._recaudacion += total;
                this.Nafta.AgregarVenta(total);

                MessageBox.Show("¡Venta Registrada!");
            }
            else
            {
                MessageBox.Show("¡No hay combustible suficiente para completar la venta!");
            }
        }
    }
}
