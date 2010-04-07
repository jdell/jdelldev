using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.payable.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Payable objVO = null;
                objVO = (Payable)_vista.InnerVO;

                objVO.Description= _vista.txtDescription.Text;
               
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
                Payable objVO = (Payable)obj;

                _vista.InnerVO = objVO;
                _vista.txtDescription.Text = objVO.Description;
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
                Payable objVO = (Payable)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.payable.doAdd lnPayable = new asr.lib.bl.payable.doAdd(objVO);
                    lnPayable.execute();
                }
                else
                {
                    lib.bl.payable.doUpdate lnPayable = new asr.lib.bl.payable.doUpdate(objVO);
                    lnPayable.execute();
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

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
