using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion.ctrl
{
    internal class ctrlQueryRazonSocial:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQueryRazonSocial _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Operacion> listaVO = (List<Operacion>)listObj;

                if (listaVO == null)
                    listaVO = new List<Operacion>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Operacion).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("Adeudado", typeof(float));
                dt.Columns.Add("Ingresos", typeof(float));
                dt.Columns.Add("Factura", typeof(string));
                dt.Columns.Add("objVO", typeof(Operacion));

                foreach (Operacion obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Descripcion"] = obj.Descripcion;
                    dr["Adeudado"] = obj.Adeudado;
                    dr["Ingresos"] = obj.Ingresos;
                    dr["Factura"] = obj.FacturaAntigua;
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
                _vista = (frmQueryRazonSocial)frm;
                Operacion objVO = (Operacion)this.getRegistroSeleccionado(ref frm);
                lib.bl.operacion.doDelete lnOperacion = new gesClinica.lib.bl.operacion.doDelete(objVO);
                lnOperacion.execute();

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
                _vista = (frmQueryRazonSocial)frm;
                lib.bl.operacion.doGetAllPorFechaYRazonSocial lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorFechaYRazonSocial(_vista.monthCalendar.Date);
                List<Operacion> ds = lnOperacion.execute();
                if (ds == null) ds = new List<Operacion>();
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
                _vista = (frmQueryRazonSocial)frm;
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
                _vista = (frmQueryRazonSocial)frm;

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
                _vista = (frmQueryRazonSocial)frm;
                _vista.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                _vista.dgConsulta.Columns["objVO"].Visible = false;
                _vista.dgConsulta.Columns["ID"].Visible = false;
                                
                _vista.dgConsulta.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Adeudado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Ingresos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Factura"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;

                _vista.dgConsulta.Columns["Adeudado"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Ingresos"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Factura"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
                _vista = (frmQueryRazonSocial)frm;

                _vista.dgConsulta.ContextMenuStrip = _vista.contextMenuCaja;

                _vista.Text += string.Format(" [{0}]", lib.bl._common.cache.EMPLEADO.Empresa.ToString());

                _vista.menuFiltrar.Enabled = false;
                _vista.chkVerFiltro.Checked = true;
                _vista.menuFiltrar.Checked = true;

                _vista.monthCalendar.Date = DateTime.Now.Date;
                repsol.forms.template.consulta.QueryForm qry = (repsol.forms.template.consulta.QueryForm)frm;
                ConsultaRegistros(ref qry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void anularFactura(lib.vo.Operacion operacion)
        {
            try
            {
                lib.bl.factura.doAnular lnFactura = new gesClinica.lib.bl.factura.doAnular(operacion);
                lnFactura.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public lib.vo.Factura obtenerFacturaAsociada(lib.vo.Operacion operacion)
        {
            try
            {
                lib.bl.factura.doGetPorOperacion lnFactura = new gesClinica.lib.bl.factura.doGetPorOperacion(operacion);
                return lnFactura.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool puedeFacturar(frmQueryRazonSocial frm)
        {
            try
            {
                _vista = (frmQueryRazonSocial)frm;
                repsol.forms.template.consulta.QueryForm qry = (repsol.forms.template.consulta.QueryForm)frm;
                
                return !((Operacion)this.getRegistroSeleccionado(ref qry)).Facturado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
