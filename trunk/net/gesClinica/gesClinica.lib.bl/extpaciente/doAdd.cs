using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.extpaciente
{
    public class doAdd : gesClinica.lib.bl._template.terapeutaActionBL
    {
        ExtPaciente _extpaciente;
        public doAdd(ExtPaciente extpaciente)
        {
            _extpaciente = extpaciente;
        }
        new public ExtPaciente execute()
        {
            return (ExtPaciente)base.execute();
        }
        protected override object accion()
        {
            if (_extpaciente == null)
                throw new _exceptions.common.NullReferenceException(typeof(ExtPaciente), this.GetType().Name);

            gesClinica.lib.dao.extpaciente.fachada extpacienteFacade = new gesClinica.lib.dao.extpaciente.fachada();
            return extpacienteFacade.doAdd(_extpaciente);
        }
    }
}
