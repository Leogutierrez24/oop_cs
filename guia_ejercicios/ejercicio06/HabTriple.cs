using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabTriple : Habitacion
    {
        private readonly List<string> _camas = new List<string> {"2 Plazas", "1 Plaza" };

        public List<string> Camas
        {
            get { return _camas; }
        }

        public HabTriple(int numero, bool vistaMar = false) : base(numero, vistaMar)
        {
            this._costo = vistaMar ? 550 * 1.15f : 550;
        }
    }
}
