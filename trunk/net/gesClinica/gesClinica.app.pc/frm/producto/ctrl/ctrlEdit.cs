using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.producto.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Producto objVO = null;
                if (newRecord)
                {
                    objVO = new Producto();
                }
                else
                {
                    objVO = (Producto)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Laboratorio= (Laboratorio)_vista.cmbLaboratorio.SelectedItem;
                objVO.Documento = _vista.txtDocumento.Text;
                objVO.Posologia= _vista.txtPosologia.Text;
                objVO.Precio = Convert.ToSingle(_vista.txtPrecio.Text);
                objVO.Detalle = ((Producto)_vista.InnerVO).Detalle;
                objVO.Activo = !_vista.chkRetirado.Checked;

                objVO.Unidades = Convert.ToInt32(_vista.txtUnidades.Text);
                objVO.TipoUnidad = (TipoUnidad)_vista.cmbTipoUnidad.SelectedItem;

                objVO.Indicaciones.Clear();
                foreach (object item in _vista.lboxTargetIndicacion.Items)
                    objVO.Indicaciones.Add((Indicacion)item);

                objVO.ContraIndicaciones.Clear();
                foreach (object item in _vista.lboxTargetContraindicacion.Items)
                    objVO.ContraIndicaciones.Add((Indicacion)item);

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
                _vista = (frmEdit)frm;
                Producto objVO = (Producto)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.txtDocumento.Text = objVO.Documento;
                _vista.txtPosologia.Text = objVO.Posologia;
                _vista.txtPrecio.Text = objVO.Precio.ToString();
                if (objVO.Laboratorio != null) _vista.cmbLaboratorio.SelectedValue = objVO.Laboratorio.ID;
                _vista.chkRetirado.Checked = !objVO.Activo;

                if (objVO.TipoUnidad != null) _vista.cmbTipoUnidad.SelectedValue = objVO.TipoUnidad.ID;
                _vista.txtUnidades.Text = objVO.Unidades.ToString();

                //lib.bl.productodetalle.doGetAll lnProductoDetalle = new gesClinica.lib.bl.productodetalle.doGetAll(objVO);
                //objVO.Detalle = lnProductoDetalle.execute();
                System.Windows.Forms.Control c = (System.Windows.Forms.Control)_vista.tabDetalleProducto;
                _vista._frmDetalle.ShowDocked(ref c);


                lib.bl.indicacion.doGetAllOutIndicacion lnIndicacionOut = new gesClinica.lib.bl.indicacion.doGetAllOutIndicacion(objVO);
                foreach (Indicacion indicacion in lnIndicacionOut.execute())
                    _vista.lboxSourceIndicacion.Items.Add(indicacion);

                lib.bl.indicacion.doGetAllInIndicacion lnIndicacionIn = new gesClinica.lib.bl.indicacion.doGetAllInIndicacion(objVO);
                foreach (Indicacion indicacion in lnIndicacionIn.execute())
                    _vista.lboxTargetIndicacion.Items.Add(indicacion);

                lib.bl.indicacion.doGetAllOutContraIndicacion lnContraIndicacionOut = new gesClinica.lib.bl.indicacion.doGetAllOutContraIndicacion(objVO);
                foreach (Indicacion indicacion in lnContraIndicacionOut.execute())
                    _vista.lboxSourceContraindicacion.Items.Add(indicacion);

                lib.bl.indicacion.doGetAllInContraIndicacion lnContraIndicacionIn = new gesClinica.lib.bl.indicacion.doGetAllInContraIndicacion(objVO);
                foreach (Indicacion indicacion in lnContraIndicacionIn.execute())
                    _vista.lboxTargetContraindicacion.Items.Add(indicacion);

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
                _vista = (frmEdit)frm;
                Producto objVO = (Producto)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.producto.doAdd lnProducto = new gesClinica.lib.bl.producto.doAdd(objVO);
                    lnProducto.execute();
                }
                else
                {
                    lib.bl.producto.doUpdate lnProducto = new gesClinica.lib.bl.producto.doUpdate(objVO);
                    lnProducto.execute();
                }
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
                _vista = (frmEdit)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);


                // ********************* Laboratorio *********************
                gesClinica.lib.bl.laboratorio.doGetAll lnLaboratorio = new gesClinica.lib.bl.laboratorio.doGetAll();
                _vista.cmbLaboratorio.DataSource = lnLaboratorio.execute();
                _vista.cmbLaboratorio.DisplayMember = "Nombre";
                _vista.cmbLaboratorio.ValueMember = "ID";
                _vista.cmbLaboratorio.SelectedIndex = -1;


                // ********************* TipoUnidad *********************
                gesClinica.lib.bl.tipounidad.doGetAll lnTipoUnidad = new gesClinica.lib.bl.tipounidad.doGetAll();
                _vista.cmbTipoUnidad.DataSource = lnTipoUnidad.execute();
                _vista.cmbTipoUnidad.DisplayMember = "Descripcion";
                _vista.cmbTipoUnidad.ValueMember = "ID";
                _vista.cmbTipoUnidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void moverItems(ref System.Windows.Forms.ListBox lSource, ref System.Windows.Forms.ListBox lTarget)
        {
            try
            {
                foreach (object item in lSource.SelectedItems)
                    lTarget.Items.Add(item);

                int i = 0;
                while ((i = lSource.SelectedItems.Count) > 0)
                {
                    lSource.Items.Remove(lSource.SelectedItems[i - 1]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
