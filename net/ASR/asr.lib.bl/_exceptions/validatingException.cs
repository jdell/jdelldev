using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions
{
    public class validatingException:asrException
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
