using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc._common.secciones
{
    class ImportacionSection:lib.common.tipos.section
    {
        bool _importOldData;

        public bool ImportOldData
        {
            get { return _importOldData; }
            set { _importOldData = value; }
        }


        bool _ownerPrint;

        public bool OwnerPrint
        {
            get { return _ownerPrint; }
            set { _ownerPrint = value; }
        }

        public ImportacionSection()
        {
            this._name = "Importacion";
            this._importOldData = false;
            this._ownerPrint = false;
        }
    }
}
