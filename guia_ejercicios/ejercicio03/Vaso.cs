using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public class Vaso
    {
        private string _tipo;
        private float _capacidad;

        public string Tipo
        {
            get { return _tipo; }
        }

        public float Capacidad
        {
            get { return _capacidad; }
        }

        public Vaso(string nombre, float capacidad)
        {
            this._tipo = nombre;
            this._capacidad = (capacidad >= 0) ? capacidad : 0;
        }
    }
}
