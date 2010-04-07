using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.accountrecord
{
    public class doGenerateActivities : asr.lib.bl._template.generalActionBL
    {
        public doGenerateActivities()
        {
        }
        new public void execute()
        {
            base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.accountrecord.fachada accountrecordFacade = new asr.lib.dao.accountrecord.fachada();
            accountrecordFacade.doGenerateActivities();
            return null;
        }
    }
}
