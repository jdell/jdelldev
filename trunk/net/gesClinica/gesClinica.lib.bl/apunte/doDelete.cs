using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        Apunte _apunte;
        public doDelete(Apunte apunte)
        {
            _apunte = apunte;
        }
        new public Apunte execute()
        {
            return (Apunte)base.execute();
        }
        protected override object accion()
        {
            if (_apunte == null)
                throw new _exceptions.common.NullReferenceException(typeof(Apunte), this.GetType().Name);

            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            return apunteFacade.doDelete(_apunte);
        }
    }
}
