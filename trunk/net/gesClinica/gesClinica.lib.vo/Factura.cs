using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Factura
    {
        private bool _contabilizada;

        public bool Contabilizada
        {
            get { return _contabilizada; }
            set { _contabilizada = value; }
        }

        private string _cliente;

        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        
        private string _concepto;

        public string Concepto
        {
            get { return _concepto; }
            set { _concepto = value; }
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private Operacion _operacion;

        public Operacion Operacion
        {
            get { return _operacion; }
            set { _operacion = value; }
        }
        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private string _serie;

        public string Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        private float _importe;

        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        private int _iva;

        public int IVA
        {
            get { return _iva; }
            set { _iva = value; }
        }
        private int _descuento;

        public int Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public Factura()
        {
            _id = common.constantes.vacio.ID;
            _fecha = DateTime.Now;
            _operacion = null;
            _numero = 0;
            _serie = string.Empty;
            _observaciones = string.Empty;
            _concepto = string.Empty;
            _cliente = string.Empty;
            _contabilizada = false;

            _importe = 0;
            _iva = 0;
            _descuento = 0;
        }
        public Factura(Operacion operacion)
        {
            _id = common.constantes.vacio.ID;
            _fecha = DateTime.Now;
            _operacion = operacion;
            _numero = 0;
            _serie = string.Empty;
            _observaciones = string.Empty;
            _concepto = string.Empty;
            _cliente = string.Empty;
            _contabilizada = false;

            _importe = 0;
            _iva = 0;
            _descuento = 0;
        }

        public string Codigo
        {
            get
            {
                if (this.Numero > 0)
                    return string.Format("{0:00}/{1}", this.Fecha.Year, this.Numero);
                else
                    return string.Empty;
            }
        }

        public float Total
        {
            get
            {
                if ((1 - Convert.ToSingle(IVA) / 100) != 0)
                    if (Descuento!=0)
                        return (Importe * (Convert.ToSingle(Descuento) / 100) * (1 + Convert.ToSingle(IVA) / 100));
                    else
                        return (Importe * (1 + Convert.ToSingle(IVA) / 100));
                else
                    return 0;
            }
        }

        public Empleado Empleado
        {
            get
            {
                if (this.Operacion.Cita != null)
                    return this.Operacion.Cita.Empleado;
                else
                    return null;
            }
        }

    }
}
