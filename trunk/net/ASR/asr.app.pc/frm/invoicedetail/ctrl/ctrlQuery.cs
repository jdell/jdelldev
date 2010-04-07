using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.invoicedetail.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<InvoiceDetail> listaVO = (List<InvoiceDetail>)listObj;

                if (listaVO == null)
                    listaVO = new List<InvoiceDetail>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(InvoiceDetail).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Client", typeof(Client));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Amount", typeof(Single));
                dt.Columns.Add("Price", typeof(Single));
                dt.Columns.Add("Total", typeof(Single));
                dt.Columns.Add("Income", typeof(bool));
                dt.Columns.Add("objVO", typeof(InvoiceDetail));

                foreach (InvoiceDetail obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Date"] = obj.Invoice.Date;
                    dr["Client"] = obj.Invoice.Client;
                    dr["Description"] = obj.Description;
                    dr["Amount"] = obj.Amount;
                    dr["Price"] = obj.Price;
                    dr["Total"] = obj.Total;
                    dr["Income"] = obj.Invoice.Income;
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

        public override object BorrarRegistro(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                InvoiceDetail objVO = (InvoiceDetail)this.getRegistroSeleccionado(ref frm);
                lib.bl.invoice.doDelete lnInvoice = new asr.lib.bl.invoice.doDelete(objVO.Invoice);
                lnInvoice.execute();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ConsultaRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                lib.bl.invoicedetail.doGetAll lnInvoiceDetail = new asr.lib.bl.invoicedetail.doGetAll();
                List<InvoiceDetail> ds = lnInvoiceDetail.execute();
                if (ds == null) ds = new List<InvoiceDetail>();
                this._vista.dgConsulta.DataSource = this.ListVOToDataView(ds);

                this._vista.dgConsulta.Select();
                this.setEstiloGridRegistros(ref frm);
                this.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override object DataGridViewRowToVO(System.Windows.Forms.DataGridViewRow dr)
        {
            try
            {
                return dr.Cells["objVO"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void filtrarRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                string filtro = "(1=1)";

                //******* Descripcion ********
                string name = asr.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                foreach (string cad in name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((description like '%{0}%') or (''='{0}')) ", cad);

                //***************************
                
                this.filtrarDV(frm, filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override object getRegistroSeleccionado(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;

                if (_vista.dgConsulta.CurrentRow == null)
                    return null;

                return this.DataGridViewRowToVO(_vista.dgConsulta.CurrentRow);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void setEstiloGridRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                _vista.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                _vista.dgConsulta.Columns["objVO"].Visible = false;
                _vista.dgConsulta.Columns["ID"].Visible = false;

                _vista.dgConsulta.Columns["Description"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                _vista.dgConsulta.Columns["Price"].CellTemplate.Style.Format = "c";
                _vista.dgConsulta.Columns["Total"].CellTemplate.Style.Format = "c";

                _vista.dgConsulta.Columns["Date"].CellTemplate.Style.Format = "d";

                _vista.dgConsulta.Columns["Date"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                _vista.dgConsulta.Columns["Price"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Amount"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Total"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
                _vista = (frmQuery)frm;
                _vista.menuFiltrar.Enabled = true;
                _vista.chkVerFiltro.Checked = true;
                _vista.menuFiltrar.Checked = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
