using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public class Holiday
    {
        //Int32 _id = common.constants.empty.ID;

        //public Int32 ID
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        public Holiday()
        {
        }
        public Holiday(DateTime date)
        {
            _date = date;
        }

        DateTime _date = DateTime.Now;

        public DateTime Date
        {
            get { return _date.Date; }
            set { _date = value; }
        }
        public static System.Drawing.Color DrawColor
        {
            get
            {
                //return System.Drawing.Color.FromName(this.Color);
                return System.Drawing.Color.FromArgb(253, 189, 189);//.FromName("Salmon");
            }
        }
    }
}
