using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.terapia
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        Terapia _terapia;
        public doAdd(Terapia terapia)
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

            if (string.IsNullOrEmpty(_terapia.Descripcion))
                throw new _exceptions.terapia.MissingDescriptionException();

            gesClinica.lib.dao.terapia.fachada terapiaFacade = new gesClinica.lib.dao.terapia.fachada();
            return terapiaFacade.doAdd(_terapia);
        }
    }
}
