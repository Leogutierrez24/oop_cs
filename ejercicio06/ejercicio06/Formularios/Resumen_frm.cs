using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio06.Formularios
{
    public partial class Resumen_frm : Form
    {
        private readonly Hotel hotel;

        public Resumen_frm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void SetearDateTimePicker(DateTimePicker inicial, DateTimePicker final)
        {
            if (final.Value <= inicial.Value)
            {
                final.Value = inicial.Value.AddDays(1);
            }
        }

        private void HabFiltrar_btn_Click(object sender, EventArgs e)
        {
            Habitacion masElegida = this.hotel.ObtenerHabitacionMasSolicitadaPorFecha(habFechaInicial_dateTimePicker.Value, habFechaFinal_dateTimePicker.Value);
            Habitacion masOcupada = this.hotel.ObtenerHabitacionMasOcupadaPorFecha(habFechaInicial_dateTimePicker.Value, habFechaFinal_dateTimePicker.Value);
            habMasElegida_lbl.Text = masElegida == null ? "No hay registro de habitaciones elegidas." : masElegida.ToString();
            habMasOcupada_lbl.Text = masOcupada == null ? "No hay registro de habitaciones ocupadas." : masOcupada.ToString();
        }

        private void RecauFiltrar_btn_Click(object sender, EventArgs e)
        {
            float recaudacionFiltrada = this.hotel.CalcularRecaudacionPorFecha(recauFechaInicial_dateTimePicker.Value, recauFechaFinal_dateTimePicker.Value);


            recaudacionParcial_lbl.Text = string.Format("${0:0.00}", recaudacionFiltrada);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void habFechaInicial_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.SetearDateTimePicker(habFechaInicial_dateTimePicker, habFechaFinal_dateTimePicker);
        }

        private void habFechaFinal_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.SetearDateTimePicker(habFechaInicial_dateTimePicker, habFechaFinal_dateTimePicker);
        }

        private void recauFechaInicial_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.SetearDateTimePicker(recauFechaInicial_dateTimePicker, recauFechaFinal_dateTimePicker);
        }

        private void recauFechaFinal_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.SetearDateTimePicker(recauFechaInicial_dateTimePicker, recauFechaFinal_dateTimePicker);
        }

        private void Resumen_frm_Load(object sender, EventArgs e)
        {
            Huesped masHospedaje = this.hotel.ObtenerHuespedMasHospedaje();

            huespedMVP.Text = masHospedaje == null ? "No hay registro de huéspedes hospedados." : masHospedaje.ToString();
            recaudacionTotal_lbl.Text = string.Format("${0:0.00}", this.hotel.Recaudacion);

            habMasElegida_lbl.Text = "Elige una fecha para obtener un resultado.";
            habMasOcupada_lbl.Text = "Elige una fecha para obtener un resultado.";
            recaudacionParcial_lbl.Text = "Elige una fecha para obtener un resultado.";
        }
    }
}
