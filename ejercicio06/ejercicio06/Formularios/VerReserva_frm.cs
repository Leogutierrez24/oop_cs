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
    public partial class VerReserva_frm : Form
    {
        private readonly Reserva reserva;

        public VerReserva_frm(Reserva reserva)
        {
            InitializeComponent();
            this.reserva = reserva;
            this.Name = $"Reserva Número: 00{reserva.numeroReserva}";
            this.ActualizarForm();
        }

        private void ActualizarForm()
        {
            habitacion_textBox.Text = this.reserva.Habitacion.ToString();
            checkin_textBox.Text = this.reserva.FechaEntrada.ToShortDateString();
            checkout_textBox.Text = this.reserva.FechaSalida.ToShortDateString();

            if (this.reserva.Adicionales.Count != 0)
            {
                this.reserva.Adicionales.ForEach(adicional => Agregados_listBox.Items.Add(adicional));
            } else
            {
                Agregados_listBox.Items.Add("No hay adicionales agregados.");
            }

            this.reserva.Ocupantes.ForEach(huesped => Huespedes_listBox.Items.Add(huesped));

            subtotal_textBox.Text = string.Format("${0:0.00}", this.reserva.Subtotal);
            totalDeposito_textBox.Text = string.Format("${0:0.00}", this.reserva.Deposito);

            checkinValue_lbl.Text = $"{(this.reserva.CheckinEstado ? "Concretado" : "Pendiente")}";
            checkoutValue_lbl.Text = $"{(this.reserva.CheckoutEstado ? "Concretado" : "Pendiente")}";
        }

        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
