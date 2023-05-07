using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    public class Carrito
    {
        private float _subtotal;
        private List<Producto> _productos = new List<Producto>();

        public float Subtotal
        {
            get { return _subtotal; }
        }

        public List<Producto> Productos
        {
            get { return _productos; }
        }

        public void AgregarProducto(Producto unProducto)
        {
            this._productos.Add(unProducto);
            this._subtotal += unProducto.Precio;
        }

        public void EliminarProducto(Producto unProducto)
        {
            this._productos.Remove(unProducto);
            this._subtotal -= unProducto.Precio;
        }
    }
}
