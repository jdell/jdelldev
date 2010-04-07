using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.cage
{
    public class doAdd : ambis1.model.bl._template.generalActionBL
    {
        Cage _cage;
        public doAdd(Cage cage)
        {
            _cage = cage;
        }
        new public Cage execute()
        {
            return (Cage)base.execute();
        }
        protected override object accion()
        {
            if (_cage == null)
                throw new _exceptions.common.NullReferenceException(typeof(Cage), this.GetType().Name);

            //if (string.IsNullOrEmpty(_cage.Description))
            //    throw new _exceptions.cage.MissingDescriptionException();

            ambis1.model.dao.cage.fachada cageFacade = new ambis1.model.dao.cage.fachada();
            return cageFacade.doAdd(_cage);
        }
    }
}
