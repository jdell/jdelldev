using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions.common
{
    public class ConfigFileNotFoundException:ambis1Exception
    {
        public ConfigFileNotFoundException():base(string.Format("{0}. {1}",ambis1.model.bl._common.constants.mensaje.CONFIGFILE_NOT_FOUND,ambis1.model.bl._common.constants.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }               
    }
}
