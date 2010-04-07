using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._common.custom
{
    public class BirthdayAlert:Alert
    {
        public BirthdayAlert(vo.Member member)
        {
            _member = member;
            this.Message = string.Format("Remember, {0}'s Birthday is today!!", _member);
        }

        vo.Member _member = null;

        public vo.Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
    }
}
