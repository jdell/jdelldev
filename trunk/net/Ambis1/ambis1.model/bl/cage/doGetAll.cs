using System;
using System.Collections.Generic;
using System.Text;
using ambis1.model.vo;

namespace ambis1.model.bl.cage
{
    public class doGetAll : ambis1.model.bl._template.generalActionBL
    {
        public doGetAll()
        {
        }
        new public List<Cage> execute()
        {
            return (List<Cage>)base.execute();
        }
        protected override object accion()
        {
            ambis1.model.dao.cage.fachada cageFacade = new ambis1.model.dao.cage.fachada();
            return cageFacade.doGetAll();
        }
    }
}
