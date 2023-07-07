using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabSimple : Habitacion
    {
        public HabSimple(int numero, bool vistaMar = false) : base(numero, vistaMar)
        {
            this._costo = vistaMar ? 200 * 1.15f : 200;
            this._camas = new List<string>{ "1 Plaza" };
        }

        public override string ToString()
        {
            return $"{Numero} Simple {(VistaMar ? "con vista al mar" : "sin vista al mar")} ${(string.Format("{0:0.00}", this._costo))}";
        }
    }
}
