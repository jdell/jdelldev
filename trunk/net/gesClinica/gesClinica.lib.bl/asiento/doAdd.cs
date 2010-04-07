using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.asiento
{
    public class doAdd : gesClinica.lib.bl._template.administrativoActionBL
    {
        Asiento _asiento;
        Empresa _empresa;
        public doAdd(Asiento asiento, Empresa empresa)
        {
            _asiento = asiento;
            _empresa = empresa;
        }
        new public Asiento execute()
        {
            return (Asiento)base.execute();
        }
        protected override object accion()
        {
            if (_asiento == null)
                throw new _exceptions.common.NullReferenceException(typeof(Asiento), this.GetType().Name);

            if (_empresa == null)
                throw new _exceptions.common.NullReferenceException(typeof(Empresa), this.GetType().Name);

            if (_asiento.IsDescuadrado)
                throw new _exceptions.asiento.AsientoDescuadradoException();

            gesClinica.lib.dao.asiento.fachada asientoFacade = new gesClinica.lib.dao.asiento.fachada();
            return asientoFacade.doAdd(_asiento, _empresa);
        }
    }
}
