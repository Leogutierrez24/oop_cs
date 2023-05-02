using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio02
{
    public class Estacion
    {
        private Surtidor _surtidor01 = new Surtidor();
        private Surtidor _surtidor02 = new Surtidor();
        private Surtidor _surtidor03 = new Surtidor();
        private List<Venta> _ventas = new List<Venta>();

        public Surtidor Surtidor01
        {
            get { return _surtidor01; }
            private set { _surtidor01 = value; }
        }
           
        public Surtidor Surtidor02
        {
            get { return _surtidor02; }
            private set { _surtidor02 = value; }
        }

        public Surtidor Surtidor03
        {
            get { return _surtidor03; }
            private set { _surtidor03 = value; }
        }

        public List<Venta> Ventas
        {
            get { return Ventas; }
        }

        public void Agregar(Venta unaVenta)
        {
            _ventas.Add(unaVenta);            
        }
    }
}
