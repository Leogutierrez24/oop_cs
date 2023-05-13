using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio03
{
    public partial class Frm_Inicio : Form
    {
        public Cafeteria cafeteria;
        public Cafetera cafetera;

        public Frm_Inicio()
        {
            InitializeComponent();
            cafeteria = new Cafeteria();
        }

        private void ActualizarCafeteras()
        {
            if (cafeteria.Cafeteras.Count > 0)
            {
                foreach(Cafetera i in cafeteria.Cafeteras)
                {
                    Cafeteras_comboBox.Items.Add(i);
                }
            }
        }


    }
}
