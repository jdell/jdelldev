using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.common
{
    public class ConfigFileNotFoundException:gesClinicaException
    {
        public ConfigFileNotFoundException():base(string.Format("{0}. {1}",gesClinica.lib.bl._common.constantes.mensaje.CONFIGFILE_NOT_FOUND,gesClinica.lib.bl._common.constantes.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }               
    }
}
