using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.common
{
    class NullReferenceException : gesClinica.lib.bl._exceptions.gesClinicaException
    {
        public NullReferenceException(Type t, string actionName)
            : base(string.Format("El objeto indicado es nulo. [Type : {0} - Action : {1}]", t.Name, actionName))
        {
        }
    }
}
