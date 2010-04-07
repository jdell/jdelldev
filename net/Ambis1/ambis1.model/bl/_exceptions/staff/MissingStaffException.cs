using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.staff
{
    public class MissingNameException:validatingException
    {
        public MissingNameException()
            : base("You must specify the name field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
