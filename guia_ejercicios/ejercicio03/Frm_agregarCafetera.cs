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
    public partial class Frm_agregarCafetera : Form
    {
        Cafeteria cafeteria;

        public Frm_agregarCafetera(Cafeteria unaCafeteria)
        {
            InitializeComponent();
            this.cafeteria = unaCafeteria;
        }

        private void ActualizarCafes()
        {
            foreach(Cafe cafe in cafeteria.Cafes)
            {
                Cafes_comboBox.Items.Add(cafe);
            }
        }

        private void Frm_agregarCafetera_Load(object sender, EventArgs e)
        {
            this.ActualizarCafes();
        }

        private void AgregarCafetera_btn_Click(object sender, EventArgs e)
        {
            if (Cafes_comboBox.SelectedIndex != -1 && !String.IsNullOrEmpty(textBox1.Text))
            {
                Cafe cafeElegido = Cafes_comboBox.SelectedItem as Cafe;
                this.cafeteria.AgregarCafetera(cafeElegido, textBox1.Text);
                MessageBox.Show("Se agrego una nueva cafetera con: " + cafeElegido.ToString());
                this.Close();
            } else
            {
                MessageBox.Show("¡Es necesario elegir un café para continuar!");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
