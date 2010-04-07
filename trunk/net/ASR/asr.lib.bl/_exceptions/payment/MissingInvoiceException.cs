using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.payment
{
    public class MissingInvoiceException:validatingException
    {
        public MissingInvoiceException()
            : base("You must specify the invoice field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
