using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.laboratorio
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        Laboratorio _laboratorio;
        public doGet(Laboratorio laboratorio)
        {
            _laboratorio = laboratorio;
        }
        new public Laboratorio execute()
        {
            return (Laboratorio)base.execute();
        }
        protected override object accion()
        {
            if (_laboratorio == null)
                throw new _exceptions.common.NullReferenceException(typeof(Laboratorio), this.GetType().Name);

            gesClinica.lib.dao.laboratorio.fachada laboratorioFacade = new gesClinica.lib.dao.laboratorio.fachada();
            return laboratorioFacade.doGet(_laboratorio);
        }
    }
}
