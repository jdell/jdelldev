using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.vo
{
    public abstract class Member
    {

        public static Member getNewMember(tMEMBER type)
        {
            switch (type)
            {
                case tMEMBER.TEAM:
                    return new Team();
                case tMEMBER.PLAYER:
                    return new Player();
                default:
                    return null;
            }
        }

        Int64 _id = common.constants.empty.ID;

        public Int64 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        Member _parent = null;

        public Member Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        String _firstName = string.Empty;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        String _address = string.Empty;

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }
        DateTime _dateOfBirth = common.constants.empty.DATETIME;

        String _city = string.Empty;

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }
        string _zc = string.Empty;

        public string ZipCode
        {
            get { return _zc; }
            set { _zc = value; }
        }
        string _state = string.Empty;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        String _lastName = string.Empty;

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        String _middleName = string.Empty;

        public String MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        Int32 _number = 0;

        public Int32 Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        String _emailAddress = string.Empty;

        public String Email
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        String _phoneNumber = string.Empty;

        public String Phone
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        String _cellPhoneNumber = string.Empty;

        public String Cell
        {
            get { return _cellPhoneNumber; }
            set { _cellPhoneNumber = value; }
        }

        tMEMBER _type = tMEMBER.PLAYER;

        protected tMEMBER Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private System.Drawing.Image _photo;

        public System.Drawing.Image Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        public static tMEMBER TypeFromName(string name)
        {
            return (tMEMBER)System.Enum.Parse(typeof(tMEMBER), name);
        }
        public static string NameFromType(tMEMBER type)
        {
            return System.Enum.GetName(typeof(tMEMBER), type);
        }
        public tMEMBER TypeOfMember
        {
            get { return _type; }
        }

        public string FullName
        {
            get
            {
                if (this.Type== tMEMBER.PLAYER)
                    return string.Format("{0}, {1} {2}", this.LastName.ToUpper(), this.FirstName, this.MiddleName).Trim();
                else
                    return string.Format("{0}", this.FirstName);
            }
        }

        public override string ToString()
        {
            return this.FullName;
        }

        public bool IsBirthday()
        {
            return DateTime.Now.Month == this.DateOfBirth.Month && DateTime.Now.Day == this.DateOfBirth.Day;
        }

        public string Code
        {
            get
            {
                return Number.ToString("00000");
            }
        }
        public void SetNumber(string number)
        {
            Int32 x = 0;
            Int32.TryParse(number, out x);
            this.Number = x;
        }

        String _comments = string.Empty;

        public String Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
        String _emergencyContactName = string.Empty;

        public String EmergencyContactName
        {
            get { return _emergencyContactName; }
            set { _emergencyContactName = value; }
        }
        String _emergencyContactPhone = string.Empty;

        public String EmergencyContactPhone
        {
            get { return _emergencyContactPhone; }
            set { _emergencyContactPhone = value; }
        }
        String _emergencyContactRelationship = string.Empty;

        public String EmergencyContactRelationship
        {
            get { return _emergencyContactRelationship; }
            set { _emergencyContactRelationship = value; }
        }
    }
}
