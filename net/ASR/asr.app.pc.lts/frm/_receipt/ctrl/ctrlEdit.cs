using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.lts.frm._receipt.ctrl
{
    class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                lib.vo.Invoice objVO = null;
                objVO = (lib.vo.Invoice)_vista.InnerVO;
                if (_vista.tabControl1.SelectedTab == _vista.tpageCashClient)
                {
                    if (_vista.txtCashClient.SelectedValue != null)
                        objVO.Client = (lib.vo.Client)_vista.txtCashClient.SelectedValue;
                }
                else
                {
                    objVO.Client = new lib.vo.Client();
                    objVO.Client.SSN= _vista.txtSSN.Text;
                    objVO.Client.CompanyName = _vista.txtCompanyName.Text;
                    objVO.Client.FirstName= _vista.txtFirstName.Text;
                    objVO.Client.LastName= _vista.txtLastName.Text;
                }
                objVO.Comment = _vista.txtComments.Text;
                objVO.Date = _vista.dtpDate.Value;
                objVO.Pending = !_vista.chkPaid.Checked;
                if (_vista.cmbPayable.SelectedItem != null) objVO.Payable = (lib.vo.Payable)_vista.cmbPayable.SelectedItem;
                if (_vista.cmbSerie.SelectedItem != null) objVO.Serie = (lib.vo.Serie)_vista.cmbSerie.SelectedItem;
                objVO.Date = _vista.dtpDate.Value;

                asr.lib.vo.InvoiceDetail line = new asr.lib.vo.InvoiceDetail();
                line.Amount = Convert.ToInt32(_vista.txtUnits.Value);
                if (_vista.cmbService.SelectedItem!=null)
                {
                    line.Service = (lib.vo.Service)_vista.cmbService.SelectedItem;
                    line.Description = line.Service.Description;
                }
                line.Price = Convert.ToSingle(_vista.txtPrice.Text);
                line.StateFee= Convert.ToSingle(_vista.txtStateFee.Text);

                objVO.Detail.Add(line);
                
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

                _vista.InnerVO = obj;
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

                lib.vo.Invoice objVO = (lib.vo.Invoice)getObject(ref frm, newRecord);

                if (newRecord)
                {
                    lib.bl.invoice.doAdd lnInvoice = new asr.lib.bl.invoice.doAdd(objVO);
                    objVO = lnInvoice.execute();
                }
                else
                {
                    lib.bl.invoice.doUpdate lnInvoice = new asr.lib.bl.invoice.doUpdate(objVO);
                    objVO = lnInvoice.execute();
                }
                _vista.InnerVO = objVO;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void loadService(ref repsol.forms.template.edicion.EditForm frm)
        {
            try
            {
                _vista = (frmEdit)frm;
                if (_vista.cmbService.SelectedItem != null)
                {
                    lib.vo.Service service = (lib.vo.Service)_vista.cmbService.SelectedItem;
                    _vista.txtStateFee.Text = service.StateFee.ToString();
                    _vista.txtPrice.Text = service.Price.ToString();
                }
                else
                {
                    _vista.txtPrice.ResetText();
                    _vista.txtStateFee.ResetText();
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

                _vista.Aceptar.Location = new System.Drawing.Point(303, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(383, 11);

                if (!_vista.IsNewRecord)
                    _vista.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                

                lib.bl.client.doGetAll doCustomer = new asr.lib.bl.client.doGetAll();
                _vista.txtCashClient.DataSource = doCustomer.execute().ToArray();
                //_vista.txtCompany.LostFocus += new EventHandler(txtCompany_LostFocus);

                lib.bl.service.doGetAllIncomes doService = new asr.lib.bl.service.doGetAllIncomes();
                _vista.cmbService.DataSource = doService.execute();
                _vista.cmbService.DisplayMember = "Description";
                _vista.cmbService.ValueMember = "ID";

                lib.bl.payable.doGetAll doPayable = new asr.lib.bl.payable.doGetAll();
                _vista.cmbPayable.DataSource = doPayable.execute();
                _vista.cmbPayable.DisplayMember = "Description";
                _vista.cmbPayable.ValueMember = "ID";

                lib.bl.serie.doGetAll doSerie = new asr.lib.bl.serie.doGetAll();
                _vista.cmbSerie.DataSource = doSerie.execute();
                _vista.cmbSerie.DisplayMember = "Description";
                _vista.cmbSerie.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
