using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public enum Sector
    {
        Acuatico = 0,
        Terrestre = 1,
        Aereo = 2,
    }

    public class Atraccion
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }

        private Sector _sector;

        public Sector Sector
        {
            get { return _sector; }
        }

        private List<Animal> _animales = new List<Animal>();

        public List<Animal> Animales
        {
            get { return _animales; }
        }

        private float _costo;

        public float Costo
        {
            get { return _costo; }
        }

        public Atraccion(string nombre, Sector sector, List<Animal> animales, float costo)
        {
            this._nombre = nombre;
            this._sector = sector;
            this._animales = animales;
            this._costo = costo;
        }
    }
}
