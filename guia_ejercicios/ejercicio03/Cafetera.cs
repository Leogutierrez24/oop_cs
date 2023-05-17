using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public class Cafetera
    {
        private Cafe _cafe;
        private float _carga = 0; // Litros
        private int _recargas = 0;
        private float _recaudacion = 0;
        private List<Venta> _ventas = new List<Venta>();
        private string _id;

        public Cafe Cafe
        {
            get { return _cafe; }
        }

        public float Carga
        {
            get { return _carga; }
        }

        public int Recargas
        {
            get { return _recargas; }
        }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public List<Venta> Ventas
        {
            get { return _ventas; }
        }

        public string Id
        {
            get { return _id; }
        }

        public Cafetera(Cafe tipoCafe, string id)
        {
            this._cafe = tipoCafe;
            this._id = id;
        }

        public void Cargar()
        {
            this._carga = 2.5f;
        }

        private void Descargar(float cantDescarga)
        {
            if (this._carga - cantDescarga >= 0) this._carga -= cantDescarga;
            else MessageBox.Show("No es posible realizar esa cantidad de descarga");
        }

        public CafePreparado PrepararCafe(Vaso unVaso)
        {
            CafePreparado cafecito = null;

            if (unVaso.Capacidad <= this._carga)
            {
                float costo = this._cafe.Precio * unVaso.Capacidad;
                this._cafe.Vender(costo);
                this.Descargar(unVaso.Capacidad);
                
                cafecito = new CafePreparado(this._cafe.Tipo, unVaso, costo);
            }

            return cafecito;
        }

        public void Vender(CafePreparado unCafe)
        {
            this._recaudacion += unCafe.Precio;
            Venta nuevaVenta = new Venta(unCafe.Precio, unCafe);
            this._ventas.Add(nuevaVenta);
        }

        public override string ToString()
        {
            return $"Cafetera {this._id}";
        }
    }
}
