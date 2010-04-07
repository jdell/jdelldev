using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.producto.productodetalle.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                ProductoDetalle objVO = null;
                if (newRecord)
                {
                    objVO = new ProductoDetalle();
                }
                else
                {
                    objVO = (ProductoDetalle)_vista.InnerVO;
                }

                Producto producto = (Producto)((gesClinica.app.pc.frm.producto.frmEdit)_vista.Owner).InnerVO;
                objVO.Dosis = _vista.txtDosis.Text;
                //objVO.Componente = (Componente)_vista.cmbComponente.SelectedItem;
                objVO.Componente = (Componente)_vista.txtComponente.Tag;
                objVO.Producto = producto;

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
                ProductoDetalle objVO = (ProductoDetalle)obj;

                _vista.InnerVO = objVO;

                _vista.txtDosis.Text = objVO.Dosis;
                //if (objVO.Componente != null) _vista.cmbComponente.SelectedValue = objVO.Componente.ID;
                setComponente(ref _vista, objVO.Componente);

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
                ProductoDetalle objVO = (ProductoDetalle)getObject(ref frm, newRecord);

                Producto producto = (Producto)((gesClinica.app.pc.frm.producto.frmEdit)_vista.Owner).InnerVO;
                producto.Detalle.Sort();
                int index = producto.Detalle.IndexOf(objVO);
                if (index > -1)
                    producto.Detalle[index] = objVO;
                else
                    producto.Detalle.Add(objVO);

                ((gesClinica.app.pc.frm.producto.frmEdit)_vista.Owner).InnerVO = producto;
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

                //// ********************* Componente *********************
                //gesClinica.lib.bl.componente.doGetAll lnComponente = new gesClinica.lib.bl.componente.doGetAll();
                //_vista.cmbComponente.DataSource = lnComponente.execute();
                //_vista.cmbComponente.DisplayMember = "Descripcion";
                //_vista.cmbComponente.ValueMember = "ID";
                //_vista.cmbComponente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setComponente(ref frmEdit frm, Componente componente)
        {
            try
            {
                _vista = frm;
                if (componente != null)
                {
                    _vista.txtComponente.Text = componente.ToString();
                }
                else
                {
                    _vista.txtComponente.ResetText();
                }
                _vista.txtComponente.Tag = componente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
