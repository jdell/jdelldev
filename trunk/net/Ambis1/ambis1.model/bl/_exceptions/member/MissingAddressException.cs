using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._exceptions.member
{
    public class MissingAddressException:validatingException
    {
        public MissingAddressException()
            : base("You must specify the address field.", _common.constants.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
