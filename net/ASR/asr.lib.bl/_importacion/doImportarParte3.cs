using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._importacion
{
    public class doImportarParte3 : asr.lib.bl._template.generalActionBL
    {
        public doImportarParte3()
        {
        }

        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {
            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Importando terceros...", 1, 1));
            dao._importacion.tercero.fachada fachadaOldTercero = new asr.lib.dao._importacion.tercero.fachada();
            fachadaOldTercero.Processing += new asr.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldTercero.doImport(fachadaOldTercero.doGetAll());

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
        void fachada_Processing(asr.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs(e.InfoProcess, e.CurrentProcess, e.TotalProcess));
        }
    }
}
