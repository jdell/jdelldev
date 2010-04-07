using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class SubCuenta: IOldGesClinica<vo.SubCuenta>
    {
        public SubCuenta()
        {
            this._bloqueada = false;
            this._codigo = string.Empty;
            this._contraPartida = string.Empty;
            this._descripcion = string.Empty;
            this._saldoHabitual = string.Empty;
        }

        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _saldoHabitual;

        public string SaldoHabitual
        {
            get { return _saldoHabitual; }
            set { _saldoHabitual = value; }
        }
        private bool _bloqueada;

        public bool Bloqueada
        {
            get { return _bloqueada; }
            set { _bloqueada = value; }
        }
        private string _contraPartida;

        public string ContraPartida
        {
            get { return _contraPartida; }
            set { _contraPartida = value; }
        }
        
        #region Miembros de IOldGesClinica<SubCuenta>

        public gesClinica.lib.vo.SubCuenta ToNewGesClinica()
        {
            vo.SubCuenta res = new gesClinica.lib.vo.SubCuenta();

            //res.ID = this.ID;
            res.Descripcion = this.Descripcion;
            res.Bloqueada = this.Bloqueada;
            res.Codigo = this.Codigo;
            if (!string.IsNullOrEmpty(this.ContraPartida))
                res.ContraPartida = new gesClinica.lib.vo.SubCuenta(this.ContraPartida);
            res.Haber = this.SaldoHabitual.Trim() == "H" ? true : false;

            return res;
        }

        #endregion
    }
}
