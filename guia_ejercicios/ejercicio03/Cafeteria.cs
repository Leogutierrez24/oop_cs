using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public class Cafeteria
    {
        private List<Cafe> _cafes = new List<Cafe>();
        private List<Vaso> _vasos = new List<Vaso>();
        private List<Cafetera> _cafeteras = new List<Cafetera>();

        public List<Cafe> Cafes
        {
            get { return _cafes; }
        }

        public List<Vaso> Vasos
        {
            get { return _vasos; }
        }

        public List<Cafetera> Cafeteras
        {
            get { return _cafeteras; }
        }

        public Cafeteria()
        {
            this._cafes = this.GenerarCafes();
            this._vasos = this.GenerarVasos();
        }

        private List<Cafe> GenerarCafes()
        {
            Cafe cafe1 = new Cafe("arabigo", 50);
            Cafe cafe2 = new Cafe("robusto", 58);

            return new List<Cafe> { cafe1, cafe2 };
        }

        private List<Vaso> GenerarVasos()
        {
            Vaso vaso1 = new Vaso("Chico", 0.050f);
            Vaso vaso2 = new Vaso("Mediano", 0.100f);
            Vaso vaso3 = new Vaso("Grande", 0.250f);

            return new List<Vaso> { vaso1, vaso2, vaso3 };
        }

    }
}
