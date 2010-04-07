using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.anexo
{
    public class doUpdate : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Anexo _anexo;
        public doUpdate(Anexo anexo)
        {
            _anexo = anexo;
        }
        new public Anexo execute()
        {
            return (Anexo)base.execute();
        }
        protected override object accion()
        {
            if (_anexo == null)
                throw new _exceptions.common.NullReferenceException(typeof(Anexo), this.GetType().Name);

            gesClinica.lib.dao.anexo.fachada anexoFacade = new gesClinica.lib.dao.anexo.fachada();
            return anexoFacade.doUpdate(_anexo);
        }
    }
}
