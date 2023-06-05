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
        private List<Opcion> _opciones = new List<Opcion>();
        private List<Juez> _jueces = new List<Juez>();
        private DateTime _fecha;
        private int _horario;
        private int _horas;
        private float _total;

        public Cancha Cancha
        {
            get { return _cancha; }
        }

        public List<Opcion> Opciones
        {
            get { return _opciones; }
        }

        public List<Juez> Jueces
        {
            get { return _jueces; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
        }

       public Alquiler(Cancha cancha, List<Opcion> opciones, List<Juez> jueces, DateTime fecha, int horario, int horas)
        {
            this._cancha = cancha;
            this._opciones = opciones;
            this._jueces = jueces;
            this._fecha = fecha;
            this._horario = horario;
            this._horas = horas;
            this._total = this.CalcularTotal(cancha, opciones, horas);
        }

        public float CalcularTotal(Cancha cancha, List<Opcion> opciones, int horas)
        {
            float total = 0;

            if (opciones.Count == 0)
            {
                total = cancha.Precio * horas;
            } else if (opciones.Count == 1)
            {
                total = (opciones[0].Aumento + cancha.Precio) * horas;
                
            } else
            {
                total += cancha.Precio;
                foreach (Opcion opcion in opciones) total += opcion.Aumento;
                total *= horas;
            }

            return total;
        }
    }
}
