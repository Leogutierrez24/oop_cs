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
    public partial class GenerarReserva_frm : Form
    {
        private Hotel hotel;

        private Habitacion habitacionElegida;

        private Adicional cuna;

        private DateTime diaReserva;

        private DateTime checkin;

        private DateTime checkout;

        private List<Huesped> ocupantes = new List<Huesped>();

        private float subtotal;

        private float deposito;

        public GenerarReserva_frm()
        {
            InitializeComponent();
        }
    }
}
