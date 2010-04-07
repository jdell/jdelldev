using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.empleado
{
    public class doGetAll : empleadoActionBL
    {
        private bool _soloActivo = false;
        public doGetAll()
        {
            this.Permiso |= tPERMISO.TERAPEUTA | tPERMISO.ADMINISTRATIVO;
        }
        public doGetAll(bool soloActivo)
        {
            this._soloActivo = soloActivo;
            this.Permiso |= tPERMISO.TERAPEUTA;
        }

        new public List<Empleado> execute()
        {
            return (List<Empleado>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.empleado.fachada empleadoFacade = new gesClinica.lib.dao.empleado.fachada();
            return empleadoFacade.doGetAll(_soloActivo);
        }
    }
}
