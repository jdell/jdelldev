using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{    
    [Serializable()]
    public class Payment : IComparable<Payment>
    {
        private int _id = common.constantes.vacio.ID;

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
        private DateTime _date = DateTime.Now;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private Single _amount = 0;
        public Single Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        #region Miembros de IComparable<Payment>

        public int CompareTo(Payment other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
