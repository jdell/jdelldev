using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.subcuenta
{
    internal class doGetAllByLista : gesClinica.lib.bl._template.generalActionBL
    {
        List<String> _lista = null;

        public doGetAllByLista(List<String> lista)
        {
            _lista = lista;
        }
        new public List<SubCuenta> execute()
        {
            return (List<SubCuenta>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.subcuenta.fachada subcuentaFacade = new gesClinica.lib.dao.subcuenta.fachada();
            return subcuentaFacade.doGetAll(_lista);
        }
    }
}
