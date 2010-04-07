using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.producto.productodetalle.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<ProductoDetalle> listaVO = (List<ProductoDetalle>)listObj;

                if (listaVO == null)
                    listaVO = new List<ProductoDetalle>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(ProductoDetalle).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Componente", typeof(gesClinica.lib.vo.Componente));
                dt.Columns.Add("Dosis", typeof(string));
                dt.Columns.Add("objVO", typeof(ProductoDetalle));

                foreach (ProductoDetalle obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Componente"] = obj.Componente;
                    dr["Dosis"] = obj.Dosis;
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
                ProductoDetalle objVO = (ProductoDetalle)this.getRegistroSeleccionado(ref frm);

                //Esta ventana sólo se abre desde la de producto.
                Producto producto = (Producto)((gesClinica.app.pc.frm.producto.frmEdit)_vista.ParentForm).InnerVO;

                producto.Detalle.Sort();
                int index = producto.Detalle.BinarySearch(objVO);
                if (index > -1) producto.Detalle.RemoveAt(index);

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

                if (_vista.IsFirstTime)
                {
                    lib.bl.productodetalle.doGetAll lnProductoDetalle = new gesClinica.lib.bl.productodetalle.doGetAll((Producto)((gesClinica.app.pc.frm.producto.frmEdit)_vista.ParentForm).InnerVO);
                    ((Producto)((gesClinica.app.pc.frm.producto.frmEdit)_vista.ParentForm).InnerVO).Detalle = lnProductoDetalle.execute();
                    _vista.IsFirstTime = false;
                }

                //TODO: Docked!
                //lib.bl.productodetalle.doGetAll lnProductoDetalle = new gesClinica.lib.bl.productodetalle.doGetAll();
                //List<ProductoDetalle> ds = lnProductoDetalle.execute();

                //Esta ventana sólo se abre desde la de producto.
                Producto producto = (Producto)((gesClinica.app.pc.frm.producto.frmEdit)_vista.ParentForm).InnerVO;
                List<ProductoDetalle> ds = producto.Detalle;
                if (ds == null) ds = new List<ProductoDetalle>();
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

                _vista.dgConsulta.Columns["Componente"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Dosis"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
