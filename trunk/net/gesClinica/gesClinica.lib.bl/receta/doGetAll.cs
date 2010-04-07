using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.receta
{
    public class doGetAll :gesClinica.lib.bl._template.terapeutaActionBL
    {
        Cita _cita;
        public doGetAll(Cita cita)
        {
            _cita = cita;
        }
        new public List<Receta> execute()
        {
            return (List<Receta>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.receta.fachada recetaFacade = new gesClinica.lib.dao.receta.fachada();
            return recetaFacade.doGetAll(_cita);
        }
    }
}
