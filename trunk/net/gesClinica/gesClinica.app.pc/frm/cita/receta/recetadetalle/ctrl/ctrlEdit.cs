using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                RecetaDetalle objVO = null;
                if (newRecord)
                    objVO = new RecetaDetalle();
                else
                    objVO = (RecetaDetalle)_vista.InnerVO;

                Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO;
                objVO.Posologia = _vista.txtPosologia.Text;
                objVO.Cantidad = Convert.ToInt32(_vista.txtCantidad.Text);
                objVO.Producto = (Producto)_vista.txtProducto.Tag;
                objVO.Receta = receta;

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
                RecetaDetalle objVO = (RecetaDetalle)obj;

                _vista.InnerVO = objVO;

                setProducto(ref _vista, objVO.Producto);
                _vista.txtPosologia.Text = objVO.Posologia;
                _vista.txtCantidad.Text = objVO.Cantidad.ToString();

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
                RecetaDetalle objVO = (RecetaDetalle)getObject(ref frm, newRecord);

                Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.Owner).InnerVO;
                receta.Detalle.Sort();
                int index = receta.Detalle.IndexOf(objVO);
                if (index > -1)
                    receta.Detalle[index] = objVO;
                else
                    receta.Detalle.Add(objVO);

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
                _vista = (frmEdit)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setProducto(ref frmEdit frm, Producto producto)
        {
            try
            {
                _vista = frm;
                if (producto != null)
                {
                    _vista.txtProducto.Text = producto.ToString();
                    _vista.txtPosologia.Text = producto.Posologia;
                }
                else
                {
                    _vista.txtProducto.ResetText();
                    _vista.txtPosologia.ResetText();
                }
                _vista.txtProducto.Tag = producto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
