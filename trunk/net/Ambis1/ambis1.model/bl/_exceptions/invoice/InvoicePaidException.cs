using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.invoice
{
    public class InvoicePaidException:validatingException
    {
        public InvoicePaidException()
            : base("You are not allowed to delete a paid invoice/receipt.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
