using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.common
{
    public class AccessNotAllowedException:validatingException
    {
        public AccessNotAllowedException()
            : base(_common.constantes.mensaje.NO_ACCESS_ALLOWED, _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
