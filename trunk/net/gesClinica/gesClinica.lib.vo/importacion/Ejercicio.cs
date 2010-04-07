using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Ejercicio:IOldGesClinica<vo.Ejercicio>, IComparable<Ejercicio>
    {
        public Ejercicio()
        {
            _codigo = string.Empty;
            _descripcion = string.Empty;
            _empresa = string.Empty;
            _fechaInicial = new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0);
            _fechaFinal = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            _trimestreCerrado = 0;
            _ultimaFacturaEmitida = 0;
            _ultimaFacturaRecibida = 0;
            _ultimoAsiento = 0;
            _ultimoAsientoDiferido = 0;
        }

        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _empresa;

        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
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
        private int _ultimoAsientoDiferido;

        public int UltimoAsientoDiferido
        {
            get { return _ultimoAsientoDiferido; }
            set { _ultimoAsientoDiferido = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private int _ultimaFacturaRecibida;

        public int UltimaFacturaRecibida
        {
            get { return _ultimaFacturaRecibida; }
            set { _ultimaFacturaRecibida = value; }
        }
        private int _ultimaFacturaEmitida;

        public int UltimaFacturaEmitida
        {
            get { return _ultimaFacturaEmitida; }
            set { _ultimaFacturaEmitida = value; }
        }
        private int _trimestreCerrado;

        public int TrimestreCerrado
        {
            get { return _trimestreCerrado; }
            set { _trimestreCerrado = value; }
        }

        #region Miembros de IOldGesClinica<Ejercicio>

        public gesClinica.lib.vo.Ejercicio ToNewGesClinica()
        {
            vo.Ejercicio res = new gesClinica.lib.vo.Ejercicio();

            res.Descripcion = this.Descripcion;
            res.Empresa = null;
            res.FechaFinal = this.FechaFinal;
            res.FechaInicial = this.FechaInicial;
            //res.ID
            res.UltimaFacturaEmitida = this.UltimaFacturaEmitida;
            res.UltimaFacturaRecibida= this.UltimaFacturaRecibida;
            res.UltimoAsiento = this.UltimoAsiento;

            return res;
        }

        #endregion

        #region Miembros de IComparable<Ejercicio>

        public int CompareTo(Ejercicio other)
        {
            return this.Codigo.CompareTo(other.Codigo);
        }

        #endregion
    }
}
