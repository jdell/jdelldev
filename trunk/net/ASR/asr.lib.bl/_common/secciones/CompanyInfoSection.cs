using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._common.secciones
{
    class CompanyInfoSection:lib.common.tipos.section
    {
        private string _companyName = string.Empty;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _companyAddress = string.Empty;

        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }
        private string _companyCity = string.Empty;

        public string CompanyCity
        {
            get { return _companyCity; }
            set { _companyCity = value; }
        }
        private string _companyState = string.Empty;

        public string CompanyState
        {
            get { return _companyState; }
            set { _companyState = value; }
        }
        private string _companyZipCode = string.Empty;

        public string CompanyZipCode
        {
            get { return _companyZipCode; }
            set { _companyZipCode = value; }
        }
        private string _companyPhone1 = string.Empty;

        public string CompanyPhone1
        {
            get { return _companyPhone1; }
            set { _companyPhone1 = value; }
        }
        private string _companyPhone2 = string.Empty;

        public string CompanyPhone2
        {
            get { return _companyPhone2; }
            set { _companyPhone2 = value; }
        }
        private string _companyFax = string.Empty;

        public string CompanyFax
        {
            get { return _companyFax; }
            set { _companyFax = value; }
        }

        private float _companyTaxPercentage = 8;

        public float CompanyTaxPercentage
        {
            get { return _companyTaxPercentage; }
            set { _companyTaxPercentage = value; }
        }

        public CompanyInfoSection()
        {
            this._name = "CompanyInfo";
        }
    }
}
