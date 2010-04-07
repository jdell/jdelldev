using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.apunte.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Apunte objVO = null;
                if (newRecord)
                {
                    objVO = new Apunte();
                }
                else
                {
                    objVO = (Apunte)_vista.InnerVO;
                }


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
                Apunte objVO = (Apunte)obj;

                _vista.InnerVO = objVO;

                _vista.txtConcepto.Text = objVO.Concepto;
                _vista.txtDebe.Text = objVO.Debe.ToString("c");
                _vista.txtFecha.Text = objVO.Fecha.ToString("dd/MM/yyyy");
                _vista.txtHaber.Text = objVO.Haber.ToString("c");
                if (objVO.NumeroFactura!=0) _vista.txtNumeroFactura.Text = objVO.NumeroFactura.ToString();
                _vista.txtSubcuenta.Text = objVO.SubCuenta.ToString();

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
                Apunte objVO = (Apunte)getObject(ref frm, newRecord);
                //if (newRecord)
                //{
                //    lib.bl.apunte.doAdd lnApunte = new gesClinica.lib.bl.apunte.doAdd(objVO);
                //    lnApunte.execute();
                //}
                //else
                //{
                //    lib.bl.apunte.doUpdate lnApunte = new gesClinica.lib.bl.apunte.doUpdate(objVO);
                //    lnApunte.execute();
                //}
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
