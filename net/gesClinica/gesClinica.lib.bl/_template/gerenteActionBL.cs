using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._template
{
    public class gerenteActionBL:actionBL
    {
        public gerenteActionBL()
        {
            this.Permiso = tPERMISO.GERENTE;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}