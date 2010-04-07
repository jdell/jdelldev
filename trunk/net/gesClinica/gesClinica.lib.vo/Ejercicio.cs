using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Ejercicio
    {


        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _fechaInicial;

        public DateTime FechaInicial
        {
            get { return _fechaInicial; }
            set { _fechaInicial = value; }
        }
        private DateTime _fechaFinal;

        public DateTime FechaFinal
        {
            get { return _fechaFinal; }
            set { _fechaFinal = value; }
        }
        private int _ultimoAsiento;

        public int UltimoAsiento
        {
            get { return _ultimoAsiento; }
            set { _ultimoAsiento = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private int _ultimaFacturaEmitida;

        public int UltimaFacturaEmitida
        {
            get { return _ultimaFacturaEmitida; }
            set { _ultimaFacturaEmitida = value; }
        }
        private int _ultimaFacturaRecibida;

        public int UltimaFacturaRecibida
        {
            get { return _ultimaFacturaRecibida; }
            set { _ultimaFacturaRecibida = value; }
        }
        private Empresa _empresa;

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public Ejercicio()
        {
            _id = common.constantes.vacio.ID;
            _fechaInicial = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
            _fechaFinal = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            _ultimoAsiento = 0;
            _descripcion = string.Empty;
            _ultimaFacturaEmitida = 0;
            _ultimaFacturaRecibida = 0;
            _empresa = null;
        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
