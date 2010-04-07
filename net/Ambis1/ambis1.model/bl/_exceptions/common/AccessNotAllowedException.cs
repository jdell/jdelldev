using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions.common
{
    public class AccessNotAllowedException:validatingException
    {
        public AccessNotAllowedException()
            : base(_common.constants.mensaje.NO_ACCESS_ALLOWED, _common.constants.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
