using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._exceptions.common
{
    public class InitializeCacheException:ambis1Exception
    {
        public InitializeCacheException()
            : base(string.Format("{0}. {1}", bl._common.constants.mensaje.NOT_LOADED_CACHE, _common.constants.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }
    }
}