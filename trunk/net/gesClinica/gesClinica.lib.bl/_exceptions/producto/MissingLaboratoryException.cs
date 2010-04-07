using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.producto
{
    public class MissingLaboratoryException:validatingException
    {
        public MissingLaboratoryException()
            : base("Debe especificar el laboratorio.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
