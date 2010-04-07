using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tarifa
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        Tarifa _tarifa;
        public doGet(Tarifa tarifa)
        {
            _tarifa = tarifa;
        }
        new public Tarifa execute()
        {
            return (Tarifa)base.execute();
        }
        protected override object accion()
        {
            if (_tarifa == null)
                throw new _exceptions.common.NullReferenceException(typeof(Tarifa), this.GetType().Name);

            gesClinica.lib.dao.tarifa.fachada tarifaFacade = new gesClinica.lib.dao.tarifa.fachada();
            return tarifaFacade.doGet(_tarifa);
        }
    }
}
