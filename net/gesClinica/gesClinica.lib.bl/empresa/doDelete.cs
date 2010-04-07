using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.empresa
{
    public class doDelete : empresaActionBL
    {
        Empresa _empresa;
        public doDelete(Empresa empresa)
        {
            _empresa = empresa;
        }
        new public Empresa execute()
        {
            return (Empresa)base.execute();
        }
        protected override object accion()
        {
            if (_empresa == null)
                throw new _exceptions.common.NullReferenceException(typeof(Empresa), this.GetType().Name);

            gesClinica.lib.dao.empresa.fachada empresaFacade = new gesClinica.lib.dao.empresa.fachada();
            return empresaFacade.doDelete(_empresa);
        }
    }
}
