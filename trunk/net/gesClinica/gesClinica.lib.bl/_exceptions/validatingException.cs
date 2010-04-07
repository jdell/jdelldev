using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions
{
    public class validatingException:gesClinicaException
    {
        public validatingException(string msg, string detail)
            : base(msg, detail)
        {
        }

        public validatingException(string msg)
            : base(msg)
        {
        }

    }
}
