using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.task.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Task> listaVO = (List<Task>)listObj;

                if (listaVO == null)
                    listaVO = new List<Task>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Task).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Priority", typeof(bool));
                dt.Columns.Add("Staff", typeof(Staff));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Completed", typeof(bool));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Staff_Id", typeof(Int32));
                dt.Columns.Add("objVO", typeof(Task));

                foreach (Task obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Priority"] = obj.Priority;
                    dr["Staff"] = obj.Staff;
                    if (obj.Staff != null)
                        dr["Staff_Id"] = obj.Staff.ID;
                    else
                        dr["Staff_Id"] = lib.common.constantes.vacio.ID;

                    dr["Description"] = obj.Description;
                    dr["Completed"] = obj.Completed;
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

        public override object BorrarRegistro(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                Task objVO = (Task)this.getRegistroSeleccionado(ref frm);
                lib.bl.task.doDelete lnTask = new asr.lib.bl.task.doDelete(objVO);
                lnTask.execute();

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
                lib.bl.task.doGetAll lnTask = new asr.lib.bl.task.doGetAll();
                List<Task> ds = lnTask.execute();
                if (ds == null) ds = new List<Task>();
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

                filtro += string.Format(" AND (Completed = {0}) ", _vista.rbOnlyCompleted.Checked);

                if (this._vista.cmbStaff.SelectedItem != null)
                    if (((Staff)_vista.cmbStaff.SelectedItem).ID != lib.common.constantes.vacio.ID)
                        filtro += string.Format(" AND ((Staff_Id = {0}) or (Staff_Id={1})) ", ((Staff)_vista.cmbStaff.SelectedItem).ID, lib.common.constantes.vacio.ID);

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
                _vista.dgConsulta.Columns["Priority"].Visible = false;

                _vista.dgConsulta.Columns["Description"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Completed"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Date"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Staff"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Priority"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["Date"].CellTemplate.Style.Format = "d";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        void dgConsulta_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                    frmQuery frm = (frmQuery)dgv.FindForm();
                    if (frm != null)
                    {
                        lib.vo.Task task = (lib.vo.Task)dgv.Rows[e.RowIndex].Cells["objVO"].Value;
                        if (task.Priority) dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.LightSalmon;
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
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

                _vista.dgConsulta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgConsulta_CellPainting);

                lib.bl.staff.doGetAll doStaff = new asr.lib.bl.staff.doGetAll();
                List<Staff> lsStaff = doStaff.execute();
                lsStaff.Insert(0, new Staff());
                _vista.cmbStaff.DataSource = lsStaff;
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
