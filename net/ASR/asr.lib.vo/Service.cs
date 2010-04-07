using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Service
    {
        private int _id = asr.lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _description = string.Empty;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private float _price = 0;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private float _stateFee = 0;
        public float StateFee
        {
            get { return _stateFee; }
            set { _stateFee = value; }
        }

        public override string ToString()
        {
            return this.Description;
        }

        private bool _income = true;

        public bool Income
        {
            get { return _income; }
            set { _income = value; }
        }
    }
}
