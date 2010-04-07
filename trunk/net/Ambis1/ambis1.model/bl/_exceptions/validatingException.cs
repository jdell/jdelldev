using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions
{
    public class validatingException:ambis1Exception
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
