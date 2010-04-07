using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.recetadetalle
{
    public class doGetAll : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Receta _receta;
        public doGetAll(Receta receta)
        {
            _receta = receta;
        }

        new public List<RecetaDetalle> execute()
        {
            return (List<RecetaDetalle>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.recetadetalle.fachada recetadetalleFacade = new gesClinica.lib.dao.recetadetalle.fachada();
            return recetadetalleFacade.doGetAll(_receta);
        }
    }
}
