using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    public class SurtidorConRecaudacion : Surtidor
    {
        private decimal _recaudacion;

        public decimal Recaudacion
        {
            get { return _recaudacion; }
            set { _recaudacion = value; }
        }

        public SurtidorConRecaudacion(Surtidor unSurtidor, decimal recaudacion)
        {
            this.Nafta = unSurtidor.Nafta;
            this.Precio = unSurtidor.Precio;
            this.Cantidad = unSurtidor.Cantidad;
            this._recaudacion = recaudacion;
        }

    }
}
