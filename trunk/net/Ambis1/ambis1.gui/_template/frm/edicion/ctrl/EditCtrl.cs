using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.frm.edicion.ctrl
{
    public abstract class EditCtrl:repsol.forms.template.edicion.ctrl.EditFormCtrl
    {
        [Obsolete("Versión antigua.",true)]
        public override bool EsCodigoValido(ref repsol.forms.template.edicion.EditForm frm)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        [Obsolete("Versión antigua.", true)]
        public override bool canAccept(ref repsol.forms.template.edicion.EditForm frm)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public abstract object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord);
    }
}
