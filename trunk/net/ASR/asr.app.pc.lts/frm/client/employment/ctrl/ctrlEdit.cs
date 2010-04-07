using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.client.employment.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Employment objVO = null;
                objVO = (Employment)_vista.InnerVO;

                objVO.AdditionalCompensation = _vista.txtAdditionalCompensation.Text;
                objVO.BaseSalary = Convert.ToSingle(_vista.txtBaseSalary.Text);
                objVO.Bonus = Convert.ToSingle(_vista.txtBonus.Text);
                objVO.Client = _vista.Client;
                objVO.ContactTitle = _vista.txtContactAndTitle.Text;
                if (_vista.txtCompany.SelectedValue != null)
                    objVO.Customer = (Customer)_vista.txtCompany.SelectedValue;
                else
                {
                    objVO.Customer = new Customer();
                    objVO.Customer.Address = _vista.txtAddress.Text;
                    objVO.Customer.City = _vista.txtCity.Text;
                    objVO.Customer.Name = _vista.txtCompany.Text;
                    objVO.Customer.State = _vista.txtState.Text;
                    objVO.Customer.ZipCode= _vista.txtZipCode.Text;
                    objVO.Customer.Phone = _vista.txtPhoneNumber.Text;
                }
                if (_vista.dateEndDate.Checked)
                    objVO.EndDate = _vista.dateEndDate.Value;
                else
                    objVO.EndDate = lib.common.constantes.vacio.FECHA;

                if (_vista.dateEndPay.Checked) 
                    objVO.EndPay = _vista.dateEndPay.Value;
                else
                    objVO.EndPay = lib.common.constantes.vacio.FECHA;
                objVO.Gap = _vista.txtGap.Text;
                objVO.MayContact = _vista.rbMayContactYes.Checked;
                objVO.PhoneNumber = _vista.txtPhoneNumber.Text;
                objVO.PositionHeld = _vista.txtPositionHeld.Text;
                objVO.PrimaryResponsibilities = _vista.txtPrimaryResponsibilities.Text;
                objVO.ProvideNotice = _vista.rbProvideNoticeYes.Checked;
                objVO.ReasonForLeaving = _vista.txtReasonForLeaving.Text;
                objVO.ReasonIfNot = _vista.txtReasonIfNot.Text;
                //objVO.RelationShip
                if (_vista.dateStartDate.Checked) 
                    objVO.StartDate = _vista.dateStartDate.Value;
                else
                    objVO.StartDate = lib.common.constantes.vacio.FECHA;

                if (_vista.dateStartPay.Checked) 
                    objVO.StartPay = _vista.dateStartPay.Value;
                else
                    objVO.StartPay = lib.common.constantes.vacio.FECHA;
    
                //objVO.Address = _vista.txtAddress.Text;
                //objVO.City = _vista.txtCity.Text;
                //objVO.State = _vista.txtState.Text;
                //objVO.ZipCode = _vista.txtZipCode.Text;
                //objVO.Fax = _vista.txtFax.Text;
                //objVO.Phone = _vista.txtPhone.Text;
                //objVO.Name = _vista.txtName.Text;
               
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
                Employment objVO = (Employment)obj;

                if (objVO.Customer == null) objVO.Customer = new Customer();

                _vista.InnerVO = objVO;

                _vista.txtAdditionalCompensation.Text = objVO.AdditionalCompensation;
                _vista.txtAddress.Text = objVO.Customer.Address;
                _vista.txtBaseSalary.Text = objVO.BaseSalary.ToString();
                _vista.txtBonus.Text = objVO.Bonus.ToString();
                _vista.txtCity.Text = objVO.Customer.City;
                _vista.txtCompany.Text = objVO.Customer.Name;
                _vista.txtContactAndTitle.Text = objVO.ContactTitle;
                _vista.txtGap.Text = objVO.Gap;
                _vista.txtPhoneNumber.Text = objVO.PhoneNumber;
                _vista.txtPositionHeld.Text = objVO.PositionHeld;
                _vista.txtPrimaryResponsibilities.Text = objVO.PrimaryResponsibilities;
                _vista.txtReasonForLeaving.Text = objVO.ReasonForLeaving;
                _vista.txtReasonIfNot.Text = objVO.ReasonIfNot;
                _vista.txtState.Text = objVO.Customer.State;
                _vista.txtZipCode.Text = objVO.Customer.ZipCode;
                if (objVO.EndDate != DateTime.MinValue)
                {
                    _vista.dateEndDate.Value = objVO.EndDate;
                    _vista.dateEndDate.Checked = true;
                }
                else
                    _vista.dateEndDate.Checked = false;

                if (objVO.EndPay != DateTime.MinValue) 
                {
                    _vista.dateEndPay.Value = objVO.EndPay;
                    _vista.dateEndPay.Checked = true;
                }
                else
                    _vista.dateEndPay.Checked = false;

                if (objVO.StartDate != DateTime.MinValue) 
                {
                    _vista.dateStartDate.Value = objVO.StartDate;
                    _vista.dateStartDate.Checked = true;
                }
                else
                    _vista.dateStartDate.Checked = false;

                if (objVO.StartPay != DateTime.MinValue) 
                {
                    _vista.dateStartPay.Value = objVO.StartPay;
                    _vista.dateStartPay.Checked = true;
                }
                else
                    _vista.dateStartPay.Checked = false;
                
                _vista.rbMayContactNo.Checked = !objVO.MayContact;
                _vista.rbMayContactYes.Checked = objVO.MayContact;

                _vista.rbProvideNoticeNo.Checked = !objVO.ProvideNotice;
                _vista.rbProvideNoticeYes.Checked = objVO.ProvideNotice;

                //TODO: Relationship
                //_vista.rbRelationshipCoWorker.Checked = !objVO.MayContact;
                //_vista.rbRelationshipSubordinate.Checked = objVO.MayContact;
                //_vista.rbRelationshipSupervisor.Checked = objVO.RelationShip;
                
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
                Employment objVO = (Employment)getObject(ref frm, newRecord);

                Client client = (Client)((asr.app.pc.lts.frm.client.frmEdit)_vista.Owner).InnerVO;
                client.EmploymentHistory.Sort();
                int index = client.EmploymentHistory.IndexOf(objVO);
                if (index > -1)
                    client.EmploymentHistory[index] = objVO;
                else
                    client.EmploymentHistory.Add(objVO);

                ((asr.app.pc.lts.frm.client.frmEdit)_vista.Owner).InnerVO = client;

                //_vista = (frmEdit)frm;
                //Employment objVO = (Employment)getObject(ref frm, newRecord);
                //if (newRecord)
                //{
                //    lib.bl.employment.doAdd lnEmployment = new asr.lib.bl.employment.doAdd(objVO);
                //    lnEmployment.execute();
                //}
                //else
                //{
                //    lib.bl.employment.doUpdate lnEmployment = new asr.lib.bl.employment.doUpdate(objVO);
                //    lnEmployment.execute();
                //}
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

                lib.bl.customer.doGetAll doCustomer = new asr.lib.bl.customer.doGetAll();
                _vista.txtCompany.DataSource= doCustomer.execute().ToArray();
                _vista.txtCompany.LostFocus += new EventHandler(txtCompany_LostFocus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void txtCompany_LostFocus(object sender, EventArgs e)
        {
            setCustomer((template.controls.TextBoxKDBII)sender);
        }

        private void setCustomer(template.controls.TextBoxKDBII txt)
        {
            try
            {
                _vista = (frmEdit)txt.FindForm();
                Customer cust = (Customer)txt.SelectedValue;
                if (cust!=null)
                {
                    _vista.txtAddress.Text = cust.Address;
                    _vista.txtCity.Text = cust.City;
                    _vista.txtZipCode.Text = cust.ZipCode;
                    _vista.txtState.Text = cust.State;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
