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
    public partial class form_venta : Form
    {
        Libreria newLibreria;
        List<Producto> listaProductos;
        decimal subtotal;

        public form_venta(Libreria someLibreria)
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
            subtotal = 0;
            newLibreria = someLibreria;
            ShowProductos();
        }

        private void Clear()
        {
            numericUpDown1.Value = 10000;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            numericUpDown2.Value = 0;
        }

        private void ShowProductos()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listaProductos;
        }

        private void button2_Click(object sender, EventArgs e) // add Producto
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && numericUpDown2.Value != 0 )
                {
                    Producto newProducto = new Producto(
                            (int)numericUpDown1.Value,
                            textBox2.Text,
                            textBox1.Text,
                            numericUpDown2.Value
                        );

                    listaProductos.Add(newProducto);
                    subtotal += newProducto.Precio;

                    Clear();
                    label7.Text = subtotal.ToString();
                    ShowProductos();
                } else
                {
                    MessageBox.Show("Hay campos incompletos o con valores no válidos !!!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) // close Sale
        {
            try
            {
                Venta newVenta = new Venta
                {
                    Productos = listaProductos,
                    Total = subtotal,
                };

                newLibreria.Agregar(newVenta);
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // cancel Sale
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) // delete Producto from Sale
        {
            try
            { 
                if (listBox1.SelectedItem != null)
                {
                    Producto toDelete = (Producto)listBox1.SelectedItem;
                    listaProductos.Remove(toDelete);
                    MessageBox.Show($"Se elimino el producto: {toDelete}");
                    ShowProductos();
                } else
                {
                    MessageBox.Show("Debe seleccionar un producto para eliminar !!!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
