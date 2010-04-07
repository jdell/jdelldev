using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.cita
{
    public class MissingPacienteException:validatingException
    {
        public MissingPacienteException()
            : base("Debe especificar el paciente.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
