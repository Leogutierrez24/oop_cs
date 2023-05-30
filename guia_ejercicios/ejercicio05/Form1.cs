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

        private void ActualizarForm()
        {
            jueces_listBox.Items.Clear();
            if (this.poli.Jueces.Count != 0)
            {
                foreach (Juez juez in this.poli.Jueces)
                {
                    jueces_listBox.Items.Add(juez);
                }
            } else
            {
                jueces_listBox.Items.Add("No hay jueces.");
            }
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
    }
}
