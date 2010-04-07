using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._exceptions.operacion
{
    public class UnableCreateOperationException:validatingException
    {
        public UnableCreateOperationException(lib.vo.Cita cita)
            : base(string.Format("No puede crear una operación de citas con este tipo de terapia [{0}].", lib.common.funciones.EnumHelper.GetDescription(cita.Terapia.TipoTerapia.Codigo)), _common.constantes.mensaje.NOTIFY_ADMINISTRATOR)
        {
        }
    }
}
