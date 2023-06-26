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
    public partial class VerHabitacion_frm : Form
    {
        private readonly Habitacion someHabitacion;

        public VerHabitacion_frm(Habitacion someHabitacion)
        {
            InitializeComponent();
            this.someHabitacion = someHabitacion;
        }

        private void SetearForm()
        {
            numero_textBox.Text = this.someHabitacion.Numero.ToString();
            costo_textBox.Text = string.Format("${0:0.00}", this.someHabitacion.Costo);
            vistaMarValue_textBox.Text = this.someHabitacion.VistaMar ? "Si" : "No";
            
            if (this.someHabitacion.Camas.Count != 1)
            {
                this.someHabitacion.Camas.ForEach(cama => {
                    camas_textBox.Text += cama + Environment.NewLine;
                });
            } else
            {
                camas_textBox.Text = this.someHabitacion.Camas[0];
            }

            if (this.someHabitacion.Artefactos.Count != 1)
            {
                this.someHabitacion.Artefactos.ForEach(artefacto => {
                    electrodomesticos_textBox.Text += artefacto + Environment.NewLine;
                });
            }
            else
            {
                electrodomesticos_textBox.Text = this.someHabitacion.Artefactos[0];
            }
        }

        private void VerHabitacion_frm_Load(object sender, EventArgs e)
        {
            this.SetearForm();
        }

        private void Cerrar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
