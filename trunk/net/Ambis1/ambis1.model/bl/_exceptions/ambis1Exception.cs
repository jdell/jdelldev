using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions
{
    public class ambis1Exception:repsol.exceptions.UserException
    {
        private string _detail = string.Empty;

        public string Detail
        {
            get { return _detail; }
        }

        public ambis1Exception(string msg, string detail)
            : base(msg)
        {
            this._detail = detail;
        }

        public ambis1Exception(string msg)
            : base(msg)
        {
        }
        public ambis1Exception(string msg, ambis1Exception ex)
            : base(msg,ex)
        {
        }

        public string FullMessage
        {
            get
            {
                return String.Format("{0} {1}", this.Message, this._detail).Trim();
            }
        }

    }
}
