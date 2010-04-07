using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._importacion
{
    public class doImportarParte3 : gesClinica.lib.bl._template.generalActionBL
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
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Importando terceros...", 1, 1));
            dao._importacion.tercero.fachada fachadaOldTercero = new gesClinica.lib.dao._importacion.tercero.fachada();
            fachadaOldTercero.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldTercero.doImport(fachadaOldTercero.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
        void fachada_Processing(gesClinica.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs(e.InfoProcess, e.CurrentProcess, e.TotalProcess));
        }
    }
}
