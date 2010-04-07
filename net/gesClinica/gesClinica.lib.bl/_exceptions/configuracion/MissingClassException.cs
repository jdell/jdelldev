using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.configuracion
{
    public class MissingClassException:validatingException
    {
        public MissingClassException()
            : base("Debe especificar la clase.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
