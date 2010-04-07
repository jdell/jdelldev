using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class Counter
    {
        public Counter()
        {
        }
        public Counter(tCOUNTER code)
        {
            _code = code;
        }

        tCOUNTER _code;

        public tCOUNTER Code
        {
            get { return _code; }
            set { _code = value; }
        }
        Int32 _number;

        public Int32 Number
        {
            get { return _number; }
            set { _number = value; }
        }


        public static tCOUNTER TypeFromName(string name)
        {
            return (tCOUNTER)System.Enum.Parse(typeof(tCOUNTER), name);
        }
        public static string NameFromType(tCOUNTER type)
        {
            return System.Enum.GetName(typeof(tCOUNTER), type);
        }
    }
}
