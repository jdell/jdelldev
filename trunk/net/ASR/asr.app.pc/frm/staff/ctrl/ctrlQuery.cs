﻿using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.staff.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Staff> listaVO = (List<Staff>)listObj;

                if (listaVO == null)
                    listaVO = new List<Staff>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Staff).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("objVO", typeof(Staff));

                foreach (Staff obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Name"] = obj.Name;
                    dr["Phone"] = obj.Phone;
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
                Staff objVO = (Staff)this.getRegistroSeleccionado(ref frm);
                lib.bl.staff.doDelete lnStaff = new asr.lib.bl.staff.doDelete(objVO);
                lnStaff.execute();

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
                lib.bl.staff.doGetAll lnStaff = new asr.lib.bl.staff.doGetAll();
                List<Staff> ds = lnStaff.execute();
                if (ds == null) ds = new List<Staff>();
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
                    filtro += string.Format(" AND ((Name like '%{0}%') or (''='{0}')) ", cad);

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

                _vista.dgConsulta.Columns["Name"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
                //_vista.menuFiltrar.Enabled = true;
                //_vista.chkVerFiltro.Checked = true;
                //_vista.menuFiltrar.Checked = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}