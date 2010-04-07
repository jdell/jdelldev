using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.invoice.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Invoice> listaVO = (List<Invoice>)listObj;

                if (listaVO == null)
                    listaVO = new List<Invoice>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Invoice).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Document", typeof(string));
                dt.Columns.Add("Client", typeof(Client));
                dt.Columns.Add("Payable", typeof(Payable));
                dt.Columns.Add("Paid", typeof(bool));
                dt.Columns.Add("objVO", typeof(Invoice));

                foreach (Invoice obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Date"] = obj.Date.Date;
                    dr["Document"] = obj.Document;
                    dr["Client"] = obj.Client;
                    dr["Payable"] = obj.Payable;
                    dr["Paid"] = !obj.Pending;
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
                Invoice objVO = (Invoice)this.getRegistroSeleccionado(ref frm);
                lib.bl.invoice.doDelete lnInvoice = new asr.lib.bl.invoice.doDelete(objVO);
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
                lib.bl.invoice.doGetAllIncomes lnInvoice = new asr.lib.bl.invoice.doGetAllIncomes();
                List<Invoice> ds = lnInvoice.execute();
                if (ds == null) ds = new List<Invoice>();
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

                ////******* Descripcion ********
                //string name = asr.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                //foreach (string cad in name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                //    filtro += string.Format(" AND ((description like '%{0}%') or (''='{0}')) ", cad);

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

                _vista.dgConsulta.Columns["Client"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                //_vista.dgConsulta.Columns["Income"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
                _vista.menuFiltrar.Enabled = false;
                _vista.chkVerFiltro.Checked = false;
                _vista.menuFiltrar.Checked = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
