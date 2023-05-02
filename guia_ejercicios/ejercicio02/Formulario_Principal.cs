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
            estacionServicio.Surtidor01.Nafta = "Normal";
            estacionServicio.Surtidor02.Nafta = "Super";
            estacionServicio.Surtidor03.Nafta = "Premium";

            estacionServicio.Surtidor01.Cantidad = 100;
            estacionServicio.Surtidor02.Cantidad = 75;
            estacionServicio.Surtidor03.Cantidad = 45;
            
            estacionServicio.Surtidor01.Precio = 17.20m;
            estacionServicio.Surtidor02.Precio = 18.50m;
            estacionServicio.Surtidor03.Precio = 21.30m;

            this.ActualizarFormulario();
        }

        /* Métodos de operaciones del formulario */
        private decimal ObtenerRecaudacion(Surtidor unSurtidor)
        {
            decimal recaudacion = 0;

            if (unSurtidor != null)
            {
                if (estacionServicio.Ventas.Count != 0)
                {
                    foreach (Venta item in estacionServicio.Ventas)
                    {
                        if (item.Tipo == unSurtidor.Nafta) recaudacion += item.Total;
                    }
                }
            }
            else
            {
                MessageBox.Show("No es posible obtener la recaudación");
            }

            return recaudacion;
        }

        private decimal ObtenerRecaudacionTotal()
        {
            decimal recaudacion = 0;

            if (estacionServicio.Ventas.Count != 0)
            {
                foreach(Venta item in estacionServicio.Ventas)
                {
                    recaudacion += item.Total;
                }
            }

            return recaudacion;
        }

        private void ActualizarFormulario() // actualización del formulario con la data de los surtidores
        {
            label2.Text = estacionServicio.Surtidor01.Nafta;
            label11.Text = estacionServicio.Surtidor02.Nafta;
            label17.Text = estacionServicio.Surtidor03.Nafta;

            label4.Text = estacionServicio.Surtidor01.Precio.ToString();
            label9.Text = estacionServicio.Surtidor02.Precio.ToString();
            label15.Text = estacionServicio.Surtidor03.Precio.ToString();

            label6.Text = estacionServicio.Surtidor01.Cantidad.ToString();
            label7.Text = estacionServicio.Surtidor02.Cantidad.ToString();
            label13.Text = estacionServicio.Surtidor03.Cantidad.ToString();

            progressBar1.Value = (int)estacionServicio.Surtidor01.Cantidad;
            progressBar2.Value = (int)estacionServicio.Surtidor02.Cantidad;
            progressBar3.Value = (int)estacionServicio.Surtidor03.Cantidad;

            if (estacionServicio.Ventas.Count != 0)
            {
                label20.Text = $"${this.ObtenerRecaudacionTotal()}";
                label21.Text = $"${this.ObtenerRecaudacion(estacionServicio.Surtidor01)}";
                label23.Text = $"${this.ObtenerRecaudacion(estacionServicio.Surtidor02)}";
                label25.Text = $"${this.ObtenerRecaudacion(estacionServicio.Surtidor03)}";
            } else
            {
                label20.Text = "$0000,00";
                label21.Text = "$000,00";
                label23.Text = "$000,00";
                label25.Text = "$000,00";
            }
        }

        // Surtidor 01
        private void GenerarVentaSurtidor01_btn_Click(object sender, EventArgs e)
        {
            Formulario_Venta form = new Formulario_Venta(estacionServicio, estacionServicio.Surtidor01);
            form.ShowDialog();
            this.ActualizarFormulario();
        }

        private void RecargarSurtidor1_btn_Click(object sender, EventArgs e)
        {
            estacionServicio.Surtidor01.Cargar();
            this.ActualizarFormulario();
        }

        // Surtidor 02
        private void GenerarVentaSurtidor02_btn_Click(object sender, EventArgs e)
        {
            Formulario_Venta form = new Formulario_Venta(estacionServicio, estacionServicio.Surtidor02);
            form.ShowDialog();
            this.ActualizarFormulario();
        }

        private void RecargarSurtidor2_btn_Click(object sender, EventArgs e)
        {
            estacionServicio.Surtidor02.Cargar();
            this.ActualizarFormulario();
        }

        // Surtidor 03
        private void GenerarVentaSurtidor03_btn_Click(object sender, EventArgs e)
        {
            Formulario_Venta form = new Formulario_Venta(estacionServicio, estacionServicio.Surtidor03);
            form.ShowDialog();
            this.ActualizarFormulario();
        }

        private void RecargarSurtidor3_btn_Click(object sender, EventArgs e)
        {
            estacionServicio.Surtidor03.Cargar();
            this.ActualizarFormulario();
        }

        /* Operaciones Generales */

        private string SurtidorMasVentas()
        {
            string resultado;
            decimal surtidor01 = this.ObtenerRecaudacion(estacionServicio.Surtidor01);
            decimal surtidor02 = this.ObtenerRecaudacion(estacionServicio.Surtidor02);
            decimal surtidor03 = this.ObtenerRecaudacion(estacionServicio.Surtidor03);

            if (estacionServicio.Ventas.Count != 0)
            {
                if (surtidor01 > surtidor02)
                {
                    if (surtidor01 > surtidor03)
                    {
                        resultado = $"El surtidor con más ventas: {estacionServicio.Surtidor01.Nafta}{Environment.NewLine}Con ${surtidor01} acumulados";
                    }
                    else
                    {
                        resultado = $"El surtidor con más ventas: {estacionServicio.Surtidor03.Nafta}{Environment.NewLine}Con ${surtidor03} acumulados";
                    }
                }
                else if (surtidor02 > surtidor03)
                {
                    resultado = $"El surtidor con más ventas: {estacionServicio.Surtidor02.Nafta}{Environment.NewLine}Con ${surtidor02} acumulados";
                }
                else
                {
                    resultado = $"El surtidor con más ventas: {estacionServicio.Surtidor03.Nafta}{Environment.NewLine}Con ${surtidor03} acumulados";
                }
            } else
            {
                resultado = "No hay ventas registradas";
            }

            return resultado;
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
                        case 0: this.textBox1.Text = this.SurtidorMasVentas();
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

        }
    }
}
