
using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.common
{
    public class OutOfServiceException : asrException
    {
        public OutOfServiceException(string msg)
            : base(msg)
        {
        }     
    }
}