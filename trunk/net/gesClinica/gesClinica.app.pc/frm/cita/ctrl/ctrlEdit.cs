using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Cita objVO = null;
                if (newRecord)
                {
                    objVO = new Cita();
                }
                else
                {
                    objVO = (Cita)_vista.InnerVO;
                }

                objVO.Empleado = (Empleado)_vista.cmbEmpleado.SelectedItem;
                objVO.EstadoCita = (EstadoCita)_vista.cmbEstadoCita.SelectedItem;
                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Paciente = (Paciente)_vista.txtPaciente.Tag;
                objVO.Sala = (Sala)_vista.cmbSala.SelectedItem;
                objVO.Terapia = (Terapia)_vista.cmbTerapia.SelectedItem;
                objVO.Duracion = Convert.ToByte(_vista.txtDuracion.Value);
                objVO.Presencial = _vista.chkPresencial.Checked;

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
                _vista = (frmEdit)frm;
                Cita objVO = (Cita)obj;

                _vista.InnerVO = objVO;

                _vista.dateFecha.Value = objVO.Fecha;
                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Sala != null) _vista.cmbSala.SelectedValue = objVO.Sala.ID;
                if (objVO.Empleado != null) _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
                if (objVO.Terapia != null) _vista.cmbTerapia.SelectedValue = objVO.Terapia.ID;
                if (objVO.EstadoCita != null) _vista.cmbEstadoCita.SelectedValue = objVO.EstadoCita.ID;
                _vista.txtDuracion.Value = objVO.Duracion>=_vista.txtDuracion.Minimum?objVO.Duracion:_vista.txtDuracion.Minimum;
                _vista.chkPresencial.Checked = objVO.Presencial;
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
                _vista = (frmEdit)frm;
                Cita objVO = (Cita)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.cita.doAdd lnCita = new gesClinica.lib.bl.cita.doAdd(objVO);
                    objVO = lnCita.execute();
                }
                else
                {
                    lib.bl.cita.doUpdate lnCita = new gesClinica.lib.bl.cita.doUpdate(objVO);
                    objVO = lnCita.execute();
                }
                _vista.InnerVO = objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void recuperarDatos(ref repsol.forms.template.edicion.EditForm frm)
        {
            try 
	        {
                _vista = (frmEdit)frm;
                Cita objVO = (Cita)_vista.InnerVO;

                _vista.dateFecha.Value = objVO.Fecha.AddMinutes(objVO.Duracion);
                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Empleado != null) _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
                if (objVO.Sala != null) _vista.cmbSala.SelectedValue = objVO.Sala.ID;
                if (objVO.EstadoCita != null) _vista.cmbEstadoCita.SelectedValue = objVO.EstadoCita.ID;
                _vista.txtDuracion.Value = objVO.Duracion>=_vista.txtDuracion.Minimum?objVO.Duracion:_vista.txtDuracion.Minimum;
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
                _vista = (frmEdit)frm;

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

                // ********************* EstadoCita *********************
                gesClinica.lib.bl.estadocita.doGetAll lnEstadoCita = new gesClinica.lib.bl.estadocita.doGetAll();
                _vista.cmbEstadoCita.DataSource = lnEstadoCita.execute();
                _vista.cmbEstadoCita.DisplayMember = "Descripcion";
                _vista.cmbEstadoCita.ValueMember = "ID";
                _vista.cmbEstadoCita.SelectedIndex = -1;



                lib.bl.configuracion.doGetConfiguracionCita lnConfiguracion = new gesClinica.lib.bl.configuracion.doGetConfiguracionCita();
                Configuracion configuracionEstadoCita = lnConfiguracion.execute();

                if ((configuracionEstadoCita != null) && (!string.IsNullOrEmpty(configuracionEstadoCita.Clave))) _vista.cmbEstadoCita.SelectedValue = Convert.ToInt32(configuracionEstadoCita.Clave);
       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarConfiguracion(ref cita.frmEdit frm)
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

        public void setPaciente(ref cita.frmEdit frm, Paciente paciente)
        {
            try
            {
                _vista = frm;
                if (paciente != null)
                {
                    _vista.txtPaciente.Text = paciente.ToString();

                    lib.bl.paciente.doGetAviones lnAviones = new gesClinica.lib.bl.paciente.doGetAviones(paciente);
                    paciente.setAviones(lnAviones.execute());

                    if (paciente.Aviones != 0)
                    {
                        _vista.toolTip1.SetToolTip((System.Windows.Forms.Control)_vista.txtPaciente, string.Format("Atención! Este paciente ha tenido {0} aviones en los últimos 6 meses.", paciente.Aviones));
                        _vista.txtPaciente.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                    }
                    else
                    {
                        _vista.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
                        _vista.toolTip1.SetToolTip((System.Windows.Forms.Control)_vista.txtPaciente, string.Empty);
                    }
                }
                else
                {
                    _vista.txtPaciente.ResetText();
                    _vista.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
                    _vista.toolTip1.SetToolTip((System.Windows.Forms.Control)_vista.txtPaciente, string.Empty);
                }
                _vista.txtPaciente.Tag = paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setDuracion(ref cita.frmEdit frm, Terapia terapia)
        {
            try
            {
                _vista = frm;
                if (terapia!=null)
                    _vista.txtDuracion.Value= terapia.Duracion>=_vista.txtDuracion.Minimum?terapia.Duracion:_vista.txtDuracion.Minimum; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarTerapias(ref cita.frmEdit frm)
        {
            try
            {
                _vista = frm;
                if (_vista.cmbEmpleado.SelectedItem != null)
                {
                    // ********************* Terapia *********************
                    gesClinica.lib.bl.terapia.doGetAllIn lnTerapia = new gesClinica.lib.bl.terapia.doGetAllIn((Empleado)_vista.cmbEmpleado.SelectedItem,true);
                    List<lib.vo.Terapia> listTerapia = lnTerapia.execute();
                    listTerapia.Sort(sortTerapias);
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
        private int sortTerapias(lib.vo.Terapia one, lib.vo.Terapia other)
        {
            return one.Descripcion.CompareTo(other.Descripcion);
        }
    }
}
