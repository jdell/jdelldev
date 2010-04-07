using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.asiento
{
    class AsientoDescuadradoException:validatingException
    {
        public AsientoDescuadradoException()
            : base("El asiento est� descuadrado.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}