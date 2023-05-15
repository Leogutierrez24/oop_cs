using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public partial class Frm_prepararCafe : Form
    {
        Cafeteria cafeteria;
        Cafetera cafetera;

        public Frm_prepararCafe(Cafeteria unaCafeteria, Cafetera unaCafetera)
        {
            InitializeComponent();
            this.cafeteria = unaCafeteria;
            this.cafetera = unaCafetera;
            this.ActualizarInformacion();
        }

        private void ActualizarInformacion()
        {
            cafe_textBox.Text = this.cafetera.Cafe.ToString();
            
            foreach(Vaso vaso in cafeteria.Vasos)
            {
                Vasos_comboBox.Items.Add(vaso);
            }

            Precio_textBox.Text = "0000,00";
        }

        private void Vasos_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vaso vasoElegido = Vasos_comboBox.SelectedItem as Vaso;
            Precio_textBox.Text = $"{this.cafetera.Cafe.Precio * vasoElegido.Capacidad}";
        }

        private void PrepararCafe_btn_Click(object sender, EventArgs e)
        {
            if (Vasos_comboBox.SelectedIndex != -1)
            {
                Vaso vasoElegido = Vasos_comboBox.SelectedItem as Vaso;
                CafePreparado cafecito = this.cafetera.PrepararCafe(vasoElegido);

                if (cafecito != null)
                {
                    this.cafetera.Vender(cafecito);
                    this.Close();
                } else
                {
                    MessageBox.Show("¡No hay suficiente café para realizar el preparado!");
                }
            } else
            {
                MessageBox.Show("¡Elige un vaso para preparar el café!");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
