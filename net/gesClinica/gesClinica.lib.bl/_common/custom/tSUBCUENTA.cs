using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.custom
{
    public enum tSUBCUENTA
    {
        SERVICIO,
        CLIENTE,
        RETENCION,
        PROVEEDOR,
        ORIGEN,
        GASTO,
        DESTINO,
        MEDIO,
        // Amortizacion
        AMORTIZACION_BIEN,
        AMORTIZACION_GASTO,
        // Prestamos
        PRESTAMO_INTERESES,
        PRESTAMO_AMORTIZACION,
        PRESTAMO_CUENTACARGO,
        // Sueldos y Salarios
        SUELDOS_SALARIO,
        SUELDOS_SEGURIDADSOCIAL,
        SUELDOS_MEDIOPAGO,
        SUELDOS_RETENCION,
        SUELDOS_SEGURIDADSOCIALACREEDORA
    }
}
