using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Visita:IOldGesClinica<vo.Cita>
    {
        public Visita()
        {
            this._actividad = null;
            this._adeudado = 0;
            this._conDatos = false;
            this._diagnostico = string.Empty;
            this._estado = 0;
            this._horaCita = DateTime.Now;
            this._id = string.Empty;
            this._llegada = DateTime.Now;
            this._moneda = 0;
            this._noPresentado = false;
            this._paciente = null;
            this._peticion = DateTime.Now;
            this._presencial = true;
            this._recetaLibre = string.Empty;
            this._salida = DateTime.Now;
            this._sintomas = string.Empty;
            this._terapeuta = null;
            this._tratamiento = string.Empty;
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
        private DateTime _horaCita;

        public DateTime HoraCita
        {
            get { return _horaCita; }
            set { _horaCita = value; }
        }
        private Terapeuta _terapeuta;

        public Terapeuta Terapeuta
        {
            get { return _terapeuta; }
            set { _terapeuta = value; }
        }
        private float _adeudado;

        public float Adeudado
        {
            get { return _adeudado; }
            set { _adeudado = value; }
        }
        private Actividad _actividad;

        public Actividad Actividad
        {
            get { return _actividad; }
            set { _actividad = value; }
        }
        private string _diagnostico;

        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }
        private string _sintomas;

        public string Sintomas
        {
            get { return _sintomas; }
            set { _sintomas = value; }
        }
        private string _tratamiento;

        public string Tratamiento
        {
            get { return _tratamiento; }
            set { _tratamiento = value; }
        }
        private bool _conDatos;

        public bool ConDatos
        {
            get { return _conDatos; }
            set { _conDatos = value; }
        }
        private DateTime _peticion;

        public DateTime Peticion
        {
            get { return _peticion; }
            set { _peticion = value; }
        }
        private DateTime _llegada;

        public DateTime Llegada
        {
            get { return _llegada; }
            set { _llegada = value; }
        }
        private DateTime _salida;

        public DateTime Salida
        {
            get { return _salida; }
            set { _salida = value; }
        }
        private int _estado;

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private bool _noPresentado;

        public bool NoPresentado
        {
            get { return _noPresentado; }
            set { _noPresentado = value; }
        }
        private bool _presencial;

        public bool Presencial
        {
            get { return _presencial; }
            set { _presencial = value; }
        }
        private string _recetaLibre;

        public string RecetaLibre
        {
            get { return _recetaLibre; }
            set { _recetaLibre = value; }
        }
        private int _moneda;

        public int Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }


        #region Miembros de IOldGesClinica<Cita>

        public Cita ToNewGesClinica()
        {
            Cita res = new Cita();

            //res.Anexo
            res.Diagnostico = this.Diagnostico;
            if (this.Actividad!=null) res.Duracion = this.Actividad.getDuracion(this.Actividad.Tiempo);
            if (this.Terapeuta!=null) res.Empleado = this.Terapeuta.ToNewGesClinica();
            //res.EstadoCita
            res.Facturada = false; //TODO: Esto lo hacemos cuando importemos la caja
            res.Fecha = this.HoraCita;
            //res.ID
            //res.Notas = 
            if (this.Paciente != null) res.Paciente = this.Paciente.ToNewGesClinica();
            //res.Prescrito
            res.Presencial = this.Presencial;
            //res.Programada = 
            //res.Receta
            //res.Resumen
            //res.Sala = this.sa //TODO: Antes no se asignaba a ninguna sala.
            res.Sintomas = this.Sintomas;
            if (this.Actividad != null) res.Terapia = this.Actividad.ToNewGesClinica();
            res.Tratamiento = this.Tratamiento;

            vo.Receta receta = new gesClinica.lib.vo.Receta();
            receta.Cita = res;
            receta.Observaciones = this.RecetaLibre;
            res.Receta.Add(receta);

            return res;
        }

        #endregion
    }
}
