using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    public class Alquiler
    {
        private int id;
        private Cancha _cancha;
        private List<Juez> _jueces = new List<Juez>();
        private DateTime _fecha;
        private int _horario;
        private int _horas;
    }
}
