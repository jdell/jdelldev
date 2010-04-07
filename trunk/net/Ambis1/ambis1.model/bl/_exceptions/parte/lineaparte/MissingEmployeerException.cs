using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._exceptions.parte.lineaparte
{
    class MissingEmployeerException : parteHoras.lib.bl._exceptions.validatingException
    {
        public MissingEmployeerException()
            : base("Debe indicar el empleado.")
        {
        }
    }
}
