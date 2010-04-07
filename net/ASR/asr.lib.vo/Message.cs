using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Message
    {
        private Staff _staff = null;

        public Staff Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }
        private Boolean _checked = false;

        public Boolean Checked
        {
            get { return _checked; }
            set { _checked = value; }
        }

        private int _id = lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _date = DateTime.Now;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private String _from = string.Empty;

        public String From
        {
            get { return _from; }
            set { _from = value; }
        }
        private String _of = string.Empty;

        public String Of
        {
            get { return _of; }
            set { _of = value; }
        }
        private String _phone = string.Empty;

        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private String _text = string.Empty;

        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }
        private Boolean _telephoned = false;

        public Boolean Telephoned
        {
            get { return _telephoned; }
            set { _telephoned = value; }
        }
        private Boolean _calledToSeeYou = false;

        public Boolean CalledToSeeYou
        {
            get { return _calledToSeeYou; }
            set { _calledToSeeYou = value; }
        }
        private Boolean _wantsToSeeYou = false;

        public Boolean WantsToSeeYou
        {
            get { return _wantsToSeeYou; }
            set { _wantsToSeeYou = value; }
        }
        private Boolean _pleaseCall = false;

        public Boolean PleaseCall
        {
            get { return _pleaseCall; }
            set { _pleaseCall = value; }
        }
        private Boolean _willCallAgain = false;

        public Boolean WillCallAgain
        {
            get { return _willCallAgain; }
            set { _willCallAgain = value; }
        }
        private Boolean _returnedYourCall = false;

        public Boolean ReturnedYourCall
        {
            get { return _returnedYourCall; }
            set { _returnedYourCall = value; }
        }
        private Boolean _urgent = false;

        public Boolean Urgent
        {
            get { return _urgent; }
            set { _urgent = value; }
        }
        private Boolean _visitedYourOffice = false;

        public Boolean VisitedYourOffice
        {
            get { return _visitedYourOffice; }
            set { _visitedYourOffice = value; }
        }
    }
}
