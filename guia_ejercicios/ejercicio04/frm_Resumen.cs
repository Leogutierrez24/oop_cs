using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio04
{
    public partial class frm_Resumen : Form
    {
        public After afterOffice;

        public frm_Resumen(After afterOffice)
        {
            InitializeComponent();
            this.afterOffice = afterOffice;
        }

        private void ActualizarListBoxes()
        {
            List<Tuple<string, float>> ventaBarriles = this.afterOffice.ObtenerPorcentajeVentaBarriles();
            List<Tuple<string, float>> recaudacionBarriles = this.afterOffice.ObtenerPorcentajeRecaudacionBarriles();
            List<Tuple<string, float>> ventaCervezas = this.afterOffice.ObtenerPorcentajeVentaCervezas();
            List<Tuple<string, float>> recaudacionCervezas = this.afterOffice.ObtenerPorcentajeRecaudacionCervezas();

            barrilVentas_listBox.DataSource = ventaBarriles;
            barrilRecaudacion_listBox.DataSource = recaudacionBarriles;
            cervezaVentas_listBox.DataSource = ventaCervezas;
            cervezaRecaudacion_listBox.DataSource = recaudacionCervezas;
        }

        private void ActualizarFrm()
        {
            Barril barrilMasVendido = this.afterOffice.ObtenerBarrilMasConsumido();
            Barril barrilMenosVendido = this.afterOffice.ObtenerBarrilMenosConsumido();
            Barril barrilMasRecaudacion = this.afterOffice.ObtenerBarrilMasRecaudacion();

            Cerveza cervezaMasVendida = this.afterOffice.ObtenerCervezaMasVendida();
            Cerveza cervezaMasRecaudacion = this.afterOffice.ObtenerCervezaMasRecaudacion();
            Cerveza cervezaMasLitros = this.afterOffice.ObtenerCervezaMasLitros();
            Cerveza cervezaMenosLitros = this.afterOffice.ObtenerCervezaMenosLitros();

            Vaso vasoMasSolicitado = this.afterOffice.ObtenerVasoMasSolicitado();

            barrilMasVendido_lbl.Text = string.Format("{0} {1} con {2}", barrilMasVendido.Id, barrilMasVendido.Cerveza, barrilMasVendido.Ventas);
            barrilMenosVendido_lbl.Text = string.Format("{0} {1} con {2}", barrilMenosVendido.Id, barrilMenosVendido.Cerveza, barrilMenosVendido.Ventas);
            barrilMasRecaudacion_lbl.Text = string.Format("{0} {1} con ${2:0.00}", barrilMasRecaudacion.Id, barrilMasRecaudacion.Cerveza, barrilMasRecaudacion.Recaudacion);

            cervezaMasVendida_lbl.Text = string.Format("{0} con {1}", cervezaMasVendida.Tipo, cervezaMasVendida.Ventas);
            cervezaMasRecaudacion_lbl.Text = string.Format("{0}", cervezaMasRecaudacion.Tipo);
            cervezaMasVendida2_lbl.Text = string.Format("{0} con {1:0.00} Litros", cervezaMasLitros.Tipo, cervezaMasLitros.CantidadVendida);
            cervezaMenosVendida2_lbl.Text = string.Format("{0} con {1:0.00} Litros", cervezaMenosLitros.Tipo, cervezaMenosLitros.CantidadVendida);

            vasoMasSolicitado_lbl.Text = string.Format("{0} con {1}", vasoMasSolicitado.Tipo, vasoMasSolicitado.Ventas);
            this.ActualizarListBoxes();
        }

        private void frm_Resumen_Load(object sender, EventArgs e)
        {
            this.ActualizarFrm();
        }
    }
}
