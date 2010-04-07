using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._importacion
{
    public class doEraseALL : asr.lib.bl._template.generalActionBL
    {
        bool _primeraParte = true;
        public doEraseALL(bool primeraParte)
        {
            _primeraParte = primeraParte;
        }
        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Borrando todo...", 1, 1));
            dao._importacion.relacion.fachada fachadaRelacion = new asr.lib.dao._importacion.relacion.fachada();
            fachadaRelacion.doDeleteAllDataBase(_primeraParte);

            this.OnProcessing(new asr.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }
    }
}
