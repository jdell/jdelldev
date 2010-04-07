using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tipooperacion.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                TipoOperacion objVO = null;
                if (newRecord)
                {
                    objVO = new TipoOperacion();
                }
                else
                {
                    objVO = (TipoOperacion)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Facturable = _vista.chkFacturable.Checked;

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
                TipoOperacion objVO = (TipoOperacion)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.chkFacturable.Checked= objVO.Facturable;
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
                TipoOperacion objVO = (TipoOperacion)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.tipooperacion.doAdd lnTipoOperacion = new gesClinica.lib.bl.tipooperacion.doAdd(objVO);
                    lnTipoOperacion.execute();
                }
                else
                {
                    lib.bl.tipooperacion.doUpdate lnTipoOperacion = new gesClinica.lib.bl.tipooperacion.doUpdate(objVO);
                    lnTipoOperacion.execute();
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

                //_vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                //_vista.Cancelar.Location = new System.Drawing.Point(429, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
