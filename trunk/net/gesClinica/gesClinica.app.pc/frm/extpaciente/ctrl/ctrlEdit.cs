using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.extpaciente.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                ExtPaciente objVO = null;
                if (_vista.InnerVO==null)
                {
                    objVO = new ExtPaciente();
                }
                else
                {
                    objVO = (ExtPaciente)_vista.InnerVO;
                }
                
                objVO.Abortos =Convert.ToInt32(_vista.txtAbortos.Text);
                objVO.Anticonceptivos= _vista.txtAnticonceptivos.Text;
                objVO.Cesareas= Convert.ToInt32(_vista.txtCesareas.Text);
                objVO.Dismenorrea = _vista.txtDismenorrea.Text;
                objVO.Dispareunemia = _vista.txtDispareunemia.Text;
                objVO.Gestaciones= Convert.ToInt32(_vista.txtGestaciones.Text);
                objVO.Hormonas = _vista.txtTratamientosHormonales.Text;

                objVO.Menarquia = Convert.ToInt32(_vista.txtMenarquia.Text);
                objVO.Menopausia = Convert.ToInt32(_vista.txtMenopausia.Text);
                objVO.MolestiasPelvicas = _vista.txtMolestiasPelvicas.Text;
                objVO.Observaciones = _vista.txtObservaciones.Text;
                objVO.Partos= Convert.ToInt32(_vista.txtPartos.Text);
                objVO.ReglaDuracion= Convert.ToInt32(_vista.txtReglaDuracion.Text);
                objVO.ReglaFrecuencia= Convert.ToInt32(_vista.txtReglaFrecuencia.Text);
                objVO.SindromePremenstrual= _vista.txtSindromePremenstrual.Text;
                objVO.Vivos= Convert.ToInt32(_vista.txtVivos.Text);

                objVO.Paciente = _vista.Paciente;

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

                ExtPaciente objVO = (ExtPaciente)obj;
                
                _vista.InnerVO = objVO;

                if (objVO == null) objVO = new ExtPaciente();

                    _vista.txtAbortos.Text = objVO.Abortos.ToString();
                    _vista.txtAnticonceptivos.Text = objVO.Anticonceptivos.ToString();
                    _vista.txtCesareas.Text = objVO.Cesareas.ToString();
                    _vista.txtDismenorrea.Text = objVO.Dismenorrea;
                    _vista.txtDispareunemia.Text = objVO.Dispareunemia;
                    _vista.txtGestaciones.Text = objVO.Gestaciones.ToString();
                    _vista.txtMenarquia.Text = objVO.Menarquia.ToString();
                    _vista.txtMenopausia.Text = objVO.Menopausia.ToString();
                    _vista.txtMolestiasPelvicas.Text = objVO.MolestiasPelvicas;
                    _vista.txtObservaciones.Text = objVO.Observaciones;
                    _vista.txtPaciente.Text = _vista.Paciente.ToString();
                    _vista.txtPartos.Text = objVO.Partos.ToString();
                    _vista.txtReglaDuracion.Text = objVO.ReglaDuracion.ToString();
                    _vista.txtReglaFrecuencia.Text = objVO.ReglaFrecuencia.ToString();
                    _vista.txtSindromePremenstrual.Text = objVO.SindromePremenstrual;
                    _vista.txtTratamientosHormonales.Text = objVO.Hormonas;
                    _vista.txtVivos.Text = objVO.Vivos.ToString();
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
                ExtPaciente objVO = (ExtPaciente)getObject(ref frm, newRecord);
                if (_vista.InnerVO==null)
                {
                    lib.bl.extpaciente.doAdd lnExtPaciente = new gesClinica.lib.bl.extpaciente.doAdd(objVO);
                    lnExtPaciente.execute();
                }
                else
                {
                    lib.bl.extpaciente.doUpdate lnExtPaciente = new gesClinica.lib.bl.extpaciente.doUpdate(objVO);
                    lnExtPaciente.execute();
                }
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

                _vista.Aceptar.Location = new System.Drawing.Point(448, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(534, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
