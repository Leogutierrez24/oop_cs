using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO.Clases
{
    public class Venta
    {
        private int _numero;

        public int Numero
        {
            get { return _numero; }
        }

        private List<Pasaporte> _pasaportes = new List<Pasaporte>();

        public List<Pasaporte> Pasaportes
        {
            get { return _pasaportes; }
        }

        private float _total;

        public float Total
        {
            get { return _total; }
        }

        public Venta(int numero, List<Pasaporte> pasaportes, float total) 
        {
            this._numero = numero;
            this._pasaportes = pasaportes;
            this._total = total;
        }

        public Venta(int numero, Pasaporte pasaporte, float total)
        {
            this._numero = numero;
            this._pasaportes.Add(pasaporte);
            this._total = total;
        }
    }
}
