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

    public enum Postura
    {
        Bipedo = 0,
        Cuadrupedo = 1,
    }

    public abstract class Animal : SerVivo
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

        public Animal(string nombre, TipoAlimentacion tipoAlimentacion, SerVivo alimentacion, int edad) : base(nombre)
        {
            this._tipoAlimentacion = tipoAlimentacion;
            this._alimentacion.Add(alimentacion);
            this._edad = edad;
        }

        public int EstablecerAlimentacion(SerVivo alimento)
        {
            int resultado;

            if ((int)this._tipoAlimentacion == 1 && !alimento.Equals(typeof(Animal))){
                this._alimentacion.Add(alimento);
                resultado = 0;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }

        public int EstablecerAlimentacion(List<SerVivo> alimentos)
        {
            int resultado;
            int[] resultados = { };

            alimentos.ForEach(alimento =>
            {
                if (this._tipoAlimentacion == TipoAlimentacion.Herbivoro && !alimento.Equals(typeof(Animal)))
                {
                    resultados.Append(0);
                }
                else
                {
                    resultados.Append(-1);
                }
            });

            if (!resultados.Contains(-1))
            {
                alimentos.ForEach(alimento => this._alimentacion.Add(alimento));
                resultado = 0;
            } else
            {
                resultado = -1;
            }

            return resultado;
        }
    }
}
