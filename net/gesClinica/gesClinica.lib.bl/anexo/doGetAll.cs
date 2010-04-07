using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.anexo
{
    public class doGetAll : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Cita _cita;
        public doGetAll(Cita cita)
        {
            _cita = cita;
        }
        new public List<Anexo> execute()
        {
            return (List<Anexo>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.anexo.fachada anexoFacade = new gesClinica.lib.dao.anexo.fachada();
            return anexoFacade.doGetAll(_cita);
        }
    }
}
