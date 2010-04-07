using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.operacion
{
    public class MissingFormaPagoException:validatingException
    {
        public MissingFormaPagoException()
            : base("Debe especificar la forma de pago.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
