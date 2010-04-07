using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.festivo
{
    internal class doDelete : gesClinica.lib.bl._template.generalActionBL
    {
        Festivo _festivo;
        public doDelete(Festivo festivo)
        {
            _festivo = festivo;
        }
        new public Festivo execute()
        {
            return (Festivo)base.execute();
        }
        protected override object accion()
        {
            if (_festivo == null)
                throw new _exceptions.common.NullReferenceException(typeof(Festivo), this.GetType().Name);

            gesClinica.lib.dao.festivo.fachada festivoFacade = new gesClinica.lib.dao.festivo.fachada();
            return festivoFacade.doDelete(_festivo);
        }
    }
}
