using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.sintoma.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Sintoma objVO = null;
                if (newRecord)
                {
                    objVO = new Sintoma();
                }
                else
                {
                    objVO = (Sintoma)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.TipoSintoma = (TipoSintoma) _vista.cmbTipoSintoma.SelectedItem;

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
                Sintoma objVO = (Sintoma)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                if (objVO.TipoSintoma != null) _vista.cmbTipoSintoma.SelectedValue = objVO.TipoSintoma.ID;

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
                Sintoma objVO = (Sintoma)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.sintoma.doAdd lnSintoma = new gesClinica.lib.bl.sintoma.doAdd(objVO);
                    lnSintoma.execute();
                }
                else
                {
                    lib.bl.sintoma.doUpdate lnSintoma = new gesClinica.lib.bl.sintoma.doUpdate(objVO);
                    lnSintoma.execute();
                }
                _vista.InnerVO = objVO;
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

                // ********************* TipoSintoma *********************
                gesClinica.lib.bl.tiposintoma.doGetAll lnTipoSintoma = new gesClinica.lib.bl.tiposintoma.doGetAll();
                _vista.cmbTipoSintoma.DataSource = lnTipoSintoma.execute();
                _vista.cmbTipoSintoma.DisplayMember = "Descripcion";
                _vista.cmbTipoSintoma.ValueMember = "ID";
                _vista.cmbTipoSintoma.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void recuperarDatos(ref repsol.forms.template.edicion.EditForm frm)
        {
            try
            {
                _vista = (frmEdit)frm;
                Sintoma objVO = (Sintoma)_vista.InnerVO;

                if (objVO.TipoSintoma != null) _vista.cmbTipoSintoma.SelectedValue = objVO.TipoSintoma.ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
