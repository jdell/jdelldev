using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.terapia.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Terapia objVO = null;
                if (newRecord)
                {
                    objVO = new Terapia();
                }
                else
                {
                    objVO = (Terapia)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Duracion = Convert.ToInt32(_vista.txtDuracion.Value);
                objVO.Precio= Convert.ToSingle(_vista.txtPrecio.Text);
                objVO.Activo = _vista.chkActivo.Checked;
                if (!string.IsNullOrEmpty(_vista.txtSubCuenta.Text))
                    objVO.SubCuenta = new SubCuenta(_vista.txtSubCuenta.Text);
                objVO.TipoTerapia = (TipoTerapia)_vista.cmbTipoTerapia.SelectedItem;

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
                Terapia objVO = (Terapia)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.txtDuracion.Value = objVO.Duracion;
                _vista.txtPrecio.Text = objVO.Precio.ToString();
                _vista.chkActivo.Checked = objVO.Activo;
                if (objVO.SubCuenta != null) _vista.txtSubCuenta.Text = objVO.SubCuenta.Codigo;
                if (objVO.TipoTerapia != null) _vista.cmbTipoTerapia.SelectedValue = objVO.TipoTerapia.ID;
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
                Terapia objVO = (Terapia)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.terapia.doAdd lnTerapia = new gesClinica.lib.bl.terapia.doAdd(objVO);
                    lnTerapia.execute();
                }
                else
                {
                    lib.bl.terapia.doUpdate lnTerapia = new gesClinica.lib.bl.terapia.doUpdate(objVO);
                    lnTerapia.execute();
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

                // ********************* TipoTerapia *********************
                gesClinica.lib.bl.tipoterapia.doGetAll lnTipoTerapia = new gesClinica.lib.bl.tipoterapia.doGetAll();
                _vista.cmbTipoTerapia.DataSource = lnTipoTerapia.execute();
                _vista.cmbTipoTerapia.DisplayMember = "Descripcion";
                _vista.cmbTipoTerapia.ValueMember = "ID";
                _vista.cmbTipoTerapia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
