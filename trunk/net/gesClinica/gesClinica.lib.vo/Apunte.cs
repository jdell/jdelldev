using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Apunte
    {
        private Tercero _tercero;
        public Tercero Tercero
        {
            get { return _tercero; }
            set { _tercero = value; }
        }

        public Apunte()
        {
            _asiento = null;
            _concepto = string.Empty;
            _consolidado = false;
            _contraPartida = null;
            _debe = 0;
            _fecha = DateTime.Now.Date;
            _haber = 0;
            _id = common.constantes.vacio.ID;
            _numeroFactura = 0;
            _punteado = false;
            _referencia = string.Empty;
            _subCuenta = null;
            _tercero = new Tercero();
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Asiento _asiento;

        public Asiento Asiento
        {
            get { return _asiento; }
            set { _asiento = value; }
        }
        private SubCuenta _subCuenta;

        public SubCuenta SubCuenta
        {
            get { return _subCuenta; }
            set { _subCuenta = value; }
        }
        private SubCuenta _contraPartida;

        public SubCuenta ContraPartida
        {
            get { return _contraPartida; }
            set { _contraPartida = value; }
        }
        private string _concepto;

        public string Concepto
        {
            get { return _concepto; }
            set { _concepto = value; }
        }
        private float _debe;

        public float Debe
        {
            get { return _debe; }
            set { _debe = value; }
        }
        private float _haber;

        public float Haber
        {
            get { return _haber; }
            set { _haber = value; }
        }
        private string _referencia;

        public string Referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
        private int _numeroFactura;

        public int NumeroFactura
        {
            get { return _numeroFactura; }
            set { _numeroFactura = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private bool _punteado;

        public bool Punteado
        {
            get { return _punteado; }
            set { _punteado = value; }
        }
        private bool _consolidado;

        public bool Consolidado
        {
            get { return _consolidado; }
            set { _consolidado = value; }
        }

        public float Saldo
        {
            get
            {
                return this.Debe - this.Haber;
            }
        }
    }
}
