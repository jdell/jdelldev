using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.extpaciente
{
    public class doGetByPaciente : gesClinica.lib.bl._template.terapeutaActionBL
    {
        Paciente _paciente;
        public doGetByPaciente(Paciente paciente)
        {
            _paciente = paciente;
        }
        new public ExtPaciente execute()
        {
            return (ExtPaciente)base.execute();
        }
        protected override object accion()
        {
            if (_paciente == null)
                throw new _exceptions.common.NullReferenceException(typeof(Paciente), this.GetType().Name);

            gesClinica.lib.dao.extpaciente.fachada extpacienteFacade = new gesClinica.lib.dao.extpaciente.fachada();
            return extpacienteFacade.doGetByPaciente(_paciente);
        }
    }
}
