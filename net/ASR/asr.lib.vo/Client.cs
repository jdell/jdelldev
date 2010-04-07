using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Client
    {
        private String _companyName = string.Empty;

        public String CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }


        private long _id = asr.lib.common.constantes.vacio.ID;

        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _firstName = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName = string.Empty;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _middleName = string.Empty;

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        private string _homeAddress = string.Empty;

        public string HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }
        private string _homeCity = string.Empty;

        public string HomeCity
        {
            get { return _homeCity; }
            set { _homeCity = value; }
        }
        private string _homeState = string.Empty;

        public string HomeState
        {
            get { return _homeState; }
            set { _homeState = value; }
        }
        private string _homeZipCode = string.Empty;

        public string HomeZipCode
        {
            get { return _homeZipCode; }
            set { _homeZipCode = value; }
        }
        private string _preferredFirstName = string.Empty;

        public string PreferredFirstName
        {
            get { return _preferredFirstName; }
            set { _preferredFirstName = value; }
        }
        private string _ssn = string.Empty;

        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }
        private string _mailingAddress = string.Empty;

        public string MailingAddress
        {
            get { return _mailingAddress; }
            set { _mailingAddress = value; }
        }
        private string _mailingCity = string.Empty;

        public string MailingCity
        {
            get { return _mailingCity; }
            set { _mailingCity = value; }
        }
        private string _mailingState = string.Empty;

        public string MailingState
        {
            get { return _mailingState; }
            set { _mailingState = value; }
        }
        private string _mailingZipCode = string.Empty;

        public string MailingZipCode
        {
            get { return _mailingZipCode; }
            set { _mailingZipCode = value; }
        }
        private string _homePhoneNumber = string.Empty;

        public string HomePhoneNumber
        {
            get { return _homePhoneNumber; }
            set { _homePhoneNumber = value; }
        }
        private string _cellPhoneNumber = string.Empty;

        public string CellPhoneNumber
        {
            get { return _cellPhoneNumber; }
            set { _cellPhoneNumber = value; }
        }
        private string _additionalContactPhone = string.Empty;

        public string AdditionalContactPhone
        {
            get { return _additionalContactPhone; }
            set { _additionalContactPhone = value; }
        }
        private string _emailAddress = string.Empty;

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        private string _emergencyContact = string.Empty;

        public string EmergencyContact
        {
            get { return _emergencyContact; }
            set { _emergencyContact = value; }
        }
        private bool _inactive = false;

        public bool Inactive
        {
            get { return _inactive; }
            set { _inactive = value; }
        }
        private string _comments = string.Empty;

        public string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }
       
        public override string ToString()
        {
            return FullName;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0}, {1} {2}", this.LastName.ToUpper(), this.FirstName, this.MiddleName).Trim();
            }
        }

        private List<Employment> _employmentHistory = new List<Employment>();

        public List<Employment> EmploymentHistory
        {
            get { return _employmentHistory; }
            set { _employmentHistory = value; }
        }

        private DateTime _dateOfBirth = DateTime.MinValue;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        private float _creditScore = 0;

        public float CreditScore
        {
            get { return _creditScore; }
            set { _creditScore = value; }
        }


        private List<SkillScore> _skillScore = new List<SkillScore>();

        public List<SkillScore> SkillScore
        {
            get { return _skillScore; }
            set 
            { 
                _skillScore = value;
                RefreshSkill();
            }
        }

        public void RefreshSkill()
        {
            _skills = new List<Skill>();
            if (this._skillScore != null)
            {
                foreach (SkillScore skillScore in _skillScore)
                {
                    if (!_skills.Contains(skillScore.Skill))
                        _skills.Add(skillScore.Skill);
                }
            }
        }

        private List<Skill> _skills = null;
        public List<Skill> Skills
        {
            get 
            {
                return _skills;
            }
            
        }

        private System.Drawing.Image _photo;

        public System.Drawing.Image Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        private int? _externalID = null;
        public int? ExternalId
        {
            get { return _externalID; }
            set { _externalID = value; }
        }

        string _userName = string.Empty;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        string _password = string.Empty;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
