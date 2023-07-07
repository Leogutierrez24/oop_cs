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
            Cafe cafe1 = new Cafe("Arábigo", 50);
            Cafe cafe2 = new Cafe("Robusto", 58);

            return new List<Cafe> { cafe1, cafe2 };
        }

        private List<Vaso> GenerarVasos()
        {
            Vaso vaso1 = new Vaso("Chico", 0.050f);
            Vaso vaso2 = new Vaso("Mediano", 0.100f);
            Vaso vaso3 = new Vaso("Grande", 0.250f);

            return new List<Vaso> { vaso1, vaso2, vaso3 };
        }

        public void AgregarCafetera(Cafe unCafe, string id)
        {
            Cafetera nuevaCafetera = new Cafetera(unCafe, id);
            this._cafeteras.Add(nuevaCafetera);
        }

        public float CalcularRecaudacion()
        {
            float resultado = 0;

            foreach(Cafetera cafetera in this._cafeteras)
            {
                resultado += cafetera.Recaudacion;
            }

            return resultado;
        }

        // operaciones con café
        public Cafe ObtenerCafeMasVendido()
        {
            List<Cafe> listaCafe = new List<Cafe>();

            foreach(Cafe cafe in this._cafes)
            {
                Cafe unCafe = cafe;
                listaCafe.Add(unCafe);
            }

            Cafe resultado = listaCafe.OrderByDescending(cafe => cafe.Ventas).First();

            return resultado;
        }

        public Cafe ObtenerCafeMenosVendido()
        {
            List<Cafe> listaCafe = new List<Cafe>();

            foreach (Cafe cafe in this._cafes)
            {
                Cafe unCafe = cafe;
                listaCafe.Add(unCafe);
            }

            Cafe resultado = listaCafe.OrderBy(cafe => cafe.Ventas).First();

            return resultado;
        }

        public Cafe ObtenerCafeMasRecaudacion()
        {
            List<Cafe> listaCafe = new List<Cafe>();

            foreach (Cafe cafe in this._cafes)
            {
                Cafe unCafe = cafe;
                listaCafe.Add(unCafe);
            }

            Cafe resultado = listaCafe.OrderByDescending(cafe => cafe.Recaudacion).First();

            return resultado;
        }

        public Cafe ObtenerCafeMenosRecaudacion()
        {
            List<Cafe> listaCafe = new List<Cafe>();

            foreach (Cafe cafe in this._cafes)
            {
                Cafe unCafe = cafe;
                listaCafe.Add(unCafe);
            }

            Cafe resultado = listaCafe.OrderBy(cafe => cafe.Recaudacion).First();

            return resultado;
        }

        public List<Tuple<string, float>> CalcularPorcentajeVentasCafe()
        {
            int cafesVendidos = 0;
            float resultado;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            foreach(Cafe cafe in this._cafes)
            {
                cafesVendidos += cafe.Ventas;
            }

            if (cafesVendidos != 0)
            {
                foreach (Cafe cafe in this._cafes)
                {
                    resultado = (cafe.Ventas * 100) / cafesVendidos;
                    Tuple<string, float> porcentaje = new Tuple<string, float>(cafe.Tipo, resultado);
                    porcentajes.Add(porcentaje);
                }
            } else
            {
                Tuple<string, float> empty = new Tuple<string, float>("No hay ventas", 0);
                porcentajes.Add(empty);
            }

            return porcentajes;
        }

        public List<Tuple<string, float>> CalcularPorcentajeRecaudacionCafe()
        {
            float recaudacionTotal = 0;
            float resultado;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            foreach (Cafe cafe in this._cafes)
            {
                recaudacionTotal += cafe.Recaudacion;
            }

            if (recaudacionTotal != 0)
            {
                foreach (Cafe cafe in this._cafes)
                {
                    resultado = (cafe.Recaudacion * 100) / recaudacionTotal;
                    Tuple<string, float> porcentaje = new Tuple<string, float>(cafe.Tipo, resultado);
                    porcentajes.Add(porcentaje);
                }
            } else
            {
                Tuple<string, float> empty = new Tuple<string, float>("No hay ventas", 0);
                porcentajes.Add(empty);
            }

            

            return porcentajes;
        }

        //operaciones con cafeteras
        public Cafetera ObtenerCafeteraMasUsada()
        {
            List<Cafetera> listaCafeteras = new List<Cafetera>();

            foreach(Cafetera cafetera in this._cafeteras)
            {
                Cafetera unaCafetera = cafetera;
                listaCafeteras.Add(unaCafetera);
            }

            Cafetera cafeteraMasUsada = listaCafeteras.OrderByDescending(cafetera => cafetera.Ventas.Count()).First();

            return cafeteraMasUsada;
        }

        public Cafetera ObtenerCafeteraMenosUsada()
        {
            List<Cafetera> listaCafeteras = new List<Cafetera>();

            foreach (Cafetera cafetera in this._cafeteras)
            {
                Cafetera unaCafetera = cafetera;
                listaCafeteras.Add(unaCafetera);
            }

            Cafetera cafeteraMenosUsada = listaCafeteras.OrderBy(cafetera => cafetera.Ventas.Count()).First();

            return cafeteraMenosUsada;
        }

        public Cafetera ObtenerCafeteraMasRecaudacion()
        {
            List<Cafetera> listaCafeteras = new List<Cafetera>();

            foreach (Cafetera cafetera in this._cafeteras)
            {
                Cafetera unaCafetera = cafetera;
                listaCafeteras.Add(unaCafetera);
            }

            Cafetera cafeteraMasRecaudacion = listaCafeteras.OrderByDescending(cafetera => cafetera.Recaudacion).First();

            return cafeteraMasRecaudacion;
        }

        public Cafetera ObtenerCafeteraMenosRecaudacion()
        {
            List<Cafetera> listaCafeteras = new List<Cafetera>();

            foreach (Cafetera cafetera in this._cafeteras)
            {
                Cafetera unaCafetera = cafetera;
                listaCafeteras.Add(unaCafetera);
            }

            Cafetera cafeteraMenosRecaudacion = listaCafeteras.OrderBy(cafetera => cafetera.Recaudacion).First();

            return cafeteraMenosRecaudacion;
        }

        public List<Tuple<string, float>> CalcularPorcentajeVentasCafetera()
        {
            int cafesVendidos = 0;
            float resultado;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            foreach (Cafetera cafetera in this._cafeteras)
            {
                cafesVendidos += cafetera.Ventas.Count();
            }

            if (cafesVendidos != 0)
            {
                foreach (Cafetera cafetera in this._cafeteras)
                {
                    resultado = (cafetera.Ventas.Count() * 100) / cafesVendidos;
                    Tuple<string, float> porcentaje = new Tuple<string, float>(cafetera.Id, resultado);
                    porcentajes.Add(porcentaje);
                }
            } else
            {
                Tuple<string, float> empty = new Tuple<string, float>("No hay ventas", 0);
                porcentajes.Add(empty);
            }

            return porcentajes;
        }

        public List<Tuple<string, float>> CalcularPorcentajeRecaudacionCafetera()
        {
            float totalRecaudado = 0;
            float resultado;
            List<Tuple<string, float>> porcentajes = new List<Tuple<string, float>>();

            foreach (Cafetera cafetera in this._cafeteras)
            {
                totalRecaudado += cafetera.Recaudacion;
            }

            if (totalRecaudado != 0)
            {
                foreach (Cafetera cafetera in this._cafeteras)
                {
                    resultado = (cafetera.Recaudacion * 100) / totalRecaudado;
                    Tuple<string, float> porcentaje = new Tuple<string, float>(cafetera.Id, resultado);
                    porcentajes.Add(porcentaje);
                }
            } else
            {
                Tuple<string, float> empty = new Tuple<string, float>("No hay ventas", 0);
                porcentajes.Add(empty);
            }

            return porcentajes;
        }

        public Cafetera ObtenerCafeteraMasRecargas()
        {
            List<Cafetera> listaCafeteras = new List<Cafetera>();

            foreach (Cafetera cafetera in this._cafeteras)
            {
                Cafetera unaCafetera = cafetera;
                listaCafeteras.Add(unaCafetera);
            }

            Cafetera cafeteraMasRecargada = listaCafeteras.OrderByDescending(cafetera => cafetera.Recargas).First();

            return cafeteraMasRecargada;
        }
    }
}
