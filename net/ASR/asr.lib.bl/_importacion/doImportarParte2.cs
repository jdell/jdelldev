using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._importacion
{
    public class doImportarParte2 : asr.lib.bl._template.generalActionBL
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
            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Importando ejercicios...", 1, 1));
            dao._importacion.ejercicio.fachada fachadaOldEjercicio = new asr.lib.dao._importacion.ejercicio.fachada();
            fachadaOldEjercicio.Processing += new asr.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldEjercicio.doImport(fachadaOldEjercicio.doGetAll(),_empresa);

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Importando apuntes...", 1, 1));
            dao._importacion.apunte.fachada fachadaOldApunte = new asr.lib.dao._importacion.apunte.fachada();
            fachadaOldApunte.Processing += new asr.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldApunte.doImport(fachadaOldApunte.doGetAll());

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
        void fachada_Processing(asr.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs(e.InfoProcess, e.CurrentProcess, e.TotalProcess));
        }
    }
}
