using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._template
{
    public class generalActionBL:actionBL
    {
        public generalActionBL()
        {
            foreach (tPERMISO permiso in System.Enum.GetValues(typeof(tPERMISO)))
            {
                this.Permiso |= permiso;  
            }
            //this.Permiso |= tPERMISO.TERAPEUTA | tPERMISO.ADMINISTRATIVO | tPERMISO.MASTERUSER;
        }

        protected override object accion()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
