using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public partial class Formulario_SetSurtidor : Form
    {
        Surtidor elSurtidor;
        Estacion laEstacion;

        public Formulario_SetSurtidor(Surtidor unSurtidor, Estacion unaEstacion)
        {
            InitializeComponent();
            this.elSurtidor = unSurtidor;
            this.laEstacion = unaEstacion;
        }

        private void Formulario_SetSurtidor_Load(object sender, EventArgs e)
        {
            foreach(Nafta i in laEstacion.Naftas)
            {
                comboBox1.Items.Add(i.Tipo);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: numericUpDown1.Value = (decimal)laEstacion.Naftas[0].Precio;
                    break;
                case 1: numericUpDown1.Value = (decimal)laEstacion.Naftas[1].Precio;
                    break;
                case 2: numericUpDown1.Value = (decimal)laEstacion.Naftas[2].Precio;
                    break;
                default: MessageBox.Show("¡Surgio un error!");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && numericUpDown1.Value != 0)
            {
                elSurtidor.EstablecerNafta(laEstacion.Naftas[comboBox1.SelectedIndex]);
                elSurtidor.CargaInicial((float)numericUpDown2.Value);
                MessageBox.Show($"Surtidor establecido con {elSurtidor.Nafta.Tipo}");
                this.Close();
            } else
            {
                MessageBox.Show("¡Hay campos inválidos o sin completar!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
