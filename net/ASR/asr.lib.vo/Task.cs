using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Task
    {
        private int _id = asr.lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _description = string.Empty;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private bool _completed = false;

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        private bool _priority = false;

        public bool Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private DateTime _date = DateTime.Now;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private Staff _staff = null;

        public Staff Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }
    }
}
