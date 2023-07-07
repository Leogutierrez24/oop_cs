using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public class Atraccion
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }

        private Habitat _habitat;

        public Habitat Habitat
        {
            get { return _habitat; }
        }

        private List<Animal> _animales = new List<Animal>();

        public List<Animal> Animales
        {
            get { return _animales; }
        }

        public Atraccion(string nombre, Habitat habitat, List<Animal> animales)
        {
            this._nombre = nombre;
            this._habitat = habitat;
            this._animales = animales;
        }
    }
}
