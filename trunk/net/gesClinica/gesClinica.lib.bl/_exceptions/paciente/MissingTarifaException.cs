using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.paciente
{
    public class MissingTarifaException:validatingException
    {
        public MissingTarifaException()
            : base("Debe especificar la tarifa.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
