using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._common.secciones
{
    class asrConfigSection : lib.common.tipos.section
    {
        private int _saltoAgenda;

        public int SaltoAgenda
        {
            get { return _saltoAgenda; }
            set { _saltoAgenda = value; }
        }

        private int _iva;

        public int IVA
        {
            get { return _iva; }
            set { _iva = value; }
        }

        private string _serieFacturacion;

        public string SerieFacturacion
        {
            get { return _serieFacturacion; }
            set { _serieFacturacion = value; }
        }

        private int _horaEntrada;

        public int HoraEntrada
        {
            get { return _horaEntrada; }
            set { _horaEntrada = (value > 23 ? 23 : value); }
        }
        private int _minutoEntrada;

        public int MinutoEntrada
        {
            get { return _minutoEntrada; }
            set { _minutoEntrada = (value > 59 ? 59 : value); }
        }
        private int _horaSalida;

        public int HoraSalida
        {
            get { return _horaSalida; }
            set { _horaSalida = (value > 23 ? 23 : value); }
        }
        private int _minutoSalida;

        public int MinutoSalida
        {
            get { return _minutoSalida; }
            set { _minutoSalida = (value > 59 ? 59 : value); }
        }

        private int _timeOutAgenda;

        public int TimeOutAgenda
        {
            get { return _timeOutAgenda; }
            set { _timeOutAgenda = value; }
        }

        public asrConfigSection()
        {
            this._name = "asrConfig";
            this._horaEntrada = 9;
            this._horaSalida = 22;
            this._minutoEntrada = 0;
            this._minutoSalida = 0;
            this._serieFacturacion = "A";
            this._iva = 7;
            this._timeOutAgenda = 5;
            this._saltoAgenda = 10;
        }

        public int TimeOutAgendaInMilliseconds
        {
            get
            {
                return this.TimeOutAgenda * 60 * 1000;
            }
        }
    }
}
