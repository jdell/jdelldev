using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlEditProgramada: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditProgramada _vista = null;

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
                objVO.Fecha = _vista.dateFechaInicio.Value;
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
                _vista = (frmEditProgramada)frm;
                Cita objVO = (Cita)obj;

                _vista.InnerVO = objVO;

                _vista.dateFechaInicio.Value = objVO.Fecha;
                switch (objVO.Fecha.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        _vista.chkViernes.Checked = true;
                        break;
                    case DayOfWeek.Monday:
                        _vista.chkLunes.Checked = true;
                        break;
                    case DayOfWeek.Saturday:
                        _vista.chkSabado.Checked = true;
                        break;
                    case DayOfWeek.Sunday:
                        _vista.chkDomingo.Checked = true;
                        break;
                    case DayOfWeek.Thursday:
                        _vista.chkJueves.Checked = true;
                        break;
                    case DayOfWeek.Tuesday:
                        _vista.chkMartes.Checked = true;
                        break;
                    case DayOfWeek.Wednesday:
                        _vista.chkMiercoles.Checked = true;
                        break;
                }

                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Empleado != null) _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
                if (objVO.Terapia != null) _vista.cmbTerapia.SelectedValue = objVO.Terapia.ID;
                if (objVO.Sala != null) _vista.cmbSala.SelectedValue = objVO.Sala.ID;
                if (objVO.EstadoCita != null) _vista.cmbEstadoCita.SelectedValue = objVO.EstadoCita.ID;
                _vista.txtDuracion.Value = objVO.Duracion;
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
                _vista = (frmEditProgramada)frm;
                
                Cita objVO = (Cita)getObject(ref frm, newRecord);

                #region Fechas

                List<DateTime> fechas = new List<DateTime>();
                //fechas.Add(_vista.dateFechaInicio.Value);
                _vista.dateFechaFin.Value = _vista.dateFechaFin.Value.Date;
                _vista.dateFechaFin.Value.AddHours(_vista.dateFechaInicio.Value.Hour);
                _vista.dateFechaFin.Value.AddMinutes(_vista.dateFechaInicio.Value.Minute);
                _vista.dateFechaFin.Value.AddSeconds(_vista.dateFechaInicio.Value.Second);
                _vista.dateFechaFin.Value.AddMilliseconds(_vista.dateFechaInicio.Value.Millisecond);

                if (
                    _vista.chkDomingo.Checked 
                    || _vista.chkJueves.Checked 
                    || _vista.chkLunes.Checked 
                    || _vista.chkMartes.Checked 
                    || _vista.chkMiercoles.Checked 
                    || _vista.chkSabado.Checked 
                    || _vista.chkViernes.Checked 
                    )
                {
                    DateTime tmp = _vista.dateFechaInicio.Value;

                    
                    while (tmp <= _vista.dateFechaFin.Value)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (tmp > _vista.dateFechaFin.Value) break;

                            switch (tmp.DayOfWeek)
                            {
                                case DayOfWeek.Friday:
                                    if (_vista.chkViernes.Checked) fechas.Add(tmp);
                                    break;
                                case DayOfWeek.Monday:
                                    if (_vista.chkLunes.Checked) fechas.Add(tmp);
                                    break;
                                case DayOfWeek.Saturday:
                                    if (_vista.chkSabado.Checked) fechas.Add(tmp);
                                    break;
                                case DayOfWeek.Sunday:
                                    if (_vista.chkDomingo.Checked) fechas.Add(tmp);
                                    break;
                                case DayOfWeek.Thursday:
                                    if (_vista.chkJueves.Checked) fechas.Add(tmp);
                                    break;
                                case DayOfWeek.Tuesday:
                                    if (_vista.chkMartes.Checked) fechas.Add(tmp);
                                    break;
                                case DayOfWeek.Wednesday:
                                    if (_vista.chkMiercoles.Checked) fechas.Add(tmp);
                                    break;
                            }
                            tmp = tmp.AddDays(1);
                        }
                        tmp = tmp.AddDays(Convert.ToDouble((this._vista.txtCadaSemana.Value - 1) * 7));
                    }                    
                }

                //fechas.Add(_vista.dateFechaFin.Value);

                #endregion


                if (newRecord)
                {
                    lib.bl.cita.doAddProgramada lnCita = new gesClinica.lib.bl.cita.doAddProgramada(objVO, fechas);
                    lnCita.execute();
                }
                else
                {
                    lib.bl.cita.doUpdate lnCita = new gesClinica.lib.bl.cita.doUpdate(objVO);
                    lnCita.execute();
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
                _vista = (frmEditProgramada)frm;
                Cita objVO = (Cita)_vista.InnerVO;

                _vista.dateFechaInicio.Value = objVO.Fecha.AddMinutes(objVO.Duracion);
                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Empleado != null) _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
                if (objVO.Sala != null) _vista.cmbSala.SelectedValue = objVO.Sala.ID;
                if (objVO.EstadoCita != null) _vista.cmbEstadoCita.SelectedValue = objVO.EstadoCita.ID;
                _vista.txtDuracion.Value = objVO.Duracion;
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
                _vista = (frmEditProgramada)frm;

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

                /********************************************************/

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setPaciente(ref cita.frmEditProgramada frm, Paciente paciente)
        {
            try
            {
                _vista = frm;
                if (paciente != null)
                    _vista.txtPaciente.Text = paciente.ToString();
                else
                    _vista.txtPaciente.ResetText();
                _vista.txtPaciente.Tag = paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setDuracion(ref cita.frmEditProgramada frm, Terapia terapia)
        {
            try
            {
                _vista = frm;
                if (terapia!=null)
                    _vista.txtDuracion.Value= terapia.Duracion; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarTerapias(ref cita.frmEditProgramada frm)
        {
            try
            {
                _vista = frm;
                if (_vista.cmbEmpleado.SelectedItem != null)
                {
                    // ********************* Terapia *********************
                    gesClinica.lib.bl.terapia.doGetAllIn lnTerapia = new gesClinica.lib.bl.terapia.doGetAllIn((Empleado)_vista.cmbEmpleado.SelectedItem,true);
                    _vista.cmbTerapia.DataSource = lnTerapia.execute();
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


        public enum tPROGRAMACION
        {
            Semanalmente,
            Mensualmente
        }
    }
}
