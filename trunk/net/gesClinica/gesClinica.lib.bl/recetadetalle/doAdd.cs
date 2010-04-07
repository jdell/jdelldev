using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.recetadetalle
{
    internal class doAdd : gesClinica.lib.bl._template.terapeutaActionBL
    {
        RecetaDetalle _recetadetalle;
        public doAdd(RecetaDetalle recetadetalle)
        {
            _recetadetalle = recetadetalle;
        }
        new public RecetaDetalle execute()
        {
            return (RecetaDetalle)base.execute();
        }
        protected override object accion()
        {
            if (_recetadetalle == null)
                throw new _exceptions.common.NullReferenceException(typeof(RecetaDetalle), this.GetType().Name);

            gesClinica.lib.dao.recetadetalle.fachada recetadetalleFacade = new gesClinica.lib.dao.recetadetalle.fachada();
            return recetadetalleFacade.doAdd(_recetadetalle);
        }
    }
}
