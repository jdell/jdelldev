using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipofestivo
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        TipoFestivo _tipofestivo;
        public doGet(TipoFestivo tipofestivo)
        {
            _tipofestivo = tipofestivo;
        }
        new public TipoFestivo execute()
        {
            return (TipoFestivo)base.execute();
        }
        protected override object accion()
        {
            if (_tipofestivo == null)
                throw new _exceptions.common.NullReferenceException(typeof(TipoFestivo), this.GetType().Name);

            gesClinica.lib.dao.tipofestivo.fachada tipofestivoFacade = new gesClinica.lib.dao.tipofestivo.fachada();
            return tipofestivoFacade.doGet(_tipofestivo);
        }
    }
}
