using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.receta
{
    public class doUpdate : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Receta _receta;
        public doUpdate(Receta receta)
        {
            _receta = receta;
        }
        new public Receta execute()
        {
            return (Receta)base.execute();
        }
        protected override object accion()
        {
            if (_receta == null)
                throw new _exceptions.common.NullReferenceException(typeof(Receta), this.GetType().Name);

            gesClinica.lib.dao.receta.fachada recetaFacade = new gesClinica.lib.dao.receta.fachada();
            return recetaFacade.doUpdate(_receta);
        }
    }
}
