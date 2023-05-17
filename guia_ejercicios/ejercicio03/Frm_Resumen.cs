using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public partial class Frm_Resumen : Form
    {
        readonly Cafeteria cafeteria;
        
        public Frm_Resumen(Cafeteria cafeteria)
        {
            InitializeComponent();
            this.cafeteria = cafeteria;
        }

        private void ActualizarPorcentajes()
        {
            List<Tuple<string, float>> porcentajesVentasCafe = cafeteria.CalcularPorcentajeVentasCafe();
            List<Tuple<string, float>> porcentajesRecaudacionCafe = cafeteria.CalcularPorcentajeRecaudacionCafe();
            List<Tuple<string, float>> porcentajesVentasCafetera = cafeteria.CalcularPorcentajeVentasCafetera();
            List<Tuple<string, float>> porcentajesRecaudacionCafetera = cafeteria.CalcularPorcentajeRecaudacionCafetera();

            foreach (Tuple<string, float> item in  porcentajesVentasCafe)
            {
                cafeVentas_listBox.Items.Add(item);
            }

            foreach (Tuple<string, float> item in porcentajesRecaudacionCafe)
            {
                cafeRecaudacion_listBox.Items.Add(item);
            }

            foreach (Tuple<string, float> item in porcentajesVentasCafetera)
            {
                cafeteraVentas_listBox.Items.Add(item);
            }

            foreach (Tuple<string, float> item in porcentajesRecaudacionCafetera)
            {
                cafeteraRecaudacion_listBox.Items.Add(item);
            }
        }

        private void Frm_Resumen_Load(object sender, EventArgs e)
        {
            Cafe cafeMasVendido = cafeteria.ObtenerCafeMasVendido();
            Cafe cafeMenosVendido = cafeteria.ObtenerCafeMenosVendido();
            Cafe cafeMasRecaudacion = cafeteria.ObtenerCafeMasRecaudacion();
            Cafe cafeMenosRecaudacion = cafeteria.ObtenerCafeMenosRecaudacion();

            Cafetera cafeteraMasUsada = cafeteria.ObtenerCafeteraMasUsada();
            Cafetera cafeteraMenosUsada = cafeteria.ObtenerCafeteraMenosUsada();
            Cafetera cafeteraMasRecaudacion = cafeteria.ObtenerCafeteraMasRecaudacion();
            Cafetera cafeteraMenosRecaudacion = cafeteria.ObtenerCafeteraMenosRecaudacion();
            Cafetera cafeteraMasRecargas = cafeteria.ObtenerCafeteraMasRecargas();

            cafeMasVendido_lbl.Text = $"{cafeMasVendido.Tipo} con {cafeMasVendido.Ventas}";
            cafeMenosVendido_lbl.Text = $"{cafeMenosVendido.Tipo} con {cafeMenosVendido.Ventas}";
            cafeMasRecaudacion_lbl.Text = string.Format("{0} con ${1:0.00}", cafeMasRecaudacion.Tipo, cafeMasRecaudacion.Recaudacion);
            cafeMenosRecaudacion_lbl.Text = string.Format("{0} con ${1:0.00}", cafeMenosRecaudacion.Tipo, cafeMenosRecaudacion.Recaudacion);

            cafeteraMasSirvio_lbl.Text = $"{cafeteraMasUsada.Id} con {cafeteraMasUsada.Ventas.Count()} cafes";
            cafeteraMenosSirvio_lbl.Text = $"{cafeteraMenosUsada.Id} con {cafeteraMenosUsada.Ventas.Count()} cafes";
            cafeteraMasRecaudacion_lbl.Text = string.Format("{0} con ${1:0.00}", cafeteraMasRecaudacion.Id, cafeteraMasRecaudacion.Recaudacion);
            cafeteraMenosRecaudacion_lbl.Text = string.Format("{0} con ${1:0.00}", cafeteraMenosRecaudacion.Id, cafeteraMenosRecaudacion.Recaudacion);

            this.ActualizarPorcentajes();
        }
    }
}
