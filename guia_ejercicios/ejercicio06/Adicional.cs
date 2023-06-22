using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Adicional
    {
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
        }

        private float _costo;

        public float Costo
        {
            get { return _costo; }
        }

        public Adicional(string descripcion, float costo) 
        {
            this._descripcion = descripcion;
            this._costo = costo;
        }
    }
}
