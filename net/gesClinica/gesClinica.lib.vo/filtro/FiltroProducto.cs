using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.filtro
{
    [Serializable()]
    public class FiltroProducto
    {
        private Laboratorio _laboratorio;

        public Laboratorio Laboratorio
        {
            get { return _laboratorio; }
            set { _laboratorio = value; }
        }

        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        private Indicacion _indicacion;

        public Indicacion Indicacion
        {
            get { return _indicacion; }
            set { _indicacion = value; }
        }

        private Boolean _activo;

        public Boolean Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }


        public FiltroProducto(Producto producto, Indicacion indicacion, Laboratorio laboratorio)
        {
            _producto = producto;
            _indicacion = indicacion;
            _laboratorio = laboratorio;
            _activo = true;
        }
        public FiltroProducto()
        {
            _producto = null;
            _indicacion = null;
            _laboratorio = null;
            _activo = true;
        }
    }
}
