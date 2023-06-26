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
    public partial class Frm_Inicio : Form
    {
        public Hotel hotel;

        public Frm_Inicio()
        {
            InitializeComponent();
            this.hotel = new Hotel();
        }

        // información del form

        private void ActualizarForm()
        {
            Habitaciones_listBox.DataSource = null;
            Reservas_listBox.DataSource = null;
            Habitaciones_listBox.DataSource = this.hotel.Habitaciones;
            Reservas_listBox.DataSource = this.hotel.Reservas;
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            this.ActualizarForm();
        }

        // buttons del form

        private void VerHabitacion_btn_Click(object sender, EventArgs e)
        {
            if (Habitaciones_listBox.SelectedItems.Count == 1)
            {
                Habitacion habitacionElegida = Habitaciones_listBox.SelectedItem as Habitacion;
                VerHabitacion_frm form = new VerHabitacion_frm(habitacionElegida);
                form.ShowDialog();
            } else
            {
                MessageBox.Show("Se necesita seleccionar una Habitación para continuar.");
            }
        }

        private void RegistrarHuesped_btn_Click(object sender, EventArgs e)
        {
            AgregarHuesped_frm form = new AgregarHuesped_frm(this.hotel);
            form.ShowDialog();
        }

        private void VerHuespedes_btn_Click(object sender, EventArgs e)
        {
            Huespedes_frm form = new Huespedes_frm(this.hotel);
            form.ShowDialog();
        }
    }
}
