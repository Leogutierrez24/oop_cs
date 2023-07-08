using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public class Terrestre : Animal
    {
        private Postura _postura;

        public Postura Postura { get { return _postura; } }

        private bool _exoesqueleto;

        public bool Exoesqueleto
        {
            get { return _exoesqueleto; }
        }

        public Terrestre(string nombre, TipoAlimentacion tipoAlimentacion, List<SerVivo> alimentacion, int edad, Postura postura, bool exoesqueleto = false) : base(nombre, tipoAlimentacion, alimentacion, edad)
        {
            this._postura = postura;
            this._exoesqueleto = exoesqueleto;
        }

        public Terrestre(string nombre, TipoAlimentacion tipoAlimentacion, SerVivo alimentacion, int edad, Postura postura, bool exoesqueleto = false) : base(nombre, tipoAlimentacion, alimentacion, edad)
        {
            this._postura = postura;
            this._exoesqueleto = exoesqueleto;
        }
    }
}
