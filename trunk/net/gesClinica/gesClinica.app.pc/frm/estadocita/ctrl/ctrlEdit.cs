using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.estadocita.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                EstadoCita objVO = null;
                if (newRecord)
                {
                    objVO = new EstadoCita();
                }
                else
                {
                    objVO = (EstadoCita)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Color = _vista.cmbColor.SelectedItem.ToString();
                objVO.GeneraRecibo = _vista.chkGeneraRecibo.Checked;
                objVO.Avion = _vista.chkAvion.Checked;

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
                EstadoCita objVO = (EstadoCita)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.cmbColor.SelectedItem = objVO.Color;
                _vista.chkGeneraRecibo.Checked = objVO.GeneraRecibo;
                _vista.chkAvion.Checked = objVO.Avion;
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
                EstadoCita objVO = (EstadoCita)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.estadocita.doAdd lnEstadoCita = new gesClinica.lib.bl.estadocita.doAdd(objVO);
                    lnEstadoCita.execute();
                }
                else
                {
                    lib.bl.estadocita.doUpdate lnEstadoCita = new gesClinica.lib.bl.estadocita.doUpdate(objVO);
                    lnEstadoCita.execute();
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
                _vista.cmbColor.DataSource = gesClinica.lib.vo.EstadoCita.Colores();
                //_vista.cmbColor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
