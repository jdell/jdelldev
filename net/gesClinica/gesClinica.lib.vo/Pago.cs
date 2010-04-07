using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Pago
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Operacion _operacion;

        public Operacion Operacion
        {
            get { return _operacion; }
            set { _operacion = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private float _importe;

        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        private FormaPago _formaPago;

        public FormaPago FormaPago
        {
            get { return _formaPago; }
            set { _formaPago = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        public Pago()
        {
            _id = common.constantes.vacio.ID;
            _operacion = null;
            _fecha = DateTime.Now;
            _importe = 0;
            _formaPago = null;
            _observaciones = string.Empty;
        }
        public Pago(Operacion operacion)
        {
            _id = common.constantes.vacio.ID;
            _operacion = operacion;
            _fecha = operacion.Fecha;
            _importe = operacion.Haber - operacion.Debe;
            _formaPago = null;
            _observaciones = string.Empty;
        }
        public override string ToString()
        {
            return DescripcionPago;
        }

        public string DescripcionPago
        {
            get
            {
                if ((Operacion != null) && (Operacion.Cita != null) && (Operacion.Cita.Empleado != null) && (FormaPago != null))
                    return string.Format("{0} - {1}", this.FormaPago.ToString(), this.Operacion.Cita.Empleado.ToString());
                else if (FormaPago != null)
                    return this.FormaPago.ToString();
                else
                    return "Pago";
            }
        }
    }
}
