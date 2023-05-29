using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    public class Cancha
    {
        private int _id;
        private string _tipo;
        private float _precio; // Precio por Hora
        private List<string> _opciones = new List<string>();
        private float _recaudacion = 0;
        private int _alquileres = 0;
        private bool _estado = true;

        public int Id
        {
            get { return _id; }
        }

        public string Tipo
        {
            get { return _tipo; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public List<string> Opciones
        {
            get { return _opciones; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Alquileres
        {
            get { return _alquileres; }
        }

        public bool Estado
        {
            get { return _estado; }
        }

        public Cancha(int id, string tipo, float precio)
        {
            this._id = id;
            this._tipo = tipo;
            this._precio = precio;
        }

        public Cancha(int id, string tipo, float precio, List<string> opciones)
        {
            this._id = id;
            this._tipo = tipo;
            this._precio = precio;
            this._opciones = opciones;
        }

        public void CambiarEstado()
        {
            this._estado = !this._estado;
        }

        public void AsignarAlquiler(float costo)
        {
            this.CambiarEstado();
            this._recaudacion += costo;
            this._alquileres++;
        }

        public void CancelarAlquiler(float costo)
        {
            this.CambiarEstado();
            this._recaudacion -= costo;
            this._alquileres--;
        }
    }
}
