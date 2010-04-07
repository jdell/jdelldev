using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    public class doCheckIfExists : gesClinica.lib.bl._template.generalActionBL
    {
        vo.tTIPOOPERACION _tipo;
        DateTime _fecha;
        public doCheckIfExists(lib.vo.tTIPOOPERACION tipo, DateTime fecha)
        {
            _tipo = tipo;
            _fecha = fecha;
        }
        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            return operacionFacade.doCheckIfExists(_tipo, _fecha);
        }
    }
}
