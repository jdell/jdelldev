using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.activity
{
    public class doGet : asr.lib.bl._template.generalActionBL
    {
        Activity _activity;
        public doGet(Activity activity)
        {
            _activity = activity;
        }
        new public Activity execute()
        {
            return (Activity)base.execute();
        }
        protected override object accion()
        {
            if (_activity == null)
                throw new _exceptions.common.NullReferenceException(typeof(Activity), this.GetType().Name);

            asr.lib.dao.activity.fachada activityFacade = new asr.lib.dao.activity.fachada();
            return activityFacade.doGet(_activity);
        }
    }
}
