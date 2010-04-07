
using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.common
{
    public class OutOfServiceException : gesClinicaException
    {
        public OutOfServiceException(string msg)
            : base(msg)
        {
        }     
    }
}