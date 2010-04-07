using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.paciente.ctrl
{
    internal class ctrlEditMuyImportante: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditMuyImportante _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Paciente objVO = null;

                objVO = (Paciente)_vista.InnerVO;

                objVO.MuyImportante = _vista.txtMuyImportante.Text;

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
                _vista = (frmEditMuyImportante)frm;
                Paciente objVO = (Paciente)obj;

                _vista.InnerVO = objVO;

                _vista.txtMuyImportante.Text = objVO.MuyImportante;
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
                _vista = (frmEditMuyImportante)frm;
                Paciente objVO = (Paciente)getObject(ref frm, newRecord);

                lib.bl.paciente.doUpdateMuyImportante lnPaciente = new gesClinica.lib.bl.paciente.doUpdateMuyImportante(objVO);
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
                _vista = (frmEditMuyImportante)frm;

                //_vista.Aceptar.Location = new System.Drawing.Point(448, 11);
                //_vista.Cancelar.Location = new System.Drawing.Point(534, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
