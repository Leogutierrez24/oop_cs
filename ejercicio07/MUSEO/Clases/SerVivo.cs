using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO
{
    public class SerVivo
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }

        public SerVivo(string nombre)
        {
            this._nombre = nombre.ToUpper();
        }
    }
}
