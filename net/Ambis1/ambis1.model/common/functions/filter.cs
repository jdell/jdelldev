using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.common.functions
{
    public abstract class filter
    {
        public static string parseString(string stringfilter)
        {
            string res;
            
            res = stringfilter.Replace("'", "").Replace("%", "").Replace("?", "").Replace("*", "");

            return res;   
        }
    }
}
