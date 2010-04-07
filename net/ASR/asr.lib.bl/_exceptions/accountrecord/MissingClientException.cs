using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.accountrecord
{
    public class MissingClientException:validatingException
    {
        public MissingClientException()
            : base("You must specify the client field.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
