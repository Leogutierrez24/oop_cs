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
    public partial class frm_agregarBarril : Form
    {
        After afterOffice;

        public frm_agregarBarril(After afterOffice)
        {
            InitializeComponent();
            this.afterOffice = afterOffice;
            this.ActualizarFrm();
        }

        private void ActualizarFrm()
        {
            if (afterOffice.Cervezas.Count != 0)
            {
                foreach(Cerveza cerveza in afterOffice.Cervezas)
                {
                    cervezas_comboBox.Items.Add(cerveza);
                }
            }
        }

        private bool ComprobarID(int id)
        {
            bool resultado = true;

            Barril someBarril = afterOffice.Barriles.Find(barril => barril.Id == id);

            if (someBarril != null) resultado = false;

            return resultado;
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            if (cervezas_comboBox.SelectedIndex != -1)
            {
                if (ComprobarID((int)id_numericUpDown.Value))
                {
                    Cerveza cervezaElegida = cervezas_comboBox.SelectedItem as Cerveza;

                    Barril nuevoBarril = new Barril((int)id_numericUpDown.Value, cervezaElegida, (float)capacidad_numericUpDown.Value);
                    afterOffice.AgregarBarril(nuevoBarril);
                    this.Close();
                } else
                {
                    MessageBox.Show("Ya existe un barril con ese identificador");
                }
            } else
            {
                MessageBox.Show("Se necesita seleccionar un tipo de cerveza para continuar");
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
