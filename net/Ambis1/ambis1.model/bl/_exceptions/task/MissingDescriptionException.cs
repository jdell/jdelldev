using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.task
{
    public class MissingDescriptionException:validatingException
    {
        public MissingDescriptionException()
            : base("You must specify the description field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
