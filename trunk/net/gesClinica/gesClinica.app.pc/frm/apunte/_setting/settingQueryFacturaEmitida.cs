using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.apunte._setting
{
    [Serializable()]
    class settingQueryFacturaEmitida: repsol.util.setting.userpreferences
    {
        private lib.vo.Empresa _empresa = null;

        public lib.vo.Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
        private lib.vo.Ejercicio _ejercicio = null;

        public lib.vo.Ejercicio Ejercicio
        {
            get { return _ejercicio; }
            set { _ejercicio = value; }
        }

        public settingQueryFacturaEmitida()
        {
        }
        
    }
}
