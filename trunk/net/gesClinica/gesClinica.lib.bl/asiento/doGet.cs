using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.asiento
{
    public class doGet : gesClinica.lib.bl._template.administrativoActionBL
    {
        Asiento _asiento;
        public doGet(Asiento asiento)
        {
            _asiento = asiento;
        }
        new public Asiento execute()
        {
            return (Asiento)base.execute();
        }
        protected override object accion()
        {
            if (_asiento == null)
                throw new _exceptions.common.NullReferenceException(typeof(Asiento), this.GetType().Name);

            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            return asientoFacade.doGet(_asiento);
        }
    }
}
