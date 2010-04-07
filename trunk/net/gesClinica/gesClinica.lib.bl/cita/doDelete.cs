using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doDelete : citaActionBL
    {
        Cita _cita;
        public doDelete(Cita cita)
        {
            _cita = cita;
        }
        new public Cita execute()
        {
            return (Cita)base.execute();
        }
        protected override object accion()
        {
            if (_cita == null)
                throw new _exceptions.common.NullReferenceException(typeof(Cita), this.GetType().Name);
            if (_cita.Facturada)
                throw new _exceptions.validatingException("La cita ya ha sido facturada y no puede ser borrada. Borre la operación asociada y vuelva a intentarlo.");


            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            return citaFacade.doDelete(_cita);
        }
    }
}
