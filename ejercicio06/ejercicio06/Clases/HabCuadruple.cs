using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabCuadruple : Habitacion
    {
        public HabCuadruple(int numero, bool vistaMar = false) : base(numero, vistaMar)
        {
            this._costo = vistaMar ? 700 * 1.15f : 700;
            this._camas = new List<string> { "2 Plazas", "Cama-cucheta" };
        }

        public override string ToString()
        {
            return $"{Numero} Cuadruple {(VistaMar ? "con vista al mar" : "sin vista al mar")} ${(string.Format("{0:0.00}", this._costo))}";
        }
    }
}
