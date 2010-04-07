using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Caja: IOldGesClinica<vo.Operacion>
    {
        public Caja()
        {
            this._debe = 0;
            this._descripcion = string.Empty;
            this._factura = string.Empty;
            this._fecha = DateTime.Now;
            this._haber = 0;
            this._id = string.Empty;
            this._paciente = null;
            this._tipoCaja = null;
            this._transferido = false;
            this._visita = null;
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Paciente _paciente;

        public Paciente Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }
        private Visita _visita;

        public Visita Visita
        {
            get { return _visita; }
            set { _visita = value; }
        }
        private TipoCaja _tipoCaja;

        public TipoCaja TipoCaja
        {
            get { return _tipoCaja; }
            set { _tipoCaja = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private float _haber;

        public float Haber
        {
            get { return _haber; }
            set { _haber = value; }
        }
        private float _debe;

        public float Debe
        {
            get { return _debe; }
            set { _debe = value; }
        }
        private string _factura;

        public string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private bool _transferido;

        public bool Transferido
        {
            get { return _transferido; }
            set { _transferido = value; }
        }

        #region Miembros de IOldGesClinica<Operacion>

        public Operacion ToNewGesClinica()
        {
            vo.Operacion res = new Operacion();

            //res.Adeudado
            if (this.Visita!=null) res.Cita = this.Visita.ToNewGesClinica();
            res.Debe = this.Debe;
            //res.Descripcion = this.Descripcion;
            res.Facturado = this.Transferido && !string.IsNullOrEmpty(this.Factura) && Convert.ToInt32(this.Factura)!=0;
            res.Fecha = this.Fecha;
            //res.Gastos
            res.Haber = this.Haber;
            //res.ID
            //res.Ingresos
            //res.IsSaldada
            res.Tipo = this.TipoCaja.ToNewGesClinica();
            res.FacturaAntigua = this.Factura;

            return res;
        }

        #endregion
    }
}
