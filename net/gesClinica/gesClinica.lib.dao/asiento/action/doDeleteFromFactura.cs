using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.asiento.action
{
    class doDeleteFromFactura : gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {

        Factura _factura = null;
        Empresa _empresa;
        public doDeleteFromFactura(Factura factura, Empresa empresa)
        {
            _factura = factura;
            _empresa = empresa;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                #region Factura - Descontabilizar

                factura.dao.facturaDAO facturaDAO = new gesClinica.lib.dao.factura.dao.facturaDAO();
                _factura.Contabilizada = false;
                facturaDAO.doUpdateContabilizada(factory.Command, _factura);

                #endregion

                #region Asiento - Borrado
                dao.asientoDAO asientoDAO = new gesClinica.lib.dao.asiento.dao.asientoDAO();
                ejercicio.dao.ejercicioDAO ejerciicoDAO = new gesClinica.lib.dao.ejercicio.dao.ejercicioDAO();

                Ejercicio ejercicio = ejerciicoDAO.doGetByFecha(factory.Command, _factura.Fecha, _empresa);

                List<Asiento> asientos = asientoDAO.doGetAll(factory.Command, _factura, ejercicio);

                apunte.dao.apunteDAO apunteDAO = new gesClinica.lib.dao.apunte.dao.apunteDAO();
                foreach (Asiento asiento in asientos)
                {
                    apunteDAO.doDeleteByAsiento(factory.Command, asiento);

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

                    asientoDAO.doDelete(factory.Command, asiento);
                }
                #endregion

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
