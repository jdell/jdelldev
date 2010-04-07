using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.dao._importacion
{
    class actionImport
    {
        public delegate void ProcessingHandler(_events.ProgressEventArgs e);
        public event ProcessingHandler Processing;

        protected void OnProcessing(_events.ProgressEventArgs e)
        {
            if (Processing != null)
                Processing(e);
        }

        protected int c;
        protected int t;
        protected string info;
    }
}
