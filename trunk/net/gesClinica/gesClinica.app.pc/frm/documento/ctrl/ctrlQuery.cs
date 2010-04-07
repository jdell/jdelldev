using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.documento.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Documento> listaVO = (List<Documento>)listObj;

                if (listaVO == null)
                    listaVO = new List<Documento>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Documento).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Titulo", typeof(string));
                dt.Columns.Add("TipoDocumento", typeof(TipoDocumento));
                dt.Columns.Add("filtroTipoDocumento", typeof(string));
                dt.Columns.Add("objVO", typeof(Documento));

                foreach (Documento obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Titulo"] = obj.Titulo;
                    dr["TipoDocumento"] = obj.TipoDocumento;
                    if (obj.TipoDocumento != null)
                        dr["filtroTipoDocumento"] = obj.TipoDocumento.ToString();
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
                Documento objVO = (Documento)this.getRegistroSeleccionado(ref frm);
                lib.bl.documento.doDelete lnDocumento = new gesClinica.lib.bl.documento.doDelete(objVO);
                lnDocumento.execute();

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
                lib.bl.documento.doGetAll lnDocumento = new gesClinica.lib.bl.documento.doGetAll();
                List<Documento> ds = lnDocumento.execute();
                if (ds == null) ds = new List<Documento>();
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

                //******* Titulo ********
                string titulo = gesClinica.lib.common.funciones.filter.parseString(_vista.txtDescripcion.Text);
                foreach (string cad in titulo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((titulo like '%{0}%') or (''='{0}')) ", cad);

                //******* TipoDocumento ********
                if (_vista.cmbTipoDocumento.SelectedItem != null)
                {
                    string tipoDocumento = _vista.cmbTipoDocumento.SelectedItem.ToString();
                    filtro += string.Format(" AND ((filtroTipoDocumento like '%{0}%') or (''='{0}')) ", tipoDocumento);
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
                _vista.dgConsulta.Columns["filtroTipoDocumento"].Visible = false;

                _vista.dgConsulta.Columns["TipoDocumento"].HeaderText = "Tipo";

                _vista.dgConsulta.Columns["Titulo"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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

                // ********************* TipoDocumento *********************
                gesClinica.lib.bl.tipodocumento.doGetAll lnTipoDocumento = new gesClinica.lib.bl.tipodocumento.doGetAll();
                List<TipoDocumento> listTipoDocumento = lnTipoDocumento.execute();
                listTipoDocumento.Insert(0, new TipoDocumento());
                _vista.cmbTipoDocumento.DataSource = listTipoDocumento;
                _vista.cmbTipoDocumento.DisplayMember = "Descripcion";
                _vista.cmbTipoDocumento.ValueMember = "ID";
                _vista.cmbTipoDocumento.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
