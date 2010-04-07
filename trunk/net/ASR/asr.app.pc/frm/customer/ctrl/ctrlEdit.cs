using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.customer.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Customer objVO = null;
                objVO = (Customer)_vista.InnerVO;

                objVO.Address = _vista.txtAddress.Text;
                objVO.City = _vista.txtCity.Text;
                objVO.State = _vista.txtState.Text;
                objVO.ZipCode = _vista.txtZipCode.Text;
                objVO.Fax = _vista.txtFax.Text;
                objVO.Phone = _vista.txtPhone.Text;
                objVO.Name = _vista.txtName.Text;
               
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
                Customer objVO = (Customer)obj;

                _vista.InnerVO = objVO;
                _vista.txtAddress.Text = objVO.Address;
                _vista.txtFax.Text = objVO.Fax;
                _vista.txtName.Text = objVO.Name;
                _vista.txtPhone.Text = objVO.Phone;

                _vista.txtCity.Text = objVO.City;
                _vista.txtState.Text = objVO.State;
                _vista.txtZipCode.Text = objVO.ZipCode;
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
                Customer objVO = (Customer)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.customer.doAdd lnCustomer = new asr.lib.bl.customer.doAdd(objVO);
                    lnCustomer.execute();
                }
                else
                {
                    lib.bl.customer.doUpdate lnCustomer = new asr.lib.bl.customer.doUpdate(objVO);
                    lnCustomer.execute();
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
