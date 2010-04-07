using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    public enum tTIPOTERAPIA
    {
        [common.tipos.EnumDescription("Normal")]
        NORMAL = 1,

        [common.tipos.EnumDescription("Normal + MC")]
        NORMAL_MC = 2,

        [common.tipos.EnumDescription("MC")]
        MC = 3,

        [common.tipos.EnumDescription("Visitador Médico")]
        VISITADOR = 4,

        [common.tipos.EnumDescription("Llamada Telefónica")]
        LLAMADA_TELEFONICA = 5
    }
}
