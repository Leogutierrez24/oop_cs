using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSEO.Formularios
{
    public partial class EstablecerAlimentacion_frm : Form
    {
        private TipoAlimentacion tipoAlimentacion;

        private List<SerVivo> alimentacion;

        private List<Animal> animales;

        public EstablecerAlimentacion_frm(List<Animal> animales, TipoAlimentacion tipoAlimentacion, List<SerVivo> alimentacion)
        {
            InitializeComponent();
            this.animales = animales;
            this.tipoAlimentacion = tipoAlimentacion;
            this.alimentacion = alimentacion;
        }

        private void EstablecerAlimentacion_frm_Load(object sender, EventArgs e)
        {
            


        }

        private void ElegirCarnivoro_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void ElegirHerbivoro_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void QuitarAlimento_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombreAlimento_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
