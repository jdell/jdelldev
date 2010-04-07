using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doDelete : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Asiento _asiento = null;
        public doDelete(Asiento asiento)
        {
            _asiento = asiento;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();

                apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                apunteDAO.doDeleteByAsiento(factory.Command, _asiento);

                //TODO: Descontabilizar factura
                //if (_asiento.TipoAsiento == tTIPOASIENTO.FACTURA_EMITIDA)
                //{
                //    factura.dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                //    vo.Factura factura = new Factura();
                //    factura.Numero = _asiento.NumeroFactura;
                //    factura = facturaDAO.doGetByAsiento(factory.Command, _asiento);
                //    factura.Contabilizada = false;
                //    facturaDAO.doUpdateContabilizada(factory.Command, factura);
                //}

                _asiento = (Asiento)asientoDAO.doDelete(factory.Command, _asiento);
                return _asiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
