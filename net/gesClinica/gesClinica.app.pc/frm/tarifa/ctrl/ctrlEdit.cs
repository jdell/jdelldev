using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tarifa.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Tarifa objVO = null;
                if (newRecord)
                {
                    objVO = new Tarifa();
                }
                else
                {
                    objVO = (Tarifa)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Descuento = Convert.ToByte(_vista.txtDescuento.Text);

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
                Tarifa objVO = (Tarifa)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.txtDescuento.Text = objVO.Descuento.ToString();

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
                Tarifa objVO = (Tarifa)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.tarifa.doAdd lnTarifa = new gesClinica.lib.bl.tarifa.doAdd(objVO);
                    lnTarifa.execute();
                }
                else
                {
                    lib.bl.tarifa.doUpdate lnTarifa = new gesClinica.lib.bl.tarifa.doUpdate(objVO);
                    lnTarifa.execute();
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
