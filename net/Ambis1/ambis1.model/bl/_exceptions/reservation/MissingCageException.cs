using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._exceptions.reservation
{
    public class MissingCageException : validatingException
    {
        public MissingCageException()
            : base("You must specify the Cage.", _common.constants.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
