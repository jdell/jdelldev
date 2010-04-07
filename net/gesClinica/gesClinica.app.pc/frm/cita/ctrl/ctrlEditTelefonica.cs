using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlEditTelefonica : template.frm.edicion.ctrl.EditCtrl
    {
        frmEditTelefonica _vista = null;

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
                objVO.EstadoCita = null;
                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Paciente = (Paciente)_vista.txtPaciente.Tag;
                objVO.Sala = null;
                objVO.Terapia = null;
                objVO.Duracion = 0;
                objVO.Presencial = false;

                objVO.Sintomas = (!string.IsNullOrEmpty(_vista.txtSintomas.RichTextBox.Text)) ? _vista.txtSintomas.RichTextBox.Rtf : string.Empty;
                objVO.Diagnostico = (!string.IsNullOrEmpty(_vista.txtDiagnostico.RichTextBox.Text)) ? _vista.txtDiagnostico.RichTextBox.Rtf : string.Empty;
                objVO.Tratamiento = (!string.IsNullOrEmpty(_vista.txtTratamiento.RichTextBox.Text)) ? _vista.txtTratamiento.RichTextBox.Rtf : string.Empty;

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
                _vista = (frmEditTelefonica)frm;
                Cita objVO = (Cita)obj;

                _vista.InnerVO = objVO;

                _vista.dateFecha.Value = objVO.Fecha;
                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Empleado != null) _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
                
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
                _vista = (frmEditTelefonica)frm;
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
                _vista = (frmEditTelefonica)frm;
                Cita objVO = (Cita)_vista.InnerVO;

                _vista.dateFecha.Value = objVO.Fecha.AddMinutes(objVO.Duracion);
                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Empleado != null) _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
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
                _vista = (frmEditTelefonica)frm;

                // ********************* Empleado *********************
                gesClinica.lib.bl.empleado.doGetAllTerapeutas lnEmpleado = new gesClinica.lib.bl.empleado.doGetAllTerapeutas();
                _vista.cmbEmpleado.DataSource = lnEmpleado.execute();
                _vista.cmbEmpleado.DisplayMember = "FullName";
                _vista.cmbEmpleado.ValueMember = "ID";
                _vista.cmbEmpleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setPaciente(ref cita.frmEditTelefonica frm, Paciente paciente)
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

    }
}
