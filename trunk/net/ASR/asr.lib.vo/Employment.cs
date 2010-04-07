using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Employment : IComparable<Employment>
    {
        private long _id = asr.lib.common.constantes.vacio.ID;

        public long ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Customer _customer = null;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        private DateTime _startDate = DateTime.MinValue;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        private DateTime _endDate = DateTime.MinValue;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        private DateTime _startPay = DateTime.MinValue;

        public DateTime StartPay
        {
            get { return _startPay; }
            set { _startPay = value; }
        }
        private DateTime _endPay = DateTime.MinValue;

        public DateTime EndPay
        {
            get { return _endPay; }
            set { _endPay = value; }
        }
        private Single _baseSalary = 0;

        public Single BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }
        private Single _bonus = 0;

        public Single Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
        private string _additionalCompensation = string.Empty;

        public string AdditionalCompensation
        {
            get { return _additionalCompensation; }
            set { _additionalCompensation = value; }
        }
        private string _positionHeld = string.Empty;

        public string PositionHeld
        {
            get { return _positionHeld; }
            set { _positionHeld = value; }
        }
        private string _primaryResponsibilities = string.Empty;

        public string PrimaryResponsibilities
        {
            get { return _primaryResponsibilities; }
            set { _primaryResponsibilities = value; }
        }
        private string _reasonForLeaving = string.Empty;

        public string ReasonForLeaving
        {
            get { return _reasonForLeaving; }
            set { _reasonForLeaving = value; }
        }
        private bool _provideNotice = true;

        public bool ProvideNotice
        {
            get { return _provideNotice; }
            set { _provideNotice = value; }
        }
        private string _contactTitle = string.Empty;

        public string ContactTitle
        {
            get { return _contactTitle; }
            set { _contactTitle = value; }
        }
        private string _phoneNumber = string.Empty;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private string _relationShip = string.Empty;

        public string RelationShip
        {
            get { return _relationShip; }
            set { _relationShip = value; }
        }
        private bool _mayContact = false;

        public bool MayContact
        {
            get { return _mayContact; }
            set { _mayContact = value; }
        }
        private string _reasonIfNot = string.Empty;

        public string ReasonIfNot
        {
            get { return _reasonIfNot; }
            set { _reasonIfNot = value; }
        }
        private string _gap = string.Empty;

        public string Gap
        {
            get { return _gap; }
            set { _gap = value; }
        }

        private tSHIFT _shift = tSHIFT.UNKNOWN;

        public tSHIFT Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }
        public static tSHIFT TipoFromName(string name)
        {
            if  (!string.IsNullOrEmpty(name))
                return (tSHIFT)System.Enum.Parse(typeof(tSHIFT), name);
            else
                return tSHIFT.UNKNOWN;
        }
        public static string NameFromTipo(tSHIFT tipo)
        {
            return System.Enum.GetName(typeof(tSHIFT), tipo);
        }

        #region Miembros de IComparable<Employment>

        public int CompareTo(Employment other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
