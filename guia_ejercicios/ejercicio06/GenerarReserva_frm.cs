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
    public partial class GenerarReserva_frm : Form
    {
        private Hotel hotel;

        private Habitacion habitacionElegida;

        private DateTime checkin;

        private DateTime checkout;

        private List<Huesped> ocupantes = new List<Huesped>();

        private List<Adicional> adicionales = new List<Adicional>();

        private float subtotal;

        private float deposito;

        public GenerarReserva_frm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void ActualizarFormInfo()
        {
            Habitaciones_comboBox.DataSource = null;
            Huespedes_listBox.DataSource = null;

            Habitaciones_comboBox.DataSource = hotel.Habitaciones;
            Huespedes_listBox.DataSource = hotel.Huespedes;

            Adicional1_checkBox.Text = this.hotel.Adicionales[0].Descripcion;
            Adicional2_checkBox.Text = this.hotel.Adicionales[1].Descripcion;
        }

        private void GenerarReserva_frm_Load(object sender, EventArgs e)
        {
            this.ActualizarFormInfo();

            DiasReserva_monthCalendar.MinDate = DateTime.Now;
        }

        private void ActualizarSubtotal()
        {
            if (this.habitacionElegida != null && this.checkin != null && this.checkout != null)
            {
                this.subtotal = this.hotel.CalcularCosto(
                    this.habitacionElegida, 
                    this.hotel.CalcularDiasReserva(this.checkin, this.checkout), 
                    this.adicionales);

                this.deposito = this.hotel.CalcularDepositoMinimo(this.subtotal);
                Deposito_numericUpDown.Minimum = (decimal)this.hotel.CalcularDepositoMinimo(this.subtotal);
                Deposito_numericUpDown.Maximum = (decimal)this.subtotal;
                subtotal_textBox.Text = string.Format("${0:0.00}", this.subtotal);
            }
        }

        private void ActualizarAgregadosListBox()
        {
            AgregadosElegidos_listBox.Items.Clear();

            if (this.adicionales.Count > 0) this.adicionales.ForEach(adicional => AgregadosElegidos_listBox.Items.Add(adicional));
            else AgregadosElegidos_listBox.Items.Add("Sin adicionales.");
        }

        private void ActualizarHuespedesListBox()
        {
           HuespedesElegidos_listBox.Items.Clear();

            if (this.ocupantes.Count > 0) this.ocupantes.ForEach(huesped => HuespedesElegidos_listBox.Items.Add(huesped));
            else HuespedesElegidos_listBox.Items.Add("No hay huéspedes seleccionados.");
        }

        // operaciones de los buttons

        private void AgregarExtra_btn_Click(object sender, EventArgs e)
        {
            AgregarExtra_frm form = new AgregarExtra_frm(this.hotel, this.adicionales);
            form.ShowDialog();
            this.ActualizarSubtotal();
            this.ActualizarAgregadosListBox();
        }

        private void RegistrarHuesped_btn_Click(object sender, EventArgs e)
        {
            AgregarHuesped_frm form = new AgregarHuesped_frm(this.hotel);
            form.ShowDialog();
            this.ActualizarFormInfo();
        }

        private void ElegirHuesped_btn_Click(object sender, EventArgs e)
        {
            if (Huespedes_listBox.SelectedItem != null)
            {
                this.ocupantes.Add(Huespedes_listBox.SelectedItem as Huesped);
                this.ActualizarHuespedesListBox();
            } else
            {
                MessageBox.Show("Se necesita elegir al menos un húesped para continuar.");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarAgregado_btn_Click(object sender, EventArgs e)
        {
            if (AgregadosElegidos_listBox.SelectedItem != null)
            {
                this.adicionales.Remove(AgregadosElegidos_listBox.SelectedItem as Adicional);
                this.ActualizarAgregadosListBox();
                this.ActualizarSubtotal();
            } else
            {
                MessageBox.Show("Debe elegir al menos una opción para poder eliminar.");
            }
        }

        private void EliminarHuesped_btn_Click(object sender, EventArgs e)
        {
            if (HuespedesElegidos_listBox.SelectedItem != null)
            {
                this.ocupantes.Remove(HuespedesElegidos_listBox.SelectedItem as Huesped);
                this.ActualizarHuespedesListBox();
            } else
            {
                MessageBox.Show("Debe elegir al menos un huésped para poder eliminar.");
            }
        }

        private void GenerarReserva_btn_Click(object sender, EventArgs e)
        {
            if (
                this.habitacionElegida != null &&
                this.checkin != null &&
                this.checkout != null &&
                this.ocupantes.Count != 0 &&
                this.subtotal != 0 &&
                this.deposito != 0
                )
            {
                Reserva nuevaReserva = this.hotel.GenerarReserva(
                    this.habitacionElegida,
                    this.ocupantes,
                    this.adicionales,
                    this.checkin,
                    this.checkout,
                    this.deposito,
                    this.subtotal
                    );
                MessageBox.Show($"¡Se generó la reserva n° 00{nuevaReserva.numeroReserva} con éxito!");
                this.Close();
            } else
            {
                MessageBox.Show("¡Faltan campos por completar!");
            }
        }

        // Actualización de las props

        private void Habitaciones_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.habitacionElegida = Habitaciones_comboBox.SelectedItem as Habitacion;
            habitacionElegida_textBox.Text = this.habitacionElegida.ToString();
            this.ActualizarSubtotal();
        }

        private void Adicional1_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Adicional1_checkBox.Checked)
            {
                this.adicionales.Add(this.hotel.Adicionales[0]);
            } else
            {
                this.adicionales.Remove(this.hotel.Adicionales[0]);
            }
            this.ActualizarAgregadosListBox();
            this.ActualizarSubtotal();
        }

        private void Adicional2_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Adicional2_checkBox.Checked)
            {
                this.adicionales.Add(this.hotel.Adicionales[1]);
            }
            else
            {
                this.adicionales.Remove(this.hotel.Adicionales[1]);
            }
            this.ActualizarAgregadosListBox();
            this.ActualizarSubtotal();
        }

        private void DiasReserva_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.checkin = DiasReserva_monthCalendar.SelectionStart;
            this.checkout = DiasReserva_monthCalendar.SelectionEnd;
            this.ActualizarSubtotal();

            checkin_textBox.Text = this.checkin.ToShortDateString();
            checkout_textBox.Text = this.checkout.ToShortDateString();
            totalDias_textBox.Text = this.hotel.CalcularDiasReserva(this.checkin, this.checkout).ToString();
        }

        private void Deposito_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.deposito = (float)Deposito_numericUpDown.Value;
            totalDeposito_textBox.Text = string.Format("${0:0.00}", Deposito_numericUpDown.Value);
        }

        
    }
}
