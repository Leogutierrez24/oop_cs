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
    public partial class Form1 : Form
    {
        public Polideportivo poli;

        public Form1()
        {
            InitializeComponent();
            this.poli = new Polideportivo();
        }

        // información del formulario
        private void ActualizarJuecezInfo()
        {
            jueces_listBox.Items.Clear();
            if (this.poli.Jueces.Count != 0)
            {
                foreach (Juez juez in this.poli.Jueces)
                {
                    jueces_listBox.Items.Add(juez);
                }
            }
            else
            {
                jueces_listBox.Items.Add("No hay jueces.");
            }
        }

        private void ActualizarCanchasInfo()
        {
            canchas_listBox.Items.Clear();
            if (this.poli.Canchas.Count != 0)
            {
                foreach (Cancha cancha in this.poli.Canchas)
                {
                    canchas_listBox.Items.Add(cancha);
                }
            }
            else
            {
                canchas_listBox.Items.Add("No hay canchas.");
            }
        }

        private void ActualizarForm()
        {
            this.ActualizarJuecezInfo();
            this.ActualizarCanchasInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActualizarForm();
        }

        // manejo de jueces
        private void RegistrarJuez_btn_Click(object sender, EventArgs e)
        {
            Frm_registrarJuez form = new Frm_registrarJuez(this.poli);
            form.ShowDialog();
            this.ActualizarForm();
        }

        private void EliminarJuez_btn_Click(object sender, EventArgs e)
        {
            if (jueces_listBox.SelectedItems.Count == 1)
            {
                this.poli.EliminarJuez(jueces_listBox.SelectedItem as Juez);
                this.ActualizarForm();
            } else
            {
                MessageBox.Show("Debe seleccionar al juez que desea eliminar");
            }
        }

        // manejo de canchas
        private void VerCancha_btn_Click(object sender, EventArgs e)
        {
            if (canchas_listBox.SelectedItems.Count == 1)
            {
                if ((Cancha)canchas_listBox.SelectedItem != null)
                {
                    Frm_verCancha form = new Frm_verCancha(canchas_listBox.SelectedItem as Cancha);
                    form.ShowDialog();
                }
            } else
            {
                MessageBox.Show("Elige una cancha para poder continuar");
            }
            
        }

        // manejo de alquileres
        private void VerAlquiler_btn_Click(object sender, EventArgs e)
        {

        }

        private void NuevoAlquiler_btn_Click(object sender, EventArgs e)
        {
            Frm_nuevoAlquiler form = new Frm_nuevoAlquiler(this.poli);
            form.ShowDialog();
            this.ActualizarForm();
        }

        private void CancelarAlquiler_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
