using System;
using System.Collections.Generic;
using System.Text;

using asr.lib.vo;

namespace asr.app.pc.frm.invoice.ctrl
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
                    objVO.Client.SSN = _vista.txtSSN.Text;
                    objVO.Client.CompanyName = _vista.txtCompanyName.Text;
                    objVO.Client.FirstName = _vista.txtFirstName.Text;
                    objVO.Client.LastName = _vista.txtLastName.Text;
                }
                objVO.Income = true;
                objVO.Comment = _vista.txtComments.Text;
                objVO.Date = _vista.dtpDate.Value;
                objVO.Pending = !_vista.chkPaid.Checked;
                if (_vista.cmbPayable.SelectedItem != null) objVO.Payable = (lib.vo.Payable)_vista.cmbPayable.SelectedItem;
                if (_vista.cmbSerie.SelectedItem != null) objVO.Serie = (lib.vo.Serie)_vista.cmbSerie.SelectedItem;
                objVO.Date = _vista.dtpDate.Value;

                objVO.Detail.Clear();
                foreach (System.Windows.Forms.DataGridViewRow dr in _vista.dgDetail.Rows)
                {
                    if (dr.IsNewRow) continue;

                    asr.lib.vo.InvoiceDetail line = new asr.lib.vo.InvoiceDetail();
                    line.Amount = Convert.ToInt32(dr.Cells["Amount"].Value);
                    line.Service = new Service();
                    line.Service.ID = Convert.ToInt32(dr.Cells["Service"].Value);
                    line.Description = dr.Cells["Service"].FormattedValue.ToString();
                    line.Price = Convert.ToSingle(dr.Cells["Price"].Value);
                    line.StateFee = Convert.ToSingle(dr.Cells["StateFee"].Value);

                    objVO.Detail.Add(line);
                }

                objVO.Payments.Clear();
                foreach (System.Windows.Forms.DataGridViewRow dr in _vista.dgPayments.Rows)
                {
                    if (dr.IsNewRow) continue;

                    asr.lib.vo.Payment payment = new asr.lib.vo.Payment();
                    payment.Amount = Convert.ToInt32(dr.Cells["Amount"].Value);
                    payment.Date = Convert.ToDateTime(dr.Cells["Date"].Value);

                    objVO.Payments.Add(payment);
                }
                
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

                lib.vo.Invoice objVO = (lib.vo.Invoice)obj;
                _vista.InnerVO = objVO;

                if (objVO.Serie != null) _vista.cmbSerie.SelectedValue = objVO.Serie.ID;
                if (objVO.Number!=0) _vista.txtNumber.Text = objVO.Number.ToString("0000");
                _vista.dtpDate.Value = objVO.Date;
                _vista.chkPaid.Checked = !objVO.Pending;
                if (objVO.Payable != null) _vista.cmbPayable.SelectedValue = objVO.Payable.ID;
                if (objVO.Client != null) _vista.txtCashClient.Text = objVO.Client.ToString();
                _vista.txtComments.Text = objVO.Comment;

                lib.bl.invoicedetail.doGetAllByInvoice doInvoiceDetail = new asr.lib.bl.invoicedetail.doGetAllByInvoice(objVO);
                objVO.Detail = doInvoiceDetail.execute(); 
                _vista.dgDetail.DataSource = ListVOToDataView(objVO.Detail);

                lib.bl.payment.doGetAllByInvoice doPayments = new asr.lib.bl.payment.doGetAllByInvoice(objVO);
                objVO.Payments = doPayments.execute();
                _vista.dgPayments.DataSource = ListVOToDataViewPayments(objVO.Payments);

                setStyleGrid();
                setStyleGridPayments();

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        protected System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<InvoiceDetail> listaVO = (List<InvoiceDetail>)listObj;

                if (listaVO == null)
                    listaVO = new List<InvoiceDetail>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(InvoiceDetail).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Service_Id", typeof(Int32));
                dt.Columns.Add("Amount", typeof(Single));
                dt.Columns.Add("Price", typeof(Single));
                dt.Columns.Add("StateFee", typeof(Single));
                dt.Columns.Add("Total", typeof(Single));
                dt.Columns.Add("objVO", typeof(InvoiceDetail));

                foreach (InvoiceDetail obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Description"] = obj.Description;
                    dr["Service_Id"] = obj.Service.ID;
                    dr["Amount"] = obj.Amount;
                    dr["Price"] = obj.Price;
                    dr["StateFee"] = obj.StateFee;
                    dr["Total"] = obj.Total;
                    dr["objVO"] = obj;

                    dt.Rows.Add(dr);
                }

                res.Table = dt;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected System.Data.DataView ListVOToDataViewPayments(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Payment> listaVO = (List<Payment>)listObj;

                if (listaVO == null)
                    listaVO = new List<Payment>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Payment).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Invoice_Id", typeof(Int32));
                dt.Columns.Add("Amount", typeof(Single));
                dt.Columns.Add("objVO", typeof(Payment));

                foreach (Payment obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Amount"] = obj.Amount;
                    dr["Invoice_Id"] = obj.Invoice.ID;
                    dr["Date"] = obj.Date;
                    dr["objVO"] = obj;

                    dt.Rows.Add(dr);
                }

                res.Table = dt;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void setStyleGrid()
        {
            _vista.dgDetail.Columns["objVO"].Visible = false;
            _vista.dgDetail.Columns["ID"].Visible = false;
            _vista.dgDetail.Columns["Description"].Visible = false;
            _vista.dgDetail.Columns["Service_Id"].Visible = false;

            _vista.dgDetail.Columns["Amount"].HeaderText = "Units";
            _vista.dgDetail.Columns["StateFee"].HeaderText = "Fees/Disc.";

            System.Windows.Forms.DataGridViewComboBoxColumn c = new System.Windows.Forms.DataGridViewComboBoxColumn();
            lib.bl.service.doGetAllIncomes doService = new asr.lib.bl.service.doGetAllIncomes();
            c.HeaderText = "Service";
            c.Name = "Service";
            c.DataSource = doService.execute();
            c.DisplayMember = "Description";
            c.ValueMember = "ID";
            c.DisplayIndex = 0;
            c.DataPropertyName = "Service_Id";
            _vista.dgDetail.Columns.Add(c);
            
            _vista.dgDetail.Columns["Service"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _vista.dgDetail.Columns["Price"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            _vista.dgDetail.Columns["Amount"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            _vista.dgDetail.Columns["Total"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            
            _vista.dgDetail.Columns["Price"].CellTemplate.Style.Format = "c";
            _vista.dgDetail.Columns["StateFee"].CellTemplate.Style.Format = "c";
            _vista.dgDetail.Columns["Total"].CellTemplate.Style.Format = "c";

            _vista.dgDetail.Columns["Price"].ReadOnly = true;
            _vista.dgDetail.Columns["Total"].ReadOnly = true;

            _vista.dgDetail.Columns["Price"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            _vista.dgDetail.Columns["StateFee"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            _vista.dgDetail.Columns["Amount"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            _vista.dgDetail.Columns["Total"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

        }
        private void setStyleGridPayments()
        {
            _vista.dgPayments.Columns["objVO"].Visible = false;
            _vista.dgPayments.Columns["ID"].Visible = false;
            _vista.dgPayments.Columns["Invoice_Id"].Visible = false;

            _vista.dgPayments.Columns["Amount"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            _vista.dgPayments.Columns["Date"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            _vista.dgPayments.Columns["Amount"].CellTemplate.Style.Format = "c";
            _vista.dgPayments.Columns["Date"].CellTemplate.Style.Format = "MM/dd/yyyy";

            _vista.dgPayments.Columns["Date"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            _vista.dgPayments.Columns["Amount"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

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
                //if (_vista.cmbService.SelectedItem != null)
                //{
                //    lib.vo.Service service = (lib.vo.Service)_vista.cmbService.SelectedItem;
                //    _vista.txtStateFee.Text = service.StateFee.ToString();
                //    _vista.txtPrice.Text = service.Price.ToString();
                //}
                //else
                //{
                //    _vista.txtPrice.ResetText();
                //    _vista.txtStateFee.ResetText();
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

                _vista.Aceptar.Location = new System.Drawing.Point(303, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(383, 11);

                _vista.cmbSerie.Enabled = _vista.IsNewRecord;
              
                lib.bl.client.doGetAll doCustomer = new asr.lib.bl.client.doGetAll();
                _vista.txtCashClient.DataSource = doCustomer.execute().ToArray();
                //_vista.txtCompany.LostFocus += new EventHandler(txtCompany_LostFocus);

                //lib.bl.service.doGetAll doService = new asr.lib.bl.service.doGetAll();
                //_vista.cmbService.DataSource = doService.execute();
                //_vista.cmbService.DisplayMember = "Description";
                //_vista.cmbService.ValueMember = "ID";

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
