using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.message.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Message objVO = null;
                objVO = (Message)_vista.InnerVO;

                objVO.CalledToSeeYou = _vista.chkCalledToSeeYou.Checked;
                objVO.Checked = _vista.chkChecked.Checked;
                objVO.Date = _vista.dtpDate.Value;
                
                DateTime date = _vista.dtpDate.Value;
                DateTime time = _vista.dtpTime.Value;
                objVO.Date = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
 
                objVO.From= _vista.txtFrom.Text;
                objVO.Of= _vista.txtOf.Text;
                objVO.Phone= _vista.txtPhone.Text;
                objVO.PleaseCall= _vista.chkPleaseCall.Checked;
                objVO.ReturnedYourCall= _vista.chkReturnedYourCall.Checked;
                objVO.Staff= (Staff)_vista.cmbStaff.SelectedItem;
                objVO.Telephoned= _vista.chkTelephoned.Checked;
                objVO.Text= _vista.txtText.Text;
                objVO.Urgent = _vista.chkUrgent.Checked;
                objVO.VisitedYourOffice = _vista.chkVisitedYourOffice.Checked;
                objVO.WantsToSeeYou= _vista.chkWantsToSeeYou.Checked;
                objVO.WillCallAgain= _vista.chkWillCallAgain.Checked;
               
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
                Message objVO = (Message)obj;

                _vista.InnerVO = objVO;

                _vista.chkCalledToSeeYou.Checked = objVO.CalledToSeeYou;
                _vista.chkChecked.Checked = objVO.Checked;
                _vista.dtpDate.Value = objVO.Date;
                _vista.dtpTime.Value = objVO.Date;
                _vista.txtFrom.Text = objVO.From;
                _vista.txtOf.Text = objVO.Of;
                _vista.txtPhone.Text= objVO.Phone;
                _vista.chkPleaseCall.Checked= objVO.PleaseCall;
                _vista.chkReturnedYourCall.Checked= objVO.ReturnedYourCall;
                if (objVO.Staff!=null) _vista.cmbStaff.SelectedValue= objVO.Staff.ID;
                _vista.chkTelephoned.Checked = objVO.Telephoned;
                _vista.txtText.Text = objVO.Text;
                _vista.chkUrgent.Checked = objVO.Urgent;
                _vista.chkVisitedYourOffice.Checked = objVO.VisitedYourOffice;
                _vista.chkWantsToSeeYou.Checked = objVO.WantsToSeeYou;
                _vista.chkWillCallAgain.Checked = objVO.WillCallAgain;
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
                Message objVO = (Message)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.message.doAdd lnMessage = new asr.lib.bl.message.doAdd(objVO);
                    lnMessage.execute();
                }
                else
                {
                    lib.bl.message.doUpdate lnMessage = new asr.lib.bl.message.doUpdate(objVO);
                    lnMessage.execute();
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


                lib.bl.staff.doGetAll doStaff = new asr.lib.bl.staff.doGetAll();
                _vista.cmbStaff.DataSource = doStaff.execute();
                _vista.cmbStaff.DisplayMember = "FullName";
                _vista.cmbStaff.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
