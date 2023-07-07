using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    public class Comprobante
    {
        private int _numero;

        public int Numero
        {
            get { return _numero; }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
        }

        private float _importe;

        public float Importe
        {
            get { return _importe; }
        }

        private MotivoComprobante _motivo;

        public MotivoComprobante Motivo
        {
            get { return _motivo; }
        }

        private int _reservaRef;

        public int ReservaRef
        {
            get { return _reservaRef; }
        }

        public Comprobante(int numero, DateTime fecha, float importe, MotivoComprobante motivo, int reservaRef) 
        {
            this._numero = numero;
            this._fecha = fecha;
            this._importe = importe;
            this._motivo = motivo;
            this._reservaRef = reservaRef;
        }
    }

    public enum MotivoComprobante
    {
        Deposito = 0,
        Total = 1
    }
}
