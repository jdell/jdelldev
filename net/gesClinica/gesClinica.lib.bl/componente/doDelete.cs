using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.componente
{
    public class doDelete : gesClinica.lib.bl._template.generalActionBL
    {
        Componente _componente;
        public doDelete(Componente componente)
        {
            _componente = componente;
        }
        new public Componente execute()
        {
            return (Componente)base.execute();
        }
        protected override object accion()
        {
            if (_componente == null)
                throw new _exceptions.common.NullReferenceException(typeof(Componente), this.GetType().Name);

            gesClinica.lib.dao.componente.fachada componenteFacade = new gesClinica.lib.dao.componente.fachada();
            return componenteFacade.doDelete(_componente);
        }
    }
}
