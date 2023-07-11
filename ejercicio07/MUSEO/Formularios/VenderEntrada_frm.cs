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

namespace MUSEO.Formularios
{
    public partial class VenderEntrada_frm : Form
    {
        private Museo museo;

        private List<Atraccion> atraccionesElegidas = new List<Atraccion>();

        public VenderEntrada_frm(Museo museo)
        {
            InitializeComponent();
            this.museo = museo;
        }

        private void ActualizarAtraccionesElegidas()
        {
            atraccionesElegidas_listBox.Items.Clear();

            atraccionesElegidas.ForEach(atraccion => atraccionesElegidas_listBox.Items.Add(atraccion));
            atraccionesElegidas_listBox.DisplayMember = "Nombre";
        }

        private void EstablecerPrecios()
        {
            if (!string.IsNullOrEmpty(nombre_textBox.Text) &&
                !string.IsNullOrEmpty(apellido_textBox.Text) &&
                atraccionesElegidas.Count > 0)
            {
                subtotal_lbl.Text = string.Format("${0:0.00}", this.museo.CalcularSubtotal(this.atraccionesElegidas));
                total_lbl.Text = string.Format("${0:0.00}", this.museo.CalcularDescuento(this.atraccionesElegidas, fechaNacimiento_dateTimePicker.Value));
            } else
            {
                subtotal_lbl.Text = "$00,00";
                total_lbl.Text = "$00,00";
            }
        }

        private void ElegirAtraccion_btn_Click(object sender, EventArgs e)
        {
            Atraccion opcionElegida = atracciones_listBox.SelectedItem as Atraccion;

            if (!atraccionesElegidas.Exists(atraccion => atraccion.Nombre == opcionElegida.Nombre))
            {
                if (atracciones_listBox.SelectedItems.Count != 0)
                {
                    this.atraccionesElegidas.Add(opcionElegida);
                    this.ActualizarAtraccionesElegidas();
                }
                else
                {
                    MessageBox.Show("Es necesario elegir al menos una atracción para continuar.");
                }
            } else
            {
                MessageBox.Show($"Ya fue agregada la atracción: {opcionElegida.Nombre}");
            }
            
        }

        private void QuitarAtraccion_btn_Click(object sender, EventArgs e)
        {
            if (atraccionesElegidas_listBox.SelectedItems.Count != 0)
            {
                this.atraccionesElegidas.Remove(atraccionesElegidas_listBox.SelectedItem as Atraccion);
                this.ActualizarAtraccionesElegidas();
            }
            else
            {
                MessageBox.Show("Es necesario elegir al menos una atracción para continuar.");
            }
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta Generada!");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VenderEntrada_frm_Load(object sender, EventArgs e)
        {
            atracciones_listBox.Items.Add(this.museo.SectorAcuatico);
            atracciones_listBox.Items.Add(this.museo.SectorAereo);
            atracciones_listBox.Items.Add(this.museo.SectorTerrestre);

            atracciones_listBox.DisplayMember = "Nombre";

            fechaNacimiento_dateTimePicker.MaxDate = DateTime.Now;
            this.EstablecerPrecios();
        }

        private void nombre_textBox_TextChanged(object sender, EventArgs e)
        {
            this.EstablecerPrecios();
        }

        private void apellido_textBox_TextChanged(object sender, EventArgs e)
        {
            this.EstablecerPrecios();
        }

        private void documento_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.EstablecerPrecios();
        }

        private void fechaNacimiento_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.EstablecerPrecios();
        }
    }
}
