using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tercero.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Tercero> listaVO = (List<Tercero>)listObj;

                if (listaVO == null)
                    listaVO = new List<Tercero>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Tercero).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("SubCuenta", typeof(SubCuenta));
                dt.Columns.Add("Nif", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("objVO", typeof(Tercero));

                foreach (Tercero obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["SubCuenta"] = obj.SubCuenta;
                    dr["Nif"] = obj.Nif;
                    dr["Nombre"] = obj.Nombre;
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
                Tercero objVO = (Tercero)this.getRegistroSeleccionado(ref frm);
                lib.bl.tercero.doDelete lnTercero = new gesClinica.lib.bl.tercero.doDelete(objVO);
                lnTercero.execute();

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
                lib.bl.tercero.doGetAll lnTercero = new gesClinica.lib.bl.tercero.doGetAll();
                List<Tercero> ds = lnTercero.execute();
                if (ds == null) ds = new List<Tercero>();
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
                
                //***************************

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

                _vista.dgConsulta.Columns["Nombre"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["SubCuenta"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Nif"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["SubCuenta"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
