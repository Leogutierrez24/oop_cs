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
            this.ActualizarFormulario();
        }

        private void ActualizarFormulario() // actualización del formulario con la data de los surtidores
        {
            if (estacionServicio.Surtidor01 != null && estacionServicio.Surtidor01.Nafta != null) // info del surtidor 01
            {
                label2.Text = estacionServicio.Surtidor01.Nafta.Tipo;
                label4.Text = estacionServicio.Surtidor01.Nafta.Precio.ToString();
                label6.Text = estacionServicio.Surtidor01.Cantidad.ToString();
                progressBar1.Value = (int)estacionServicio.Surtidor01.Cantidad;
                label21.Text = $"${estacionServicio.Surtidor01.Recaudacion}";
            } else
            {
                label2.Text = "Vacío";
                label4.Text = "Sin asignar";
                label6.Text = "vacío";
                progressBar1.Value = 0;
                label21.Text = "$0000,00";
            }

            if (estacionServicio.Surtidor02 != null && estacionServicio.Surtidor02.Nafta != null) // info del surtidor 02
            {
                label11.Text = estacionServicio.Surtidor02.Nafta.Tipo;
                label9.Text = estacionServicio.Surtidor02.Nafta.Precio.ToString();
                label7.Text = estacionServicio.Surtidor02.Cantidad.ToString();
                progressBar2.Value = (int)estacionServicio.Surtidor02.Cantidad;
                label23.Text = $"${estacionServicio.Surtidor02.Recaudacion}";
            }
            else
            {
                label11.Text = "Vacío";
                label9.Text = "Sin asignar";
                label7.Text = "vacío";
                progressBar2.Value = 0;
                label23.Text = "$0000,00";
            }

            if (estacionServicio.Surtidor03 != null && estacionServicio.Surtidor03.Nafta != null) // infor del surtidor 03
            {
                label17.Text = estacionServicio.Surtidor03.Nafta.Tipo;
                label15.Text = estacionServicio.Surtidor03.Nafta.Precio.ToString();
                label13.Text = estacionServicio.Surtidor03.Cantidad.ToString();
                progressBar3.Value = (int)estacionServicio.Surtidor03.Cantidad;
                label25.Text = $"${estacionServicio.Surtidor03.Recaudacion}";
            }
            else
            {
                label17.Text = "Vacío";
                label15.Text = "Sin asignar";
                label13.Text = "vacío";
                progressBar3.Value = 0;
                label25.Text = "$0000,00";
            }

            label20.Text = $"{estacionServicio.ObtenerRecaudacionTotal()}"; 
        }

        private void ImprimirListBox(int option)
        {
            Ventas_listBox.DataSource = null;

            switch (option)
            {
                case 0:
                    this.Ventas_listBox.DataSource = estacionServicio.PorcentajeVentas();
                    break;
                case 1:
                    this.Ventas_listBox.DataSource = estacionServicio.PorcentajeRecaudacion();
                    break;
                case 2:
                    this.Ventas_listBox.DataSource = estacionServicio.PorcentajeVentasNafta();
                    break;
                case 3:
                    this.Ventas_listBox.DataSource = estacionServicio.PorcentajeRecaudacionNafta();
                    break;
                default:
                    MessageBox.Show("Algo salio mal");
                    break;
            }
        }

        // Surtidor 01
        private void GenerarVentaSurtidor01_btn_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor01.Nafta != null)
            {
                Formulario_Venta form = new Formulario_Venta(estacionServicio.Surtidor01);
                form.ShowDialog();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("El surtidor no tiene nafta asignada");
            }
        }

        private void RecargarSurtidor1_btn_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor01.Nafta != null)
            {
                estacionServicio.Surtidor01.Cargar();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("El surtidor no tiene nafta asignada para recargar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor01.Nafta == null)
            {
                Formulario_SetSurtidor form = new Formulario_SetSurtidor(estacionServicio.Surtidor01, estacionServicio);
                form.ShowDialog();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("Este surtidor ya tiene una nafta asignada");
            }
        }

        // Surtidor 02
        private void GenerarVentaSurtidor02_btn_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor02.Nafta != null)
            {
                Formulario_Venta form = new Formulario_Venta(estacionServicio.Surtidor02);
                form.ShowDialog();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("El surtidor no tiene nafta asignada");
            }
        }

        private void RecargarSurtidor2_btn_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor02.Nafta != null)
            {
                estacionServicio.Surtidor02.Cargar();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("El surtidor no tiene nafta asignada para recargar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor02.Nafta == null)
            {
                Formulario_SetSurtidor form = new Formulario_SetSurtidor(estacionServicio.Surtidor02, estacionServicio);
                form.ShowDialog();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("Este surtidor ya tiene una nafta asignada");
            }
        }

        // Surtidor 03
        private void GenerarVentaSurtidor03_btn_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor03.Nafta != null)
            {
                Formulario_Venta form = new Formulario_Venta(estacionServicio.Surtidor03);
                form.ShowDialog();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("El surtidor no tiene nafta asignada");
            }
        }

        private void RecargarSurtidor3_btn_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor03.Nafta != null)
            {
                estacionServicio.Surtidor03.Cargar();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("El surtidor no tiene nafta asignada para recargar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (estacionServicio.Surtidor03.Nafta == null)
            {
                Formulario_SetSurtidor form = new Formulario_SetSurtidor(estacionServicio.Surtidor03, estacionServicio);
                form.ShowDialog();
                this.ActualizarFormulario();
            } else
            {
                MessageBox.Show("Este surtidor ya tiene una nafta asignada");
            }
        }

        // Operaciones de surtidores
        private void EjecutarGeneral_btn_Click(object sender, EventArgs e) 
        {
            try
            {
                int operacion = General_comboBox.SelectedIndex;
                if (operacion != -1)
                {
                    string resultado = string.Empty;
                    switch (operacion)
                    {
                        case 0:
                            Surtidor masRecaudacion = estacionServicio.SurtidorMasRecaudacion();
                            resultado = $"El Surtidor con más recaudación es: {masRecaudacion.Nafta.Tipo}{Environment.NewLine}Con una recaudación de: ${masRecaudacion.Recaudacion}";
                            this.textBox1.Text = resultado;
                            break;
                        case 1:
                            Surtidor menosRecaudacion = estacionServicio.SurtidorMenosRecaudacion();
                            resultado = $"El Surtidor con menos recaudación es: {menosRecaudacion.Nafta.Tipo}{Environment.NewLine}Con una recaudación de: ${menosRecaudacion.Recaudacion}";
                            this.textBox1.Text = resultado;
                            break;                   
                        case 2:
                            Surtidor masClientes = estacionServicio.SurtidorMasClientes();
                            resultado = $"El Surtidor con más clientes es: {masClientes.Nafta.Tipo}{Environment.NewLine}Con {masClientes.Ventas.Count} clientes";
                            this.textBox1.Text = resultado;
                            break;                   
                        case 3:
                            Surtidor masRecargas = estacionServicio.SurtidorMasRecargas();
                            resultado = $"El Surtidor con más recargas es: {masRecargas.Nafta.Tipo}{Environment.NewLine}Con {masRecargas.Recargas}";
                            this.textBox1.Text = resultado;
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
