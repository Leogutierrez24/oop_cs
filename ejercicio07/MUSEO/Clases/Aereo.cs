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

        public Aereo(string nombre, TipoAlimentacion tipoAlimentacion, List<SerVivo> alimentacion, int edad) : base(nombre, tipoAlimentacion, alimentacion, edad)
        {
        }

        public Aereo(string nombre, TipoAlimentacion tipoAlimentacion, SerVivo alimentacion, int edad) : base(nombre, tipoAlimentacion, alimentacion, edad)
        {

        }
    }
}
