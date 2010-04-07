using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.estadocivil
{
    public class doAdd : gesClinica.lib.bl._template.administrativoActionBL
    {
        EstadoCivil _estadocivil;
        public doAdd(EstadoCivil estadocivil)
        {
            _estadocivil = estadocivil;
        }
        new public EstadoCivil execute()
        {
            return (EstadoCivil)base.execute();
        }
        protected override object accion()
        {
            if (_estadocivil == null)
                throw new _exceptions.common.NullReferenceException(typeof(EstadoCivil), this.GetType().Name);

            if (string.IsNullOrEmpty(_estadocivil.Descripcion))
                throw new _exceptions.estadocivil.MissingDescriptionException();


            gesClinica.lib.dao.estadocivil.fachada estadocivilFacade = new gesClinica.lib.dao.estadocivil.fachada();
            return estadocivilFacade.doAdd(_estadocivil);
        }
    }
}
