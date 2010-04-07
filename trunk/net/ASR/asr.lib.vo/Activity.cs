using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Activity
    {
        private int _id = lib.common.constantes.vacio.ID;

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
        private bool _income = true;

        public bool Income
        {
            get { return _income; }
            set { _income = value; }
        }

        public override string ToString()
        {
            return this.Description;
        }

        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        private int? _externalID = null;
        public int? ExternalId
        {
            get { return _externalID; }
            set { _externalID = value; }
        }
    }
}
