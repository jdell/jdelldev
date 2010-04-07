using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions.common
{
    public class IncorrectFormatConfigFileException : ambis1Exception
    {
        public IncorrectFormatConfigFileException()
            : base(string.Format("{0}. {1}", bl._common.constants.mensaje.INCORRECT_FORMAT_CONFIG_FILE, _common.constants.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }
    }
}