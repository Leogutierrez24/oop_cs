using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Ocupante
    {
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

        private int _edad;

        public int Edad
        {
            get { return _edad; }
        }

        private long _documento;

        public long Documento
        {
            get { return _documento; }
        }

        public Ocupante(long documento, string nombre, string apellido, int edad, DateTime fechaNacimiento)
        {
            this._documento = documento;
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._fechaNacimiento = fechaNacimiento;
        }
    }
}
