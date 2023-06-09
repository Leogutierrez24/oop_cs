﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    public class Opcion
    {
        private int _jueces;            // Cantidad de jueces adicionales
        private float _aumento;         // Aumento de la cancha
        private float _remuneracion;    // Pago al juez
        private string _descripcion;

        public int Jueces
        {
            get { return _jueces; }
        }

        public float Aumento
        {
            get { return _aumento; }
        }

        public float Remuneracion
        {
            get { return _remuneracion; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public Opcion(int jueces, float aumento, float remuneracion, string descripcion)
        {
            this._jueces = jueces;
            this._aumento = aumento;
            this._remuneracion = remuneracion;
            this._descripcion = descripcion;
        }

        public override string ToString()
        {
            return this._descripcion;
        }
    }
}
