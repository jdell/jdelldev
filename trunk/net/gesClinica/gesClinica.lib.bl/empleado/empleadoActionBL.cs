using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl.empleado
{
    public class empleadoActionBL:_template.actionBL
    {
        public empleadoActionBL()
        {
            this.Permiso = tPERMISO.MASTERUSER | tPERMISO.GERENTE;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
