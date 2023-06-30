using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio06
{
    public partial class AgregarExtra_frm : Form
    {
        private readonly Hotel hotel;

        private List<Adicional> adicionales;

        public AgregarExtra_frm(Hotel hotel, List<Adicional> adicionales)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.adicionales = adicionales;
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            string descripcion = textBox1.Text;
            float costo = (float)numericUpDown1.Value;

            Adicional nuevoAdicional = hotel.CrearAdicional(descripcion, costo);

            if (nuevoAdicional != null)
            {
                this.adicionales.Add(nuevoAdicional);
                this.Close();
            }
            else MessageBox.Show("No se pudo crear el adicional. Intente nuevamente.");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
