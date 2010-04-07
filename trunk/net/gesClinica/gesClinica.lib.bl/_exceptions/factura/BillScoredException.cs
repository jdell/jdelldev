using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.factura
{
    public class BillScoredException:validatingException
    {
        public BillScoredException()
            : base("La factura ya ha sido contabilizada y no puede ser modificada ni anulada.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
