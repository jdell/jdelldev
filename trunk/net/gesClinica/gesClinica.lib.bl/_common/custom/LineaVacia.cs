using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.custom
{
    internal class LineaVacia
    {
        private string _campoVacio;

        public string CampoVacio
        {
            get { return _campoVacio; }
            set { _campoVacio = value; }
        }
    }
}
