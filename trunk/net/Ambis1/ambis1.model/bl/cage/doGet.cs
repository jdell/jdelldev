using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.cage
{
    public class doGet : ambis1.model.bl._template.generalActionBL
    {
        Cage _cage;
        public doGet(Cage cage)
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

            ambis1.model.dao.cage.fachada cageFacade = new ambis1.model.dao.cage.fachada();
            return cageFacade.doGet(_cage);
        }
    }
}
