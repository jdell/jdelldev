
using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions.common
{
    public class OutOfServiceException : ambis1Exception
    {
        public OutOfServiceException(string msg)
            : base(msg)
        {
        }     
    }
}