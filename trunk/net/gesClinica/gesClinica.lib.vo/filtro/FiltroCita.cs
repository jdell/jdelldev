using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.filtro
{
    [Serializable()]
    public class FiltroCita
    {
        private Sala _sala;

        public Sala Sala
        {
            get { return _sala; }
            set { _sala = value; }
        }
        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public FiltroCita(Sala sala, Empleado empleado, DateTime fecha)
        {
            this._sala = sala;
            this._empleado = empleado;
            this._fecha = fecha;
        }
    }
}