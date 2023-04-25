using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio01
{
    public class Libreria
    {
		private List<Venta> _Ventas = new List<Venta>();

		public List<Venta> Ventas
		{
			get { return _Ventas; }
			set { _Ventas = value; }
		}

		public void Agregar(Venta newVenta)
		{
			_Ventas.Add(newVenta);
		}

		public void Eliminar(Venta toDelete)
		{
			_Ventas.Remove(toDelete);
		}
	}
}