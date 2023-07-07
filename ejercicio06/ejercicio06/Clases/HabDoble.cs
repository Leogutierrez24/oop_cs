using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabDoble : Habitacion
    {
        public HabDoble(int numero, bool marVista = false) : base(numero, marVista) 
        {
            this._costo = marVista ? 350 * 1.15f : 350;
            this._camas = new List<string> { "2 Plazas" };
        }

        public override string ToString()
        {
            return $"{Numero} Doble {(VistaMar ? "con vista al mar" : "sin vista al mar")} ${(string.Format("{0:0.00}", this._costo))}";
        }
    }
}
