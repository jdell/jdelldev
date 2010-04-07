using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.empresa
{
    public class MissingRazonSocialException : validatingException
    {
        public MissingRazonSocialException()
            : base("Debe especificar la razón social.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
