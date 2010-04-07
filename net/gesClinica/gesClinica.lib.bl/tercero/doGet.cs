using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tercero
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        Tercero _tercero;
        public doGet(Tercero tercero)
        {
            _tercero = tercero;
        }
        new public Tercero execute()
        {
            return (Tercero)base.execute();
        }
        protected override object accion()
        {
            if (_tercero == null)
                throw new _exceptions.common.NullReferenceException(typeof(Tercero), this.GetType().Name);

            gesClinica.lib.dao.tercero.fachada terceroFacade = new gesClinica.lib.dao.tercero.fachada();
            return terceroFacade.doGet(_tercero);
        }
    }
}
