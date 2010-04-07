using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.terapia
{
    public class doBind : gesClinica.lib.bl._template.generalActionBL
    {
        Terapia _first;
        Terapia _second;
        public doBind(Terapia first, Terapia second)
        {
            _first = first;
            _second = second;
        }
        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {
            if (_first == null)
                throw new _exceptions.common.NullReferenceException(typeof(Terapia), this.GetType().Name);

            //if (_second == null)
            //    throw new _exceptions.common.NullReferenceException(typeof(Terapia), this.GetType().Name);

            if ((_second != null) && (lib.common.constantes.vacio.IsEmpty(_second.ID)))
                _second = null;
            gesClinica.lib.dao.terapia.fachada terapiaFacade = new gesClinica.lib.dao.terapia.fachada();
            return terapiaFacade.doBind(_first, _second);
        }
    }
}
