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
        private Cerveza _cerveza;
        private float _capacidad;
        private float _recaudacion;
        private int _ventas;

        public Cerveza Cerveza
        {
            get { return _cerveza; }            
        }

        public float Capacidad
        {
            get { return _capacidad; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Ventas
        {
            get { return _ventas; }
        }

        public Barril(Cerveza cerveza)
        {
            this._cerveza = cerveza;
            this._capacidad = 0;
            this._recaudacion = 0;
            this._ventas = 0;
        }

        public void AgregarVenta(float total)
        {
            this._recaudacion += total;
            this._ventas++;
        }
    }
}
