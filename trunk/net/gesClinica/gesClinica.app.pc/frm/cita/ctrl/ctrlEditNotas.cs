using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlEditNotas: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditNotas _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Cita objVO = (Cita)_vista.InnerVO;

                objVO.Notas = _vista.txtNotas.Text;
                objVO.Paciente = (Paciente)_vista.txtPaciente.Tag;

                if (objVO.Paciente != null) objVO.Paciente.NotasAgenda = objVO.Notas;

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
                _vista = (frmEditNotas)frm;
                Cita objVO = (Cita)obj;

                _vista.InnerVO = objVO;

                _vista.txtNotas.Text = objVO.Notas;
                setPaciente(ref _vista, objVO.Paciente);
                if (objVO.Paciente != null)
                {
                    lib.bl.paciente.doGet lnPaciente = new gesClinica.lib.bl.paciente.doGet(objVO.Paciente);
                    Paciente paciente = lnPaciente.execute();
                    if (paciente != null) _vista.txtNotas.Text = paciente.NotasAgenda;
                }
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
                _vista = (frmEditNotas)frm;
                Cita objVO = (Cita)getObject(ref frm, newRecord);

                //lib.bl.cita.doUpdateNotas lnCita = new gesClinica.lib.bl.cita.doUpdateNotas(objVO);
                //lnCita.execute();

                lib.bl.paciente.doUpdateNotas lnPaciente = new gesClinica.lib.bl.paciente.doUpdateNotas(objVO.Paciente);
                lnPaciente.execute();
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
                _vista = (frmEditNotas)frm;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setPaciente(ref cita.frmEditNotas frm, Paciente paciente)
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
