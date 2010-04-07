using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tarifa
{
    public class doUpdate : gesClinica.lib.bl._template.generalActionBL
    {
        Tarifa _tarifa;
        public doUpdate(Tarifa tarifa)
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

            if (string.IsNullOrEmpty(_tarifa.Descripcion))
                throw new _exceptions.tarifa.MissingDescriptionException();

            gesClinica.lib.dao.tarifa.fachada tarifaFacade = new gesClinica.lib.dao.tarifa.fachada();
            return tarifaFacade.doUpdate(_tarifa);
        }
    }
}
