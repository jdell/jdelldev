using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class AccountRecord
    {
        private Activity _activity = null;

        public Activity Activity
        {
            get { return _activity; }
            set { _activity = value; }
        }

        private bool _incoming = false;

        public bool Incoming
        {
            get { return _incoming; }
            set { _incoming = value; }
        }

        private int _id = asr.lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _date = DateTime.Now;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private String _description = String.Empty;

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private Single _amount = 0;

        public Single Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private String _reference = string.Empty;

        public String Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }
        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        public Single Expense
        {
            get { return this.Incoming ? 0 : this.Amount; }
        }
        public Single Income
        {
            get { return this.Incoming ? this.Amount : 0; }
        }

        public Single Percentage
        {
            get { return this.Expense!=0? (100*this.Income/this.Expense): 0; }
        }

        public Single Result
        {
            get { return this.Incoming ? this.Amount : -this.Amount; }
        }
        private int? _externalID = null;
        public int? ExternalId
        {
            get { return _externalID; }
            set { _externalID = value; }
        }

    }
}
