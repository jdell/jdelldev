using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Customer
    {
        private long _id = asr.lib.common.constantes.vacio.ID;
        private string _name = string.Empty;
        private string _phone = string.Empty;
        private string _address = string.Empty;
        private string _fax = string.Empty;

        private string _city = string.Empty;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _state = string.Empty;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _zipCode = string.Empty;

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        
        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private bool _active = true;

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        
        public override string ToString()
        {
            return this.Name;
        }

    }
}
