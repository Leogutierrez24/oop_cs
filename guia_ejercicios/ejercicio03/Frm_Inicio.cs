using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public partial class Frm_Inicio : Form
    {
        public Cafeteria cafeteria;
        public Cafetera cafetera;

        public Frm_Inicio()
        {
            InitializeComponent();
            this.cafeteria = new Cafeteria();
            this.ActualizarInfoCafetera();
        }

        private void ActualizarCafeteras()
        {
            if (cafeteria.Cafeteras.Count > 0)
            {
                Cafeteras_comboBox.Items.Clear();
                foreach(Cafetera i in cafeteria.Cafeteras)
                {
                    Cafeteras_comboBox.Items.Add(i);
                }
            }
        }

        private void HabilitarOperacionesCafetera()
        {
            if (this.cafetera == null)
            {
                PrepararCafe_btn.Enabled = false;
                Recargar_btn.Enabled = false;
            }
            else
            {
                PrepararCafe_btn.Enabled = true;
                Recargar_btn.Enabled = true;
            }
        }

        private void ActualizarInfoCafetera()
        {
            groupBox_cafeteraInfo.Text = (this.cafetera != null) ? this.cafetera.ToString() : "Info de la cafetera";
            nombreCafe_lbl.Text = (this.cafetera != null) ? this.cafetera.Cafe.Tipo : "";
            cantidadCafe_lbl.Text = (this.cafetera != null) ? this.cafetera.Carga.ToString() : "00,00";
            precioCafe_lbl.Text = (this.cafetera != null) ? this.cafetera.Cafe.Precio.ToString() : "0000,00";
            recaudacionCafe_lbl.Text = (this.cafetera != null) ? this.cafetera.Recaudacion.ToString() : "0000,00";
            total_lbl.Text = this.cafeteria.CalcularRecaudacion().ToString();
            this.HabilitarOperacionesCafetera();
        }        

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            this.HabilitarOperacionesCafetera();
        }

        // Operaciones de cafeteras
        private void AgregarCafetera_btn_Click(object sender, EventArgs e)
        {
            Frm_agregarCafetera form = new Frm_agregarCafetera(this.cafeteria);
            form.ShowDialog();
            this.ActualizarCafeteras();
        }

        //Operaciones de la cafetera
        private void PrepararCafe_btn_Click(object sender, EventArgs e)
        {
            Frm_prepararCafe form = new Frm_prepararCafe(this.cafeteria, this.cafetera);
            form.ShowDialog();
            this.ActualizarInfoCafetera();
        }

        private void Recargar_btn_Click(object sender, EventArgs e)
        {
            this.cafetera.Cargar();
            this.ActualizarInfoCafetera();
        }

        private void Cafeteras_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cafeteras_comboBox.SelectedIndex != -1)
            {
                this.cafetera = Cafeteras_comboBox.SelectedItem as Cafetera;
                this.ActualizarInfoCafetera();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cafeteria.Cafeteras.Count != 0)
            {
                Frm_Resumen form = new Frm_Resumen(this.cafeteria);
                form.ShowDialog();
            } else
            {
                MessageBox.Show("¡No hay cafeteras para resumir operaciones!");
            }
            
        }
    }
}
