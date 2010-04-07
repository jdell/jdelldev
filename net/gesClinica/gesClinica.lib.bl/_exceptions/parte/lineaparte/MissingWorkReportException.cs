using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._exceptions.parte.lineaparte
{
    class MissingWorkReportException : parteHoras.lib.bl._exceptions.validatingException
    {
        public MissingWorkReportException()
            : base("Debe indicar el parte de trabajo.")
        {
        }
    }
}
