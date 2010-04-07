using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita.receta.ctrl
{
    class ctrlPrint:template.frm.impresion.ctrl.PrintCtrl
    {
        private frmPrint _vista;

        public override void imprimir(ref repsol.forms.template.informe.ReportForm frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                _vista.viewer.Reset();
                lib.bl._reports.receta.rptReceta informe = new gesClinica.lib.bl._reports.receta.rptReceta(_vista.Receta);
                Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                informe.setInformeViewer(ref viewer);
                _vista.viewer.RefreshReport();
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
                _vista = (frmPrint)frm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
