using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public enum TipoAlimentacion
    {
        Carnivoro = 0,
        Herbivoro = 1
    }

    public class Animal : SerVivo
    {
        private int _edad;

        public int Edad
        {
            get { return _edad; }
        }

        private TipoAlimentacion _tipoAlimentacion;

        public TipoAlimentacion TipoAlimentacion
        {
            get { return _tipoAlimentacion; }
        }

        private List<SerVivo> _alimentacion;

        public List<SerVivo> Alimentacion
        {
            get { return _alimentacion; }
        }

        public Animal(string nombre, TipoAlimentacion tipoAlimentacion, List<SerVivo> alimentacion, int edad) : base(nombre)
        {
            this._tipoAlimentacion = tipoAlimentacion;
            this._alimentacion = alimentacion;
            this._edad = edad;
        }
    }
}
