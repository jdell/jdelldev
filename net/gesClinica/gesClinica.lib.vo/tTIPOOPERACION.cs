using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    public enum tTIPOOPERACION
    {
        [common.tipos.EnumDescription("Caja Inicial")]
        CAJA_INICIAL = 1,

        [common.tipos.EnumDescription("Operaciones con pacientes")]
        OPERACION_PACIENTE = 2,

        [common.tipos.EnumDescription("Pago Terapeutas")]
        PAGO_TERAPEUTA = 3,

        [common.tipos.EnumDescription("Otros Pagos")]
        OTROS_PAGOS = 4,

        [common.tipos.EnumDescription("Cobros fuera de cita")]
        COBRO_FUERA_CITA = 5
    }
}