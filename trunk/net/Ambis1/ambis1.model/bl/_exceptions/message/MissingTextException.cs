using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.message
{
    public class MissingTextException:validatingException
    {
        public MissingTextException()
            : base("You must specify the message field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
