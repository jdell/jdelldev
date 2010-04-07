using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.sala
{
    public class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        Sala _sala;
        public doDelete(Sala sala)
        {
            _sala = sala;
        }
        new public Sala execute()
        {
            return (Sala)base.execute();
        }
        protected override object accion()
        {
            if (_sala == null)
                throw new _exceptions.common.NullReferenceException(typeof(Sala), this.GetType().Name);

            gesClinica.lib.dao.sala.fachada salaFacade = new gesClinica.lib.dao.sala.fachada();
            return salaFacade.doDelete(_sala);
        }
    }
}
