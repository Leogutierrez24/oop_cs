using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Hotel
    {
        private List<Habitacion> _habitaciones = new List<Habitacion>();

        public List<Habitacion> Habitaciones
        {
            get { return _habitaciones; }
        }

        private List<Reserva> _reservas = new List<Reserva>();

        public List<Reserva> Reservas
        {
            get { return _reservas; }
        }

        public Hotel() { }
    }
}
