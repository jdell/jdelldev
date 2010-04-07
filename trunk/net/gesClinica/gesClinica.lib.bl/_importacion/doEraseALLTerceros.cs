using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._importacion
{
    public class doEraseALLTerceros : gesClinica.lib.bl._template.generalActionBL
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

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Borrando todo...terceros", 1, 1));
            dao._importacion.relacion.fachada fachadaRelacion = new gesClinica.lib.dao._importacion.relacion.fachada();
            fachadaRelacion.doDeleteAllDataBaseTerceros();

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
    }
}
