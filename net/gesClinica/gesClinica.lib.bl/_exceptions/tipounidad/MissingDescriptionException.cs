using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.tipounidad
{
    public class MissingDescriptionException:validatingException
    {
        public MissingDescriptionException()
            : base("Debe especificar la descripción.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
