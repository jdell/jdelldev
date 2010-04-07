using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._exceptions.parte.lineaparte
{
    class MissingCostsCenterException : parteHoras.lib.bl._exceptions.validatingException
    {
        public MissingCostsCenterException():base("Debe indicar el centro de coste.")
        {
        }
    }
}
