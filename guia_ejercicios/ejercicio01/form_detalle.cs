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
    public partial class form_detalle : Form
    {
        Venta toShow;
        public form_detalle(Venta someVenta)
        {
            InitializeComponent();
            toShow = someVenta;
        }

        private void form_detalle_Load(object sender, EventArgs e)
        {
            try
            {
                foreach(Producto item in toShow.Productos)
                {
                    listBox1.Items.Add(item);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
