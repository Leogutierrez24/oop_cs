using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO.Clases
{
    public class Pasaporte
    {
        private Visitante _visitante;

        public Visitante Visitante { get { return _visitante; } }

        private List<Atraccion> _atracciones = new List<Atraccion>();

        public List<Atraccion> Atracciones
        {
            get { return _atracciones; }
        }

        private float _costo;

        public float Costo
        {
            get { return _costo; }
        }

        private bool _descuento;

        public bool Descuento
        {
            get { return _descuento; }
        }

        public Pasaporte(Visitante visitante, List<Atraccion> atracciones)
        {
            this._visitante = visitante;
            this._atracciones = atracciones;
            this._costo = this.CalcularCosto(50, this._atracciones.Count);
            this._descuento = false;
            this.AplicarDescuento();
        }

        public Pasaporte(Visitante visitante, Atraccion atraccion)
        {
            this._visitante = visitante;
            this._atracciones.Add(atraccion);
            this._costo = this.CalcularCosto(50, this._atracciones.Count);
            this._descuento = false;
            this.AplicarDescuento();
        }

        public float CalcularCosto(float costoAtraccion, int cantAtracciones)
        {
            float costo;

            if (cantAtracciones == 1)
            {
                costo = costoAtraccion;
            } else if (cantAtracciones == 2)
            {
                costo = (costoAtraccion * 2) - ((costoAtraccion * 2) * 10 / 100);
            } else if (cantAtracciones == 3)
            {
                costo = (costoAtraccion * 3) - ((costoAtraccion * 2) * 30 / 100);
            } else
            {
                costo = 0;
            }

            return costo;
        }

        public bool ComprobarDescuento()
        {
            bool comprobacion = false;
            int edad = this._visitante.CalcularEdad();

            if (edad < 12 || edad > 65)
            {
                comprobacion = true;
            }

            return comprobacion;
        }

        private void AplicarDescuento()
        {
            if (this.ComprobarDescuento())
            {
                this._costo /= 2;
                this._descuento = true;
            }
        }
    }
}
