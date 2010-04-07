using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.formapago.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                FormaPago objVO = null;
                if (newRecord)
                {
                    objVO = new FormaPago();
                }
                else
                {
                    objVO = (FormaPago)_vista.InnerVO;
                }

                objVO.Descripcion= _vista.txtDescripcion.Text;
                objVO.Facturar = _vista.chkFacturar.Checked;

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
                FormaPago objVO = (FormaPago)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.chkFacturar.Checked = objVO.Facturar;

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
                FormaPago objVO = (FormaPago)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.formapago.doAdd lnFormaPago = new gesClinica.lib.bl.formapago.doAdd(objVO);
                    lnFormaPago.execute();
                }
                else
                {
                    lib.bl.formapago.doUpdate lnFormaPago = new gesClinica.lib.bl.formapago.doUpdate(objVO);
                    lnFormaPago.execute();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
