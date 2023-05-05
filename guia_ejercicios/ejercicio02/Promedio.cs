using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    public class Promedio
    {
        private string _item;

        public string Item
        {
            get { return _item; }
            set { _item = value; }
        }

        private float _porcentaje;

        public float Porcentaje
        {
            get { return _porcentaje; }
            set { _porcentaje = value; }
        }

        public Promedio(string item, float porcentaje)
        {
            this._item = item;
            this._porcentaje = porcentaje;
        }

        public override string ToString()
        {
            return string.Format("{0} {1:0.00}", this._item, this._porcentaje);
        }
    }
}
