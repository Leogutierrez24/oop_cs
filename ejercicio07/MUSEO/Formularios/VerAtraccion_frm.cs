using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSEO.Formularios
{
    public partial class VerAtraccion_frm : Form
    {
        private readonly Atraccion atraccion;

        public VerAtraccion_frm(Atraccion atraccion)
        {
            InitializeComponent();
            this.atraccion = atraccion;
        }

        private void VerAtraccion_Load(object sender, EventArgs e)
        {
            nombre_textBox.Text = this.atraccion.Nombre;
            sector_textBox.Text = this.atraccion.Sector.ToString();
            precio_textBox.Text = string.Format("{0:0.00}", this.atraccion.Costo);

            if (this.atraccion.Animales.Count != 0)
            {
                this.atraccion.Animales.ForEach(animal => animales_listBox.Items.Add(animal));
                animales_listBox.DisplayMember = "Nombre";
            } else
            {
                animales_listBox.Items.Add("No hay animales");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
