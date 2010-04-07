using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Receta objVO = null;
                if (newRecord)
                {
                    objVO = new Receta();
                }
                else
                {
                    objVO = (Receta)_vista.InnerVO;
                }

                objVO.Observaciones = _vista.txtObservaciones.Text;
                objVO.Detalle = ((Receta)_vista.InnerVO).Detalle;

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
                Receta objVO = (Receta)obj;

                _vista.InnerVO = objVO;

                _vista.txtObservaciones.Text = objVO.Observaciones;

                //TODO: Recetas - Completar
                /*
                lib.bl.recetadetalle.doGetAll lnRecetaDetalle = new gesClinica.lib.bl.recetadetalle.doGetAll(objVO);
                objVO.Detalle = lnRecetaDetalle.execute();
                 */
                System.Windows.Forms.Control c = (System.Windows.Forms.Control)_vista.tabDetalleReceta;
                _vista._frmDetalle.ShowDocked(ref c);
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
                Receta objVO = (Receta)getObject(ref frm, newRecord);

                Cita cita = (Cita)((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.Owner).InnerVO;
                cita.Receta.Sort();
                int index = cita.Receta.IndexOf(objVO);
                if (index > -1)
                    cita.Receta[index] = objVO;
                else
                    cita.Receta.Add(objVO);

                ((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.Owner).InnerVO = cita;

                /*
                if (newRecord)
                {
                    lib.bl.receta.doAdd lnReceta = new gesClinica.lib.bl.receta.doAdd(objVO);
                    lnReceta.execute();
                }
                else
                {
                    lib.bl.receta.doUpdate lnReceta = new gesClinica.lib.bl.receta.doUpdate(objVO);
                    lnReceta.execute();
                }
                */
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
