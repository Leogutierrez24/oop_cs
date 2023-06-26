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

        private List<Huesped> _huespedes = new List<Huesped>();

        public List<Huesped> Huespedes
        {
            get { return _huespedes; }
        }

        public Hotel() 
        {
            this.InicializarHotel();
        }

        // método de inicialización de habitaciones.

        private void InicializarHotel()
        {
            HabSimple hab_1 = new HabSimple(1);
            HabSimple hab_2 = new HabSimple(2, true);
            HabDoble hab_3 = new HabDoble(3);
            HabDoble hab_4 = new HabDoble(4, true);
            HabTriple hab_5 = new HabTriple(5, true);
            HabCuadruple hab_6 = new HabCuadruple(6, true);
            HabCuadruple hab_7 = new HabCuadruple(7);

            this._habitaciones = new List<Habitacion>{hab_1, hab_2, hab_3, hab_4, hab_5, hab_6, hab_7 };

            Huesped huesped_01 = new Huesped(32145543, "Martín", "Garabal", 31, DateTime.Now);
            Huesped huesped_02 = new Huesped(34213454, "Miguel", "Granados", 36, DateTime.Now);

            this._huespedes = new List<Huesped> { huesped_01, huesped_02 };

        }

        // métodos de operaciones con los huspedes

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
    }
}
