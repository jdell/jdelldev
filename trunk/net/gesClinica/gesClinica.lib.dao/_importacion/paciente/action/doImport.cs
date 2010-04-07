using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.paciente.action
{
    class doImport : actionImport, gesClinica.lib.dao._common.plain.TransactionalPlainAction
    {
        List<vo.importacion.Paciente> _listOldPaciente;
        lib.vo.SubCuenta _subCuenta;

        public doImport(List<vo.importacion.Paciente> listOldPaciente, lib.vo.SubCuenta subCuenta)
        {
            _listOldPaciente = listOldPaciente;
            _subCuenta = subCuenta;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                lib.dao._importacion.tabla.dao.tablaDAO tablaDAO = new gesClinica.lib.dao._importacion.tabla.dao.tablaDAO();
                Tabla tabla = new Tabla(typeof(vo.importacion.Paciente).FullName);
                if (!tablaDAO.doCheckIfExists(factory.Command, tabla))
                {
                    c = 0;
                    t = _listOldPaciente.Count;
                    info = "Importando pacientes...";
                    this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                    //dao.pacienteDAO oldPacienteDAO = new gesClinica.lib.dao._importacion.paciente.dao.pacienteDAO();
                    lib.dao.paciente.dao.pacienteDAO newPacienteDAO = new gesClinica.lib.dao.paciente.dao.pacienteDAO();
                    lib.dao._importacion.relacion.dao.relacionDAO relacionDAO = new gesClinica.lib.dao._importacion.relacion.dao.relacionDAO();
                    
                    //List<vo.importacion.Paciente> listOldPaciente = (List<vo.importacion.Paciente>)oldPacienteDAO.doGetAll(factory.Command);
                    foreach (vo.importacion.Paciente paciente in _listOldPaciente)
                    {
                        c++;
                        this.OnProcessing(new gesClinica.lib.dao._events.ProgressEventArgs(info, c, t));

                        vo.importacion.Relacion relacion = new Relacion();
                        relacion.IdAntiguo = paciente.Codigo;
                        relacion.Tipo = typeof(vo.importacion.Paciente).FullName;
                        if (!relacionDAO.doCheckIfExists(factory.Command,relacion))
                        {
                            vo.Paciente newPaciente = paciente.ToNewGesClinica();
                            newPaciente.SubCuenta = _subCuenta;

                            Relacion relacionAux;

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = paciente.Club.ID;
                            relacionAux.Tipo = typeof(lib.vo.importacion.Club).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null) newPaciente.Tarifa.ID = Convert.ToInt32(relacionAux.IdNuevo);

                            relacionAux = new Relacion();
                            relacionAux.IdAntiguo = paciente.EstadoCivil;
                            relacionAux.Tipo = typeof(lib.vo.EstadoCivil).FullName;
                            relacionAux = relacionDAO.doGetByIDAntiguoAndTipo(factory.Command, relacionAux);
                            if (relacionAux != null)
                            {
                                newPaciente.EstadoCivil = new gesClinica.lib.vo.EstadoCivil();
                                newPaciente.EstadoCivil.ID = Convert.ToInt32(relacionAux.IdNuevo);
                            }
                            else
                            {
                                vo.EstadoCivil estadocivilTmp = new gesClinica.lib.vo.EstadoCivil();
                                estadocivilTmp.Descripcion = paciente.EstadoCivil;

                                estadocivil.dao.estadocivilDAO estadocivilDAO = new gesClinica.lib.dao.estadocivil.dao.estadocivilDAO();
                                estadocivilTmp.ID = Convert.ToInt32(estadocivilDAO.doAdd(factory.Command, estadocivilTmp));

                                relacionAux = new Relacion();
                                relacionAux.IdAntiguo = paciente.EstadoCivil;
                                relacionAux.IdNuevo = estadocivilTmp.ID.ToString();
                                relacionAux.Tipo = typeof(lib.vo.EstadoCivil).FullName;
                                relacionDAO.doAdd(factory.Command, relacionAux);

                                newPaciente.EstadoCivil = estadocivilTmp;
                            }

                            newPaciente.ID=Convert.ToInt32(newPacienteDAO.doAdd(factory.Command, newPaciente));
                            relacion.IdNuevo = newPaciente.ID.ToString();

                            relacionDAO.doAdd(factory.Command, relacion);
                        }
                    }
                    tablaDAO.doAdd(factory.Command, tabla);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
