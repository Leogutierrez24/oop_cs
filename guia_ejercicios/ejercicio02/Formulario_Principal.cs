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

            ActualizarFormulario();
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

        }

        // Surtidor 02
        private void GenerarVentaSurtidor02_btn_Click(object sender, EventArgs e)
        {

        }

        private void RecargarSurtidor2_btn_Click(object sender, EventArgs e)
        {

        }

        // Surtidor 03
        private void GenerarVentaSurtidor03_btn_Click(object sender, EventArgs e)
        {

        }

        private void RecargarSurtidor3_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
