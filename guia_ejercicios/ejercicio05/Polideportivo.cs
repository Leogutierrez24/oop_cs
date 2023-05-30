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


        // Operaciones de canchas

        public bool ComprobarID(Cancha unaCancha)
        {
            return true;
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

        // Operaciones de alquileres

        public void GenerarAlquiler()
        {

        }


    }
}
