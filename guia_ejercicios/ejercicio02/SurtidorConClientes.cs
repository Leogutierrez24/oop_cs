using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    public class SurtidorConClientes : Surtidor
    {
        private int _clientes;

        public int Clientes
        {
            get { return _clientes; }
            set { _clientes = value; }
        }

        public SurtidorConClientes(Surtidor unSurtidor, int clientes = 0)
        {
            this.Nafta = unSurtidor.Nafta;
            this.Precio = unSurtidor.Precio;
            this.Cantidad = unSurtidor.Cantidad;
            this._clientes = clientes;
        }
    }
}
