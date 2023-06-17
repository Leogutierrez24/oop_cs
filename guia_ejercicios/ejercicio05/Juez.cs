using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public class Juez
    {
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private List<Cita> _trabajos = new List<Cita>();
        private float _recaudacion = 0;
        private int _partidos = 0;

        public int Legajo
        {
            get { return _legajo; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Apellido
        {
            get { return _apellido; }
        }

        public List<Cita> Trabajos
        {
            get { return _trabajos; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Partidos
        {
            get { return _partidos; }
        }

        public Juez(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public void AsignarPartido(float pago)
        {
            this._recaudacion += pago;
            this._partidos++;
        }

        public void CancelarPartido(float pago)
        {
            this._recaudacion -= pago;
            this._partidos--;
        }

        public bool ComprobarCita(DateTime fecha, int horaInicio, int horaFinal)
        {
            bool disponible = true;

            if (this._trabajos.Count != 0)
            {
                List<Cita> citasMismaFecha = this._trabajos.FindAll(cita => cita.Fecha == fecha);

                if (citasMismaFecha.Exists(cita => cita.HoraInicial == horaInicio))
                {
                    disponible = false;
                } else if (citasMismaFecha.Exists(cita => cita.HoraInicial > horaInicio && cita.HoraInicial < horaFinal))
                {
                    disponible = false;
                } else if (citasMismaFecha.Exists(cita => cita.HoraFinal > horaInicio && cita.HoraFinal < horaFinal))
                {
                    disponible = false;
                }
            }

            return disponible;
        }

        public int OrganizarCita(DateTime fecha, int horaInicio, int horaFinal)
        {
            int resultado;

            if (this.ComprobarCita(fecha, horaInicio, horaFinal))
            {
                Cita nuevaCita = new Cita(fecha, horaInicio, horaFinal);
                this._trabajos.Add(nuevaCita);
                resultado = 0;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }

        public override string ToString()
        {
            return $"{this._legajo} {this._nombre} {this._apellido}";
        }
    }
}
