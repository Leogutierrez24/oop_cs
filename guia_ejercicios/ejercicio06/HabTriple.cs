using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabTriple : Habitacion
    {
        public HabTriple(int numero, bool vistaMar = false) : base(numero, vistaMar)
        {
            this._costo = vistaMar ? 550 * 1.15f : 550;
            this._camas = new List<string> { "2 Plazas", "1 Plaza" };
        }

        public override string ToString()
        {
            return $"{Numero} Triple {(VistaMar ? "con vista al mar" : "sin vista al mar")} ${(string.Format("{0:0.00}", this._costo))}";
        }
    }
}
