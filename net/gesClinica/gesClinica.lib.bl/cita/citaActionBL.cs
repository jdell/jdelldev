using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl.cita
{
    public class citaActionBL:_template.actionBL
    {
        public citaActionBL()
        {
            this.Permiso = tPERMISO.TERAPEUTA | tPERMISO.ADMINISTRATIVO;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
