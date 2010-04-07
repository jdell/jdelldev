using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.accountrecord
{
    public class doGet : asr.lib.bl._template.generalActionBL
    {
        AccountRecord _accountrecord;
        public doGet(AccountRecord accountrecord)
        {
            _accountrecord = accountrecord;
        }
        new public AccountRecord execute()
        {
            return (AccountRecord)base.execute();
        }
        protected override object accion()
        {
            if (_accountrecord == null)
                throw new _exceptions.common.NullReferenceException(typeof(AccountRecord), this.GetType().Name);

            asr.lib.dao.accountrecord.fachada accountrecordFacade = new asr.lib.dao.accountrecord.fachada();
            return accountrecordFacade.doGet(_accountrecord);
        }
    }
}
