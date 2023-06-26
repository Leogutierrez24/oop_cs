using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public abstract class Habitacion
    {
        private int _numero;
        
        public int Numero
        {
            get { return _numero; }
        }

        protected float _costo;

        public float Costo
        {
            get { return _costo; }
        }

        protected List<string> _camas;

        public List<string> Camas
        {
            get { return _camas; }
        }

        private List<string> _artefactos = new List<string> {"Frigo Bar", "Aire acondicionado", "Televisor" };

        public List<string> Artefactos
        {
            get { return _artefactos; }
        }

        private bool _vistaMar;

        public bool VistaMar
        {
            get { return _vistaMar; }
        }

        public Habitacion(int numero, bool vistaMar = false)
        {
            this._numero = numero;
            this._vistaMar = vistaMar;
        }
    }
}
