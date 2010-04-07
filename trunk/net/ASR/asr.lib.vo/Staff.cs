using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Staff
    {
        private int _id = lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _name = string.Empty;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FullName
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Name))
                return string.Format("[{1}] {0}", Name, Phone);
            else
                return string.Empty;
        }

        private string _phone = string.Empty;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

    }
}
