using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.formapago
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        FormaPago _formapago;
        public doGet(FormaPago formapago)
        {
            _formapago = formapago;
        }
        new public FormaPago execute()
        {
            return (FormaPago)base.execute();
        }
        protected override object accion()
        {
            if (_formapago == null)
                throw new _exceptions.common.NullReferenceException(typeof(FormaPago), this.GetType().Name);

            gesClinica.lib.dao.formapago.fachada formapagoFacade = new gesClinica.lib.dao.formapago.fachada();
            return formapagoFacade.doGet(_formapago);
        }
    }
}
