using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion.ctrl
{
    internal class ctrlEditConfiguracionSala: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditConfiguracionSala _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Configuracion objVO = null;
                //if (newRecord)
                //{
                //    objVO = new Configuracion();
                //}
                //else
                //{
                //    objVO = (Configuracion)_vista.InnerVO;
                //}


                if ((Sala)_vista.cmbSala.SelectedItem!=null)
                    objVO = new Configuracion((Sala)_vista.cmbSala.SelectedItem);

                objVO.Childs.Clear();
                if ((Empleado)_vista.cmbEmpleado.SelectedItem != null)
                    objVO.Childs.Add(new Configuracion((Empleado)_vista.cmbEmpleado.SelectedItem));

                if ((Terapia)_vista.cmbTerapia.SelectedItem != null)
                    objVO.Childs.Add(new Configuracion((Terapia)_vista.cmbTerapia.SelectedItem));

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEditConfiguracionSala)frm;
                Configuracion objVO = (Configuracion)obj;

                _vista.InnerVO = objVO;

                //if (!string.IsNullOrEmpty(objVO.Clave)) _vista.cmbSala.SelectedValue = objVO.Clave;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEditConfiguracionSala)frm;
                Configuracion objVO = (Configuracion)getObject(ref frm, newRecord);
                lib.bl.configuracion.doSaveConfiguracionSala lnConfiguracion = new gesClinica.lib.bl.configuracion.doSaveConfiguracionSala(objVO);
                lnConfiguracion.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEditConfiguracionSala)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);
                
                // ********************* Empleado *********************
                gesClinica.lib.bl.empleado.doGetAllTerapeutas lnEmpleado = new gesClinica.lib.bl.empleado.doGetAllTerapeutas();
                _vista.cmbEmpleado.DataSource = lnEmpleado.execute();
                _vista.cmbEmpleado.DisplayMember = "FullName";
                _vista.cmbEmpleado.ValueMember = "ID";
                _vista.cmbEmpleado.SelectedIndex = -1;

                // ********************* Sala *********************
                gesClinica.lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
                _vista.cmbSala.DataSource = lnSala.execute();
                _vista.cmbSala.DisplayMember = "Descripcion";
                _vista.cmbSala.ValueMember = "ID";
                _vista.cmbSala.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cargarTerapias(ref frmEditConfiguracionSala frm)
        {
            try
            {
                _vista = frm;
                if (_vista.cmbEmpleado.SelectedItem != null)
                {
                    // ********************* Terapia *********************
                    gesClinica.lib.bl.terapia.doGetAllIn lnTerapia = new gesClinica.lib.bl.terapia.doGetAllIn((Empleado)_vista.cmbEmpleado.SelectedItem, true);
                    List<lib.vo.Terapia> listTerapia = lnTerapia.execute();
                    _vista.cmbTerapia.DataSource = listTerapia;
                    _vista.cmbTerapia.DisplayMember = "Descripcion";
                    _vista.cmbTerapia.ValueMember = "ID";
                    _vista.cmbTerapia.SelectedIndex = -1;
                }
                else
                    _vista.cmbTerapia.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void recuperarConfiguracion(ref frmEditConfiguracionSala frm)
        {
            try
            {
                _vista = frm;
                if (_vista.cmbSala.SelectedItem != null)
                {
                    Sala sala = (Sala)_vista.cmbSala.SelectedItem;
                    lib.bl.configuracion.doGetConfiguracionSala lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionSala(sala);
                    Configuracion configuracion = lnConfiguracion.execute();
                    if (configuracion != null)
                    {
                        Empleado empleado = null;
                        Terapia terapia = null;
                        foreach (Configuracion child in configuracion.Childs)
                        {
                            if (child.IsEmpleado())
                            {
                                empleado = new Empleado();
                                empleado.ID = Convert.ToInt32(child.Clave);
                            }
                            else if (child.IsTerapia())
                            {
                                terapia = new Terapia();
                                terapia.ID = Convert.ToInt32(child.Clave);
                            }                            
                        }
                        if (empleado != null) _vista.cmbEmpleado.SelectedValue = empleado.ID;
                        if (terapia != null) _vista.cmbTerapia.SelectedValue = terapia.ID;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
