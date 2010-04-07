using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._exceptions.common
{
    public class IncorrectFormatConfigFileException : asrException
    {
        public IncorrectFormatConfigFileException()
            : base(string.Format("{0}. {1}", bl._common.constantes.mensaje.INCORRECT_FORMAT_CONFIG_FILE, _common.constantes.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }
    }
}