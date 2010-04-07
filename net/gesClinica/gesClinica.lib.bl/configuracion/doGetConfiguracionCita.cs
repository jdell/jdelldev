using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.configuracion
{
    public class doGetConfiguracionCita : gesClinica.lib.bl._template.generalActionBL
    {
        public doGetConfiguracionCita()
        {
        }
        new public Configuracion execute()
        {
            return (Configuracion)base.execute();
        }
        protected override object accion()
        {
            Configuracion res = new Configuracion(new EstadoCita());

            gesClinica.lib.dao.configuracion.fachada configuracionFacade = new gesClinica.lib.dao.configuracion.fachada();
            res = configuracionFacade.doGetByClase(res);

            if (res == null) res = new Configuracion(new EstadoCita());


            return res;
        }
    }
}
