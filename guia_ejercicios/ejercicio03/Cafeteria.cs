using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public class Cafeteria
    {
        private float _recaudacion;
        private List<Venta> _ventas = new List<Venta>();
        private List<Cafetera> _cafeteras = new List<Cafetera>();

        public float Recaudacion
        {
            get { return _recaudacion; }
        }
        

    }
}
