using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.evento
{
    public class MissingRoomException:validatingException
    {
        public MissingRoomException()
            : base("Debe especificar la sala.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
