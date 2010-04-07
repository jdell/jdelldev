using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.tercero
{
    public class MissingSubCuentaException:validatingException
    {
        public MissingSubCuentaException()
            : base("Debe especificar la subcuenta.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
