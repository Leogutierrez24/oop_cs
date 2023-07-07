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

        private Habitacion _habitacion;

        public Habitacion Habitacion
        {
            get { return _habitacion; }
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

        private float _subtotal;

        public float Subtotal
        {
            get { return _subtotal; }
        }

        private bool _checkinEstado;

        public bool CheckinEstado
        {
            get { return _checkinEstado; }
        }

        private bool _checkoutEstado;

        public bool CheckoutEstado
        {
            get { return _checkoutEstado; }
        }

        public Reserva(
            int numeroReserva,
            Habitacion habitacion,
            List<Huesped> ocupantes,
            List<Adicional> adicionales,
            DateTime fechaEntrada,
            DateTime fechaSalida,
            float deposito,
            float total
            )
        {
            this._numeroReserva = numeroReserva;
            this._habitacion = habitacion;
            this._ocupantes = ocupantes;
            this._adicionales = adicionales;
            this._fechaReserva = DateTime.Now;
            this._fechaEntrada = fechaEntrada;
            this._fechaSalida = fechaSalida;
            this._deposito = deposito;
            this._subtotal = total;
            this._checkinEstado = false;
            this._checkoutEstado = false;
        }

        public override string ToString()
        {
            return $"00{this.numeroReserva} {this.FechaReserva.ToShortDateString()}";
        }

        public void ConcretarCheckin()
        {
            this._checkinEstado = true;
        }

        public void ConcretarCheckout()
        {
            this._checkoutEstado = true;
        }
    }
}
