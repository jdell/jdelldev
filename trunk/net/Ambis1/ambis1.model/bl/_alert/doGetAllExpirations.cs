using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.alert
{
    public class doGetAllExpirations: ambis1.model.bl._template.generalActionBL
    {
        public doGetAllExpirations()
        {
        }
        new public List<_common.custom.Alert> execute()
        {
            return (List<_common.custom.Alert>)base.execute();
        }
        protected override object accion()
        {
            try
            {
                List<_common.custom.Alert> res = new List<ambis1.model.bl._common.custom.Alert>();

                bl.membership.doGetAll memberships = new ambis1.model.bl.membership.doGetAll();
                foreach (Membership membership in memberships.execute())
                {
                    if (membership.IsGoingToExpire)
                    {
                        _common.custom.MembershipExpirationAlert alert = new ambis1.model.bl._common.custom.MembershipExpirationAlert(membership);
                        res.Add(alert);
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
