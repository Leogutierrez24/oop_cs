using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public class Estacion
    {
        private Surtidor _surtidor01 = new Surtidor();
        private Surtidor _surtidor02 = new Surtidor();
        private Surtidor _surtidor03 = new Surtidor();
        private List<Nafta> _naftas = new List<Nafta>();

        public Surtidor Surtidor01
        {
            get { return _surtidor01; }
            set { _surtidor01 = value; }
        }

        public Surtidor Surtidor02
        {
            get { return _surtidor02; }
            set { _surtidor02 = value; }
        }

        public Surtidor Surtidor03
        {
            get { return _surtidor03; }
            set { _surtidor03 = value; }
        }

        public List<Nafta> Naftas
        {
            get { return _naftas; }
        }

        public Estacion()
        {
            this._naftas = this.GenerarNaftas();
        }

        public float ObtenerRecaudacionTotal()
        {
            float recaudacion = 0;

            if (this._surtidor01 != null) recaudacion += this._surtidor01.Recaudacion;
            if (this._surtidor02 != null) recaudacion += this._surtidor02.Recaudacion;
            if (this._surtidor03 != null) recaudacion += this._surtidor03.Recaudacion;

            return recaudacion;
        }

        public int ObtenerClientesSurtidor(Surtidor unSurtidor)
        {
            int resultado = (unSurtidor.Ventas.Count != 0) ? unSurtidor.Ventas.Count : 0;

            return resultado;
        }

        public Surtidor SurtidorMasRecaudacion()
        {
            Surtidor resultado = (this._surtidor01.Recaudacion >= this._surtidor02.Recaudacion) ? this._surtidor01 : this._surtidor02; ;
            resultado = (resultado.Recaudacion >= this._surtidor03.Recaudacion) ? resultado : this._surtidor03;
            return resultado;
        }

        public Surtidor SurtidorMenosRecaudacion()
        {
            Surtidor resultado = (this._surtidor01.Recaudacion <= this._surtidor02.Recaudacion) ? this._surtidor01 : this._surtidor02; ;
            resultado = (resultado.Recaudacion <= this._surtidor03.Recaudacion) ? resultado : this._surtidor03;
            return resultado;
        }

        public Surtidor SurtidorMasClientes()
        {
            Surtidor resultado = (this._surtidor01.Ventas.Count >= this._surtidor02.Ventas.Count) ? this._surtidor01 : this._surtidor02; ;
            resultado = (resultado.Ventas.Count >= this._surtidor03.Ventas.Count) ? resultado : this._surtidor03;
            return resultado;
        }

        public Surtidor SurtidorMasRecargas()
        {
            Surtidor resultado = (this._surtidor01.Recargas >= this._surtidor02.Recargas) ? this._surtidor01 : this._surtidor02; ;
            resultado = (resultado.Recargas >= this._surtidor03.Recargas) ? resultado : this._surtidor03;
            return resultado;
        }

        public List<Promedio> PorcentajeVentas()
        {
            List<Promedio> promedios = new List<Promedio>();
            List<Surtidor> surtidores = new List<Surtidor>
            {
                this._surtidor01,
                this._surtidor02,
                this._surtidor03,
            };
            int ventasTotales = this._surtidor01.Ventas.Count + this._surtidor02.Ventas.Count + this._surtidor03.Ventas.Count;

            foreach(Surtidor item in surtidores)
            {
                int ventasAcumuladas = this.ObtenerClientesSurtidor(item);
                float porcentaje = (ventasAcumuladas * 100) / ventasTotales;
                Promedio p = new Promedio(item.Nafta.Tipo, porcentaje);
                promedios.Add(p);
            }

            return promedios;
        }

        public List<Promedio> PorcentajeRecaudacion()
        {
            List<Promedio> promedios = new List<Promedio>();
            List<Surtidor> surtidores = new List<Surtidor>
            {
                this._surtidor01,
                this._surtidor02,
                this._surtidor03,
            };
            float recaudacionTotal = this.ObtenerRecaudacionTotal();

            foreach(Surtidor item in surtidores)
            {
                float recaudacion = item.Recaudacion;
                float porcentaje = (recaudacion * 100) / recaudacionTotal;
                Promedio p = new Promedio(item.Nafta.Tipo, porcentaje);
                promedios.Add(p);
            }

            return promedios;
        }

        private List<Nafta> GenerarNaftas()
        {
            Nafta normal = new Nafta("Normal", 17.20f);
            Nafta super = new Nafta("Super", 18.85f);
            Nafta premium = new Nafta("Premium", 21.30f);

            List<Nafta> listaNaftas = new List<Nafta> { normal, super, premium };

            return listaNaftas;
        }
    }
}
