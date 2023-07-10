using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MUSEO.Clases;
using MUSEO.Formularios;

namespace MUSEO
{
    public partial class Inicio_frm : Form
    {
        private Museo museo;

        public Inicio_frm()
        {
            InitializeComponent();
            this.museo = new Museo();
        }

        private void Inicio_frm_Load(object sender, EventArgs e)
        {
            atracciones_listBox.Items.Add(this.museo.SectorTerrestre);
            atracciones_listBox.Items.Add(this.museo.SectorAereo);
            atracciones_listBox.Items.Add(this.museo.SectorAcuatico);
            atracciones_listBox.DisplayMember = "Nombre";
        }

        private void AgregarNuevoAnimal_btn_Click(object sender, EventArgs e)
        {
            NuevoAnimal_frm form = new NuevoAnimal_frm(this.museo);
            form.ShowDialog();
        }

        private void ConsultarAnimales_btn_Click(object sender, EventArgs e)
        {

        }

        private void VerAtraccion_btn_Click(object sender, EventArgs e)
        {
            if (atracciones_listBox.SelectedItems.Count == 1)
            {
                VerAtraccion_frm form = new VerAtraccion_frm(atracciones_listBox.SelectedItem as Atraccion);
                form.ShowDialog();
            } else
            {
                MessageBox.Show("Se necesita elegir al menos una atracción para continuar.");
            }
        }

        private void VenderEntrada_btn_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarRecaudacion_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
