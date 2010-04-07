using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.evento
{
    public class doGet : gesClinica.lib.bl._template.generalActionBL
    {
        Evento _evento;
        public doGet(Evento evento)
        {
            _evento = evento;
        }
        new public Evento execute()
        {
            return (Evento)base.execute();
        }
        protected override object accion()
        {
            if (_evento == null)
                throw new _exceptions.common.NullReferenceException(typeof(Evento), this.GetType().Name);

            gesClinica.lib.dao.evento.fachada eventoFacade = new gesClinica.lib.dao.evento.fachada();
            return eventoFacade.doGet(_evento);
        }
    }
}
