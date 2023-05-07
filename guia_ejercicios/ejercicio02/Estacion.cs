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

        public void CerrarVenta(Surtidor unSurtidor, decimal cantCombustible)
        {
            decimal total = cantCombustible * unSurtidor.Precio;            

            if (unSurtidor.Cantidad >= cantCombustible)
            {
                unSurtidor.Descargar(cantCombustible);
                Venta nuevaVenta = new Venta(unSurtidor.Nafta, cantCombustible, total);
                this.AgregarVenta(nuevaVenta);
                MessageBox.Show("¡Venta Registrada con éxito!");
            }
            else
            {
                MessageBox.Show("No hay combustible suficiente para completar la venta!!!");
            }
        }

        public void AgregarVenta(Venta unaVenta)
        {
            _ventas.Add(unaVenta);            
        }

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

        public string SurtidorMasRecaudacion()
        {
            string resultado;

            if (this._ventas.Count != 0)
            {
                List<SurtidorConRecaudacion> listaRecaudacion = new List<SurtidorConRecaudacion>();
                foreach (Surtidor item in this._surtidores)
                {
                    SurtidorConRecaudacion conRecaudacion = new SurtidorConRecaudacion(item, this.ObtenerRecaudacionSurtidor(item));
                    listaRecaudacion.Add(conRecaudacion);
                }

                SurtidorConRecaudacion surtidorMasVendido = listaRecaudacion.OrderByDescending(i => i.Recaudacion).First();

                resultado = $"El surtidor con más ventas es el {surtidorMasVendido.Nafta}{Environment.NewLine}Con una recaudación de ${surtidorMasVendido.Recaudacion}";

            }
            else resultado = "¡No se registraron ventas!";
            

            return resultado;
        }

        public string SurtidorMenosRecaudacion()
        {
            string resultado;

            if (this._ventas.Count != 0)
            {
                List<SurtidorConRecaudacion> listaRecaudacion = new List<SurtidorConRecaudacion>();
                foreach (Surtidor item in this._surtidores)
                {
                    SurtidorConRecaudacion conRecaudacion = new SurtidorConRecaudacion(item, this.ObtenerRecaudacionSurtidor(item));
                    listaRecaudacion.Add(conRecaudacion);
                }

                SurtidorConRecaudacion surtidorMenosVendido = listaRecaudacion.OrderBy(i => i.Recaudacion).First();

                resultado = $"El surtidor con menos ventas es el {surtidorMenosVendido.Nafta}{Environment.NewLine}Con una recaudación de ${surtidorMenosVendido.Recaudacion}";

            }
            else resultado = "¡No se registraron ventas!";


            return resultado;
        }

        public string SurtidorMasClientes()
        {
            string resultado;

            if (this._ventas.Count != 0)
            {
                List<SurtidorConClientes> listaClientes = new List<SurtidorConClientes>();
                foreach (Surtidor item in this._surtidores)
                {
                    SurtidorConClientes conRecaudacion = new SurtidorConClientes(item, this.ObtenerClientesSurtidor(item));
                    listaClientes.Add(conRecaudacion);
                }

                SurtidorConClientes surtidorMasClientes = listaClientes.OrderByDescending(i => i.Clientes).First();

                resultado = $"El surtidor con más clientes es el {surtidorMasClientes.Nafta}.{Environment.NewLine}Con {surtidorMasClientes.Clientes} clientes.";

            }
            else resultado = "¡No se registraron ventas!";


            return resultado;
        }

        public string SurtidorMasRecargas()
        {
            string resultado;

            if (this._ventas.Count != 0)
            {
                List<Surtidor> listaRecargas = new List<Surtidor>();
                foreach (Surtidor item in this._surtidores)
                {
                    listaRecargas.Add(item);
                }

                Surtidor surtidorMasRecargas = listaRecargas.OrderByDescending(i => i.Recargas).First();

                resultado = $"El surtidor con más recargas es el {surtidorMasRecargas.Nafta}{Environment.NewLine}.Con {surtidorMasRecargas.Recargas} acumuladas.";

            }
            else resultado = "¡No se registraron ventas!";


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
