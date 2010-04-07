using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.formapago
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        FormaPago _formapago;
        public doAdd(FormaPago formapago)
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

            if (string.IsNullOrEmpty(_formapago.Descripcion))
                throw new _exceptions.formapago.MissingDescriptionException();

            gesClinica.lib.dao.formapago.fachada formapagoFacade = new gesClinica.lib.dao.formapago.fachada();
            return formapagoFacade.doAdd(_formapago);
        }
    }
}
