using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace asr.app.pc.frm._acercade.ctrl
{
    internal class ctrlAcercaDe:template.frm.BaseCtrl
    {
        frmAcercaDe _vista;
        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmAcercaDe)frm;

                _vista.labTituloCompany.Text = Application.CompanyName;
                _vista.labTituloProducto.Text = Application.ProductName;
                _vista.labTituloDescripcion.Text = Application.ProductVersion;

                _vista.labCompany.Text = Application.CompanyName;
                _vista.labProduct.Text = Application.ProductName;
                _vista.labVersion.Text = Application.ProductVersion;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
