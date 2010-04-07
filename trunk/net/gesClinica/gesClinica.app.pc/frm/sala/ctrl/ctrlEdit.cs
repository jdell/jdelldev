using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.sala.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Sala objVO = null;
                if (newRecord)
                {
                    objVO = new Sala();
                }
                else
                {
                    objVO = (Sala)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Color = _vista.cmbColor.SelectedItem.ToString();
                objVO.Activo = _vista.chkActiva.Checked;

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
                Sala objVO = (Sala)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.cmbColor.SelectedItem = objVO.Color;
                _vista.chkActiva.Checked = objVO.Activo;

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
                Sala objVO = (Sala)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.sala.doAdd lnSala = new gesClinica.lib.bl.sala.doAdd(objVO);
                    lnSala.execute();
                }
                else
                {
                    lib.bl.sala.doUpdate lnSala = new gesClinica.lib.bl.sala.doUpdate(objVO);
                    lnSala.execute();
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

                // ********************* Color *********************
                _vista.cmbColor.DataSource = gesClinica.lib.vo.EstadoCita.Colores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
