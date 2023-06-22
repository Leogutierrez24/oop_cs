using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class HabDoble : Habitacion
    {
        private readonly string _cama = "2 Plazas";

        public string Cama
        {
            get { return _cama; }
        }

        public HabDoble(int numero, bool marVista = false) : base(numero, marVista) 
        {
            this._costo = marVista ? 350 * 1.15f : 350; 
        }
    }
}
