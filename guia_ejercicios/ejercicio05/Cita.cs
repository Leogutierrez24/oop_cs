using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    public class Cita
    {
        private readonly DateTime _fecha;
        private readonly int _horaInicial;
        private readonly int _horaFinal;

        public DateTime Fecha
        {
            get { return _fecha; }
        }

        public int HoraInicial
        {
            get { return _horaInicial; }
        }

        public int HoraFinal
        {
            get { return _horaFinal; }
        }

        public Cita(DateTime fecha, int horaInicial, int horaFinal)
        {
            this._fecha = fecha;
            this._horaInicial = horaInicial;
            this._horaFinal = horaFinal;
        }
    }
}
