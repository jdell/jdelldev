using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tipoterapia.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;


        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                TipoTerapia objVO = null;
                if (newRecord)
                {
                    objVO = new TipoTerapia();
                }
                else
                {
                    objVO = (TipoTerapia)_vista.InnerVO;
                }

                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Color = _vista.cmbColor.SelectedItem.ToString();
                objVO.Cobrable = _vista.chkCobrable.Checked;
                objVO.Codigo = (lib.vo.tTIPOTERAPIA)_vista.cmbCodigo.SelectedValue;

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
                TipoTerapia objVO = (TipoTerapia)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.cmbColor.SelectedItem = objVO.Color;
                _vista.chkCobrable.Checked = objVO.Cobrable;
                _vista.cmbCodigo.SelectedValue = objVO.Codigo;
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
                TipoTerapia objVO = (TipoTerapia)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.tipoterapia.doAdd lnTipoTerapia = new gesClinica.lib.bl.tipoterapia.doAdd(objVO);
                    lnTipoTerapia.execute();
                }
                else
                {
                    lib.bl.tipoterapia.doUpdate lnTipoTerapia = new gesClinica.lib.bl.tipoterapia.doUpdate(objVO);
                    lnTipoTerapia.execute();
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
                _vista.cmbColor.DataSource = gesClinica.lib.vo.TipoTerapia.Colores();
                //_vista.cmbColor.SelectedIndex = -1;


                _vista.cmbCodigo.DataSource = lib.common.funciones.EnumHelper.ToList(typeof(lib.vo.tTIPOTERAPIA));
                _vista.cmbCodigo.DisplayMember = "Value";
                _vista.cmbCodigo.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
