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
    public partial class AgregarHuesped_frm : Form
    {
        private readonly Hotel hotel;

        public AgregarHuesped_frm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private int ComprobarCampos()
        {
            int resultado;

            if (string.IsNullOrEmpty(nombre_textBox.Text) || string.IsNullOrEmpty(apellido_textBox.Text))
            {
                resultado = -1;
            }
            else resultado = 0;

            return resultado;
        }

        // buttons del form

        private void Registrar_btn_Click(object sender, EventArgs e)
        {
            if (this.ComprobarCampos() != -1)
            {
                Huesped nuevoHuesped = new Huesped(
                    (long)documento_numericUpDown.Value,
                    nombre_textBox.Text,
                    apellido_textBox.Text,
                    (int)edad_numericUpDown.Value,
                    fechaNacimiento_dateTimePicker.Value
                    );

                int resultado = this.hotel.RegistrarHuesped(nuevoHuesped);
                
                if (resultado != -1)
                {
                    MessageBox.Show($"Se registro al huesped:\nNombre: {nuevoHuesped.Nombre}\nApellido: {nuevoHuesped.Apellido}\nEdad: {nuevoHuesped.Edad}\nFecha de Nacimiento: {nuevoHuesped.FechaNacimiento.ToShortDateString()}\nDocumento: {nuevoHuesped.Documento}");
                    this.Close();
                } else
                {
                    MessageBox.Show("Ya existe un huésped con ese documento.");
                }

            } else
            {
                MessageBox.Show("Todos los campos deben estar completos para continuar.");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
