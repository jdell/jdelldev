using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.apunte._setting
{
    [Serializable()]
    class settingQuerySubCuenta: repsol.util.setting.userpreferences
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
        private lib.vo.SubCuenta _subCuenta = null;

        public lib.vo.SubCuenta SubCuenta
        {
            get { return _subCuenta; }
            set { _subCuenta = value; }
        }

        private DateTime _fechaDesde;

        public DateTime FechaDesde
        {
            get { return _fechaDesde; }
            set { _fechaDesde = value; }
        }
        private DateTime _fechaHasta;

        public DateTime FechaHasta
        {
            get { return _fechaHasta; }
            set { _fechaHasta = value; }
        }

        public settingQuerySubCuenta()
        {
        }
        
    }
}
