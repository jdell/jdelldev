using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.serie
{
    public class doGetAll : asr.lib.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Serie> execute()
        {
            return (List<Serie>)base.execute();
        }
        protected override object accion()
        {
            asr.lib.dao.serie.fachada serieFacade = new asr.lib.dao.serie.fachada();
            return serieFacade.doGetAll();
        }
    }
}
