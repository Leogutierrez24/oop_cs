using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public enum TipoCafe
    {
        Arabigo = 1,
        Robusto = 2,
    }

    public class Cafe
    {
        private TipoCafe _tipo;
        private float _precio;
        
        public TipoCafe Tipo
        {
            get { return _tipo; }
        }

        public float Precio
        {
            get { return _precio; }
        }

        public Cafe(TipoCafe tipoCafe)
        {
            this._tipo = tipoCafe;
            this._precio = ((int)tipoCafe == 1) ? 50 : 58;
        }

        public void ActualizarPrecio(float nuevoPrecio)
        {
            this._precio = nuevoPrecio;
        }
    }
}
