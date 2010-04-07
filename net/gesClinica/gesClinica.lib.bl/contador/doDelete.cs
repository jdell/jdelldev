using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.contador
{
    [Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.", true)]
    internal class doDelete : gesClinica.lib.bl._template.administrativoActionBL
    {
        Contador _contador;
        public doDelete(Contador contador)
        {
            _contador = contador;
        }
        new public Contador execute()
        {
            return (Contador)base.execute();
        }
        protected override object accion()
        {
            if (_contador == null)
                throw new _exceptions.common.NullReferenceException(typeof(Contador), this.GetType().Name);

            gesClinica.lib.dao.contador.fachada contadorFacade = new gesClinica.lib.dao.contador.fachada();
            return contadorFacade.doDelete(_contador);
        }
    }
}
