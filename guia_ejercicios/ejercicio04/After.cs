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

        private List<Barril> DuplicarListaBarriles()
        {
            List<Barril> barriles = new List<Barril>();

            foreach(Barril barril in this._barriles)
            {
                barriles.Add(barril);
            }

            return barriles;
        }

        private List<Cerveza> DuplicarListaCerveza()
        {
            List<Cerveza> cervezas = new List<Cerveza>();
            foreach(Cerveza cerveza in this._cervezas)
            {
                cervezas.Add(cerveza);
            }
            return cervezas;
        }

        private List<Vaso> DuplicarListaVasos()
        {
            List<Vaso> vasos = new List<Vaso>();
            foreach (Vaso vaso in this._vasos)
            {
                vasos.Add(vaso);
            }
            return vasos;
        }

        // operaciones de barriles
        public void AgregarBarril(Barril nuevoBarril)
        {
            this._barriles.Add(nuevoBarril);
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

        // operaciones de calculo
        public Barril ObtenerBarrilMasConsumido()
        {
            Barril barrilMasVendido = null;

            if (this._ventas.Count != 0)
            {
                List<Barril> barriles = this.DuplicarListaBarriles();
                barrilMasVendido = barriles.OrderByDescending(barril => barril.Ventas).First();
            }

            return barrilMasVendido;
        }

        public Barril ObtenerBarrilMenosConsumido()
        {
            Barril barrilMenosVendido = null;
            
            if (this._ventas.Count != 0)
            {
                List<Barril> barriles = this.DuplicarListaBarriles();
                barrilMenosVendido = barriles.OrderBy(barril => barril.Ventas).First();
            }

            return barrilMenosVendido;
        }

        public Barril ObtenerBarrilMasRecaudacion()
        {
            Barril barrilMasRecaudacion = null;

            if (this._ventas.Count != 0)
            {
                List<Barril> barriles = this.DuplicarListaBarriles();
                barrilMasRecaudacion = barriles.OrderByDescending(barril => barril.Recaudacion).First();
            }

            return barrilMasRecaudacion;
        }

        public Cerveza ObtenerCervezaMasVendida()
        {
            Cerveza masVendida = null;

            if (this._ventas.Count != 0)
            {
                List<Cerveza> cervezas = this.DuplicarListaCerveza();
                masVendida = cervezas.OrderByDescending(cerveza => cerveza.Ventas).First();
            }

            return masVendida;
        }

        public Cerveza ObtenerCervezaMasRecaudacion()
        {
            Cerveza masRecaudacion = null;

            if (this._ventas.Count != 0)
            {
                List<Cerveza> cervezas = this.DuplicarListaCerveza();
                masRecaudacion = cervezas.OrderByDescending(cerveza => cerveza.Ventas).First();
            }
            
            return masRecaudacion;
        }

        public Cerveza ObtenerCervezaMasLitros()
        {
            Cerveza masVentas = null;

            if (this._ventas.Count != 0)
            {
                List<Cerveza> cervezas = this.DuplicarListaCerveza();
                masVentas = cervezas.OrderByDescending(cerveza => cerveza.CantidadVendida).First();
            }
            
            return masVentas;
        }

        public Cerveza ObtenerCervezaMenosLitros()
        {
            Cerveza menosVentas = null;

            if (this._ventas.Count != 0)
            {
                List<Cerveza> cervezas = this.DuplicarListaCerveza();
                menosVentas = cervezas.OrderBy(cerveza => cerveza.CantidadVendida).First();
            }
            
            return menosVentas;
        }

        public Vaso ObtenerVasoMasSolicitado()
        {
            Vaso masSolicitado = null;

            if (this._ventas.Count != 0)
            {
                List<Vaso> vasos = this.DuplicarListaVasos();
                masSolicitado = vasos.OrderByDescending(vaso => vaso.Ventas).First();
            }
            
            return masSolicitado;
        }

        public List<Tuple<string, float>> ObtenerPorcentajeVentaBarriles()
        {
            int ventasTotales = 0;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>(); 

            if (this._ventas.Count != 0)
            {
                foreach (Barril barril in this._barriles)
                {
                    ventasTotales += barril.Ventas;
                }

                foreach (Barril barril in this._barriles)
                {
                    float porcentaje = (barril.Ventas * 100) / ventasTotales;
                    Tuple<string, float> item = new Tuple<string, float>($"{barril.Id} {barril.Cerveza}", porcentaje);
                    porcentajes.Add(item);
                }
            }

            return porcentajes;
        }

        public List<Tuple<string, float>> ObtenerPorcentajeRecaudacionBarriles()
        {
            float recaudacionTotal = 0;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            if (this._ventas.Count != 0)
            {
                foreach (Barril barril in this._barriles)
                {
                    recaudacionTotal += barril.Recaudacion;
                }

                foreach (Barril barril in this._barriles)
                {
                    float porcentaje = (barril.Recaudacion * 100) / recaudacionTotal;
                    Tuple<string, float> item = new Tuple<string, float>($"{barril.Id} {barril.Cerveza}", porcentaje);
                    porcentajes.Add(item);
                }
            }

            return porcentajes;
        }

        public List<Tuple<string, float>> ObtenerPorcentajeVentaCervezas()
        {
            float ventasTotales = 0;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            if (this._ventas.Count != 0)
            {
                foreach (Cerveza cerveza in this._cervezas)
                {
                    ventasTotales += cerveza.Ventas;
                }

                foreach (Cerveza cerveza in this._cervezas)
                {
                    float porcentaje = (cerveza.Ventas * 100) / ventasTotales;
                    Tuple<string, float> item = new Tuple<string, float>($"{cerveza.Tipo}", porcentaje);
                    porcentajes.Add(item);
                }
            }

            return porcentajes;
        }

        public List<Tuple<string, float>> ObtenerPorcentajeRecaudacionCervezas()
        {
            float recaudacionTotal = 0;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            if (this._ventas.Count != 0)
            {
                foreach (Cerveza cerveza in this._cervezas)
                {
                    recaudacionTotal += cerveza.Recaudacion;
                }

                foreach (Cerveza cerveza in this._cervezas)
                {
                    float porcentaje = (cerveza.Recaudacion * 100) / recaudacionTotal;
                    Tuple<string, float> item = new Tuple<string, float>($"{cerveza.Tipo}", porcentaje);
                    porcentajes.Add(item);
                }
            }

            return porcentajes;
        }

    }
}
