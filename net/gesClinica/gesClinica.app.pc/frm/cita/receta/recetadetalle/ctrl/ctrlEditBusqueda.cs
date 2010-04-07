using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl
{
    internal class ctrlEditBusqueda: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditBusqueda _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                //RecetaDetalle objVO = null;
                //if (newRecord)
                //    objVO = new RecetaDetalle();
                //else
                //    objVO = (RecetaDetalle)_vista.InnerVO;

                //TODO: Receta
                //Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO;
                //objVO.Posologia = _vista.txtPosologia.Text;
                //objVO.Cantidad = Convert.ToInt32(_vista.txtCantidad.Text);
                //objVO.Producto = (Producto)_vista.txtProducto.Tag;
                //objVO.Receta = receta;

                //List<RecetaDetalle> objVO = new List<RecetaDetalle>();
                List<RecetaDetalle> objVO = (List<RecetaDetalle>)_vista.dgProductosSeleccionados.Tag;
                //List<Producto> listSeleccionado = (List<Producto>)_vista.dgProductosSeleccionados.Tag;
                //if (listSeleccionado != null)
                //{
                //    Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO;
                //    foreach (Producto producto in listSeleccionado)
                //    {
                //        RecetaDetalle recetaDetalle = new RecetaDetalle();
                //        recetaDetalle.Posologia = producto.Posologia;
                //        recetaDetalle.Cantidad = 1;
                //        recetaDetalle.Producto = producto;
                //        recetaDetalle.Receta = receta;

                //        objVO.Add(recetaDetalle);
                //    }
                //}

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;
                RecetaDetalle objVO = (RecetaDetalle)obj;

                _vista.InnerVO = objVO;

                //TODO: Receta
                //setProducto(ref _vista, objVO.Producto);
                //_vista.txtPosologia.Text = objVO.Posologia;
                //_vista.txtCantidad.Text = objVO.Cantidad.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;
                List<RecetaDetalle> objVO = (List<RecetaDetalle>)getObject(ref frm, newRecord);

                Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO;
                receta.Detalle.Sort();
                foreach (RecetaDetalle recetaDetalle in objVO)
                {
                    int index = receta.Detalle.IndexOf(recetaDetalle);
                    if (index > -1)
                        receta.Detalle[index] = recetaDetalle;
                    else
                        receta.Detalle.Add(recetaDetalle);                    
                }

                ((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO = receta;
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
                _vista = (frmEditBusqueda)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(704, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(785, 11);

                this._vista.dgProductos.DataSource = this.ProductoListVOToDataView(new List<Producto>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected System.Data.DataView ProductoListVOToDataView(List<Producto> listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Producto> listaVO = (List<Producto>)listObj;

                if (listaVO == null)
                    listaVO = new List<Producto>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Producto).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("Laboratorio", typeof(gesClinica.lib.vo.Laboratorio));
                dt.Columns.Add("Precio", typeof(float));
                dt.Columns.Add("Retirado", typeof(bool));
                dt.Columns.Add("filtroLaboratorio", typeof(string));
                dt.Columns.Add("objVO", typeof(Producto));

                foreach (Producto obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Descripcion"] = obj.Descripcion;
                    dr["Laboratorio"] = obj.Laboratorio;
                    dr["Precio"] = obj.Precio;
                    dr["Retirado"] = !obj.Activo;
                    if (obj.Laboratorio != null)
                        dr["filtroLaboratorio"] = obj.Laboratorio.ToString();
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
        public void ProductoSetEstiloGridRegistros(ref System.Windows.Forms.DataGridView dg)
        {
            try
            {
                dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                if (dg.Columns.Contains("objVO")) dg.Columns["objVO"].Visible = false;
                dg.Columns["ID"].Visible = false;
                if (dg.Columns.Contains("filtroLaboratorio")) dg.Columns["filtroLaboratorio"].Visible = false;

                dg.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns["Laboratorio"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                
                dg.Columns["Precio"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                dg.Columns["Precio"].DefaultCellStyle.Format = "c";

                if (dg.Columns.Contains("Retirado")) dg.Columns["Retirado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ProductoFiltrarRegistros(ref frmEditBusqueda frm)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;
                string filtro = "(1=1)";

                //******* Descripcion ********
                string descripcion = gesClinica.lib.common.funciones.filter.parseString(_vista.txtProductoDescripcion.Text);
                foreach (string cad in descripcion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((descripcion like '%{0}%') or (''='{0}')) ", cad);

                //******* Laboratorio ********
                string laboratorio = gesClinica.lib.common.funciones.filter.parseString(_vista.txtProductoLaboratorio.Text);
                foreach (string cad in laboratorio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((filtroLaboratorio like '%{0}%') or (''='{0}')) ", cad);

                //***************************

                ((System.Data.DataView)this._vista.dgProductos.DataSource).RowFilter = filtro;
                this._vista.dgProductos.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Producto ProductoGetRegistroSeleccionado(System.Windows.Forms.DataGridView dg)
        {
            try
            {
                if (dg.CurrentRow == null)
                    return null;

                return (Producto)dg.CurrentRow.Cells["objVO"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ProductoSetPosologia(ref frmEditBusqueda frm)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;
                setPosologiaInfo(ref frm, ProductoGetRegistroSeleccionado(_vista.dgProductos));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ProductoConsultaRegistros(ref frmEditBusqueda frm)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                //************ Productos *************
                lib.vo.filtro.FiltroProducto filtroProducto = new gesClinica.lib.vo.filtro.FiltroProducto();
                if (!string.IsNullOrEmpty(_vista.txtIndicacionDescripcion.Text))
                {
                    filtroProducto.Indicacion = new Indicacion();
                    filtroProducto.Indicacion.Descripcion = _vista.txtIndicacionDescripcion.Text;
                }
                if (!string.IsNullOrEmpty(_vista.txtProductoDescripcion.Text))
                {
                    filtroProducto.Producto = new Producto();
                    filtroProducto.Producto.Descripcion = _vista.txtProductoDescripcion.Text;
                }
                if (!string.IsNullOrEmpty(_vista.txtProductoLaboratorio.Text))
                {
                    filtroProducto.Laboratorio = new Laboratorio();
                    filtroProducto.Laboratorio.Nombre = _vista.txtProductoLaboratorio.Text;
                }

                lib.bl.producto.doGetAll lnProducto = new gesClinica.lib.bl.producto.doGetAll(filtroProducto);
                List<Producto> ds = lnProducto.execute();
                if (ds == null) ds = new List<Producto>();
                this._vista.dgProductos.DataSource = this.ProductoListVOToDataView(ds);
                System.Windows.Forms.DataGridView dg = _vista.dgProductos;
                ProductoFiltrarRegistros(ref _vista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
        public void ProductoAñadir(ref frmEditBusqueda frm)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;

                lib.vo.Producto producto = this.ProductoGetRegistroSeleccionado(_vista.dgProductos);
                if (producto != null)
                {
                    List<lib.vo.RecetaDetalle> listSeleccionado = (List<lib.vo.RecetaDetalle>)_vista.dgProductosSeleccionados.Tag;
                    if (listSeleccionado == null) listSeleccionado = new List<RecetaDetalle>();

                    Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO;
                    RecetaDetalle recetaDetalle = new RecetaDetalle();
                    recetaDetalle.Posologia = producto.Posologia;
                    recetaDetalle.Cantidad = 1;
                    recetaDetalle.Producto = producto;
                    recetaDetalle.Receta = receta;

                    listSeleccionado.Add(recetaDetalle);

                    _vista.dgProductosSeleccionados.DataSource = RecetaDetalleListVOToDataView(listSeleccionado);
                    _vista.dgProductosSeleccionados.Tag = listSeleccionado;
                    System.Windows.Forms.DataGridView dg = _vista.dgProductosSeleccionados;
                    RecetaDetalleSetEstiloGridRegistros(ref dg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ProductoQuitar(ref frmEditBusqueda frm)
        {
            try
            {
                _vista = (frmEditBusqueda)frm;

                lib.vo.RecetaDetalle recetaDetalle = this.RecetaDetalleGetRegistroSeleccionado(_vista.dgProductosSeleccionados);
                if (recetaDetalle != null)
                {
                    List<lib.vo.RecetaDetalle> listSeleccionado = (List<lib.vo.RecetaDetalle>)_vista.dgProductosSeleccionados.Tag;
                    if (listSeleccionado == null) listSeleccionado = new List<RecetaDetalle>();

                    listSeleccionado.Remove(recetaDetalle);

                    _vista.dgProductosSeleccionados.DataSource = RecetaDetalleListVOToDataView(listSeleccionado);
                    _vista.dgProductosSeleccionados.Tag = listSeleccionado;
                    System.Windows.Forms.DataGridView dg = _vista.dgProductosSeleccionados;
                    RecetaDetalleSetEstiloGridRegistros(ref dg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void setPosologiaInfo(ref frmEditBusqueda frm, Producto producto)
        {
            try
            {
                _vista = frm;

                if (producto != null)
                {
                    lib.bl.indicacion.doGetAllInIndicacion lnIndicacion = new gesClinica.lib.bl.indicacion.doGetAllInIndicacion(producto);
                    producto.Indicaciones = lnIndicacion.execute();

                    lib.bl.indicacion.doGetAllInContraIndicacion lnContraIndicacion = new gesClinica.lib.bl.indicacion.doGetAllInContraIndicacion(producto);
                    producto.ContraIndicaciones = lnContraIndicacion.execute();

                    lib.bl.productodetalle.doGetAll lnProductoDetalle = new gesClinica.lib.bl.productodetalle.doGetAll(producto);
                    producto.Detalle = lnProductoDetalle.execute();

                    _vista.txtPosologia.RichTextBox.Rtf = producto.AllInfoRTF();
                }
                else
                    _vista.txtPosologia.Text = string.Empty;
                _vista.txtPosologia.Tag = producto;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        
        protected System.Data.DataView RecetaDetalleListVOToDataView(List<RecetaDetalle> listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<RecetaDetalle> listaVO = (List<RecetaDetalle>)listObj;

                if (listaVO == null)
                    listaVO = new List<RecetaDetalle>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(RecetaDetalle).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Producto", typeof(gesClinica.lib.vo.Producto));
                dt.Columns.Add("Posologia", typeof(string));
                dt.Columns.Add("objVO", typeof(RecetaDetalle));

                foreach (RecetaDetalle obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Cantidad"] = obj.Cantidad;
                    dr["Producto"] = obj.Producto;
                    dr["Posologia"] = obj.Posologia;
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
        public void RecetaDetalleSetEstiloGridRegistros(ref System.Windows.Forms.DataGridView dg)
        {
            try
            {
                dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                dg.Columns["objVO"].Visible = false;
                dg.Columns["ID"].Visible = false;

                dg.Columns["Cantidad"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                dg.Columns["Producto"].Width = 400;
                dg.Columns["Posologia"].Width = 500;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RecetaDetalle RecetaDetalleGetRegistroSeleccionado(System.Windows.Forms.DataGridView dg)
        {
            try
            {
                if (dg.CurrentRow == null)
                    return null;

                return (RecetaDetalle)dg.CurrentRow.Cells["objVO"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RecetaDetalleSetRegistroSeleccionado(ref System.Windows.Forms.DataGridView dg, RecetaDetalle recetaDetalle)
        {
            try
            {
                lib.vo.RecetaDetalle recetaDetalleTmp = this.RecetaDetalleGetRegistroSeleccionado(dg);
                if (recetaDetalleTmp != null)
                {
                    List<lib.vo.RecetaDetalle> listSeleccionado = (List<lib.vo.RecetaDetalle>)dg.Tag;
                    if (listSeleccionado == null) listSeleccionado = new List<RecetaDetalle>();

                    listSeleccionado[listSeleccionado.IndexOf(recetaDetalle)] = recetaDetalle;
                    
                    dg.DataSource = null;
                    dg.Refresh();
                    dg.DataSource = RecetaDetalleListVOToDataView(listSeleccionado);
                    dg.Tag = listSeleccionado;
                    RecetaDetalleSetEstiloGridRegistros(ref dg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
