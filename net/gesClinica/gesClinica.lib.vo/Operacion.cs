using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Operacion
    {
        private Paciente _paciente;

        public Paciente Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }

        private List<Pago> _pagos;

        public List<Pago> Pagos
        {
            get { return _pagos; }
            set { _pagos = value; }
        }

        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Cita _cita;

        public Cita Cita
        {
            get { return _cita; }
            set { _cita = value; }
        }
        private tTIPOOPERACION _tipo;

        public tTIPOOPERACION Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
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
        private bool _facturado;

        public bool Facturado
        {
            get { return _facturado; }
            set { _facturado = value; }
        }

        public Operacion()
        {
            _id = common.constantes.vacio.ID;
            _cita = null;
            _tipo =  tTIPOOPERACION.OPERACION_PACIENTE;
            _fecha = DateTime.Now;
            _debe = 0;
            _haber = 0;
            _facturado = false;

            _empleado = null;
            _observaciones = string.Empty;
            _facturaAntigua = string.Empty;

            _pagos = new List<Pago>();
            _paciente = null;
        }

        public Operacion(tTIPOOPERACION tipo, DateTime fecha)
        {
            _id = common.constantes.vacio.ID;
            _cita = null;
            _tipo = tipo;
            _fecha = fecha;
            _debe = 0;
            _haber = 0;
            _facturado = false;

            _empleado = null;
            _observaciones = string.Empty;
            _facturaAntigua = string.Empty;

            _pagos = new List<Pago>();
            _paciente = null;
        }

        public Operacion(Cita cita)
        {
            _id = common.constantes.vacio.ID;
            _cita = cita;
            _tipo = tTIPOOPERACION.OPERACION_PACIENTE;
            _fecha = cita.Fecha;
            _debe = 0;
            _haber = 0;
            _facturado = false;

            _empleado = null;
            _observaciones = string.Empty;
            _facturaAntigua = string.Empty;

            _pagos = new List<Pago>();
            _paciente = null;
        }

        public Operacion(Empleado empleado)
        {
            _id = common.constantes.vacio.ID;
            _cita = null;
            _tipo = tTIPOOPERACION.OPERACION_PACIENTE;
            _fecha = DateTime.Now;
            _debe = 0;
            _haber = 0;
            _facturado = false;

            _empleado = empleado;
            _observaciones = string.Empty;
            _facturaAntigua = string.Empty;

            _pagos = new List<Pago>();
            _paciente = null;
        }

        public static tTIPOOPERACION TipoFromName(string name)
        {
            return (tTIPOOPERACION)System.Enum.Parse(typeof(tTIPOOPERACION), name);
        }
        public static string NameFromTipo(tTIPOOPERACION tipo)
        {
            return System.Enum.GetName(typeof(tTIPOOPERACION), tipo);
        }

        public string Descripcion
        {
            get
            {
                string res = string.Empty;

                if (Cita != null)
                    res = this.DebeFacturarse ? string.Format("(*) {0}", Cita.ToString()) : string.Format("    {0}", Cita.ToString());
                else if (Empleado != null)
                    res = string.Format("{0} - {1}", common.funciones.EnumHelper.GetDescription(this.Tipo), this.Empleado.ToString());
                else if (Paciente != null)
                    res = string.Format("{0} - {1}", common.funciones.EnumHelper.GetDescription(this.Tipo), this.Paciente.ToString());
                else
                    res = common.funciones.EnumHelper.GetDescription(this.Tipo);

                return res;
            }
        }
        public string DescripcionTipo
        {
            get
            {
                string res = string.Empty;

                   res = common.funciones.EnumHelper.GetDescription(this.Tipo);

                return res;
            }
        }
        public float Ingresos
        {
            get
            {
                return this.Debe;
            }
        }
        public float Adeudado
        {
            get
            {
                return this.Tipo == tTIPOOPERACION.OPERACION_PACIENTE ? this.Haber : 0;
            }
        }
        public float Gastos
        {
            get
            {
                return this.Tipo != tTIPOOPERACION.OPERACION_PACIENTE ? this.Haber : 0;
            }
        }

        public bool IsSaldada
        {
            get
            {
                return this.Debe.CompareTo(this.Haber) == 0;
            }
        }

        public float Deuda
        {
            get
            {
                return this.Haber - this.Debe;
            }
        }
        public float Saldo
        {
            get
            {
                return this.Tipo != tTIPOOPERACION.OPERACION_PACIENTE ? -this.Haber + this.Debe : this.Debe;
            }
        }

        private string _facturaAntigua;

        public string FacturaAntigua
        {
            get { return _facturaAntigua.Trim()=="0"?string.Empty:_facturaAntigua; }
            set { _facturaAntigua = value; }
        }


        public string DescripcionDeuda
        {
            get
            {
                string res = string.Empty;

                if ((Cita != null) && (Cita.Terapia!=null))
                    res = string.Format("{0} - {1} - {2}", this.Cita.Fecha, this.Cita.Terapia.ToString(), this.Deuda.ToString("c"));
                else
                    res = common.funciones.EnumHelper.GetDescription(this.Tipo);

                return res;
            }
        }

        public string DescripcionTerapia
        {
            get
            {
                string res = string.Empty;

                if ((Cita != null) && (Cita.Terapia != null))
                    res = Cita.Terapia.ToString();
                else
                    res = "Terapia";
             
                return res;
            }
        }
        private bool _debeFacturarse = true;

        public bool DebeFacturarse
        {
            get { return _debeFacturarse; }
            set { _debeFacturarse = value; }
        }
    }
}
