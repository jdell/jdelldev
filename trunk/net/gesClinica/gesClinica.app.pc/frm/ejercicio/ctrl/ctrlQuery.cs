using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.ejercicio.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Ejercicio> listaVO = (List<Ejercicio>)listObj;

                if (listaVO == null)
                    listaVO = new List<Ejercicio>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Ejercicio).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Empresa", typeof(Empresa));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("FechaInicial", typeof(DateTime));
                dt.Columns.Add("FechaFinal", typeof(DateTime));
                dt.Columns.Add("UltimaFacturaEmitida", typeof(int));
                dt.Columns.Add("UltimaFacturaRecibida", typeof(int));
                dt.Columns.Add("UltimoAsiento", typeof(int));
                dt.Columns.Add("objVO", typeof(Ejercicio));

                foreach (Ejercicio obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Empresa"] = obj.Empresa;
                    dr["Descripcion"] = obj.Descripcion;
                    dr["FechaInicial"] = obj.FechaInicial;
                    dr["FechaFinal"] = obj.FechaFinal;
                    dr["UltimaFacturaEmitida"] = obj.UltimaFacturaEmitida;
                    dr["UltimaFacturaRecibida"] = obj.UltimaFacturaRecibida;
                    dr["UltimoAsiento"] = obj.UltimoAsiento;
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
                Ejercicio objVO = (Ejercicio)this.getRegistroSeleccionado(ref frm);
                lib.bl.ejercicio.doDelete lnEjercicio = new gesClinica.lib.bl.ejercicio.doDelete(objVO);
                lnEjercicio.execute();

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
                List<Ejercicio> ds = null;
                if (this._vista.cmbEmpresa.SelectedItem != null)
                {
                    lib.bl.ejercicio.doGetAll lnEjercicio = new gesClinica.lib.bl.ejercicio.doGetAll((Empresa)this._vista.cmbEmpresa.SelectedItem);
                    ds = lnEjercicio.execute();
                }
                if (ds == null) ds = new List<Ejercicio>();
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

                _vista.dgConsulta.Columns["FechaInicial"].HeaderText = "Inicio";
                _vista.dgConsulta.Columns["FechaFinal"].HeaderText = "Fin";
                _vista.dgConsulta.Columns["UltimaFacturaEmitida"].HeaderText = "F.Emitidas";
                _vista.dgConsulta.Columns["UltimaFacturaRecibida"].HeaderText = "F.Recibidas";
                _vista.dgConsulta.Columns["UltimoAsiento"].HeaderText = "Asientos";

                _vista.dgConsulta.Columns["Empresa"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["FechaInicial"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["FechaFinal"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["UltimaFacturaEmitida"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["UltimaFacturaRecibida"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["UltimoAsiento"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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

                // ********************* Razón Social *********************
                gesClinica.lib.bl.empresa.doGetAll lnEmpresa = new gesClinica.lib.bl.empresa.doGetAll();
                List<Empresa> listEmpresa = lnEmpresa.execute();
                //listEmpresa.Sort(sortEmpresa);
                _vista.cmbEmpresa.DataSource = listEmpresa;
                _vista.cmbEmpresa.DisplayMember = "RazonSocial";
                _vista.cmbEmpresa.ValueMember = "ID";
                _vista.cmbEmpresa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
