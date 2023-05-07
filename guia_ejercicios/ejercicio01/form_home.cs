using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio01
{
    public partial class form_home : Form
    {
        Libreria newLibreria;

        public form_home()
        {
            InitializeComponent();
            newLibreria = new Libreria();
            ShowVentas();
        }

        private void ShowVentas()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = newLibreria.Ventas;
        }

        private void button1_Click_1(object sender, EventArgs e) // ver el total recaudado
        {
            try
            {
                MessageBox.Show("El total recaudado es de: $" + newLibreria.Recaudacion);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) // generar nueva venta
        {
            form_venta form = new form_venta(newLibreria);
            form.ShowDialog();
            ShowVentas();
        }

        private void button3_Click(object sender, EventArgs e) // show venta
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    Venta selectedVenta = listBox1.SelectedItem as Venta;
                    form_detalle form = new form_detalle(selectedVenta);
                    form.ShowDialog();
                } else
                {
                    MessageBox.Show("Debe seleccionar al menos una venta !!!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
