using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public class Alquiler
    {
        private Cancha _cancha;
        private Opcion _opcion;
        private List<Juez> _jueces = new List<Juez>();
        private DateTime _fecha;
        private int _horaInicial;
        private int _horaFinal;
        private int _horas;
        private float _total;

        public Cancha Cancha
        {
            get { return _cancha; }
        }

        public Opcion Opcion
        {
            get { return _opcion; }
        }

        public List<Juez> Jueces
        {
            get { return _jueces; }
        }

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

        public int Horas
        {
            get { return _horas; }
        }

        public float Total
        {
            get { return _total; }
        }

       public Alquiler(Cancha cancha, List<Juez> jueces, DateTime fecha, int horaInicial, int horas, Opcion opcion = null)
        {
            this._cancha = cancha;
            this._opcion = opcion;
            this._jueces = jueces;
            this._fecha = fecha;
            this._horaInicial = horaInicial;
            this._horaFinal = horaInicial + horas;
            this._horas = horas;
            this._total = this.CalcularTotal(cancha, opcion, horas);
        }

        private float CalcularTotal(Cancha cancha, Opcion opcion, int horas)
        {
            float total;

            if (opcion != null)
            {
                total = (cancha.Precio + opcion.Aumento) * horas;
            } else
            {
                total = cancha.Precio * horas;
            }

            return total;
        }
    }
}
