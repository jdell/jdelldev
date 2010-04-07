using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.asiento
{
    public class doUpdate : gesClinica.lib.bl._template.administrativoActionBL
    {
        Asiento _asiento;
        public doUpdate(Asiento asiento)
        {
            _asiento = asiento;
        }
        new public Asiento execute()
        {
            return (Asiento)base.execute();
        }
        protected override object accion()
        {
            if (_asiento == null)
                throw new _exceptions.common.NullReferenceException(typeof(Asiento), this.GetType().Name);
           
            if (_asiento.Ejercicio == null)
                throw new _exceptions.common.NullReferenceException(typeof(Ejercicio), this.GetType().Name);

            if (_asiento.IsDescuadrado)
                throw new _exceptions.asiento.AsientoDescuadradoException();

            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            return asientoFacade.doUpdate(_asiento);
        }
    }
}
