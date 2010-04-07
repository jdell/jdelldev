using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.tercero
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        Tercero _tercero;
        public doAdd(Tercero tercero)
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

            if (_tercero.SubCuenta == null)
                throw new _exceptions.tercero.MissingSubCuentaException();

            if (string.IsNullOrEmpty(_tercero.Nombre))
                throw new _exceptions.tercero.MissingNombreException();

            gesClinica.lib.dao.tercero.fachada terceroFacade = new gesClinica.lib.dao.tercero.fachada();
            return terceroFacade.doAdd(_tercero);
        }
    }
}
