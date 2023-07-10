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
    public partial class NuevoAnimal_frm : Form
    {
        private Museo museo;

        private TiposHabitat habitat;

        private TipoAlimentacion tipoAlimentacion;

        private string nombre;

        private long periodoVida;

        private List<SerVivo> alimentacion = new List<SerVivo>();

        private Postura postura;

        private bool exoesqueleto;

        private float vision;

        private float velocidad;

        public NuevoAnimal_frm(Museo museo)
        {
            InitializeComponent();
            this.museo = museo;
        }

        private void NuevoAnimal_frm_Load(object sender, EventArgs e)
        {
            Habitat_comboBox.Items.Add(TiposHabitat.Terrestre);
            Habitat_comboBox.Items.Add(TiposHabitat.Aereo);
            Habitat_comboBox.Items.Add(TiposHabitat.Acuatico);

            TipoAlimentacion_comboBox.Items.Add(TipoAlimentacion.Carnivoro);
            TipoAlimentacion_comboBox.Items.Add(TipoAlimentacion.Herbivoro);

            Postura_comboBox.Items.Add(Postura.Bipedo);
            Postura_comboBox.Items.Add(Postura.Cuadrupedo);

            if (this.museo.Animales.Count != 0)
            {
                this.museo.Animales.ForEach(animal =>
                {
                    animales_listBox.Items.Add(animal);
                });
                animales_listBox.DisplayMember = "Nombre";
            }

            this.ActualizarListAlimentos();
        }

        private void HabilitatCaracteristicasForm()
        {
            if (this.habitat == TiposHabitat.Terrestre)
            {
                Postura_comboBox.Enabled = true;
                Exoesqueleto_comboBox.Enabled = true;
                Velocidad_numericUpDown.Enabled = false;
                Vision_numericUpDown.Enabled = false;
            } else if (this.habitat == TiposHabitat.Aereo)
            {
                Postura_comboBox.Enabled = false;
                Exoesqueleto_comboBox.Enabled = false;
                Velocidad_numericUpDown.Enabled = true;
                Vision_numericUpDown.Enabled = true;
            } else
            {
                Postura_comboBox.Enabled = false;
                Exoesqueleto_comboBox.Enabled = false;
                Velocidad_numericUpDown.Enabled = false;
                Vision_numericUpDown.Enabled = false;
            }
        }

        private void HabilitarAlimentacionForm()
        {
            if (tipoAlimentacion == TipoAlimentacion.Carnivoro)
            {
                nombreAlimento_textBox.Enabled = false;
                ElegirHerbivoro_btn.Enabled = false;

                animales_listBox.Enabled = true;
                ElegirCarnivoro_btn.Enabled = true;
            }
            else
            {
                nombreAlimento_textBox.Enabled = true;
                ElegirHerbivoro_btn.Enabled = true;

                animales_listBox.Enabled = false;
                ElegirCarnivoro_btn.Enabled = false;
            }
        }

        private void ActualizarListAlimentos()
        {
            alimentosElegidos_listBox.Items.Clear();
            if (this.alimentacion.Count != 0)
            {
                this.alimentacion.ForEach(alimento =>
                {
                    alimentosElegidos_listBox.Items.Add(alimento);
                });
                alimentosElegidos_listBox.DisplayMember = "Nombre";
            }
        }

        private void Habitat_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.habitat = (TiposHabitat)Habitat_comboBox.SelectedItem;
            this.HabilitatCaracteristicasForm();
        }

        private void TipoAlimentacion_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoAlimentacion = (TipoAlimentacion)TipoAlimentacion_comboBox.SelectedItem;
            this.alimentacion = new List<SerVivo>();
            this.HabilitarAlimentacionForm();
            this.ActualizarListAlimentos();
        }

        private void Nombre_textBox_TextChanged(object sender, EventArgs e)
        {
            this.nombre = Nombre_textBox.Text;
        }

        private void Periodo_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.periodoVida = (long)Periodo_numericUpDown.Value;
        }

        // Características -> Terrestre
        private void Postura_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.postura = (Postura)Postura_comboBox.SelectedItem;
        }

        private void Exoesqueleto_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.exoesqueleto = Exoesqueleto_comboBox.SelectedIndex == 0 ? true : false; 
        }

        // Características -> Aéreo
        private void Vision_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.vision = (float)Vision_numericUpDown.Value;
        }

        private void Velocidad_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.velocidad = (float)Velocidad_numericUpDown.Value;
        }

        // Alimentación -> Carnívoro
        private void ElegirCarnivoro_btn_Click(object sender, EventArgs e)
        {
            if (animales_listBox.SelectedItems.Count != 0)
            {
                int cantidad = animales_listBox.SelectedItems.Count - 1;

                for (int i = 0; i <= cantidad; i++)
                {
                    Animal animal = animales_listBox.SelectedItems[i] as Animal;
                    if (!this.alimentacion.Exists(a => a.Nombre == animal.Nombre))
                    {
                        this.alimentacion.Add(animal);
                    }
                }

                this.ActualizarListAlimentos();
            }
            else
            {
                MessageBox.Show("Se necesita seleccionar al menos un animal para continuar.");
            }
        }

        // Alimentación -> Herbívoro
        private void ElegirHerbivoro_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreAlimento_textBox.Text))
            {
                SerVivo alimento = new SerVivo(nombreAlimento_textBox.Text);
                this.alimentacion.Add(alimento);
                nombreAlimento_textBox.Text = string.Empty;
                this.ActualizarListAlimentos();
            }
            else
            {
                MessageBox.Show("Se necesita proveer un nombre poder agregar el alimento.");
            }
        }

        private void QuitarAlimento_btn_Click(object sender, EventArgs e)
        {
            if (alimentosElegidos_listBox.SelectedItems.Count != 0)
            {
                if (tipoAlimentacion == TipoAlimentacion.Carnivoro)
                {
                    this.alimentacion.Remove(alimentosElegidos_listBox.SelectedItem as Animal);
                }
                else
                {
                    this.alimentacion.Remove(alimentosElegidos_listBox.SelectedItem as SerVivo);
                }
                this.ActualizarListAlimentos();
            }
            else
            {
                MessageBox.Show("Se necesita seleccionar al menos un elemento para poder continuar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Habitat_comboBox.SelectedItem != null &&
                TipoAlimentacion_comboBox.SelectedItem != null &&
                !string.IsNullOrEmpty(Nombre_textBox.Text)
                )
            {
                if (this.habitat == TiposHabitat.Terrestre)
                {
                    if (Postura_comboBox.SelectedItem != null && Exoesqueleto_comboBox.SelectedItem != null)
                    {
                        Terrestre nuevoAnimal = new Terrestre(this.nombre,
                            this.tipoAlimentacion,
                            this.periodoVida,
                            this.postura,
                            this.exoesqueleto
                            );

                        if (this.alimentacion.Count != 0)
                        {
                            nuevoAnimal.EstablecerAlimentacion(this.alimentacion);
                        }

                        int respuesta = this.museo.AgregarNuevoAnimal(nuevoAnimal);

                        if (respuesta != -1)
                        {
                            MessageBox.Show($"Se agregó el animal: {nuevoAnimal.Nombre}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"No se puede agregar el animal: {nuevoAnimal.Nombre} porque ya existe");
                            Nombre_textBox.Focus();
                        }

                    }
                    else MessageBox.Show("¡Hay campos incompletos!");
                }
                else if (this.habitat == TiposHabitat.Aereo)
                {
                    if (Velocidad_numericUpDown.Value != 0 && Vision_numericUpDown.Value != 0)
                    {
                        Aereo nuevoAnimal = new Aereo(this.nombre,
                            this.tipoAlimentacion,
                            this.periodoVida,
                            this.vision,
                            this.velocidad
                            );

                        if (this.alimentacion.Count != 0)
                        {
                            nuevoAnimal.EstablecerAlimentacion(this.alimentacion);
                        }

                        int respuesta = this.museo.AgregarNuevoAnimal(nuevoAnimal);

                        if (respuesta != -1)
                        {
                            MessageBox.Show($"Se agregó el animal: {nuevoAnimal.Nombre}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"No se puede agregar el animal: {nuevoAnimal.Nombre} porque ya existe");
                            Nombre_textBox.Focus();
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    Acuatico nuevoAnimal = new Acuatico(this.nombre, this.tipoAlimentacion, this.periodoVida);

                    if (this.alimentacion.Count != 0)
                    {
                        nuevoAnimal.EstablecerAlimentacion(this.alimentacion);
                    }

                    int respuesta = this.museo.AgregarNuevoAnimal(nuevoAnimal);

                    if (respuesta != -1)
                    {
                        MessageBox.Show($"Se agregó el animal: {nuevoAnimal.Nombre}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede agregar el animal: {nuevoAnimal.Nombre} porque ya existe");
                        Nombre_textBox.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Hay campos incompletos!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
