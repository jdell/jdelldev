using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tarifa
{
    public class doGetAll :gesClinica.lib.bl._template.generalActionBL
    {
        private bool _soloActivo = false;
        public doGetAll()
        {
        }
        public doGetAll(bool soloActivo)
        {
            this._soloActivo = soloActivo;
        }
        new public List<Tarifa> execute()
        {
            return (List<Tarifa>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tarifa.fachada tarifaFacade = new gesClinica.lib.dao.tarifa.fachada();
            return tarifaFacade.doGetAll(_soloActivo);
        }
    }
}
