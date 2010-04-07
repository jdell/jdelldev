using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.festivo
{
    public class MissingTypeOfFestivoException:validatingException
    {
        public MissingTypeOfFestivoException()
            : base("Debe especificar el tipo de festivo.", _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
