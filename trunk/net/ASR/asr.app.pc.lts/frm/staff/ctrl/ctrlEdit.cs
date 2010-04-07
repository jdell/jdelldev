using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.staff.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Staff objVO = null;
                objVO = (Staff)_vista.InnerVO;

                objVO.Name = _vista.txtName.Text;
                objVO.Phone = _vista.txtPhone.Text;
               
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
                Staff objVO = (Staff)obj;

                _vista.InnerVO = objVO;
                _vista.txtName.Text = objVO.Name;
                _vista.txtPhone.Text = objVO.Phone;
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
                Staff objVO = (Staff)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.staff.doAdd lnStaff = new asr.lib.bl.staff.doAdd(objVO);
                    lnStaff.execute();
                }
                else
                {
                    lib.bl.staff.doUpdate lnStaff = new asr.lib.bl.staff.doUpdate(objVO);
                    lnStaff.execute();
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
