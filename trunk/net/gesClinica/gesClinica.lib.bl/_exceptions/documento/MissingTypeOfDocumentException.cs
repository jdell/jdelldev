using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.documento
{
    public class MissingTypeOfDocumentException:validatingException
    {
        public MissingTypeOfDocumentException()
            : base("Debe especificar el tipo.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
