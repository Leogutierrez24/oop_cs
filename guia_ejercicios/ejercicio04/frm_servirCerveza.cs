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
    public partial class frm_servirCerveza : Form
    {
        After afterOffice;
        Cerveza cervezaElegida;
        Barril barrilElegido;
        Vaso vasoElegido;

        public frm_servirCerveza(After afterOffice)
        {
            InitializeComponent();
            this.afterOffice = afterOffice;
            this.ActualizarFrm();
        }

        // métodos de info del form
        private void ActualizarFrm()
        {
            if (afterOffice.Cervezas.Count > 0)
            {
                foreach (Cerveza cerveza in afterOffice.Cervezas)
                {
                    cervezas_comboBox.Items.Add(cerveza);
                }
            }
            else
            {
                cervezas_comboBox.Items.Add("No hay cervezas");
            }

            if (afterOffice.Vasos.Count > 0)
            {
                foreach (Vaso vaso in afterOffice.Vasos)
                {
                    vasos_comboBox.Items.Add(vaso);
                }
            }
            else
            {
                vasos_comboBox.Items.Add("No hay vasos");
            }

            if (afterOffice.Barriles.Count > 0)
            {
                foreach (Barril barril in afterOffice.Barriles)
                {
                    barriles_comboBox.Items.Add(barril);
                }
            }
            else
            {
                barriles_comboBox.Items.Add("No hay barriles");
            }

            cantidad_lbl.Text = $"0,000";
            total_lbl.Text = "$000,00";
        }

        private void ActualizarPrecio()
        {
            if (this.cervezaElegida != null && this.barrilElegido != null && this.vasoElegido != null)
            {
                total_lbl.Text = string.Format("${0:0.00}", this.afterOffice.CalcularPrecio(this.cervezaElegida, this.vasoElegido));
                servir_btn.Enabled = true;
            }
        }

        // botones
        private void servir_btn_Click(object sender, EventArgs e)
        {
            if (this.cervezaElegida != null && this.barrilElegido != null && this.vasoElegido != null)
            {
                VasoConCerveza vasoFinal = this.barrilElegido.ServirCerveza(this.vasoElegido);

                if (vasoFinal != null)
                {
                    this.afterOffice.AgregarVenta(new Venta(vasoFinal));
                    MessageBox.Show("Cerveza preparada: " + vasoFinal.ToString());
                    this.Close();
                } else
                {
                    MessageBox.Show("No hay suficiente cerveza para completar el pedido");
                }
            } else
            {
                MessageBox.Show("Completa todos los campos para continuar");
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // comboBoxes
        private void cervezas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cervezaElegida = cervezas_comboBox.SelectedItem as Cerveza;

            if (cervezaElegida != null)
            {
                List<Barril> barrilesFiltrados = this.afterOffice.FiltrarBarriles(cervezaElegida);
                barriles_comboBox.Items.Clear();

                if (barrilesFiltrados.Count != 0)
                {
                    foreach (Barril barril in barrilesFiltrados)
                    {
                        barriles_comboBox.Items.Add(barril);
                    }
                }
                else
                {
                    barriles_comboBox.Items.Add("No hay barriles disponibles");
                }
            }
            this.ActualizarPrecio();
        }

        private void barriles_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.barrilElegido = barriles_comboBox.SelectedItem as Barril;
            cantidad_lbl.Text = (barrilElegido != null) ? barrilElegido.Cantidad.ToString() : "00,00";
            this.ActualizarPrecio();
        }

        private void vasos_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vasoElegido = vasos_comboBox.SelectedItem as Vaso;
            this.ActualizarPrecio();
        }
    }
}
