using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._importacion
{
    public class doEraseALLTerceros : asr.lib.bl._template.generalActionBL
    {
        public doEraseALLTerceros()
        {
        }
        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Borrando todo...terceros", 1, 1));
            dao._importacion.relacion.fachada fachadaRelacion = new asr.lib.dao._importacion.relacion.fachada();
            fachadaRelacion.doDeleteAllDataBaseTerceros();

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
    }
}
