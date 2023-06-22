using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabCuadruple : Habitacion
    {
        private readonly List<string> _camas = new List<string> { "2 Plazas", "Cama-cucheta" };

        public List<string> Camas
        {
            get { return _camas; }
        }

        public HabCuadruple(int numero, bool vistaMar = false) : base(numero, vistaMar)
        {
            this._costo = vistaMar ? 700 * 1.5f : 700;
        }
    }
}
