using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._template
{
    public class terapeutaActionBL:actionBL
    {
        public terapeutaActionBL()
        {
            this.Permiso = tPERMISO.TERAPEUTA;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
