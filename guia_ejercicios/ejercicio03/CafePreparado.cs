using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public class CafePreparado
    {
        readonly private string _contenido;
        readonly private Vaso _vaso;
        readonly private float _precio;

        public string Contenido
        {
            get { return _contenido; }
        }

        public Vaso Vaso
        {
            get { return _vaso; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public CafePreparado(string contenido, Vaso vaso, float precio)
        {
            this._contenido = contenido;
            this._vaso = vaso;
            this._precio = precio;
        }
    }
}
