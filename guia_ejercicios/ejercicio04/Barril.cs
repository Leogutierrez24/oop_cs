using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    public class Barril
    {
        private int _id;
        private Cerveza _cerveza;
        private float _capacidad;
        private float _cantidad;
        private float _recaudacion;
        private int _ventas;

        public int Id
        {
            get { return _id; }
        }

        public Cerveza Cerveza
        {
            get { return _cerveza; }            
        }

        public float Capacidad
        {
            get { return _capacidad; }
        }

        public float Cantidad
        {
            get { return _cantidad; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Ventas
        {
            get { return _ventas; }
        }

        public Barril(int id, Cerveza cerveza, int capacidad)
        {
            this._id = id;
            this._cerveza = cerveza;
            this._capacidad = capacidad;
            this._recaudacion = 0;
            this._ventas = 0;
        }

        public void AgregarVenta(float total)
        {
            this._cerveza.AgregarVenta(total);
            this._recaudacion += total;
            this._ventas++;
        }

        private void Descargar(float cantidad)
        {
            this._cantidad -= cantidad;
        }

        public VasoConCerveza ServirCerveza(Vaso vaso)
        {
            VasoConCerveza vasoConBirra = null;

            if (vaso.Cantidad <= this._cantidad)
            {
                vaso.Solicitar();
                this.Descargar(vaso.Cantidad);
                vasoConBirra = new VasoConCerveza(vaso, this._cerveza);
                this.AgregarVenta(vasoConBirra.Precio);
            }
            
            return vasoConBirra;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this._id, this._cerveza, (this._cantidad == 0) ? "Vacío" : this._cantidad.ToString());
        }
    }
}
