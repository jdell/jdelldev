using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.custom
{
    public class ResumenFacturacion
    {
        private vo.Empleado _empleado;

        public vo.Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private float _facturado;

        public float Facturado
        {
            get { return _facturado; }
            set { _facturado = value; }
        }
        private float _generado;

        public float Generado
        {
            get { return _generado; }
            set { _generado = value; }
        }

        public ResumenFacturacion()
        {
            _empleado = null;
            _facturado = 0;
            _generado = 0;
        }

        public float Porcentaje
        {
            get
            {
                return (this.Generado!=0?this.Facturado/this.Generado:0);
            }
        }

        public float Comision
        {
            get
            {
                return this.Generado * this.Empleado.Comision / 100;
            }
        }

        public float NoFacturado
        {
            get
            {
                return this.Generado - this.Facturado;
            }
        }
    }
}
