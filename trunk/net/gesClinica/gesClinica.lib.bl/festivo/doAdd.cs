using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.festivo
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        List<Festivo> _festivo;
        public doAdd(List<Festivo> festivo)
        {
            _festivo = festivo;
        }
        new public Festivo execute()
        {
            return (Festivo)base.execute();
        }
        protected override object accion()
        {
            if (_festivo == null)
                throw new _exceptions.common.NullReferenceException(typeof(Festivo), this.GetType().Name);

            foreach (Festivo festivo in _festivo)
            {
                if (festivo.TipoFestivo == null)
                    throw new _exceptions.festivo.MissingTypeOfFestivoException();
            }
            
            gesClinica.lib.dao.festivo.fachada festivoFacade = new gesClinica.lib.dao.festivo.fachada();
            return festivoFacade.doAdd(_festivo);
        }
    }
}
