using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl.empresa
{
    public class empresaActionBL:_template.actionBL
    {
        public empresaActionBL()
        {
            this.Permiso = tPERMISO.MASTERUSER;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
