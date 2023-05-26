using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio04
{
    public partial class frm_Home : Form
    {
        After afterOffice;

        public frm_Home()
        {
            InitializeComponent();
            afterOffice = new After();
            this.ActualizarFrm();
        }

        private void ActualizarFrm()
        {
            cervezas_listBox.Items.Clear();
            vasos_listBox.Items.Clear();
            barriles_listBox.Items.Clear();

            if (afterOffice.Cervezas.Count > 0)
            {
                foreach (Cerveza cerveza in afterOffice.Cervezas)
                {
                    cervezas_listBox.Items.Add(cerveza);
                }
            } else
            {
                cervezas_listBox.Items.Add("No hay cervezas");
            }

            if (afterOffice.Vasos.Count > 0)
            {
                foreach (Vaso vaso in afterOffice.Vasos)
                {
                    vasos_listBox.Items.Add(vaso);
                }
            } else
            {
                vasos_listBox.Items.Add("No hay vasos");
            }

            if (afterOffice.Barriles.Count > 0)
            {
                foreach (Barril barril in afterOffice.Barriles)
                {
                    barriles_listBox.Items.Add(barril);
                }
            } else
            {
                barriles_listBox.Items.Add("No hay barriles");
            }

            recaudacion_lbl.Text = (afterOffice.Recaudacion != 0) ? "$" + afterOffice.Recaudacion.ToString() : "$0000,00";
        }

        private void servirCerveza_btn_Click(object sender, EventArgs e)
        {
            frm_servirCerveza form = new frm_servirCerveza(this.afterOffice);
            form.ShowDialog();
            this.ActualizarFrm();
        }

        private void agregarBarril_btn_Click(object sender, EventArgs e)
        {
            frm_agregarBarril form = new frm_agregarBarril(this.afterOffice);
            form.ShowDialog();
            this.ActualizarFrm();
        }

        private void resumen_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
