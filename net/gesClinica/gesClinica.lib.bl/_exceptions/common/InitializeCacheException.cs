using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.common
{
    public class InitializeCacheException:gesClinicaException
    {
        public InitializeCacheException()
            : base(string.Format("{0}. {1}", bl._common.constantes.mensaje.NOT_LOADED_CACHE, _common.constantes.mensaje.NOTIFY_ADMINISTRATOR))
        {
        }
    }
}