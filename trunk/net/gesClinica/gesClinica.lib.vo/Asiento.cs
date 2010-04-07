using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Asiento
    {
        private int _numeroFactura;

        public int NumeroFactura
        {
            get { return _numeroFactura; }
            set { _numeroFactura = value; }
        }

        private tTIPOASIENTO _tipoAsiento;

        public tTIPOASIENTO TipoAsiento
        {
            get { return _tipoAsiento; }
            set { _tipoAsiento = value; }
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        private Ejercicio _ejercicio;

        public Ejercicio Ejercicio
        {
            get { return _ejercicio; }
            set { _ejercicio = value; }
        }

        public Asiento()
        {
            _id = common.constantes.vacio.ID;
            _numero = 0;
            _fecha = DateTime.Now;
            _observaciones = string.Empty;
            _ejercicio = null;
            _tipoAsiento = tTIPOASIENTO.OTRO;
            _numeroFactura = 0;
        }

        private List<Apunte> _apuntes = new List<Apunte>();

        public List<Apunte> Apuntes
        {
            get { return _apuntes; }
            set { _apuntes = value; }
        }

        public bool IsDescuadrado
        {
            get
            {
                bool res = false;

                if (Apuntes != null)
                {
                    float debe = 0;
                    float haber = 0;
                    foreach (Apunte apunte in Apuntes)
                    {
                        debe += apunte.Debe;
                        haber += apunte.Haber;
                    }
                    res = Math.Round(debe, 2) != Math.Round(haber, 2);
                }

                return res;
            }
        }
    }
}
