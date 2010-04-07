using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.serie
{
    public class doUpdate : asr.lib.bl._template.generalActionBL
    {
        Serie _serie;
        public doUpdate(Serie serie)
        {
            _serie = serie;
        }
        new public Serie execute()
        {
            return (Serie)base.execute();
        }
        protected override object accion()
        {
            if (_serie == null)
                throw new _exceptions.common.NullReferenceException(typeof(Serie), this.GetType().Name);

            if (string.IsNullOrEmpty(_serie.Description))
                throw new _exceptions.serie.MissingDescriptionException();

            asr.lib.dao.serie.fachada serieFacade = new asr.lib.dao.serie.fachada();
            return serieFacade.doUpdate(_serie);
        }
    }
}
