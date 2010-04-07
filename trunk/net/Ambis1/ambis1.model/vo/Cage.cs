using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class Cage
    {
        Int32 _id = common.constants.empty.ID;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        String _description = string.Empty;

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
