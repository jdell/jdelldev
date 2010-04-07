using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable(), Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.",true)]
    public class Contador
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Empresa _empresa;

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
        private int _año;

        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }
        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public Contador()
        {
            _id = common.constantes.vacio.ID;
            _empresa = null;
            _año = DateTime.Now.Year;
            _numero = 0;
        }

        public Contador(Factura factura)
        {
            _id = common.constantes.vacio.ID;
            _empresa = factura.Operacion.Cita.Empleado.Empresa;
            _año = factura.Fecha.Year;
            _numero = 0;
        }
    }
}
