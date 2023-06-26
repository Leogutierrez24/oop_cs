using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Reserva
    {
        private int _numeroReserva;

        public int numeroReserva { get {  return _numeroReserva; } }

        private List<Habitacion> _habitaciones = new List<Habitacion>();

        public List<Habitacion> Habitaciones
        {
            get { return _habitaciones; }
        }

        private List<Huesped> _ocupantes = new List<Huesped>();

        public List<Huesped> Ocupantes
        {
            get { return _ocupantes; }
        }

        private List<Adicional> _adicionales = new List<Adicional>(); // opciones extra que se agregan y aumentan el valor de la reserva final

        public List<Adicional> Adicionales
        {
            get { return _adicionales; }
        }

        private DateTime _fechaReserva;

        public DateTime FechaReserva
        {
            get { return _fechaReserva; } 
        }

        private DateTime _fechaEntrada;

        public DateTime FechaEntrada
        {
            get { return _fechaEntrada; } 
        }

        private DateTime _fechaSalida;

        public DateTime FechaSalida
        {
            get { return _fechaSalida; }
        }

        private float _deposito;

        public float Deposito
        {
            get { return _deposito; }
        }

        private float _total;

        public float Total
        {
            get { return _total; }
        }

        private int _duracion;

        public int Duracion // en DÍAS
        {
            get { return _duracion; }
        }

        public Reserva(
            int numeroReserva,
            List<Habitacion> habitaciones,
            List<Huesped> ocupantes,
            List<Adicional> adicionales,
            DateTime fechaEntrada,
            DateTime fechaSalida,
            float deposito,
            float total
            )
        {
            this._numeroReserva = numeroReserva;
            this._habitaciones = habitaciones;
            this._ocupantes = ocupantes;
            this._adicionales = adicionales;
            this._fechaReserva = DateTime.Now.Date;
            this._fechaEntrada = fechaEntrada;
            this._fechaSalida = fechaSalida;
            this._deposito = deposito;
            this._total = total;
            this._duracion = fechaSalida.Day - fechaEntrada.Day;
        }
    }
}
