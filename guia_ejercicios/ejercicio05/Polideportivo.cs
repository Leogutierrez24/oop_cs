using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    public class Polideportivo
    {
        private List<Juez> _jueces = new List<Juez>();
        private List<Cancha> _canchas = new List<Cancha>();
        private List<Alquiler> _alquileres = new List<Alquiler>();
        private float _recaudacion = 0f;

        public List<Juez> Jueces
        {
            get { return _jueces; }
        }

        public List<Cancha> Canchas
        {
            get { return _canchas; }
        }

        public List <Alquiler> Alquileres
        {
            get { return _alquileres; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public Polideportivo()
        {
            this.InicializarCanchas();
        }

        private void InicializarCanchas()
        {
            Opcion opcional01 = new Opcion
                (
                    1,
                    100,
                    50,
                    "Agregar 1 juez, adiciona $100 al valor de la cancha."
                );
            Opcion opcional02 = new Opcion
                (
                    2,
                    90,
                    35,
                    "Opcion 1 + 2 jueces de línea, incrementando $190 al costo total."
                );

            Cancha tenis = new Cancha(1, "Tenis", 200, new List<Opcion>{ opcional01 });
            Cancha futbol5 = new Cancha(2, "Fútbol 5", 500);
            Cancha futbol7 = new Cancha(3, "Fútbol 7", 650, new List<Opcion>{ opcional01 });
            Cancha futbol11 = new Cancha(4, "Fútbol 11", 800, new List<Opcion>{ opcional01, opcional02 });

            this._canchas = new List<Cancha> { tenis, futbol5, futbol7, futbol11 };
        }

        // Operaciones de canchas
        public bool ComprobarID(Cancha unaCancha)
        {
            Cancha busqueda = this._canchas.Find(cancha => cancha.Id == unaCancha.Id);
            return busqueda == null;
        }

        public void AgregarCancha(Cancha nuevaCancha)
        {
            this._canchas.Add(nuevaCancha);
        }

        // Operaciones de jueces
        public bool ComprobarID(Juez unJuez)
        {
            Juez busqueda = this._jueces.Find(juez => juez.Legajo == unJuez.Legajo);
            return busqueda == null;
        }

        public void AgregarJuez(Juez nuevoJuez)
        {
            this._jueces.Add(nuevoJuez);
        }

        public void EliminarJuez(Juez unJuez)
        {
            this._jueces.Remove(unJuez);
        }

        public List<Juez> JuecesDisponibles(DateTime fecha, int horario, int horas)
        {
            List<Juez> juecesDisponibles = new List<Juez>();

            foreach (Juez juez in this._jueces)
            {
                if (juez.ComprobarCita(fecha, horario, horario + horas))
                {
                    juecesDisponibles.Add(juez);
                }
            }

            return juecesDisponibles;
        } 

        // Operaciones de alquileres
        public void GenerarAlquiler(Cancha cancha, List<Juez> jueces, DateTime fecha, int horaInicial, int horas, Opcion opcion)
        {
            foreach (Juez juez in jueces)
            {
                juez.OrganizarCita(fecha, horaInicial, horaInicial + horas);
            }

            Alquiler nuevoAlquiler = new Alquiler(cancha, jueces, fecha, horaInicial, horas, opcion);
            this._alquileres.Add(nuevoAlquiler);
        }

        public List<Alquiler> FiltarAlquileres(DateTime fecha)
        {
            List<Alquiler> alquileresFiltrados = new List<Alquiler>();

            foreach(Alquiler alquiler in this._alquileres)
            {
                if (alquiler.Fecha == fecha) alquileresFiltrados.Add(alquiler);
            }

            return alquileresFiltrados;
        }

        public float CalcularTotalAlquiler(Cancha cancha, Opcion opcion, int horas)
        {
            float total;

            if (opcion != null)
            {
                total = (cancha.Precio + opcion.Aumento) * horas;
            }
            else
            {
                total = cancha.Precio * horas;
            }

            return total;
        }

        public bool ComprobarDisponibilidad(DateTime fecha, int horas, int horaInicio)
        {
            bool disponible = true;

            if (this._alquileres.Count > 0)
            {
                List<Alquiler> alquilerMismaFecha = this._alquileres.FindAll(alquiler => alquiler.Fecha == fecha);

                if (alquilerMismaFecha.Count != 0)
                {
                    if (alquilerMismaFecha.Exists(alquiler => alquiler.HoraInicial == horaInicio))
                    {
                        disponible = false;
                    } else if (alquilerMismaFecha.Exists(alquiler => alquiler.HoraInicial > horaInicio && alquiler.HoraInicial < (horaInicio + horas)))
                    {
                        disponible = false;
                    } else if (alquilerMismaFecha.Exists(alquiler => alquiler.HoraFinal > horaInicio && alquiler.HoraFinal < (horaInicio + horas)))
                    {
                        disponible = false;
                    }
                }
            }

            return disponible;
        }



    }
}
