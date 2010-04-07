using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.tercero
{
    public class MissingNombreException:validatingException
    {
        public MissingNombreException()
            : base("Debe especificar el nombre.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
