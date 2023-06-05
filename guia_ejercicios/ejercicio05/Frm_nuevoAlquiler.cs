using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public partial class Frm_nuevoAlquiler : Form
    {
        public Polideportivo poli;

        public Frm_nuevoAlquiler(Polideportivo poli)
        {
            InitializeComponent();
            this.poli = poli;
        }

        public void PresetForm()
        {
            foreach(Cancha cancha in this.poli.Canchas)
            {
                Cancha_comboBox.Items.Add(cancha);
            }

            totalValue_lbl.Text = "$000,00";
        }

        private void Frm_nuevoAlquiler_Load(object sender, EventArgs e)
        {
            this.PresetForm();
        }

        private void Cancha_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Opciones_comboBox.Items.Clear();

            Cancha canchaSeleccionada = Cancha_comboBox.SelectedItem as Cancha;

            if (canchaSeleccionada.Opciones.Count != 0)
            {
                foreach(Opcion opcion in canchaSeleccionada.Opciones)
                {
                    Opciones_comboBox.Items.Add(opcion);
                }
            } 
        }

        private void Opciones_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fecha_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            alquileres_listBox.Items.Clear();

            DateTime fechaElegida = fecha_dateTimePicker.Value;

            List<Alquiler> alquileres = this.poli.FiltarAlquileres(fechaElegida);

            if (alquileres.Count != 0)
            {
                foreach (Alquiler alquiler in alquileres)
                {
                    alquileres_listBox.Items.Add(alquiler);
                }
            } else
            {
                alquileres_listBox.Items.Add("No hay alquileres dentro de esta fecha.");
            }
        }

        private void CalcularTotal_btn_Click(object sender, EventArgs e)
        {
            Cancha canchaSeleccionada = Cancha_comboBox.SelectedItem as Cancha;
            Opcion opcionElegida = Opciones_comboBox.SelectedItem as Opcion;
            int horasAlquiler = (int)horas_numericUpDown.Value;

            if (canchaSeleccionada != null)
            {
                totalValue_lbl.Text = string.Format("${0:0.00}", (canchaSeleccionada.Precio + (opcionElegida != null ? opcionElegida.Aumento : 0)) * horasAlquiler);
            } else
            {
                MessageBox.Show("¡Faltan campos por completar!");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
