using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    internal class doGetPorCita : gesClinica.lib.bl._template.generalActionBL
    {
        Cita _cita;
        public doGetPorCita(Cita cita)
        {
            _cita = cita;
        }
        new public Operacion execute()
        {
            return (Operacion)base.execute();
        }
        protected override object accion()
        {
            if (_cita == null)
                throw new _exceptions.common.NullReferenceException(typeof(Operacion), this.GetType().Name);

            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            return operacionFacade.doGet(_cita);
        }
    }
}
