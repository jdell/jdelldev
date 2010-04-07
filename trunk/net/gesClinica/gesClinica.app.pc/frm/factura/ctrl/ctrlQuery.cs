using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.factura.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Factura> listaVO = (List<Factura>)listObj;

                if (listaVO == null)
                    listaVO = new List<Factura>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Factura).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Fecha", typeof(DateTime));
                dt.Columns.Add("Numero", typeof(int));
                dt.Columns.Add("Empleado", typeof(lib.vo.Empleado));
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("Total", typeof(float));
                dt.Columns.Add("Contabilizada", typeof(bool));
                dt.Columns.Add("objVO", typeof(Factura));

                foreach (Factura obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Fecha"] = obj.Fecha;
                    dr["Numero"] = obj.Numero;
                    dr["Empleado"] = obj.Empleado;
                    dr["Cliente"] = obj.Cliente;
                    dr["Total"] = obj.Total;
                    dr["Contabilizada"] = obj.Contabilizada;

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
                Factura objVO = (Factura)this.getRegistroSeleccionado(ref frm);
                lib.bl.factura.doDelete lnFactura = new gesClinica.lib.bl.factura.doDelete(objVO);
                lnFactura.execute();

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
                List<Factura> ds = null;
                if (_vista.cmbEjercicio.SelectedItem != null)
                {
                    lib.bl.factura.doGetAll lnFactura = new gesClinica.lib.bl.factura.doGetAll((Ejercicio)this._vista.cmbEjercicio.SelectedItem);
                    ds= lnFactura.execute();
                }
                if (ds == null) ds = new List<Factura>();
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


                _vista.dgConsulta.Columns["Empleado"].HeaderText = "Terapeuta";

                _vista.dgConsulta.Columns["Fecha"].CellTemplate.Style.Format = "dd/MM/yyyy";
                _vista.dgConsulta.Columns["Total"].CellTemplate.Style.Format = "c";

                _vista.dgConsulta.Columns["Fecha"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                _vista.dgConsulta.Columns["Numero"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Total"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgConsulta.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Numero"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Empleado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Cliente"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Total"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Contabilizada"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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

                _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.toolStripMenuSeparadorImprimir);
                _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.imprimirFacturaToolStripMenuItem);


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

        public void loadEjercicio(ref frmQuery frm)
        {
            try
            {
                _vista = (frmQuery)frm;

                if (_vista.cmbEmpresa.SelectedItem != null)
                {
                    // ********************* Ejercicio *********************
                    gesClinica.lib.bl.ejercicio.doGetAll lnEjercicio = new gesClinica.lib.bl.ejercicio.doGetAll((Empresa)_vista.cmbEmpresa.SelectedItem);
                    List<Ejercicio> listEjercicio = lnEjercicio.execute();
                    listEjercicio.Sort(sortEjercicio);
                    _vista.cmbEjercicio.DataSource = listEjercicio;
                    _vista.cmbEjercicio.DisplayMember = "Descripcion";
                    _vista.cmbEjercicio.ValueMember = "ID";
                    if (_vista.cmbEjercicio.Items.Count > 0)
                        _vista.cmbEjercicio.SelectedIndex = 0;
                    else
                    {
                        repsol.forms.template.consulta.QueryForm qry = (repsol.forms.template.consulta.QueryForm)frm;
                        ConsultaRegistros(ref qry);
                    }
                }
                else
                    _vista.cmbEjercicio.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int sortEjercicio(Ejercicio one, Ejercicio two)
        {
            return -one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
