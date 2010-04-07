using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions.common
{
    class NullReferenceException : ambis1.model.bl._exceptions.ambis1Exception
    {
        public NullReferenceException(Type t, string actionName)
            : base(string.Format("Null object! [Type : {0} - Action : {1}]", t.Name, actionName))
        {
        }
    }
}
