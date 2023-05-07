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
        Carrito carritoProductos;

        public form_venta(Libreria someLibreria)
        {
            InitializeComponent();
            newLibreria = someLibreria;
            carritoProductos = new Carrito();
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
            listBox1.DataSource = carritoProductos.Productos;
        }

        private void button2_Click(object sender, EventArgs e) // nuevo producto al carrito
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && numericUpDown2.Value != 0 )
                {
                    Producto newProducto = new Producto(
                            (int)numericUpDown1.Value,
                            textBox2.Text,
                            textBox1.Text,
                            (float)numericUpDown2.Value
                        );

                    carritoProductos.AgregarProducto(newProducto);                   

                    Clear();
                    label7.Text = carritoProductos.Subtotal.ToString();
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

        private void button3_Click(object sender, EventArgs e) // cierre de venta
        {
            try
            {
                if (carritoProductos.Productos.Count > 0)
                {
                    newLibreria.CerrarVenta(carritoProductos);
                    MessageBox.Show("Venta cerrada con éxito!");
                    this.Close();
                } else
                {
                    MessageBox.Show("El carrito esta vacío!!!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) // cancelar la venta
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) // quitar producto del carrito
        {
            try
            { 
                if (listBox1.SelectedItem != null)
                {
                    Producto toDelete = (Producto)listBox1.SelectedItem;
                    carritoProductos.EliminarProducto(toDelete);
                    MessageBox.Show($"Se elimino el producto: {toDelete}");
                    ShowProductos();
                    label7.Text = carritoProductos.Subtotal.ToString();
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
