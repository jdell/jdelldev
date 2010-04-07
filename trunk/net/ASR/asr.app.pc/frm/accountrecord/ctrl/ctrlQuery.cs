using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.accountrecord.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<AccountRecord> listaVO = (List<AccountRecord>)listObj;

                if (listaVO == null)
                    listaVO = new List<AccountRecord>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(AccountRecord).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Client", typeof(Client));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Amount", typeof(string));
                dt.Columns.Add("Incoming", typeof(bool));
                dt.Columns.Add("Reference", typeof(string));
                dt.Columns.Add("objVO", typeof(AccountRecord));

                foreach (AccountRecord obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Client"] = obj.Client;
                    dr["Date"] = obj.Date;
                    dr["Description"] = obj.Activity.Description;
                    dr["Amount"] = obj.Amount.ToString("c");
                    dr["Incoming"] = obj.Incoming;
                    dr["Reference"] = obj.Reference;
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
                AccountRecord objVO = (AccountRecord)this.getRegistroSeleccionado(ref frm);
                lib.bl.accountrecord.doDelete lnAccountRecord = new asr.lib.bl.accountrecord.doDelete(objVO);
                lnAccountRecord.execute();

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
                lib.bl.accountrecord.doGetAll lnAccountRecord = new asr.lib.bl.accountrecord.doGetAll(_vista.Client);
                List<AccountRecord> ds = lnAccountRecord.execute();
                if (ds == null) ds = new List<AccountRecord>();
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

                filtro += string.Format(" AND (date >= #{0}#) ", _vista.dtpDateFrom.Value.Date);
                filtro += string.Format(" AND (date <= #{0}#) ", _vista.dtpDateTo.Value.Date.AddDays(1));

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
                _vista.dgConsulta.Columns["Client"].Visible = false;
                _vista.dgConsulta.Columns["Incoming"].HeaderText = "Income";

                _vista.dgConsulta.Columns["Client"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Date"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Description"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Amount"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Incoming"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Reference"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["Date"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                _vista.dgConsulta.Columns["Date"].CellTemplate.Style.Format = "MM/dd/yyyy";
                _vista.dgConsulta.Columns["Amount"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Reference"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                //_vista.dgConsulta.Columns["Amount"].CellTemplate.Style.Format = "#.0,00";
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
                
                _vista.dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                _vista.dtpDateTo.Value = _vista.dtpDateFrom.Value.AddMonths(1).AddDays(-1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
