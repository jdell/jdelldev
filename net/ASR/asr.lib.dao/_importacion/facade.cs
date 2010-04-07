using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.dao._importacion
{
    public class facade: _common.facade
    {
        public delegate void ProcessingHandler(_events.ProgressEventArgs e);
        public event ProcessingHandler Processing;

        protected void OnProcessing(_events.ProgressEventArgs e)
        {
            if (Processing != null)
                Processing(e);
        }

        public facade()
        {
            this.factory = new asr.lib.dao._common.DAOFactory(asr.lib.dao._common.conexion.tCONEXION.oldasr);
        }

        protected void action_Processing(asr.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(e);
        }
    }
}
