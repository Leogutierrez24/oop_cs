using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO.Clases
{
    public class Visitante
    {
        private long _documento;

        public long Documento
        {
            get { return _documento; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
        }

        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
        }

        public Visitante(long documento, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this._documento = documento;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNacimiento = fechaNacimiento;
        }
        
        public int CalcularEdad()
        {
            TimeSpan edad = DateTime.Now - this._fechaNacimiento;
            return edad.Days / 365;
        }
    }
}
