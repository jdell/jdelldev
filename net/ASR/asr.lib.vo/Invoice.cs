using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Invoice
    {
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
        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        private string _comment = string.Empty;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private List<InvoiceDetail> _detail = new List<InvoiceDetail>();
        public List<InvoiceDetail> Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }

        private bool _pending = true;
        public bool Pending
        {
            get { return _pending; }
            set { _pending = value; }
        }

        private Payable _payable = null;
        public Payable Payable
        {
            get { return _payable; }
            set { _payable = value; }
        }

        private Serie _serie = null;
        public Serie Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        private Int32 _number = 0;

        public Int32 Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public String Document
        {
            get { return this.Serie!=null?string.Format("{0}{1:0000}",this.Serie, this.Number):string.Empty; }
        }

        private bool _income = true;

        public bool Income
        {
            get { return _income; }
            set { _income = value; }
        }


        private List<Payment> _payments = new List<Payment>();
        public List<Payment> Payments
        {
            get { return _payments; }
            set { _payments = value; }
        }

        public void x()
        { 

        }
    }
}
