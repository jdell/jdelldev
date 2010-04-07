using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class Reservation
    {
        Int32 _id = common.constants.empty.ID;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        DateTime _dateAndTime = DateTime.Now;

        public DateTime DateAndTime
        {
            get { return _dateAndTime; }
            set { _dateAndTime = value; }
        }
        DateTime _duration = DateTime.Now;

        public DateTime Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        Member _member = null;

        public Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
        Cage _cage = null;

        public Cage Cage
        {
            get { return _cage; }
            set { _cage = value; }
        }

        public System.Drawing.Color DrawColor
        {
            get
            {
                //return System.Drawing.Color.FromName(this.Color);
                return System.Drawing.Color.FromName("PaleGreen");
            }
        }
    }
}
