using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.common
{
    class NullReferenceException : asr.lib.bl._exceptions.asrException
    {
        public NullReferenceException(Type t, string actionName)
            : base(string.Format("El objeto indicado es nulo. [Type : {0} - Action : {1}]", t.Name, actionName))
        {
        }
    }
}
