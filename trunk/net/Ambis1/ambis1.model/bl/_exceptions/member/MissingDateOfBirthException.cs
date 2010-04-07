using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._exceptions.member
{
    public class MissingDateOfBirthException:validatingException
    {
        public MissingDateOfBirthException()
            : base("You must specify the DOB field.", _common.constants.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
