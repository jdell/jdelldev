using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class ExtPaciente
    {
        private int _id;

        public int ID
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

        public ExtPaciente()
        {
            _id = lib.common.constantes.vacio.ID;
            _paciente = null;
            _reglaDuracion = 0;
            _reglaFrecuencia = 0;
            _menarquia = 0;
            _menopausia = 0;
            _dispareunemia = string.Empty;
            _dismenorrea = string.Empty;
            _sindromePremenstrual = string.Empty;
            _molestiasPelvicas = string.Empty;
            _gestaciones = 0;
            _abortos = 0;
            _vivos = 0;
            _partos = 0;
            _cesareas = 0;
            _hormonas = string.Empty;
            _anticonceptivos = string.Empty;
            _observaciones = string.Empty;
        }

        public override string ToString()
        {
            if (this.Paciente != null)
                return Paciente.ToString();
            else
                return string.Empty;
        }
    }
}
