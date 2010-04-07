using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.common
{
    public class ConfigFileNotFoundException:asrException
    {
        public ConfigFileNotFoundException():base(string.Format("{0}. {1}",asr.lib.bl._common.constantes.mensaje.CONFIGFILE_NOT_FOUND,asr.lib.bl._common.constantes.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }               
    }
}
