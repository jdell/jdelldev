using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.subcuenta
{
    public class doGet : gesClinica.lib.bl._template.administrativoActionBL
    {
        SubCuenta _subcuenta;
        public doGet(SubCuenta subcuenta)
        {
            _subcuenta = subcuenta;
        }
        new public SubCuenta execute()
        {
            return (SubCuenta)base.execute();
        }
        protected override object accion()
        {
            if (_subcuenta == null)
                throw new _exceptions.common.NullReferenceException(typeof(SubCuenta), this.GetType().Name);

            gesClinica.lib.dao.subcuenta.fachada subcuentaFacade = new gesClinica.lib.dao.subcuenta.fachada();
            return subcuentaFacade.doGet(_subcuenta);
        }
    }
}
