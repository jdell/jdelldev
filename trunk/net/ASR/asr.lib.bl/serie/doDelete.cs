using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.serie
{
    public class doDelete : asr.lib.bl._template.generalActionBL
    {
        Serie _serie;
        public doDelete(Serie serie)
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

            asr.lib.dao.serie.fachada serieFacade = new asr.lib.dao.serie.fachada();
            return serieFacade.doDelete(_serie);
        }
    }
}
