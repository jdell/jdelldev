using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.common.types
{
    public class ParObject
    {
        private object _obj1;

        protected object Objeto1
        {
            get { return _obj1; }
            set { _obj1 = value; }
        }
        private object _obj2;

        protected object Objeto2
        {
            get { return _obj2; }
            set { _obj2 = value; }
        }

        public ParObject()
        {
            _obj1 = null;
            _obj2 = null;
        }

    }
}
