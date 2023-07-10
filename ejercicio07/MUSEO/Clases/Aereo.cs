using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public class Aereo : Animal
    {
        private float _distanciaVision;

        public float DistanciaVision
        {
            get { return _distanciaVision; }
        }

        private float _velocidadVuelo;

        public float VelocidadVuelo
        {
            get { return _velocidadVuelo; }
        }

        public Aereo(string nombre, TipoAlimentacion tipoAlimentacion, long periodo, float distanciaVision, float velocidadVuelo) : base(nombre, tipoAlimentacion, periodo)
        {
            this._distanciaVision = distanciaVision;
            this._velocidadVuelo = velocidadVuelo;
        }
    }
}
