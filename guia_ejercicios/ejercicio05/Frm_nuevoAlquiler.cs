﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio05
{
    public partial class Frm_nuevoAlquiler : Form
    {
        // props globales
        public Polideportivo poli;

        // props del alquiler
        public Cancha canchaElegida;

        public DateTime fechaElegida;

        public Opcion opcionElegida;

        public int horas = 0;

        public int horario = 0;

        public List<Juez> jueces = new List<Juez>();

        // form
        public Frm_nuevoAlquiler(Polideportivo poli)
        {
            InitializeComponent();
            this.poli = poli;
            this.horas = (int)horas_numericUpDown.Value;
            this.horario = (int)Horario_numericUpDown.Value;
        }

        // form data
        public void PresetForm()
        {
            foreach(Cancha cancha in this.poli.Canchas)
            {
                Cancha_comboBox.Items.Add(cancha);
            }

            totalValue_lbl.Text = "$000,00";
        }

        private void Frm_nuevoAlquiler_Load(object sender, EventArgs e)
        {
            this.PresetForm();
            fecha_dateTimePicker.Value = DateTime.Now;
        }

        private void ActualizarJueces()
        {
            List<Juez> juecesDisponibles = this.poli.JuecesDisponibles(this.fechaElegida, this.horario, this.horas);

            jueces_listBox.Items.Clear();

            if (juecesDisponibles.Count != 0)
            {
                foreach (Juez juez in juecesDisponibles)
                {
                    jueces_listBox.Items.Add(juez);
                }
                EstablecerJueces_btn.Enabled = true;
            } else
            {
                jueces_listBox.Items.Add("No hay jueces disponibles");
                EstablecerJueces_btn.Enabled = false;
            }
            
        }

        // cambios de valores
        private void Cancha_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Opciones_comboBox.Items.Clear();
            jueces_listBox.Items.Clear();

            this.canchaElegida = Cancha_comboBox.SelectedItem as Cancha;
            this.opcionElegida = null;
            this.jueces.Clear();

            if (canchaElegida.Opciones.Count != 0)
            {
                foreach(Opcion opcion in canchaElegida.Opciones)
                {
                    Opciones_comboBox.Items.Add(opcion);
                }
            } 
        }

        private void Opciones_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.opcionElegida = Opciones_comboBox.SelectedItem as Opcion;
            this.jueces.Clear();
            this.ActualizarJueces();
        }

        private void fecha_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            alquileres_listBox.Items.Clear();

            this.fechaElegida = fecha_dateTimePicker.Value.Date;
            this.jueces.Clear();
            this.ActualizarJueces();

            List<Alquiler> alquileres = this.poli.FiltarAlquileres(fechaElegida);

            if (alquileres.Count != 0)
            {
                foreach (Alquiler alquiler in alquileres)
                {
                    alquileres_listBox.Items.Add(alquiler);
                }
            } else
            {
                alquileres_listBox.Items.Add("No hay alquileres dentro de esta fecha.");
            }
        }

        private void horas_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.horas = (int)horas_numericUpDown.Value;
            this.jueces.Clear();
            this.ActualizarJueces();
        }

        private void Horario_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.horario = (int)Horario_numericUpDown.Value;
            this.jueces.Clear();
            this.ActualizarJueces();
        }

        // operaciones de los buttons
        private void CalcularTotal_btn_Click(object sender, EventArgs e)
        {
            if (this.canchaElegida != null)
            {
                totalValue_lbl.Text = string.Format("${0:0.00}", this.poli.CalcularTotalAlquiler(this.canchaElegida, this.opcionElegida, this.horas));
            } else
            {
                MessageBox.Show("¡Faltan campos por completar!");
            }
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerDisponibilidad_btn_Click(object sender, EventArgs e)
        {
            if (this.canchaElegida == null || this.fechaElegida == null || this.horas == 0 || this.horario == 0)
            {
                MessageBox.Show("¡Faltan campos por completar!");
            } else
            {
                bool disponibilidad = this.poli.ComprobarDisponibilidad(this.canchaElegida, this.fechaElegida, this.horas, this.horario);
                estadoValue_lbl.Visible = true;
                label7.Visible = true;
                estadoValue_lbl.Text = (disponibilidad) ? "Disponible" : "No disponible";
            }
        }

        private void Alquilar_btn_Click(object sender, EventArgs e)
        {
            if (this.canchaElegida != null && this.fechaElegida != null && this.horas != 0 && this.horario != 0 && this.opcionElegida != null)
            {
                Alquiler respuesta = this.poli.GenerarAlquiler(this.canchaElegida, this.jueces, this.fechaElegida, this.horario, this.horas, this.opcionElegida);
                if (respuesta != null)
                {
                    string resumen = $"Se generó el siguiente alquiler:\n* Cancha: {respuesta.Cancha.Tipo}\n* Fecha: {respuesta.Fecha.ToShortDateString()}\n* Horario: {respuesta.HoraInicial} hrs\n* Cant. Horas: {respuesta.Horas}\n* Adicionales: {respuesta.Opcion.Descripcion}";
                    MessageBox.Show(resumen);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo concretar el alquiler");
                }
            }
            else
            {
                MessageBox.Show("¡Faltan campos por completar!");
            }
        }

        private void EstablecerJueces_btn_Click(object sender, EventArgs e)
        {
            if (this.opcionElegida != null)
            {
                if (this.opcionElegida.Jueces > 0)
                {
                    if (opcionElegida.Jueces == jueces_listBox.SelectedItems.Count)
                    {
                        foreach (object juez in jueces_listBox.SelectedItems)
                        {
                            this.jueces.Add((Juez)juez);
                        }

                        MessageBox.Show("Jueces seleccionados");
                    } else
                    {
                        MessageBox.Show("No se eligieron los jueces necesarios para continuar");
                    }
                } else
                {
                    MessageBox.Show("No es necesario elegir jueces");
                }
            } else
            {
                MessageBox.Show("Es necesario elegir una opción");
            }
        }

        
    }
}
