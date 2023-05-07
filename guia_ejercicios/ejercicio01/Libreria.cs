using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio01
{
    public class Libreria
    {
		private float _recaudacion;
		private List<Venta> _ventas = new List<Venta>();

		public float Recaudacion
		{
			get { return this._recaudacion; }
			set
			{
				if (value >= 0) this._recaudacion = value;
			}
		}

		public List<Venta> Ventas
		{
			get { return _ventas; }
		}

		public void CerrarVenta(Carrito unCarrito)
		{
			Venta nuevaVenta = new Venta(unCarrito);
			this.AgregarVenta(nuevaVenta);
		}

		public void AgregarVenta(Venta newVenta)
		{
			this._ventas.Add(newVenta);
			this._recaudacion += newVenta.Total;
		}

		public void EliminarVenta(Venta toDelete)
		{
			this._ventas.Remove(toDelete);
			this._recaudacion -= toDelete.Total;
		}
	}
}