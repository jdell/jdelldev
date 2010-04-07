using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.client.customer.ctrl
{
    internal class ctrlQueryByCustomer:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQueryByCustomer _vista = null;

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
                dt.Columns.Add("Client", typeof(Client));
                dt.Columns.Add("Customer_Id", typeof(Int32));
                dt.Columns.Add("StartDate", typeof(DateTime));
                dt.Columns.Add("EndDate", typeof(DateTime));
                dt.Columns.Add("Shift", typeof(tSHIFT));
                dt.Columns.Add("ReasonForLeaving", typeof(String));
                dt.Columns.Add("objVO", typeof(Employment));

                foreach (Employment obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Client"] = obj.Client;
                    dr["StartDate"] = lib.common.constantes.vacio.IsEmpty(obj.StartDate) ? Convert.DBNull : obj.StartDate;
                    dr["EndDate"] = lib.common.constantes.vacio.IsEmpty(obj.EndDate) ? Convert.DBNull : obj.EndDate;
                    dr["Shift"] = obj.Shift;
                    dr["ReasonForLeaving"] = obj.ReasonForLeaving;
                    dr["Customer_Id"] = obj.Customer.ID;
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
                //_vista = (frmQueryByCustomer)frm;
                //CustomerScore objVO = (CustomerScore)this.getRegistroSeleccionado(ref frm);

                ////AQUI
                //Client client = (Client)((asr.app.pc.frm.client.frmEdit)_vista.ParentForm).InnerVO;

                //client.CustomerScore.Sort();
                //int index = client.CustomerScore.BinarySearch(objVO);
                //if (index > -1) client.CustomerScore.RemoveAt(index);

                //client.RefreshCustomer();

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
                _vista = (frmQueryByCustomer)frm;
                lib.bl.employment.doGetAll lnEmployment = new asr.lib.bl.employment.doGetAll();
                List<Employment> ds = lnEmployment.execute();
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
                _vista = (frmQueryByCustomer)frm;
                string filtro = "(1=1)";

                //******* Descripcion ********
                //string name = asr.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                //foreach (string cad in name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                //    filtro += string.Format(" AND ((description like '%{0}%') or (''='{0}')) ", cad);

                if (_vista.cmbCustomer.SelectedItem!=null)
                    if (((Customer)_vista.cmbCustomer.SelectedItem).ID != lib.common.constantes.vacio.ID)
                        filtro += string.Format(" AND (Customer_Id = {0}) ", ((Customer)_vista.cmbCustomer.SelectedItem).ID, lib.common.constantes.vacio.ID);


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
                _vista = (frmQueryByCustomer)frm;

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
                _vista = (frmQueryByCustomer)frm;
                _vista.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                _vista.dgConsulta.Columns["objVO"].Visible = false;
                _vista.dgConsulta.Columns["ID"].Visible = false;
                _vista.dgConsulta.Columns["Customer_Id"].Visible = false;

                _vista.dgConsulta.Columns["Client"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["StartDate"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["EndDate"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["ReasonForLeaving"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Shift"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                
                _vista.dgConsulta.Columns["StartDate"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                _vista.dgConsulta.Columns["EndDate"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                
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
                _vista = (frmQueryByCustomer)frm;
                _vista.menuFiltrar.Enabled = true;
                _vista.chkVerFiltro.Checked = true;
                _vista.menuFiltrar.Checked = true;

                lib.bl.customer.doGetAll doCustomer = new asr.lib.bl.customer.doGetAll();
                _vista.cmbCustomer.DataSource = doCustomer.execute();
                _vista.cmbCustomer.DisplayMember = "Name";
                _vista.cmbCustomer.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
