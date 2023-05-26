using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    public class After
    {
        private List<Cerveza> _cervezas;
        private List<Vaso> _vasos;
        private List<Barril> _barriles = new List<Barril>();
        private List<Venta> _ventas = new List<Venta>();
        private float _recaudacion;

        public List<Cerveza> Cervezas
        {
            get { return _cervezas; }
        }

        public List<Vaso> Vasos
        {
            get { return _vasos; }
        }

        public List<Barril> Barriles
        {
            get { return _barriles; }
        }

        public List<Venta> Ventas { get { return _ventas; } }

        public float Recaudacion
        {
            get { return _recaudacion; }
        }

        public After()
        {
            this._cervezas = this.CervezasIniciales();
            this._vasos = this.VasosIniciales();
        }

        // métodos para inicializar el ejercicio con valores predeterminados
        private List<Cerveza> CervezasIniciales()
        {
            Cerveza rubiaNacional = new Cerveza("Rubia Nacional", 50);
            Cerveza negraNacional = new Cerveza("Negra Nacional", 58);
            Cerveza rubiaInternacional = new Cerveza("Rubia Internacional", 65);
            return new List<Cerveza> {  rubiaNacional, negraNacional, rubiaInternacional };
        }

        private List<Vaso> VasosIniciales()
        {
            Vaso chopp = new Vaso("Chopp", 0.125f);
            Vaso vaso = new Vaso("Vaso", 0.500f);
            Vaso jarra = new Vaso("Jarra", 3);
            return new List<Vaso> {  chopp, vaso, jarra };
        }

        // operaciones de barriles
        public void AgregarBarril(Barril nuevoBarril)
        {
            this._barriles.Add(nuevoBarril);
        }

        public void EliminarBarril(Barril unBarril)
        {
            this._barriles.Remove(unBarril);
        }

        public List<Barril> FiltrarBarriles(Cerveza cerveza)
        {
            List<Barril> barrilesFiltrados = this._barriles.FindAll(barril => barril.Cerveza == cerveza);
            return barrilesFiltrados;
        }

        public float CalcularPrecio(Cerveza cerveza, Vaso vaso)
        {
            return (cerveza.Precio * vaso.Cantidad) * 1.05f;
        }

        // operaciones de ventas
        public void AgregarVenta(Venta nuevaVenta)
        {
            this._ventas.Add(nuevaVenta);
            this._recaudacion += nuevaVenta.Total;
        }
    }
}
