using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.cita
{
    public class MissingTerapiaException:validatingException
    {
        public MissingTerapiaException()
            : base("Debe especificar la terapia.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
