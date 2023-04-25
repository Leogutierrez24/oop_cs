using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    public class Producto
    {
        public Producto(int codigo, string nombre, string descripcion, decimal precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{this.Codigo} {this.Nombre} {this.Descripcion} ${this.Precio}";
        }
    }
}
