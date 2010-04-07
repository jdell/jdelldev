using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tipofestivo.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                TipoFestivo objVO = null;
                if (newRecord)
                {
                    objVO = new TipoFestivo();
                }
                else
                {
                    objVO = (TipoFestivo)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Color = _vista.cmbColor.SelectedItem.ToString();

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
                TipoFestivo objVO = (TipoFestivo)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.cmbColor.SelectedItem = objVO.Color;
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
                TipoFestivo objVO = (TipoFestivo)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.tipofestivo.doAdd lnTipoFestivo = new gesClinica.lib.bl.tipofestivo.doAdd(objVO);
                    lnTipoFestivo.execute();
                }
                else
                {
                    lib.bl.tipofestivo.doUpdate lnTipoFestivo = new gesClinica.lib.bl.tipofestivo.doUpdate(objVO);
                    lnTipoFestivo.execute();
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
                
                // ********************* Color *********************
                _vista.cmbColor.DataSource = gesClinica.lib.vo.TipoFestivo.Colores();
                //_vista.cmbColor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
