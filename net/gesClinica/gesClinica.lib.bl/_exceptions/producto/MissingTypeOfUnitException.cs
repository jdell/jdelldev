using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.producto
{
    public class MissingTypeOfUnitException:validatingException
    {
        public MissingTypeOfUnitException()
            : base("Debe especificar el tipo de unidad.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
