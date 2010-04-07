using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadocita
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        EstadoCita _estadocita;
        public doGet(EstadoCita estadocita)
        {
            _estadocita = estadocita;
        }
        new public EstadoCita execute()
        {
            return (EstadoCita)base.execute();
        }
        protected override object accion()
        {
            if (_estadocita == null)
                throw new _exceptions.common.NullReferenceException(typeof(EstadoCita), this.GetType().Name);

            gesClinica.lib.dao.estadocita.fachada estadocitaFacade = new gesClinica.lib.dao.estadocita.fachada();
            return estadocitaFacade.doGet(_estadocita);
        }
    }
}
