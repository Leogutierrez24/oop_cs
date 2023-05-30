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
    public partial class Frm_registrarJuez : Form
    {
        public Polideportivo poli;

        public Frm_registrarJuez(Polideportivo poli)
        {
            InitializeComponent();
            this.poli = poli;
        }

        private bool ComprobarCampos()
        {
            bool resultado = true;

            if (legajo_numericUpDown.Value == 0 || string.IsNullOrEmpty(nombre_textBox.Text) || string.IsNullOrEmpty(apellido_textBox.Text))
            {
                resultado = false;
            }

            return resultado;
        }

        private void Registrar_btn_Click(object sender, EventArgs e)
        {
            if (this.ComprobarCampos())
            {
                Juez nuevoJuez = new Juez((int)legajo_numericUpDown.Value, nombre_textBox.Text, apellido_textBox.Text);

                if (this.poli.ComprobarID(nuevoJuez))
                {
                    this.poli.AgregarJuez(nuevoJuez);
                    MessageBox.Show("Se registro al juez: " + nuevoJuez.Nombre + " " + nuevoJuez.Apellido);
                    this.Close();
                } else
                {
                    MessageBox.Show("¡Ya existe un juez con ese n° de legajo!");
                }
            } else
            {
                MessageBox.Show("¡Hay campos incompletos o con valores no válidos!");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
