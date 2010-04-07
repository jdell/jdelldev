using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.paciente
{
    public class doUpdateMuyImportante : gesClinica.lib.bl._template.generalActionBL
    {
        Paciente _paciente;
        public doUpdateMuyImportante(Paciente paciente)
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

            gesClinica.lib.dao.paciente.fachada pacienteFacade = new gesClinica.lib.dao.paciente.fachada();
            return pacienteFacade.doUpdateMuyImportante(_paciente);
        }
    }
}
