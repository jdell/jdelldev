using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.ejercicio.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Ejercicio objVO = null;
                if (newRecord)
                {
                    objVO = new Ejercicio();
                }
                else
                {
                    objVO = (Ejercicio)_vista.InnerVO;
                }

                objVO.Descripcion= _vista.txtDescripcion.Text;

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
                Ejercicio objVO = (Ejercicio)obj;

                _vista.InnerVO = objVO;

                _vista.txtDescripcion.Text = objVO.Descripcion;

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
                Ejercicio objVO = (Ejercicio)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.ejercicio.doAdd lnEjercicio = new gesClinica.lib.bl.ejercicio.doAdd(objVO);
                    lnEjercicio.execute();
                }
                else
                {
                    lib.bl.ejercicio.doUpdate lnEjercicio = new gesClinica.lib.bl.ejercicio.doUpdate(objVO);
                    lnEjercicio.execute();
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
