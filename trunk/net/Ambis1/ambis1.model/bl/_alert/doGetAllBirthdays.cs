using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.alert
{
    public class doGetAllBirthdays : ambis1.model.bl._template.generalActionBL
    {
        public doGetAllBirthdays()
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

                bl.member.doGetAllByType players = new ambis1.model.bl.member.doGetAllByType(tMEMBER.PLAYER);
                foreach (Member player in players.execute())
                {
                    if (player.IsBirthday())
                    {
                        _common.custom.BirthdayAlert alert = new ambis1.model.bl._common.custom.BirthdayAlert(player);
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
