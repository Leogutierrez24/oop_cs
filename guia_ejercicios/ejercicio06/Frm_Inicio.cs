﻿using System;
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
    public partial class Frm_Inicio : Form
    {
        public Hotel hotel;

        public Frm_Inicio()
        {
            InitializeComponent();
            this.hotel = new Hotel();
        }

        // información del form

        private void ActualizarForm()
        {
            Habitaciones_listBox.DataSource = null;
            Reservas_listBox.DataSource = null;
            Habitaciones_listBox.DataSource = this.hotel.Habitaciones;
            Reservas_listBox.DataSource = this.hotel.Reservas;
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            this.ActualizarForm();
        }

        // buttons del form

        private void VerHabitacion_btn_Click(object sender, EventArgs e)
        {
            if (Habitaciones_listBox.SelectedItems.Count == 1)
            {
                Habitacion habitacionElegida = Habitaciones_listBox.SelectedItem as Habitacion;
                VerHabitacion_frm form = new VerHabitacion_frm(habitacionElegida);
                form.ShowDialog();
            } else
            {
                MessageBox.Show("Se necesita seleccionar una Habitación para continuar.");
            }
        }

        private void RegistrarHuesped_btn_Click(object sender, EventArgs e)
        {
            AgregarHuesped_frm form = new AgregarHuesped_frm(this.hotel);
            form.ShowDialog();
        }

        private void VerHuespedes_btn_Click(object sender, EventArgs e)
        {
            Huespedes_frm form = new Huespedes_frm(this.hotel);
            form.ShowDialog();
        }

        private void GenerarReserva_btn_Click(object sender, EventArgs e)
        {
            GenerarReserva_frm form = new GenerarReserva_frm(this.hotel);
            form.ShowDialog();
            this.ActualizarForm();
        }

        private void VerReserva_btn_Click(object sender, EventArgs e)
        {
            if (Reservas_listBox.SelectedItems.Count == 1)
            {
                VerReserva_frm form = new VerReserva_frm(Reservas_listBox.SelectedItem as Reserva);
                form.ShowDialog();
            } else
            {
                MessageBox.Show("Se necesita elegir una reserva para poder continuar.");
            }
        }

        private void RegistrarCheckin_btn_Click(object sender, EventArgs e)
        {
            if (Reservas_listBox.SelectedItems.Count == 1)
            {
                Reserva reservaElegida = Reservas_listBox.SelectedItem as Reserva;

                int resultado = this.hotel.RegistrarOcupacion(reservaElegida);

                if (resultado != -1)
                {
                    MessageBox.Show($"Se realizo el checkin de la reserva: 00{reservaElegida.numeroReserva} con éxito.");
                } else
                {
                    MessageBox.Show("No se puede concretar la operación de checkin.");
                }
            }
            else
            {
                MessageBox.Show("Se necesita elegir una reserva para poder continuar.");
            }
        }

        private void RegistrarCheckout_btn_Click(object sender, EventArgs e)
        {
            if (Reservas_listBox.SelectedItems.Count == 1)
            {
                Reserva reservaElegida = Reservas_listBox.SelectedItem as Reserva;

                int resultado = this.hotel.RegistrarDesocupacion(reservaElegida);

                if (resultado != -1)
                {
                    MessageBox.Show($"Se realizo el checkout de la reserva: 00{reservaElegida.numeroReserva} con éxito.");
                    this.ActualizarForm();
                }
                else
                {
                    MessageBox.Show("No se puede concretar la operación de checkout.");
                }
            }
            else
            {
                MessageBox.Show("Se necesita elegir una reserva para poder continuar.");
            }
        }

        private void CancelarReserva_btn_Click(object sender, EventArgs e)
        {
            if (Reservas_listBox.SelectedItems.Count == 1)
            {
                CancelarReserva_frm form = new CancelarReserva_frm(this.hotel, this.Reservas_listBox.SelectedItem as Reserva);
                form.ShowDialog();
                this.ActualizarForm();
            }
            else
            {
                MessageBox.Show("Se necesita elegir una reserva para poder continuar.");
            }
        }
    }
}
