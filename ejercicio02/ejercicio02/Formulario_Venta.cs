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
    public partial class Formulario_Venta : Form
    {
        Surtidor elSurtidor;

        public Formulario_Venta(Surtidor unSurtidor)
        {
            InitializeComponent();
            elSurtidor = unSurtidor;
            label4.Text = unSurtidor.Nafta.Tipo;
        }

        private void CerrarVenta_btn_Click(object sender, EventArgs e)
        {
            elSurtidor.CerrarVenta((float)numericUpDown1.Value);
            this.Close();
        }

        private void CancelarVenta_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.label6.Text = $"${(float)numericUpDown1.Value * elSurtidor.Nafta.Precio}";
        }
    }
}
