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
        private List<Surtidor> _surtidores = new List<Surtidor>();

        public List<Surtidor> Surtidores
        {
            get { return _surtidores; }
        }

        private List<Venta> _ventas = new List<Venta>();

        public List<Venta> Ventas
        {
            get { return _ventas; }
        }

        public void AgregarSurtidor(Surtidor nuevoSurtidor)
        {
            _surtidores.Add(nuevoSurtidor);
        }

        public Surtidor ObtenerSurtidor(int numeroSurtidor)
        {
            return _surtidores[numeroSurtidor - 1];
        }

        public void AgregarVenta(Venta unaVenta)
        {
            _ventas.Add(unaVenta);            
        }

        /*  Manejo de operaciones */
        public decimal ObtenerRecaudacionSurtidor(Surtidor unSurtidor)
        {
            decimal recaudacion = 0;

            if (unSurtidor != null)
            {
                if (this._ventas.Count != 0)
                {
                    foreach (Venta item in this._ventas)
                    {
                        if (item.Tipo == unSurtidor.Nafta) recaudacion += item.Total;
                    }
                }
            }
            else
            {
                MessageBox.Show("No es posible obtener la recaudación");
            }

            return recaudacion;
        }

        public decimal ObtenerRecaudacionTotal()
        {
            decimal recaudacion = 0;

            if (this._ventas.Count != 0)
            {
                foreach (Venta item in this._ventas)
                {
                    recaudacion += item.Total;
                }
            }

            return recaudacion;
        }

        public int ObtenerClientesSurtidor(Surtidor unSurtidor)
        {
            int resultado = 0;

            if (this._ventas.Count != 0)
            {
                foreach (Venta item in this._ventas)
                {
                    if (item.Tipo == unSurtidor.Nafta) resultado++;
                }
            }

            return resultado;
        }

        public string SurtidorMasVentas()
        {
            string resultado;
            decimal surtidor01 = this.ObtenerRecaudacionSurtidor(this.ObtenerSurtidor(1));
            decimal surtidor02 = this.ObtenerRecaudacionSurtidor(this.ObtenerSurtidor(2));
            decimal surtidor03 = this.ObtenerRecaudacionSurtidor(this.ObtenerSurtidor(3));

            if (this._ventas.Count != 0)
            {
                if (surtidor01 > surtidor02)
                {
                    if (surtidor01 > surtidor03)
                    {
                        resultado = $"El surtidor con más ventas: {this.ObtenerSurtidor(1).Nafta}{Environment.NewLine}Con ${surtidor01} acumulados";
                    }
                    else
                    {
                        resultado = $"El surtidor con más ventas: {this.ObtenerSurtidor(3).Nafta}{Environment.NewLine}Con ${surtidor03} acumulados";
                    }
                }
                else if (surtidor02 > surtidor03)
                {
                    resultado = $"El surtidor con más ventas: {this.ObtenerSurtidor(2).Nafta}{Environment.NewLine}Con ${surtidor02} acumulados";
                }
                else
                {
                    resultado = $"El surtidor con más ventas: {this.ObtenerSurtidor(3).Nafta}{Environment.NewLine}Con ${surtidor03} acumulados";
                }
            }
            else
            {
                resultado = "No hay ventas registradas";
            }

            return resultado;
        }

        public string SurtidorMenosVentas()
        {
            string resultado;
            decimal surtidor01 = this.ObtenerRecaudacionSurtidor(this.ObtenerSurtidor(1));
            decimal surtidor02 = this.ObtenerRecaudacionSurtidor(this.ObtenerSurtidor(2));
            decimal surtidor03 = this.ObtenerRecaudacionSurtidor(this.ObtenerSurtidor(3));

            if (this._ventas.Count != 0)
            {
                if (surtidor01 < surtidor02 && surtidor01 < surtidor03)
                {
                    resultado = $"El surtidor con menos ventas: {this.ObtenerSurtidor(1).Nafta}{Environment.NewLine}Con ${surtidor01} acumulados";
                }
                else if (surtidor02 < surtidor01 && surtidor02 < surtidor03)
                {
                    resultado = $"El surtidor con menos ventas: {this.ObtenerSurtidor(2).Nafta}{Environment.NewLine}Con ${surtidor02} acumulados";
                }
                else if (surtidor03 < surtidor01 && surtidor03 < surtidor02)
                {
                    resultado = $"El surtidor con menos ventas: {this.ObtenerSurtidor(3).Nafta}{Environment.NewLine}Con ${surtidor03} acumulados";
                }
                else
                {
                    resultado = $"Todos los surtidores tienen la misma cantidad de ventas acumuladas de ${surtidor01}";
                }
            }
            else
            {
                resultado = "No hay ventas registradas";
            }

            return resultado;
        }

        public string SurtidorMasClientes()
        {
            string resultado;
            int surtidor01 = this.ObtenerClientesSurtidor(this.ObtenerSurtidor(1));
            int surtidor02 = this.ObtenerClientesSurtidor(this.ObtenerSurtidor(2));
            int surtidor03 = this.ObtenerClientesSurtidor(this.ObtenerSurtidor(3));

            if (surtidor01 > surtidor02 && surtidor01 > surtidor03)
            {
                resultado = $"El surtidor con más clientes es el {this.ObtenerSurtidor(1).Nafta} con {surtidor01} clientes";
            }
            else if (surtidor02 > surtidor01 && surtidor02 > surtidor03)
            {
                resultado = $"El surtidor con más clientes es el {this.ObtenerSurtidor(2).Nafta} con {surtidor02} clientes";
            }
            else if (surtidor03 > surtidor01 && surtidor03 > surtidor02)
            {
                resultado = $"El surtidor con más clientes es el {this.ObtenerSurtidor(3).Nafta} con {surtidor03} clientes";
            }
            else
            {
                resultado = $"Todos los surtidores tienen una cantidad de {surtidor01} clientes";
            }

            return resultado;
        }

        public string SurtidorMasRecargas()
        {
            string resultado;
            int surtidor01 = this.ObtenerSurtidor(1).Recargas;
            int surtidor02 = this.ObtenerSurtidor(2).Recargas;
            int surtidor03 = this.ObtenerSurtidor(3).Recargas;

            if (surtidor01 > surtidor02 && surtidor01 > surtidor03)
            {
                resultado = $"El surtidor con más recargas es el {this.ObtenerSurtidor(1).Nafta} con {surtidor01} recargas";
            }
            else if (surtidor02 > surtidor01 && surtidor02 > surtidor03)
            {
                resultado = $"El surtidor con más recargas es el {this.ObtenerSurtidor(2).Nafta} con {surtidor02} recargas";
            }
            else if (surtidor03 > surtidor01 && surtidor03 > surtidor02)
            {
                resultado = $"El surtidor con más recargas es el {this.ObtenerSurtidor(3).Nafta} con {surtidor03} recargas";
            }
            else
            {
                resultado = $"Todos los surtidores tienen la misma cantidad de recargas";
            }

            return resultado;
        }

        public List<Promedio> PorcentajeVentas()
        {
            List<Promedio> promedios = new List<Promedio>();
            int ventasTotales = this._ventas.Count();

            foreach(Surtidor item in this._surtidores)
            {
                int ventasAcumuladas = this.ObtenerClientesSurtidor(item);
                float porcentaje = (ventasAcumuladas * 100) / ventasTotales;
                Promedio p = new Promedio(item.Nafta, porcentaje);
                promedios.Add(p);
            }

            return promedios;
        }

        public List<Promedio> PorcentajeRecaudacion()
        {
            List<Promedio> promedios = new List<Promedio>();
            decimal recaudacionTotal = this.ObtenerRecaudacionTotal();

            foreach(Surtidor item in this._surtidores)
            {
                decimal recaudacion = this.ObtenerRecaudacionSurtidor(item);
                float porcentaje = ((float)recaudacion * 100) / (float)recaudacionTotal;
                Promedio p = new Promedio(item.Nafta, porcentaje);
                promedios.Add(p);
            }

            return promedios;
        }
    }
}
