using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.indicacion
{
    public class doGetAllInIndicacion : gesClinica.lib.bl._template.generalActionBL
    {
        private Producto _producto = null;

        public doGetAllInIndicacion(Producto producto)
        {
            _producto = producto;
        }

        new public List<Indicacion> execute()
        {
            return (List<Indicacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.indicacion.fachada indicacionFacade = new gesClinica.lib.dao.indicacion.fachada();
            return indicacionFacade.doGetAllInIndicacion(_producto);
        }
    }
}
