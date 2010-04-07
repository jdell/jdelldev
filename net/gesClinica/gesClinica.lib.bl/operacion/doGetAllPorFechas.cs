using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.operacion
{
    internal class doGetAllPorFechas : gesClinica.lib.bl._template.generalActionBL
    {
        lib.common.tipos.ParDateTime _fechas;
        List<vo.tTIPOOPERACION> _tipos;
        public doGetAllPorFechas(lib.common.tipos.ParDateTime fechas, List<vo.tTIPOOPERACION> tipos)
        {
            _fechas = fechas;
            _tipos = tipos;
        }
        new public List<Operacion> execute()
        {
            return (List<Operacion>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.operacion.fachada operacionFacade = new gesClinica.lib.dao.operacion.fachada();
            List<Operacion> res = operacionFacade.doGetAll(_fechas, _tipos);

            res.Sort(sortByTipo);

            return res;
        }

        private int sortByTipo(Operacion one, Operacion other)
        {
            if (one.Tipo.CompareTo(other.Tipo)!=0)
                return one.Tipo.CompareTo(other.Tipo);
            else
                return one.ID.CompareTo(other.ID);
        }
    }
}
