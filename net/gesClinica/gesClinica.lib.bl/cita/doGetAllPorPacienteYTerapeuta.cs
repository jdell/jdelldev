using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.bl.cita
{
    public class doGetAllPorPacienteYTerapeuta : citaActionBL
    {
        Paciente _paciente;
        Empleado _empleado;
        bool _full;
        public doGetAllPorPacienteYTerapeuta(Paciente paciente, Empleado empleado, bool full)
        {
            _paciente = paciente;
            _empleado = empleado;
            _full = full;
        }
        new public List<Cita> execute()
        {
            return (List<Cita>)base.execute();
        }
        protected override object accion()
        {
            gesClinica.lib.dao.cita.fachada citaFacade = new gesClinica.lib.dao.cita.fachada();
            List<Cita> listCita = (List<Cita>)citaFacade.doGetAll(_paciente, _empleado);
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
