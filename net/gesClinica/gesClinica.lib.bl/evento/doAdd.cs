using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.evento
{
    public class doAdd : gesClinica.lib.bl._template.generalActionBL
    {
        Evento _evento;
        public doAdd(Evento evento)
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

            if (string.IsNullOrEmpty(_evento.Descripcion))
                throw new _exceptions.evento.MissingDescriptionException();

            if (_evento.Empleado == null)
                throw new _exceptions.evento.MissingEmployeeException();

            if (_evento.Sala == null)
                throw new _exceptions.evento.MissingRoomException();

            if (_evento.EstadoEvento == null)
                throw new _exceptions.evento.MissingStateException();

            gesClinica.lib.dao.evento.fachada eventoFacade = new gesClinica.lib.dao.evento.fachada();
            return eventoFacade.doAdd(_evento);
        }
    }
}
