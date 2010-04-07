using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._importacion
{
    public class doImportarParte2 : gesClinica.lib.bl._template.generalActionBL
    {
        vo.Empresa _empresa = null;
        public doImportarParte2(vo.Empresa empresa)
        {
            _empresa = empresa;
        }

        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Importando ejercicios...", 1, 1));
            dao._importacion.ejercicio.fachada fachadaOldEjercicio = new gesClinica.lib.dao._importacion.ejercicio.fachada();
            fachadaOldEjercicio.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldEjercicio.doImport(fachadaOldEjercicio.doGetAll(),_empresa);

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Importando apuntes...", 1, 1));
            dao._importacion.apunte.fachada fachadaOldApunte = new gesClinica.lib.dao._importacion.apunte.fachada();
            fachadaOldApunte.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldApunte.doImport(fachadaOldApunte.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
        void fachada_Processing(gesClinica.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs(e.InfoProcess, e.CurrentProcess, e.TotalProcess));
        }
    }
}
