using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.festivo
{
    internal class doUpdate : gesClinica.lib.bl._template.generalActionBL
    {
        Festivo _festivo;
        public doUpdate(Festivo festivo)
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

            if (_festivo.TipoFestivo == null)
                throw new _exceptions.festivo.MissingTypeOfFestivoException();
            
            gesClinica.lib.dao.festivo.fachada festivoFacade = new gesClinica.lib.dao.festivo.fachada();
            return festivoFacade.doUpdate(_festivo);
        }
    }
}
