using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._exceptions.parte
{
    class MissingForemanException : parteHoras.lib.bl._exceptions.validatingException
    {
        public MissingForemanException()
            : base("Debe indicar el capataz.")
        {
        }
    }
}
