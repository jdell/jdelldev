using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.estadoevento.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                EstadoEvento objVO = null;
                if (newRecord)
                {
                    objVO = new EstadoEvento();
                }
                else
                {
                    objVO = (EstadoEvento)_vista.InnerVO;
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
                EstadoEvento objVO = (EstadoEvento)obj;

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
                EstadoEvento objVO = (EstadoEvento)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.estadoevento.doAdd lnEstadoEvento = new gesClinica.lib.bl.estadoevento.doAdd(objVO);
                    lnEstadoEvento.execute();
                }
                else
                {
                    lib.bl.estadoevento.doUpdate lnEstadoEvento = new gesClinica.lib.bl.estadoevento.doUpdate(objVO);
                    lnEstadoEvento.execute();
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
                _vista.cmbColor.DataSource = gesClinica.lib.vo.EstadoEvento.Colores();
                //_vista.cmbColor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
