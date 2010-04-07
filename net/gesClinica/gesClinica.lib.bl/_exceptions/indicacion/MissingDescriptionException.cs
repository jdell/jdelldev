using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.indicacion
{
    public class MissingDescriptionException:validatingException
    {
        public MissingDescriptionException()
            : base("Debe especificar la descripci�n.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
