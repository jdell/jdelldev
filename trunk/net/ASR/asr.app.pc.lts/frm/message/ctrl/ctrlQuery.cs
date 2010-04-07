using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.message.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Message> listaVO = (List<Message>)listObj;

                if (listaVO == null)
                    listaVO = new List<Message>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Message).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Staff_Id", typeof(Int32));
                dt.Columns.Add("From", typeof(string));
                dt.Columns.Add("Of", typeof(string));
                dt.Columns.Add("Urgent", typeof(bool));
                dt.Columns.Add("Checked", typeof(bool));
                dt.Columns.Add("objVO", typeof(Message));

                foreach (Message obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Staff_Id"] = obj.Staff.ID;
                    dr["Date"] = obj.Date;
                    dr["From"] = obj.From;
                    dr["Of"] = obj.Of;
                    dr["Urgent"] = obj.Urgent;
                    dr["Checked"] = obj.Checked;
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
                Message objVO = (Message)this.getRegistroSeleccionado(ref frm);
                lib.bl.message.doDelete lnMessage = new asr.lib.bl.message.doDelete(objVO);
                lnMessage.execute();

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
                lib.bl.message.doGetAll lnMessage = new asr.lib.bl.message.doGetAll();
                List<Message> ds = lnMessage.execute();
                if (ds == null) ds = new List<Message>();
                this._vista.dgConsulta.DataSource = this.ListVOToDataView(ds);

                this._vista.dgConsulta.Select();
                this.setEstiloGridRegistros(ref frm);
                this.filtrarRegistros(ref frm);
                //template._common.extend.Translate((repsol.forms.template.consulta.QueryForm)_vista);

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
                //string name = asr.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                //foreach (string cad in name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                //    filtro += string.Format(" AND ((text like '%{0}%') or (''='{0}')) ", cad);

                if (this._vista.cmbStaff.SelectedItem != null) filtro += string.Format(" AND ((Staff_Id = '{0}') or (''='{0}')) ", ((Staff)_vista.cmbStaff.SelectedItem).ID);

                filtro += string.Format(" AND (Checked = {0}) ", _vista.rbOnlyChecked.Checked);

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
                _vista.dgConsulta.Columns["Staff_Id"].Visible = false;

                _vista.dgConsulta.Columns["Date"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["From"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Of"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Urgent"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Checked"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["Date"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
