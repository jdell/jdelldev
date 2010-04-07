using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._exceptions.member
{
    public class MissingNameException:validatingException
    {
        public MissingNameException()
            : base("You must specify the name field.", _common.constants.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
