using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.client
{
    public class MissingSSNException:validatingException
    {
        public MissingSSNException()
            : base("You must specify the ssn field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
