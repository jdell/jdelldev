using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Apunte:IOldGesClinica<vo.Asiento>
    {
        public Apunte()
        {
            this._abono = string.Empty;
            this._asiento = 0;
            this._centroCoste= string.Empty;
            this._codigo= string.Empty;
            this._codigoUsuario= 0;
            this._conceptoCodigo= string.Empty;
            this._conceptoTexto= string.Empty;
            this._consolidado= string.Empty;
            this._contraPartida= null;
            this._cuentaReferencia= string.Empty;
            this._debe= 0;
            this._documento= string.Empty;
            this._ejercicio = null;
            this._empresa= string.Empty;
            this._factura= string.Empty;
            this._fecha= DateTime.Now;
            this._fechaGrabacion= DateTime.Now;
            this._haber= 0;
            this._moneda = 0;
            this._numeroApunte = 0;
            this._punteado = string.Empty;
            this._referencia= string.Empty;
            this._subCuenta = null;
            this._tipoDocumento= string.Empty;
            this._unidades= 0;
            this._vencimiento= DateTime.Now;
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
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private Ejercicio _ejercicio;

        public Ejercicio Ejercicio
        {
            get { return _ejercicio; }
            set { _ejercicio = value; }
        }
        private int _asiento;

        public int Asiento
        {
            get { return _asiento; }
            set { _asiento = value; }
        }
        private int _numeroApunte;

        public int NumeroApunte
        {
            get { return _numeroApunte; }
            set { _numeroApunte = value; }
        }

        private string _documento;

        public string Documento
        {
            get { return _documento; }
            set { _documento = value; }
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
        private string _conceptoTexto;

        public string ConceptoTexto
        {
            get { return _conceptoTexto; }
            set { _conceptoTexto = value; }
        }
        private string _conceptoCodigo;

        public string ConceptoCodigo
        {
            get { return _conceptoCodigo; }
            set { _conceptoCodigo = value; }
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
        private string _factura;

        public string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }
        private string _abono;

        public string Abono
        {
            get { return _abono; }
            set { _abono = value; }
        }
        private string _tipoDocumento;

        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }
        private string _centroCoste;

        public string CentroCoste
        {
            get { return _centroCoste; }
            set { _centroCoste = value; }
        }
        private string _cuentaReferencia;

        public string CuentaReferencia
        {
            get { return _cuentaReferencia; }
            set { _cuentaReferencia = value; }
        }
        private int _unidades;

        public int Unidades
        {
            get { return _unidades; }
            set { _unidades = value; }
        }
        private int _codigoUsuario;

        public int CodigoUsuario
        {
            get { return _codigoUsuario; }
            set { _codigoUsuario = value; }
        }
        private DateTime _fechaGrabacion;

        public DateTime FechaGrabacion
        {
            get { return _fechaGrabacion; }
            set { _fechaGrabacion = value; }
        }
        private string _punteado;

        public string Punteado
        {
            get { return _punteado; }
            set { _punteado = value; }
        }
        private string _consolidado;

        public string Consolidado
        {
            get { return _consolidado; }
            set { _consolidado = value; }
        }
        private DateTime _vencimiento;

        public DateTime Vencimiento
        {
            get { return _vencimiento; }
            set { _vencimiento = value; }
        }
        private int _moneda;

        public int Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }

        #region Miembros de IOldGesClinica<Asiento>

        public Asiento ToNewGesClinica()
        {
            vo.Asiento res = new Asiento();

            res.Ejercicio = this.Ejercicio.ToNewGesClinica();
            res.Fecha = this.Fecha;
            res.NumeroFactura = !string.IsNullOrEmpty(this.Factura) ? Convert.ToInt32(this.Factura) : 0;
            //res.ID
            res.Numero = this.Asiento;

            vo.Apunte apunte = new gesClinica.lib.vo.Apunte();
            apunte.Asiento = res;
            apunte.Concepto = this.ConceptoTexto;
            apunte.Consolidado = this.Consolidado!="S"?false:true;
            if ((this.ContraPartida!=null) && (!string.IsNullOrEmpty(this.ContraPartida.Codigo))) apunte.ContraPartida = this.ContraPartida.ToNewGesClinica();
            apunte.Debe = this.Debe;
            apunte.Haber = this.Haber;
            //apunte.ID
            apunte.Fecha = this.Fecha;
            apunte.NumeroFactura = !string.IsNullOrEmpty(this.Factura)?Convert.ToInt32(this.Factura):0;
            apunte.Punteado = this.Punteado!="S"?false:true;
            apunte.Referencia = this.Referencia;
            apunte.SubCuenta = this.SubCuenta.ToNewGesClinica();
            
            res.Apuntes.Add(apunte);            

            return res;
        }

        #endregion
    }
}
