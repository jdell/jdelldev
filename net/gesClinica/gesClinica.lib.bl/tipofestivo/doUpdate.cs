using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tipofestivo
{
    public class doUpdate : gesClinica.lib.bl._template.generalActionBL
    {
        TipoFestivo _tipofestivo;
        public doUpdate(TipoFestivo tipofestivo)
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

            if (string.IsNullOrEmpty(_tipofestivo.Descripcion))
                throw new _exceptions.tipofestivo.MissingDescriptionException();

            gesClinica.lib.dao.tipofestivo.fachada tipofestivoFacade = new gesClinica.lib.dao.tipofestivo.fachada();
            return tipofestivoFacade.doUpdate(_tipofestivo);
        }
    }
}
