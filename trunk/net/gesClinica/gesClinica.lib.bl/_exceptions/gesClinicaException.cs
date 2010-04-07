using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions
{
    public class gesClinicaException:repsol.exceptions.UserException
    {
        private string _detail = string.Empty;

        public string Detail
        {
            get { return _detail; }
        }

        public gesClinicaException(string msg, string detail)
            : base(msg)
        {
            this._detail = detail;
        }

        public gesClinicaException(string msg)
            : base(msg)
        {
        }
        public gesClinicaException(string msg, gesClinicaException ex)
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
