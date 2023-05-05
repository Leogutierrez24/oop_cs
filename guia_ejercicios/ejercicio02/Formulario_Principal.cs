using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public partial class Formulario_Principal : Form
    {
        Estacion estacionServicio;

        public Formulario_Principal() // seteo de todos los surtidos de la estación de servicio
        {
            InitializeComponent();
            estacionServicio = new Estacion();
            Surtidor surtidor01 = new Surtidor("Normal", 17.20m, 100);
            Surtidor surtidor02 = new Surtidor("Super", 18.50m, 75);
            Surtidor surtidor03 = new Surtidor("Premium", 21.30m, 45);
            estacionServicio.AgregarSurtidor(surtidor01);
            estacionServicio.AgregarSurtidor(surtidor02);
            estacionServicio.AgregarSurtidor(surtidor03);
            this.ActualizarFormulario();
        }

        private void ActualizarFormulario() // actualización del formulario con la data de los surtidores
        {
            label2.Text = estacionServicio.ObtenerSurtidor(1).Nafta;
            label11.Text = estacionServicio.ObtenerSurtidor(2).Nafta;
            label17.Text = estacionServicio.ObtenerSurtidor(3).Nafta;

            label4.Text = estacionServicio.ObtenerSurtidor(1).Precio.ToString();
            label9.Text = estacionServicio.ObtenerSurtidor(2).Precio.ToString();
            label15.Text = estacionServicio.ObtenerSurtidor(3).Precio.ToString();

            label6.Text = estacionServicio.ObtenerSurtidor(1).Cantidad.ToString();
            label7.Text = estacionServicio.ObtenerSurtidor(2).Cantidad.ToString();
            label13.Text = estacionServicio.ObtenerSurtidor(3).Cantidad.ToString();

            progressBar1.Value = (int)estacionServicio.ObtenerSurtidor(1).Cantidad;
            progressBar2.Value = (int)estacionServicio.ObtenerSurtidor(2).Cantidad;
            progressBar3.Value = (int)estacionServicio.ObtenerSurtidor(3).Cantidad;

            if (estacionServicio.Ventas.Count != 0)
            {
                label20.Text = $"${estacionServicio.ObtenerRecaudacionTotal()}";
                label21.Text = $"${estacionServicio.ObtenerRecaudacionSurtidor(estacionServicio.ObtenerSurtidor(1))}";
                label23.Text = $"${estacionServicio.ObtenerRecaudacionSurtidor(estacionServicio.ObtenerSurtidor(2))}";
                label25.Text = $"${estacionServicio.ObtenerRecaudacionSurtidor(estacionServicio.ObtenerSurtidor(3))}";
            } else
            {
                label20.Text = "$0000,00";
                label21.Text = "$000,00";
                label23.Text = "$000,00";
                label25.Text = "$000,00";
            }
        }

        private void ImprimirListBox(int option)
        {
            this.Ventas_listBox.DataSource = null;

            if (option == 0)
            {
                this.Ventas_listBox.DataSource = estacionServicio.PorcentajeVentas();
            } else if (option == 1)
            {
                this.Ventas_listBox.DataSource = estacionServicio.PorcentajeRecaudacion();
            } else
            {
                MessageBox.Show("Ocurrio un error");
            }


        }

        // Surtidor 01
        private void GenerarVentaSurtidor01_btn_Click(object sender, EventArgs e)
        {
            Formulario_Venta form = new Formulario_Venta(estacionServicio, estacionServicio.ObtenerSurtidor(1));
            form.ShowDialog();
            this.ActualizarFormulario();
        }

        private void RecargarSurtidor1_btn_Click(object sender, EventArgs e)
        {
            estacionServicio.ObtenerSurtidor(1).Cargar();
            this.ActualizarFormulario();
        }

        // Surtidor 02
        private void GenerarVentaSurtidor02_btn_Click(object sender, EventArgs e)
        {
            Formulario_Venta form = new Formulario_Venta(estacionServicio, estacionServicio.ObtenerSurtidor(2));
            form.ShowDialog();
            this.ActualizarFormulario();
        }

        private void RecargarSurtidor2_btn_Click(object sender, EventArgs e)
        {
            estacionServicio.ObtenerSurtidor(2).Cargar();
            this.ActualizarFormulario();
        }

        // Surtidor 03
        private void GenerarVentaSurtidor03_btn_Click(object sender, EventArgs e)
        {
            Formulario_Venta form = new Formulario_Venta(estacionServicio, estacionServicio.ObtenerSurtidor(3));
            form.ShowDialog();
            this.ActualizarFormulario();
        }

        private void RecargarSurtidor3_btn_Click(object sender, EventArgs e)
        {
            estacionServicio.ObtenerSurtidor(3).Cargar();
            this.ActualizarFormulario();
        }

        // Operaciones de surtidores
        private void EjecutarGeneral_btn_Click(object sender, EventArgs e) 
        {
            try
            {
                int operacion = General_comboBox.SelectedIndex;
                if (operacion != -1)
                {
                    switch (operacion)
                    {
                        case 0: this.textBox1.Text = estacionServicio.SurtidorMasVentas();
                            break;
                        case 1: this.textBox1.Text = estacionServicio.SurtidorMenosVentas();
                            break;                   
                        case 2: this.textBox1.Text = estacionServicio.SurtidorMasClientes();
                            break;                   
                        case 3: this.textBox1.Text = estacionServicio.SurtidorMasRecargas();
                            break;
                        default: MessageBox.Show("Algo salio mal");
                            break;
                    }
                } else
                {
                    MessageBox.Show("Selecciona una de las opciones para operar!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Operaciones de ventas 

        private void EjecutarOperacionVentas_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int operacion = Ventas_comboBox.SelectedIndex;
                if (operacion != -1)
                {
                    this.ImprimirListBox(operacion);
                }
                else
                {
                    MessageBox.Show("Selecciona una de las opciones para operar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
