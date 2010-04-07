using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.client.employment.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Employment> listaVO = (List<Employment>)listObj;

                if (listaVO == null)
                    listaVO = new List<Employment>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Employment).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Customer", typeof(Customer));
                dt.Columns.Add("PositionHeld", typeof(string));
                dt.Columns.Add("StartDate", typeof(DateTime));
                dt.Columns.Add("objVO", typeof(Employment));

                foreach (Employment obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Customer"] = obj.Customer;
                    dr["PositionHeld"] = obj.PositionHeld;
                    dr["StartDate"] = obj.StartDate;
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
                //_vista = (frmQuery)frm;
                //Employment objVO = (Employment)this.getRegistroSeleccionado(ref frm);
                //lib.bl.employment.doDelete lnEmployment = new asr.lib.bl.employment.doDelete(objVO);
                //lnEmployment.execute();
                
                //return true;

                _vista = (frmQuery)frm;
                Employment objVO = (Employment)this.getRegistroSeleccionado(ref frm);

                //AQUI
                Client client = (Client)((asr.app.pc.frm.client.frmEdit)_vista.ParentForm).InnerVO;

                client.EmploymentHistory.Sort();
                int index = client.EmploymentHistory.BinarySearch(objVO);
                if (index > -1) client.EmploymentHistory.RemoveAt(index);

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
                //_vista = (frmQuery)frm;
                //lib.bl.employment.doGetAll lnEmployment = new asr.lib.bl.employment.doGetAll();
                //List<Employment> ds = lnEmployment.execute();
                //if (ds == null) ds = new List<Employment>();
                //this._vista.dgConsulta.DataSource = this.ListVOToDataView(ds);

                //this._vista.dgConsulta.Select();
                //this.setEstiloGridRegistros(ref frm);
                //this.filtrarRegistros(ref frm);

                _vista = (frmQuery)frm;
                Client client = (Client)((asr.app.pc.frm.client.frmEdit)_vista.ParentForm).InnerVO;
                List<Employment> ds = client.EmploymentHistory;
                if (ds == null) ds = new List<Employment>();
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
                //    filtro += string.Format(" AND ((name like '%{0}%') or (''='{0}')) ", cad);

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

                _vista.dgConsulta.Columns["Customer"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["PositionHeld"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["StartDate"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["StartDate"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                _vista.dgConsulta.Columns["StartDate"].CellTemplate.Style.Format = "d";
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
