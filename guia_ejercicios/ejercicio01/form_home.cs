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
        decimal totalVentas;

        public form_home()
        {
            InitializeComponent();
            newLibreria = new Libreria();
            totalVentas = 0;
            ShowVentas();
        }

        private void ShowVentas()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = newLibreria.Ventas;
        }

        private void button1_Click_1(object sender, EventArgs e) // show total
        {
            try
            {
                foreach(Venta item in newLibreria.Ventas)
                {
                    totalVentas += item.Total;
                }

                MessageBox.Show("El total recaudado es de: $" + totalVentas);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) // open form_venta
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
                    form_detalle from = new form_detalle(selectedVenta);
                    from.ShowDialog();
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
