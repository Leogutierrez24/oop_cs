﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    public class Juez
    {
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private float _recaudacion = 0;
        private int _partidos = 0;
        private bool _estado = true;

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

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public int Partidos
        {
            get { return _partidos; }
        }

        public bool Estado
        {
            get { return _estado; }
        }

        public Juez(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public void CambiarEstado()
        {
            this._estado = !this._estado;
        }

        public void AsignarPartido(float pago)
        {
            this.CambiarEstado();
            this._recaudacion += pago;
            this._partidos++;
        }

        public void CancelarPartido(float pago)
        {
            this.CambiarEstado();
            this._recaudacion -= pago;
            this._partidos--;
        }
    }
}