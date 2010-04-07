using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._common.sections
{
    class AdministracionSection:model.common.types.section
    {
        private Int32 _accountRecordChartMonths = 6;

        public Int32 AccountRecordChartMonths
        {
            get { return _accountRecordChartMonths; }
            set { _accountRecordChartMonths = value; }
        }

        
        private bool _presentationMode = false;

        public bool PresentationMode
        {
            get { return _presentationMode; }
            set { _presentationMode = value; }
        }

        private List<string> _masterUser;
        public List<string> MasterUser
        {
            get { return _masterUser; }
            set { _masterUser = value; }
        }

        private string _systemUser;
        public string SystemUser
        {
            get { return _systemUser; }
            set { _systemUser = value; }
        }

        public AdministracionSection()
        {
            this._name = "Administracion";
            this._masterUser = new List<string>();
            this._systemUser = "asr";
            this._presentationMode = false;
            this.AccountRecordChartMonths = 6;
        }
        public void SetMasterUsers(string cadena, string separador)
        {
            if (this.MasterUser == null) this.MasterUser = new List<string>();
            string[] mUsers = cadena.Split(new string[]{separador}, StringSplitOptions.RemoveEmptyEntries);
            if (mUsers!=null) this.MasterUser.AddRange(mUsers);
        }
    }
}
