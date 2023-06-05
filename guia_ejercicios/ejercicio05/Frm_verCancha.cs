using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public partial class Frm_verCancha : Form
    {
        Cancha cancha;

        public Frm_verCancha(Cancha cancha)
        {
            InitializeComponent();
            this.cancha = cancha;
        }

        private void Frm_verCancha_Load(object sender, EventArgs e)
        {
            id_textBox.Text = this.cancha.Id.ToString();
            tipo_textBox.Text = this.cancha.Tipo;
            precio_textBox.Text = string.Format("${0:0.00}", this.cancha.Precio);

            if (this.cancha.Opciones.Count != 0)
            {
                foreach(Opcion opcion in this.cancha.Opciones)
                {
                    opciones_listBox.Items.Add(opcion.Descripcion);
                }
            } else opciones_listBox.Items.Add("No cuenta con opciones.");
        }
    }
}
