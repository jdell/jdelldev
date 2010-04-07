using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.apunte
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        private vo.Asiento _asiento = null;
        public doGetAll()
        {
        }
        public doGetAll(vo.Asiento asiento)
        {
            _asiento = asiento;
        }

        new public List<Apunte> execute()
        {
            return (List<Apunte>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.apunte.fachada apunteFacade = new gesClinica.lib.dao.apunte.fachada();
            if (_asiento == null)
                return apunteFacade.doGetAll();
            else
                return apunteFacade.doGetAll(_asiento);
        }
    }
}
