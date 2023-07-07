using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    public class Producto
    {
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        
        public int Codigo
        {
            get { return _codigo; }
        }

        public string Nombre 
        {
            get { return _nombre; }
        }

        public string Descripcion 
        {
            get { return _descripcion; }
        }

        public float Precio
        {
            get { return _precio; }
        }


        public Producto(int codigo, string nombre, string descripcion, float precio)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._precio = precio;
        }

        public override string ToString()
        {
            return $"{this.Codigo} {this.Nombre} {this.Descripcion} ${this.Precio}";
        }
    }
}
