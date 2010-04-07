using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._common.custom
{
    public class MembershipExpirationAlert:Alert
    {
        public MembershipExpirationAlert(vo.Membership membership)
        {
            _membership = membership;
            this.Message = string.Format("Membership for {0} will expire on {1}", _membership.Member, _membership.ToDate.ToShortDateString() );
        }

        vo.Membership _membership = null;

        public vo.Membership Membership
        {
            get { return _membership; }
            set { _membership = value; }
        }
    }
}
