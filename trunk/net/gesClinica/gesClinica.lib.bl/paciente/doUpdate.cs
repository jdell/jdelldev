using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.paciente
{
    public class doUpdate : gesClinica.lib.bl._template.generalActionBL
    {
        Paciente _paciente;
        public doUpdate(Paciente paciente)
        {
            _paciente = paciente;
        }
        new public Paciente execute()
        {
            return (Paciente)base.execute();
        }
        protected override object accion()
        {
            if (_paciente == null)
                throw new _exceptions.common.NullReferenceException(typeof(Paciente), this.GetType().Name);

            if (string.IsNullOrEmpty(_paciente.Nombre))
                throw new _exceptions.paciente.MissingNameException();

            if (_paciente.Tarifa == null)
                throw new _exceptions.paciente.MissingTarifaException();

            gesClinica.lib.dao.paciente.fachada pacienteFacade = new gesClinica.lib.dao.paciente.fachada();
            return pacienteFacade.doUpdate(_paciente);
        }
    }
}
