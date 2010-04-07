using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._template
{
    public class masteruserActionBL:actionBL
    {
        public masteruserActionBL()
        {
            this.Permiso = tPERMISO.MASTERUSER | tPERMISO.ADMINISTRATIVO;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
