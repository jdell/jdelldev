using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.lib.dao.cita.action
{
    class doUpdateDatosClinicos : gesClinica.lib.dao._common.plain.NonTransactionalPlainAction
    {

        Cita _cita = null;
        public doUpdateDatosClinicos(Cita cita)
        {
            _cita = cita;
        }

        #region PlainAction Members

        public object execute(gesClinica.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.citaDAO citaDAO = new gesClinica.lib.dao.cita.dao.citaDAO();
                _cita = (Cita)citaDAO.doUpdateDatosClinicos(factory.Command, _cita);

                /**********/
                    if (_cita.Receta != null)
                    {
                        receta.dao.recetaDAO recetaDAO = new gesClinica.lib.dao.receta.dao.recetaDAO();
                        if (_cita.Receta.Count > 0)
                        {
                            List<Receta> oldReceta = recetaDAO.doGetAll(factory.Command, _cita);
                            if (oldReceta.Count == 0)
                            {
                                foreach (Receta receta in _cita.Receta)
                                {
                                    receta.Cita = _cita;
                                    receta.ID = Convert.ToInt32(recetaDAO.doAdd(factory.Command, receta));
                                    if (receta.Detalle != null)
                                    {
                                        recetadetalle.dao.recetadetalleDAO recetaDetalleDAO = new gesClinica.lib.dao.recetadetalle.dao.recetadetalleDAO();
                                        foreach (RecetaDetalle recetaDetalle in receta.Detalle)
                                        {
                                            recetaDetalle.Receta = receta;
                                            recetaDetalleDAO.doAdd(factory.Command, recetaDetalle);   
                                        }
                                    }
                                }
                            }
                            else
                            {
                                oldReceta.Sort();
                                foreach (Receta receta in _cita.Receta)
                                {
                                    receta.Cita = _cita;
                                    int index = oldReceta.BinarySearch(receta);
                                    if (index > -1)
                                    {
                                        recetaDAO.doUpdate(factory.Command, receta);

                                        /*********************************************************/
                                        if (receta.Detalle != null)
                                        {
                                            recetadetalle.dao.recetadetalleDAO recetaDetalleDAO = new gesClinica.lib.dao.recetadetalle.dao.recetadetalleDAO();
                                            if (receta.Detalle.Count > 0)
                                            {
                                                List<RecetaDetalle> oldRecetaDetalle = recetaDetalleDAO.doGetAll(factory.Command, receta);
                                                if (oldRecetaDetalle.Count == 0)
                                                {
                                                    foreach (RecetaDetalle recetadetalle in receta.Detalle)
                                                    {
                                                        recetadetalle.Receta = receta;
                                                        recetaDetalleDAO.doAdd(factory.Command, recetadetalle);
                                                    }
                                                }
                                                else
                                                {
                                                    oldRecetaDetalle.Sort();
                                                    foreach (RecetaDetalle recetadetalle in receta.Detalle)
                                                    {
                                                        recetadetalle.Receta = receta;
                                                        int indexDetalle = oldRecetaDetalle.BinarySearch(recetadetalle);
                                                        if (indexDetalle > -1)
                                                        {
                                                            recetaDetalleDAO.doUpdate(factory.Command, recetadetalle);
                                                            oldRecetaDetalle.RemoveAt(indexDetalle);
                                                        }
                                                        else
                                                            recetaDetalleDAO.doAdd(factory.Command, recetadetalle);
                                                    }
                                                    foreach (RecetaDetalle recetadetalle in oldRecetaDetalle)
                                                        recetaDetalleDAO.doDelete(factory.Command, recetadetalle);
                                                }
                                            }
                                            else
                                                recetaDetalleDAO.doDeleteAll(factory.Command, receta);
                                        }
                                        /*********************************************************/

                                        oldReceta.RemoveAt(index);
                                    }
                                    else
                                    {
                                        receta.ID = Convert.ToInt32(recetaDAO.doAdd(factory.Command, receta));
                                        if (receta.Detalle != null)
                                        {
                                            recetadetalle.dao.recetadetalleDAO recetaDetalleDAO = new gesClinica.lib.dao.recetadetalle.dao.recetadetalleDAO();
                                            foreach (RecetaDetalle recetaDetalle in receta.Detalle)
                                            {
                                                recetaDetalle.Receta = receta;
                                                recetaDetalleDAO.doAdd(factory.Command, recetaDetalle);
                                            }
                                        }
                                    }
                                }
                                foreach (Receta receta in oldReceta)
                                    recetaDAO.doDelete(factory.Command, receta);
                            }
                        }
                        else
                            recetaDAO.doDeleteAll(factory.Command, _cita);
                    }


                    if (_cita.Anexo!=null)
                    {
                        anexo.dao.anexoDAO anexoDAO = new gesClinica.lib.dao.anexo.dao.anexoDAO();
                        if (_cita.Anexo.Count > 0)
                        {
                            List<Anexo> oldAnexo = anexoDAO.doGetAll(factory.Command, _cita);
                            if (oldAnexo.Count == 0)
                            {
                                foreach (Anexo anexo in _cita.Anexo)
                                {
                                    anexo.Cita = _cita;
                                    anexoDAO.doAdd(factory.Command, anexo);
                                }
                            }
                            else
                            {
                                oldAnexo.Sort();
                                foreach (Anexo anexo in _cita.Anexo)
                                {
                                    anexo.Cita = _cita;
                                    int index = oldAnexo.BinarySearch(anexo);
                                    if (index > -1)
                                    {
                                        anexoDAO.doUpdate(factory.Command, anexo);
                                        oldAnexo.RemoveAt(index);
                                    }
                                    else
                                        anexoDAO.doAdd(factory.Command, anexo);
                                }
                                foreach (Anexo anexo in oldAnexo)
                                    anexoDAO.doDelete(factory.Command, anexo);
                            }
                        }
                        else
                            anexoDAO.doDeleteAll(factory.Command, _cita);
                    }

                return _cita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
