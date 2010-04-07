using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipofestivo
{
    public class doGetAll : gesClinica.lib.bl._template.generalActionBL
    {
        new public List<TipoFestivo> execute()
        {
            return (List<TipoFestivo>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.tipofestivo.fachada tipofestivoFacade = new gesClinica.lib.dao.tipofestivo.fachada();
            return tipofestivoFacade.doGetAll();
        }
    }
}
