using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.payable
{
    public class doAdd : asr.lib.bl._template.generalActionBL
    {
        Payable _payable;
        public doAdd(Payable payable)
        {
            _payable = payable;
        }
        new public Payable execute()
        {
            return (Payable)base.execute();
        }
        protected override object accion()
        {
            if (_payable == null)
                throw new _exceptions.common.NullReferenceException(typeof(Payable), this.GetType().Name);

            if (string.IsNullOrEmpty(_payable.Description))
                throw new _exceptions.payable.MissingDescriptionException();

            asr.lib.dao.payable.fachada payableFacade = new asr.lib.dao.payable.fachada();
            return payableFacade.doAdd(_payable);
        }
    }
}
