using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Hotel
    {
        private int _numReservas = 0;
        private int _numComprobantes = 0;

        private float _recaudacion;

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

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

        private List<Reserva> _reservasConcretadas = new List<Reserva>();

        public List<Reserva> ReservasConcretadas
        {
            get { return _reservasConcretadas; }
        }

        private List<Huesped> _huespedes = new List<Huesped>();

        public List<Huesped> Huespedes
        {
            get { return _huespedes; }
        }

        private List<Adicional> _adicionales = new List<Adicional>();

        public List<Adicional> Adicionales
        {
            get { return _adicionales; }
        }

        private List<Habitacion> _habitacionesOcupadas = new List<Habitacion>();

        public List<Habitacion> HabitacionesOcupadas
        {
            get { return _habitacionesOcupadas; }
        }

        private List<Comprobante> _comprobantes = new List<Comprobante>();

        public List<Comprobante> Comprobantes
        {
            get { return _comprobantes; }
        }

        public Hotel() 
        {
            this.InicializarHotel();
            this._recaudacion = 0;
        }

        // inicialización del ejercicio.

        private void InicializarHotel()
        {
            // habitaciones
            HabSimple hab_1 = new HabSimple(1);
            HabSimple hab_2 = new HabSimple(2, true);
            HabDoble hab_3 = new HabDoble(3);
            HabDoble hab_4 = new HabDoble(4, true);
            HabTriple hab_5 = new HabTriple(5, true);
            HabCuadruple hab_6 = new HabCuadruple(6, true);
            HabCuadruple hab_7 = new HabCuadruple(7);

            this._habitaciones = new List<Habitacion>{hab_1, hab_2, hab_3, hab_4, hab_5, hab_6, hab_7 };

            // huespedes
            Huesped huesped_01 = new Huesped(32145543, "Martín", "Garabal", 31, DateTime.Now);
            Huesped huesped_02 = new Huesped(34213454, "Miguel", "Granados", 36, DateTime.Now);

            this._huespedes = new List<Huesped> { huesped_01, huesped_02 };

            // adicionales
            Adicional adicional1 = new Adicional("Agregar cuna a la habitación", 50);
            Adicional adicional2 = new Adicional("Consumo del frigobar", 17);

            this._adicionales = new List<Adicional> { adicional1, adicional2 };

            // reservas
            this.GenerarReserva(hab_3, new List<Huesped> { huesped_01 }, new List<Adicional>(), new DateTime(2023, 12, 19), new DateTime(2023, 12, 24), 210, 2100);
        }

        // operaciones con huspedes

        private int VerificarHuesped(long documento) // Verificación de si ya existe el huesped que se quiere registrar (por su doc.)
        {
            int resultado;

            Huesped huespedRegistrado = this._huespedes.Find(huesped => huesped.Documento == documento);

            if(huespedRegistrado == null)
            {
                resultado = 0;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }

        public int RegistrarHuesped(Huesped nuevoHuesped)
        {
            int comprobacion = this.VerificarHuesped(nuevoHuesped.Documento);

            if (comprobacion == 0)
            {
                this._huespedes.Add(nuevoHuesped);
            }

            return comprobacion;
        }

        // operaciones con reservas

        public float CalcularCosto(Habitacion habitacion, int cantDias, List<Adicional> adicionales)
        {
            float resultado = 0;

            float costo = habitacion.Costo;

            if (adicionales.Count > 0) adicionales.ForEach(adicional => costo += adicional.Costo);

            resultado = costo * cantDias;

            return resultado;
        }

        public float CalcularDepositoMinimo(float total)
        {
            return (total * 10) / 100;
        }

        public int CalcularDiasReserva(DateTime fechaCheckin, DateTime fechaCheckout)
        {
            TimeSpan cantDias = fechaCheckout - fechaCheckin;

            return cantDias.Days + 1;
        }

        public Reserva GenerarReserva(
            Habitacion habitacion,
            List<Huesped> ocupantes,
            List<Adicional> adicionales,
            DateTime fechaEntrada,
            DateTime fechaSalida,
            float deposito,
            float total)
        {
            Reserva nuevaReserva = new Reserva(
                    this._numReservas + 1,
                    habitacion,
                    ocupantes,
                    adicionales,
                    fechaEntrada,
                    fechaSalida,
                    deposito,
                    total
                );

            if (this.ComprobarDisponibilidad(nuevaReserva) != -1)
            {
                this._numReservas++;

                this._reservas.Add(nuevaReserva);

                this._numComprobantes++;

                Comprobante comprobanteReserva = new Comprobante(this._numComprobantes, nuevaReserva.FechaReserva, nuevaReserva.Deposito, MotivoComprobante.Deposito, nuevaReserva.numeroReserva);
                this._comprobantes.Add(comprobanteReserva);
            } else
            {
                nuevaReserva = null;
            }
            
            return nuevaReserva;
        }

        private int ComprobarDisponibilidad(Reserva nuevaReserva)
        {
            int resultado = 0;

            List<Reserva> reservasMismaHabitacion = this._reservas.FindAll( reserva => reserva.Habitacion.Numero == nuevaReserva.Habitacion.Numero);

            if (reservasMismaHabitacion.Count != 0)
            {
                if (reservasMismaHabitacion.Exists(reserva => nuevaReserva.FechaEntrada.ToShortDateString() == reserva.FechaEntrada.ToShortDateString() || nuevaReserva.FechaEntrada.ToShortDateString() == reserva.FechaSalida.ToShortDateString()))
                {
                    resultado = -1;
                } else if (reservasMismaHabitacion.Exists(reserva => nuevaReserva.FechaSalida.ToShortDateString() == reserva.FechaEntrada.ToShortDateString() || nuevaReserva.FechaSalida.ToShortDateString() == reserva.FechaSalida.ToShortDateString())) 
                {
                    resultado = -1;
                } else if (reservasMismaHabitacion.Exists(reserva => nuevaReserva.FechaEntrada < reserva.FechaEntrada && nuevaReserva.FechaSalida > reserva.FechaEntrada))
                {
                    resultado = -1;
                } else if (reservasMismaHabitacion.Exists(reserva => nuevaReserva.FechaEntrada < reserva.FechaSalida && nuevaReserva.FechaSalida > reserva.FechaSalida))
                {
                    resultado = -1;
                } else if (reservasMismaHabitacion.Exists(reserva => nuevaReserva.FechaEntrada > reserva.FechaEntrada && nuevaReserva.FechaSalida < reserva.FechaSalida))
                {
                    resultado = -1;
                }
            }

            return resultado;
        }

        // operaciones con adicionales

        public Adicional CrearAdicional(string descripcion, float costo)
        {
            Adicional nuevoAdicional = null;

            if (costo > 0)
            {
                nuevoAdicional = new Adicional(descripcion, costo);
            }

            return nuevoAdicional;
        }

        // operaciones con habitaciones (checkin, checkout)

        public int RegistrarOcupacion(Reserva reserva)
        {
            int resultado;

            if (reserva.CheckinEstado != true && reserva.CheckoutEstado != true)
            {
                this._habitacionesOcupadas.Add(reserva.Habitacion);
                reserva.Habitacion.Ocupar();
                reserva.ConcretarCheckin();
                resultado = 0;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }

        public int RegistrarDesocupacion(Reserva reserva)
        {
            int resultado;

            if (reserva.CheckinEstado != false && reserva.CheckoutEstado != true)
            {
                Comprobante nuevoComprobante = new Comprobante(this._numComprobantes + 1, DateTime.Now, reserva.Subtotal, MotivoComprobante.Total, reserva.numeroReserva);
                this._numComprobantes++;
                this._comprobantes.Add(nuevoComprobante);

                this._habitacionesOcupadas.Remove(reserva.Habitacion);

                this._reservasConcretadas.Add(reserva);
                this._reservas.Remove(reserva);
                resultado = 0;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }

        // métodos de cancelación

        public Tuple<string, float> CalcularDevolucion(Reserva reserva)
        {
            string motivo;
            float resultado;

            DateTime fechaCancelacion = DateTime.Now;
            TimeSpan dif = reserva.FechaEntrada - fechaCancelacion;
            int dias = dif.Days;

            float totalReserva = reserva.Subtotal;
            float depositoAbonado = reserva.Deposito;
            float pagoMinimo = (totalReserva * 10) / 100;

            if (dias < 2)
            {
                resultado = depositoAbonado - pagoMinimo;
                motivo = $"La diferencia de días es de: {dias} por lo que el reintegro es de: ${(resultado < 0 ? 0 : resultado)}";
            } else if (dias <= 7)
            {
                resultado = depositoAbonado - (pagoMinimo / 2);
                motivo = $"La diferencia de días es de: {dias} por lo que el reintegro es de: ${resultado}";
            } else
            {
                resultado = depositoAbonado;
                motivo = "La diferencia de días es mayor a la semana por lo que se reintegra el total.";
            }

            return new Tuple<string, float>(motivo, resultado);
        }

        public void CancelarReserva(Reserva reserva)
        {
            float devolucion = this.CalcularDevolucion(reserva).Item2;
            this._recaudacion -= devolucion;
            this._reservas.Remove(reserva);
        }
    }
}
