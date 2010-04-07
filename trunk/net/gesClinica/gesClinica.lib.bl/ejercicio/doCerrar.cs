using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.ejercicio
{
    public class doCerrar : gesClinica.lib.bl._template.administrativoActionBL
    {
        Ejercicio _ejercicio;
        public doCerrar(Ejercicio ejercicio)
        {
            _ejercicio = ejercicio;
        }
        new public Ejercicio execute()
        {
            return (Ejercicio)base.execute();
        }
        protected override object accion()
        {
            if (_ejercicio == null)
                throw new _exceptions.common.NullReferenceException(typeof(Ejercicio), this.GetType().Name);

            gesClinica.lib.dao.ejercicio.fachada ejercicioFacade = new gesClinica.lib.dao.ejercicio.fachada();
            return ejercicioFacade.doCerrar(_ejercicio, new SubCuenta(_common.cache.SUBCUENTAS.SubCuentaPerdidasYGanancias));
        }
    }
}
