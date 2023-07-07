using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio06
{
    public partial class CancelarReserva_frm : Form
    {
        private readonly Hotel hotel;

        private readonly Reserva reserva;

        public CancelarReserva_frm(Hotel hotel, Reserva reserva)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.reserva = reserva;
        }

        private void LlenarForm()
        {
            numeroReserva_textBox.Text = $"00{this.reserva.numeroReserva}";
            montoAbonado_textBox.Text = string.Format("${0:0.00}", this.reserva.Deposito);
            checkin_textBox.Text = this.reserva.FechaEntrada.ToShortDateString();

            Tuple<string, float> reintegro = this.hotel.CalcularDevolucion(this.reserva);

            devolucion_textBox.Text = string.Format("${0:0.00}", reintegro.Item2);
            motivo_textBox.Text = reintegro.Item1;
        }

        private void CancelarReserva_frm_Load(object sender, EventArgs e)
        {
            this.LlenarForm();
        }

        private void Confirmar_btn_Click(object sender, EventArgs e)
        {
            this.hotel.CancelarReserva(this.reserva);
            MessageBox.Show("Se canceló la reserva n° 00" + this.reserva.numeroReserva);
            this.Close();
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
