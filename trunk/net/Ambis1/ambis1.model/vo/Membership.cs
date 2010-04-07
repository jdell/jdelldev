using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class Membership
    {
        Boolean _paid = false;

        public Boolean Paid
        {
            get { return _paid; }
            set { _paid = value; }
        }

        public string PaymentStatus
        {
            get
            {
                return this.Paid ? "Paid" : "Pending";
            }
        }

        Int32 _id = common.constants.empty.ID;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }

        DateTime _creationDate = DateTime.Now;

        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        DateTime _fromDate = common.constants.empty.DATETIME;

        public DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        public DateTime ToDate
        {
            get {
                return this.FromDate.AddMonths(this.NumOfMonths); 
            }
        }
        Member _member = null;

        public Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
        TypeOfMembership _typeOfMembership = null;

        public TypeOfMembership TypeOfMembership
        {
            get { return _typeOfMembership; }
            set { _typeOfMembership = value; }
        }


        Single _price = 0;

        public Single Price
        {
            get { return _price; }
            set { _price = value; }
        }
        Int32 _numOfMonths = 0;

        public Int32 NumOfMonths
        {
            get { return _numOfMonths; }
            set { _numOfMonths = value; }
        }

        bool _active = true;

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public bool IsExpired
        {
            get
            {
                return DateTime.Now > this.ToDate;
            }
        }
        public String TypeOfMember
        {
            get
            {
                return this.Member != null ? this.Member.TypeOfMember.ToString() : string.Empty;
            }
        }
        public bool IsGoingToExpire
        {
            get
            {
                return DateTime.Now.AddDays(7) > this.ToDate && !this.IsExpired;
            }
        }
        public String Number
        {
            get
            {
                return this.Member == null ? string.Empty : this.Member.Code;
            }
        }
    }
}
