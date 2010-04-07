using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doGetAllPorPaciente : citaActionBL
    {
        Paciente _paciente;
        bool _full;
        public doGetAllPorPaciente(Paciente paciente, bool full)
        {
            _paciente = paciente;
            _full = full;
        }
        new public List<Cita> execute()
        {
            return (List<Cita>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            List<Cita> listCita = (List < Cita >) citaFacade.doGetAll(_paciente);

            if (_full)
            {
                gesClinica.lib.dao.receta.fachada recetaFacade = new gesClinica.lib.dao.receta.fachada();
                foreach (Cita cita in listCita)
                {
                    cita.Receta = recetaFacade.doGetAll(cita);

                    #region Cargar Detalle Recetas

                    foreach (Receta receta in cita.Receta)
                    {
                        gesClinica.lib.dao.recetadetalle.fachada recetadetalleFacade = new gesClinica.lib.dao.recetadetalle.fachada();
                        receta.Detalle = recetadetalleFacade.doGetAll(receta);
                    }

                    #endregion
                }
            }

            return listCita;
        }
    }
}
