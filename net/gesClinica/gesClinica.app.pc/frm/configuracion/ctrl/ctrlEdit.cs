using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.configuracion.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Configuracion objVO = null;
                if (newRecord)
                {
                    objVO = new Configuracion();
                }
                else
                {
                    objVO = (Configuracion)_vista.InnerVO;
                }

                //objVO.Descripcion= _vista.txtDescripcion.Text;

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
                Configuracion objVO = (Configuracion)obj;

                _vista.InnerVO = objVO;

                //_vista.txtDescripcion.Text = objVO.Descripcion;

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
                Configuracion objVO = (Configuracion)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.configuracion.doAdd lnConfiguracion = new gesClinica.lib.bl.configuracion.doAdd(objVO);
                    lnConfiguracion.execute();
                }
                else
                {
                    lib.bl.configuracion.doUpdate lnConfiguracion = new gesClinica.lib.bl.configuracion.doUpdate(objVO);
                    lnConfiguracion.execute();
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
