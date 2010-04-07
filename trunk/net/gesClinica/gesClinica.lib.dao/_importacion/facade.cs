using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.dao._importacion
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
            this.factory = new gesClinica.lib.dao._common.DAOFactory(gesClinica.lib.dao._common.conexion.tCONEXION.oldGesClinica);
        }

        protected void action_Processing(gesClinica.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(e);
        }
    }
}
