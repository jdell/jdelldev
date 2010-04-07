using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.client.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Client objVO = null;
                objVO = (Client)_vista.InnerVO;

                objVO.AdditionalContactPhone = _vista.txtAdditionalContactPhone.Text;
                objVO.CellPhoneNumber = _vista.txtCellPhoneNumber.Text;
                objVO.Comments= _vista.txtComments.Text;
                objVO.EmailAddress= _vista.txtEmailAddress.Text;
                objVO.EmergencyContact= _vista.txtEmergencyContact.Text;
                objVO.FirstName= _vista.txtFirstName.Text;
                objVO.HomeAddress= _vista.homeAddress.txtAddress.Text;
                objVO.HomeCity= _vista.homeAddress.txtCity.Text;
                objVO.HomePhoneNumber= _vista.txtHomePhoneNumber.Text;
                objVO.HomeState= _vista.homeAddress.txtState.Text;
                objVO.HomeZipCode= _vista.homeAddress.txtZipCode.Text;
                //objVO.Inactive= _vista.txtAdditionalContactPhone.Text;
                objVO.LastName= _vista.txtLastName.Text;
                objVO.MailingAddress= _vista.mailingAddress.txtAddress.Text;
                objVO.MailingCity= _vista.mailingAddress.txtCity.Text;
                objVO.MailingState= _vista.mailingAddress.txtState.Text;
                objVO.MailingZipCode= _vista.mailingAddress.txtZipCode.Text;
                objVO.MiddleName= _vista.txtMiddleName.Text;
                objVO.PreferredFirstName= _vista.txtPreferredFirstName.Text;
                objVO.SSN= _vista.txtSSN.Text;
                objVO.CompanyName = _vista.txtCompanyName.Text;

                objVO.CreditScore = Convert.ToSingle(_vista.txtCreditScore.Text);

                if (_vista.dateDateOfBirth.Checked) objVO.DateOfBirth = _vista.dateDateOfBirth.Value;

                if (_vista.picPhoto.Image != null)
                    objVO.Photo = _vista.picPhoto.Image;
                else
                    objVO.Photo = null;

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
                Client objVO = (Client)obj;

                _vista.InnerVO = objVO;
                _vista.txtAdditionalContactPhone.Text = objVO.AdditionalContactPhone;
                _vista.txtCellPhoneNumber.Text = objVO.CellPhoneNumber;
                _vista.txtComments.Text = objVO.Comments;
                _vista.txtEmailAddress.Text = objVO.EmailAddress;
                _vista.txtEmergencyContact.Text = objVO.EmergencyContact;
                _vista.txtFirstName.Text = objVO.FirstName;
                _vista.txtHomePhoneNumber.Text = objVO.HomePhoneNumber;
                _vista.txtLastName.Text = objVO.LastName;
                _vista.txtMiddleName.Text = objVO.MiddleName;
                _vista.txtPreferredFirstName.Text = objVO.PreferredFirstName;
                _vista.txtSSN.Text = objVO.SSN;
                _vista.txtCompanyName.Text = objVO.CompanyName;

                _vista.homeAddress.txtAddress.Text = objVO.HomeAddress;
                _vista.homeAddress.txtCity.Text = objVO.HomeCity;
                _vista.homeAddress.txtState.Text = objVO.HomeState;
                _vista.homeAddress.txtZipCode.Text = objVO.HomeZipCode;

                _vista.mailingAddress.txtAddress.Text = objVO.MailingAddress;
                _vista.mailingAddress.txtCity.Text = objVO.MailingCity;
                _vista.mailingAddress.txtState.Text = objVO.MailingState;
                _vista.mailingAddress.txtZipCode.Text = objVO.MailingZipCode;

                if (objVO.Photo != null) _vista.picPhoto.Image = objVO.Photo;

                _vista.txtCreditScore.Text = objVO.CreditScore.ToString();

                if (objVO.DateOfBirth != DateTime.MinValue) _vista.dateDateOfBirth.Value = objVO.DateOfBirth;

                lib.bl.employment.doGetAll lnEmployment = new asr.lib.bl.employment.doGetAll(objVO);
                objVO.EmploymentHistory = lnEmployment.execute();
                System.Windows.Forms.Control cEmployment = (System.Windows.Forms.Control)_vista.tpageEmploymentHistory;
                _vista._frmEmployment.ShowDocked(ref cEmployment);

                lib.bl.skillscore.doGetAll lnSkillScore = new asr.lib.bl.skillscore.doGetAll(objVO);
                objVO.SkillScore = lnSkillScore.execute();
                System.Windows.Forms.Control cSkillScore = (System.Windows.Forms.Control)_vista.tpageSkillScore;
                _vista._frmSkillScore.ShowDocked(ref cSkillScore);
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
                Client objVO = (Client)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.client.doAdd lnClient = new asr.lib.bl.client.doAdd(objVO);
                    lnClient.execute();
                }
                else
                {
                    lib.bl.client.doUpdate lnClient = new asr.lib.bl.client.doUpdate(objVO);
                    lnClient.execute();
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

                _vista.homeAddress.Text = "Home";
                _vista.mailingAddress.Text = "Mail";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
