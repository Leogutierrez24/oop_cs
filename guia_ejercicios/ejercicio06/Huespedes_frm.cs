using System;
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
    public partial class Huespedes_frm : Form
    {
        private readonly Hotel hotel;

        public Huespedes_frm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void Huespedes_frm_Load(object sender, EventArgs e)
        {
            huespedes_listBox.DataSource = this.hotel.Huespedes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
