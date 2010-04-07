using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._template
{
    public class administrativoActionBL:actionBL
    {
        public administrativoActionBL()
        {
            this.Permiso = tPERMISO.ADMINISTRATIVO;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
