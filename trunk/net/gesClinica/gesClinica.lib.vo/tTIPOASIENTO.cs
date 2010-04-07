using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    public enum tTIPOASIENTO
    {
        [common.tipos.EnumDescription("Factura Emitida")]
        FACTURA_EMITIDA = 1,

        [common.tipos.EnumDescription("Factura Recibida")]
        FACTURA_RECIBIDA = 2,

        [common.tipos.EnumDescription("Préstamo")]
        PRESTAMO = 3,

        [common.tipos.EnumDescription("Sueldos y Salarios")]
        SUELDO = 4,

        [common.tipos.EnumDescription("Otro")]
        OTRO = 5
    }
}
