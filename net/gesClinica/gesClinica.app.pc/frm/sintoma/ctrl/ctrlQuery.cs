using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.sintoma.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Sintoma> listaVO = (List<Sintoma>)listObj;

                if (listaVO == null)
                    listaVO = new List<Sintoma>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Sintoma).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("TipoSintoma", typeof(lib.vo.TipoSintoma));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("filtroTipoSintoma", typeof(string));
                dt.Columns.Add("objVO", typeof(Sintoma));

                foreach (Sintoma obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["TipoSintoma"] = obj.TipoSintoma;
                    dr["Descripcion"] = obj.Descripcion;
                    if (obj.TipoSintoma != null)
                        dr["filtroTipoSintoma"] = obj.TipoSintoma.ToString();
                    else
                        dr["filtroLaboratorio"] = string.Empty;
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
                Sintoma objVO = (Sintoma)this.getRegistroSeleccionado(ref frm);
                lib.bl.sintoma.doDelete lnSintoma = new gesClinica.lib.bl.sintoma.doDelete(objVO);
                lnSintoma.execute();

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
                lib.bl.sintoma.doGetAll lnSintoma = new gesClinica.lib.bl.sintoma.doGetAll();
                List<Sintoma> ds = lnSintoma.execute();
                if (ds == null) ds = new List<Sintoma>();
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

                //******* TipoSintoma ********
                if (_vista.cmbTipoSintoma.SelectedItem != null)
                {
                    string tipoSintoma = _vista.cmbTipoSintoma.SelectedItem.ToString();
                    filtro += string.Format(" AND ((filtroTipoSintoma like '%{0}%') or (''='{0}')) ", tipoSintoma);
                }

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
                _vista.dgConsulta.Columns["filtroTipoSintoma"].Visible = false;

                _vista.dgConsulta.Columns["TipoSintoma"].HeaderText = "Categoria";

                _vista.dgConsulta.Columns["TipoSintoma"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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

                // ********************* TipoSintoma *********************
                gesClinica.lib.bl.tiposintoma.doGetAll lnTipoSintoma = new gesClinica.lib.bl.tiposintoma.doGetAll();
                List<TipoSintoma> listTipoSintoma = lnTipoSintoma.execute();
                listTipoSintoma.Insert(0, new TipoSintoma());
                _vista.cmbTipoSintoma.DataSource = listTipoSintoma;
                _vista.cmbTipoSintoma.DisplayMember = "Descripcion";
                _vista.cmbTipoSintoma.ValueMember = "ID";
                _vista.cmbTipoSintoma.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
