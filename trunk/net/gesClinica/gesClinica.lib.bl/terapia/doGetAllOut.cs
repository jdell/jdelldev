using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.terapia
{
    public class doGetAllOut : gesClinica.lib.bl._template.generalActionBL
    {
        private Empleado _empleado = null;
        private bool _soloActivo = false;

        public doGetAllOut(Empleado empleado)
        {
            _empleado = empleado;
        }
        public doGetAllOut(Empleado empleado, bool soloActivo)
        {
            _empleado = empleado;
            _soloActivo = soloActivo;
        }
        new public List<Terapia> execute()
        {
            return (List<Terapia>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.terapia.fachada terapiaFacade = new gesClinica.lib.dao.terapia.fachada();
            return terapiaFacade.doGetAllOut(_empleado, _soloActivo);
        }
    }
}
