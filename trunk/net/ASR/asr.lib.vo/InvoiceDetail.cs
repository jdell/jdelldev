using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class InvoiceDetail : IComparable<InvoiceDetail>
    {
        private int _id = lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Invoice _invoice = null;

        public Invoice Invoice
        {
            get { return _invoice; }
            set { _invoice = value; }
        }
        private Service _service = null;

        public Service Service
        {
            get { return _service; }
            set { _service = value; }
        }
        private String _description = string.Empty;

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private Single _price = 0;

        public Single Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _amount = 1;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public Single Total
        {
            get { return this.Amount * (this.Price + this.StateFee); }
        }


        private Single _stateFee = 0;

        public Single StateFee
        {
            get { return _stateFee; }
            set { _stateFee = value; }
        }

        public Single Expense
        {
            get { return this.Invoice.Income ? 0 : this.Total; }
        }
        public Single Income
        {
            get { return this.Invoice.Income ? this.Total: 0; }
        }

        public Single Percentage
        {
            get { return this.Expense != 0 ? (100 * this.Income / this.Expense) : 0; }
        }

        public Single Result
        {
            get { return this.Invoice.Income ? this.Total : -this.Total; }
        }

        #region Miembros de IComparable<InvoiceDetail>

        public int CompareTo(InvoiceDetail other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
