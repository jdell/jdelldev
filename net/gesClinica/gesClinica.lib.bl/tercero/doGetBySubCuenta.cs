using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tercero
{
    internal class doGetBySubCuenta : gesClinica.lib.bl._template.generalActionBL
    {
        SubCuenta _subcuenta;
        public doGetBySubCuenta(SubCuenta subcuenta)
        {
            _subcuenta = subcuenta;
        }
        new public Tercero execute()
        {
            return (Tercero)base.execute();
        }
        protected override object accion()
        {
            if (_subcuenta == null)
                throw new _exceptions.common.NullReferenceException(typeof(SubCuenta), this.GetType().Name);

            gesClinica.lib.dao.tercero.fachada terceroFacade = new gesClinica.lib.dao.tercero.fachada();
            return terceroFacade.doGetBySubCuenta(_subcuenta);
        }
    }
}
