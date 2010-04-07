using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadocita
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        EstadoCita _estadocita;
        public doAdd(EstadoCita estadocita)
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
            if (string.IsNullOrEmpty(_estadocita.Descripcion))
                throw new _exceptions.estadocita.MissingDescriptionException();


            gesClinica.lib.dao.estadocita.fachada estadocitaFacade = new gesClinica.lib.dao.estadocita.fachada();
            return estadocitaFacade.doAdd(_estadocita);
        }
    }
}
