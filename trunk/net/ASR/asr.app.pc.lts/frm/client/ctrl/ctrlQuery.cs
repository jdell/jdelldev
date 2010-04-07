using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.client.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Client> listaVO = (List<Client>)listObj;

                if (listaVO == null)
                    listaVO = new List<Client>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Client).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("HomePhoneNumber", typeof(string));
                dt.Columns.Add("CellPhoneNumber", typeof(string));
                dt.Columns.Add("Comments", typeof(string));
                dt.Columns.Add("objVO", typeof(Client));

                foreach (Client obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["FullName"] = obj.FullName;
                    dr["HomePhoneNumber"] = obj.HomePhoneNumber;
                    dr["CellPhoneNumber"] = obj.CellPhoneNumber;
                    dr["Comments"] = obj.Comments;
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
                Client objVO = (Client)this.getRegistroSeleccionado(ref frm);
                lib.bl.client.doDelete lnClient = new asr.lib.bl.client.doDelete(objVO);
                lnClient.execute();

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
                List<Client> ds = null;
                switch (_vista.ClientQuery)
                {
                    case tCLIENTQUERY.FULL_INFORMATION:
                        lib.bl.client.doGetAll lnClientFull = new asr.lib.bl.client.doGetAll();
                        ds = lnClientFull.execute();
                        break;
                    case tCLIENTQUERY.CREDIT_REPAIR_ONLY:
                        lib.bl.client.doGetAllCreditRepair lnClientCredit = new asr.lib.bl.client.doGetAllCreditRepair();
                        ds = lnClientCredit.execute();
                        break;
                    case tCLIENTQUERY.ACCOUNT_RECORD_ONLY:
                        lib.bl.client.doGetAllAccountRecord lnClientAccountRecord = new asr.lib.bl.client.doGetAllAccountRecord();
                        ds = lnClientAccountRecord.execute();
                        break;
                    default:
                        lib.bl.client.doGetAll lnClientDefault = new asr.lib.bl.client.doGetAll();
                        ds = lnClientDefault.execute();
                        break;
                }

                if (ds == null) ds = new List<Client>();
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

                //******* XX ********
                string name = asr.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                foreach (string cad in name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((fullname like '%{0}%') or (''='{0}')) ", cad);

                //******* XX ********
                string comm = asr.lib.common.funciones.filter.parseString(_vista.txtComments.Text);
                foreach (string cad in comm.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((comments like '%{0}%') or (''='{0}')) ", cad);

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
                _vista.dgConsulta.Columns["Comments"].Visible = false;

                _vista.dgConsulta.Columns["FullName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["HomePhoneNumber"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["CellPhoneNumber"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["HomePhoneNumber"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                _vista.dgConsulta.Columns["CellPhoneNumber"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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

                //_vista.superToolTipClient1.Visible = false;

                //_vista.dgConsulta.ShowCellToolTips = false;
                //_vista.dgConsulta.MouseMove += new System.Windows.Forms.MouseEventHandler(dgConsulta_MouseMove);
                //_vista.dgConsulta.Leave += new EventHandler(dgConsulta_Leave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //void dgConsulta_Leave(object sender, EventArgs e)
        //{

        //}

        //void dgConsulta_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        //{

        //}
    }
}
