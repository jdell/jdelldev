using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.employment
{
    public class MissingCustomerException : validatingException
    {
        public MissingCustomerException()
            : base("You must specify the customer field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
