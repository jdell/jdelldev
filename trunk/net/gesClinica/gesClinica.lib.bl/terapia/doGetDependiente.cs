using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.terapia
{
    public class doGetDependiente : gesClinica.lib.bl._template.generalActionBL
    {
        Terapia _terapia;
        public doGetDependiente(Terapia terapia)
        {
            _terapia = terapia;
        }
        new public Terapia execute()
        {
            return (Terapia)base.execute();
        }
        protected override object accion()
        {
            if (_terapia == null)
                throw new _exceptions.common.NullReferenceException(typeof(Terapia), this.GetType().Name);

            gesClinica.lib.dao.terapia.fachada terapiaFacade = new gesClinica.lib.dao.terapia.fachada();
            return terapiaFacade.doGetDependiente(_terapia);
        }
    }
}
