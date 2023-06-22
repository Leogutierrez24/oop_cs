using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabSimple : Habitacion
    {
        private readonly string _cama = "1 Plaza";

        public string Cama
        {
            get { return _cama; }
        }

        public HabSimple(int numero, bool vistaMar = false) : base(numero, vistaMar)
        {
            this._costo = vistaMar ? 200 * 1.15f : 200;
        }
    }
}
