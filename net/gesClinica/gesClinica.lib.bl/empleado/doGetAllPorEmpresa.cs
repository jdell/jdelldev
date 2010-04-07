using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.empleado
{
    public class doGetAllPorEmpresa : empleadoActionBL
    {
        private Empresa _empresa = null;

        public doGetAllPorEmpresa(Empresa empresa)
        {
            this.Permiso |= tPERMISO.TERAPEUTA | tPERMISO.ADMINISTRATIVO;
            this._empresa = empresa;
        }

        new public List<Empleado> execute()
        {
            return (List<Empleado>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.empleado.fachada empleadoFacade = new gesClinica.lib.dao.empleado.fachada();
            return empleadoFacade.doGetAll(_empresa);
        }
    }
}
