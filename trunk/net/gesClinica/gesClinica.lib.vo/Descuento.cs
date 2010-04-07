using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Descuento:IComparable<Descuento>
    {
        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private Paciente _paciente;

        public Paciente Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }
        private int _descuento;

        public int Discount
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public Descuento()
        {
            _empleado = null;
            _paciente = null;
            _descuento = 0;
        }
        public Descuento(Empleado empleado, Paciente paciente)
        {
            _empleado = empleado;
            _paciente = paciente;
            _descuento = 0;
        }

        #region Miembros de IComparable<Descuento>

        public int CompareTo(Descuento other)
        {
            if (this.Paciente.ID.CompareTo(other.Paciente.ID) == 0)
                return this.Empleado.ID.CompareTo(other.Empleado.ID);
            else
                return this.Paciente.ID.CompareTo(other.Paciente.ID);
        }

        #endregion
    }
}
