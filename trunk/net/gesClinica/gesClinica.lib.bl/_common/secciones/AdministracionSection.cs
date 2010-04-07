using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.secciones
{
    class AdministracionSection:lib.common.tipos.section
    {
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
            this._systemUser = "gesClinica";
        }
        public void SetMasterUsers(string cadena, string separador)
        {
            if (this.MasterUser == null) this.MasterUser = new List<string>();
            string[] mUsers = cadena.Split(new string[]{separador}, StringSplitOptions.RemoveEmptyEntries);
            if (mUsers!=null) this.MasterUser.AddRange(mUsers);
        }
    }
}
