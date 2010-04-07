using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._exceptions.reservation
{
    public class MissingMemberException:validatingException
    {
        public MissingMemberException()
            : base("You must specify the Member.", _common.constants.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
