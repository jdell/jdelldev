using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.factura.action
{
    class doGetAllContabilizadaByFechas : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {
        DateTime _fechaDesde;
        DateTime _fechaHasta;
        Empresa _empresa;

        public doGetAllContabilizadaByFechas(DateTime fechaDesde, DateTime fechaHasta, Empresa empresa)
        {
            this._fechaDesde = fechaDesde;
            this._fechaHasta = fechaHasta;
            this._empresa = empresa;
        }
        
        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                return facturaDAO.doGetAllContabilizada(factory.Command, _fechaDesde, _fechaHasta, _empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
