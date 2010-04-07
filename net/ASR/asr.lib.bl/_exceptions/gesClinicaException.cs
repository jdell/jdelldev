using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions
{
    public class asrException:repsol.exceptions.UserException
    {
        private string _detail = string.Empty;

        public string Detail
        {
            get { return _detail; }
        }

        public asrException(string msg, string detail)
            : base(msg)
        {
            this._detail = detail;
        }

        public asrException(string msg)
            : base(msg)
        {
        }
        public asrException(string msg, asrException ex)
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
