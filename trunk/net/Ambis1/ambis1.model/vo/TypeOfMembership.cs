using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class TypeOfMembership
    {
        public TypeOfMembership()
        {
        }
        public TypeOfMembership(Int32 numOfMonths)
        {
            _numOfMonths = numOfMonths;
        }

        Int32 _id = common.constants.empty.ID;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        Int32 _numOfMonths = 1;

        public Int32 NumOfMonths
        {
            get { return _numOfMonths; }
            set { _numOfMonths = value; }
        }
        Single _individualPrice = 0;

        public Single IndividualPrice
        {
            get { return _individualPrice; }
            set { _individualPrice = value; }
        }

        Single _teamPrice = 0;

        public Single TeamPrice
        {
            get { return _teamPrice; }
            set { _teamPrice = value; }
        }
        Single _familyPrice = 0;

        public Single FamilyPrice
        {
            get { return _familyPrice; }
            set { _familyPrice = value; }
        }

        public override string ToString()
        {
            return this.Description;
        }

        public String Description
        {
            get
            {
                if ((this.NumOfMonths % 12 == 0) && (this.NumOfMonths > 0))
                    return String.Format("{0} Year{1}", this.NumOfMonths / 12, this.NumOfMonths / 12 > 1 ? "s" : "");
                else
                    return String.Format("{0} Month{1}", this.NumOfMonths, this.NumOfMonths > 1 ? "s" : "");
    
            }
        }
    }
}
