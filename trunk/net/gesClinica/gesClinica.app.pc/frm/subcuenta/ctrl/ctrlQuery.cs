using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.subcuenta.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        public ctrlQuery()
        {
            this._columnNameToRemember = "Codigo";
            this._propertyNameToRemember = "Codigo";
        }

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<SubCuenta> listaVO = (List<SubCuenta>)listObj;

                if (listaVO == null)
                    listaVO = new List<SubCuenta>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(SubCuenta).FullName);
                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("ContraPartida", typeof(SubCuenta));
                dt.Columns.Add("Haber", typeof(bool));
                dt.Columns.Add("Bloqueada", typeof(bool));
                dt.Columns.Add("objVO", typeof(SubCuenta));

                foreach (SubCuenta obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["Codigo"] = obj.Codigo;
                    dr["Descripcion"] = obj.Descripcion;
                    dr["ContraPartida"] = obj.ContraPartida;
                    dr["Haber"] = obj.Haber;
                    dr["Bloqueada"] = obj.Bloqueada;
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
                SubCuenta objVO = (SubCuenta)this.getRegistroSeleccionado(ref frm);
                lib.bl.subcuenta.doDelete lnSubCuenta = new gesClinica.lib.bl.subcuenta.doDelete(objVO);
                lnSubCuenta.execute();

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
                lib.bl.subcuenta.doGetAll lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAll();
                List<SubCuenta> ds = lnSubCuenta.execute();
                if (ds == null) ds = new List<SubCuenta>();
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
                string descripcion = gesClinica.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                foreach (string cad in descripcion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((descripcion like '%{0}%') or (''='{0}')) ", cad);

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

                _vista.dgConsulta.Columns["Codigo"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["ContraPartida"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Haber"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Bloqueada"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

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
