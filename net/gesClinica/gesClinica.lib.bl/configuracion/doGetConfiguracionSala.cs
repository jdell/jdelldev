using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.configuracion
{
    public class doGetConfiguracionSala : gesClinica.lib.bl._template.generalActionBL
    {
        Sala _sala;
        public doGetConfiguracionSala(Sala sala)
        {
            _sala = sala;
        }
        new public Configuracion execute()
        {
            return (Configuracion)base.execute();
        }
        protected override object accion()
        {
            Configuracion res = new Configuracion(_sala);

            gesClinica.lib.dao.configuracion.fachada configuracionFacade = new gesClinica.lib.dao.configuracion.fachada();
            res = configuracionFacade.doGetByClaseYClave(res);

            if (res == null) res = new Configuracion(_sala);


            return res;
        }
    }
}
