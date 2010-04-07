using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Ginecologia: IOldGesClinica<vo.ExtPaciente>
    {
        public Ginecologia()
        {
            this._abortos = 0;
            this._anticonceptivos = string.Empty ;
            this._cesareas = 0;
            this._dismenorrea= string.Empty;
            this._dispareunemia= string.Empty;
            this._gestaciones= 0;
            this._hormonas= string.Empty;
            this._id= string.Empty;
            this._menarquia= 0;
            this._menopausia= 0;
            this._molestiasPelvicas= string.Empty;
            this._observaciones= string.Empty;
            this._paciente= null;
            this._partos= 0;
            this._reglaDuracion= 0;
            this._reglaFrecuencia= 0;
            this._sindromePremenstrual= string.Empty;
            this._vivos= 0;
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

        private int _reglaDuracion;

        public int ReglaDuracion
        {
            get { return _reglaDuracion; }
            set { _reglaDuracion = value; }
        }
        private int _reglaFrecuencia;

        public int ReglaFrecuencia
        {
            get { return _reglaFrecuencia; }
            set { _reglaFrecuencia = value; }
        }
        private int _menarquia;

        public int Menarquia
        {
            get { return _menarquia; }
            set { _menarquia = value; }
        }
        private int _menopausia;

        public int Menopausia
        {
            get { return _menopausia; }
            set { _menopausia = value; }
        }
        private string _dispareunemia;

        public string Dispareunemia
        {
            get { return _dispareunemia; }
            set { _dispareunemia = value; }
        }
        private string _dismenorrea;

        public string Dismenorrea
        {
            get { return _dismenorrea; }
            set { _dismenorrea = value; }
        }
        private string _sindromePremenstrual;

        public string SindromePremenstrual
        {
            get { return _sindromePremenstrual; }
            set { _sindromePremenstrual = value; }
        }
        private string _molestiasPelvicas;

        public string MolestiasPelvicas
        {
            get { return _molestiasPelvicas; }
            set { _molestiasPelvicas = value; }
        }
        private int _gestaciones;

        public int Gestaciones
        {
            get { return _gestaciones; }
            set { _gestaciones = value; }
        }
        private int _abortos;

        public int Abortos
        {
            get { return _abortos; }
            set { _abortos = value; }
        }
        private int _vivos;

        public int Vivos
        {
            get { return _vivos; }
            set { _vivos = value; }
        }
        private int _partos;

        public int Partos
        {
            get { return _partos; }
            set { _partos = value; }
        }
        private int _cesareas;

        public int Cesareas
        {
            get { return _cesareas; }
            set { _cesareas = value; }
        }
        private string _hormonas;

        public string Hormonas
        {
            get { return _hormonas; }
            set { _hormonas = value; }
        }
        private string _anticonceptivos;

        public string Anticonceptivos
        {
            get { return _anticonceptivos; }
            set { _anticonceptivos = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }


        #region Miembros de IOldGesClinica<ExtPaciente>

        public ExtPaciente ToNewGesClinica()
        {
            vo.ExtPaciente res = new ExtPaciente();

            res.Abortos = this.Abortos;
            res.Anticonceptivos = this.Anticonceptivos;
            res.Cesareas = this.Cesareas;
            res.Dismenorrea = this.Dismenorrea;
            res.Dispareunemia = this.Dispareunemia;
            res.Gestaciones = this.Gestaciones;
            res.Hormonas = this.Hormonas;
            //res.ID
            res.Menarquia = this.Menarquia;
            res.Menopausia = this.Menopausia;
            res.MolestiasPelvicas = this.MolestiasPelvicas;
            res.Observaciones = this.Observaciones;
            res.Paciente = this.Paciente.ToNewGesClinica();
            res.Partos = this.Partos;
            res.ReglaDuracion = this.ReglaDuracion;
            res.ReglaFrecuencia = this.ReglaFrecuencia;
            res.SindromePremenstrual = this.SindromePremenstrual;
            res.Vivos = this.Vivos;

            return res;
        }

        #endregion
    }
}
