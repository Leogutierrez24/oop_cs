﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSEO.Clases
{
    public class Museo
    {
        private float _recaudacion;

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        private Atraccion _sectorTerrestre = new Atraccion("Animales Terrestres", Sector.Terrestre, new List<Animal> { }, 50);

        public Atraccion SectorTerrestre
        {
            get { return _sectorTerrestre; }
        }

        private Atraccion _sectorAereo = new Atraccion("Animales Aéreos", Sector.Aereo, new List<Animal> { }, 50);

        public Atraccion SectorAereo
        {
            get { return _sectorAereo; }
        }

        private Atraccion _sectorAcuatico = new Atraccion("Animales Acuáticos", Sector.Acuatico, new List<Animal> { }, 50);

        public Atraccion SectorAcuatico
        {
            get { return _sectorAcuatico; }
        }

        private List<Animal> _animales = new List<Animal>();

        public List<Animal> Animales
        {
            get { return _animales; }
        }

        private List<Venta> _ventas = new List<Venta>();

        public List<Venta> Ventas
        {
            get { return _ventas; }
        }

        public Museo(){}

        public int AgregarNuevoAnimal(Animal animal)
        {
            int resultado = 0;

            if (this._animales.Count != 0)
            {
                if (!this._animales.Exists(a => a.Nombre == animal.Nombre))
                {
                    this._animales.Add(animal);

                    if (animal.GetType() == typeof(Terrestre))
                    {
                        this._sectorTerrestre.AgregarAnimal(animal);
                    } else if (animal.GetType() == typeof(Aereo))
                    {
                        this._sectorAereo.AgregarAnimal(animal);
                    } else
                    {
                        this.SectorAcuatico.AgregarAnimal(animal);
                    }
                } else
                {
                    resultado = -1;
                }
            } else
            {
                this._animales.Add(animal);

                if (animal.GetType() == typeof(Terrestre))
                {
                    this._sectorTerrestre.AgregarAnimal(animal);
                }
                else if (animal.GetType() == typeof(Aereo))
                {
                    this._sectorAereo.AgregarAnimal(animal);
                }
                else
                {
                    this.SectorAcuatico.AgregarAnimal(animal);
                }
            }

            return resultado;
        }

        public float CalcularSubtotal(List<Atraccion> atracciones)
        {
            float resultado = 0;

            atracciones.ForEach(atraccion => resultado += atraccion.Costo);

            return resultado;
        }

        public float CalcularDescuento(List<Atraccion> atracciones, DateTime fechaNacimiento)
        {
            float resultado = this.CalcularSubtotal(atracciones);
            TimeSpan rangoDeEdad = DateTime.Now - fechaNacimiento;
            int visitanteEdad = rangoDeEdad.Days / 365;

            if (atracciones.Count == 2)
            {
                resultado -= (resultado * 10 / 100);
            } else if(atracciones.Count == 3)
            {
                resultado -= (resultado * 30 / 100);
            }

            if (visitanteEdad > 65 || visitanteEdad < 12)
            {
                resultado /= 2;
            }

            return resultado;
        }

        /*public Venta GenerarVenta()
        {
            return new Venta();
        }*/
    }
}
