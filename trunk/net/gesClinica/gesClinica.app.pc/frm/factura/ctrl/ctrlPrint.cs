using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.factura.ctrl
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
                if (_vista.Factura != null)
                {
                    lib.bl._reports.factura.rptFactura informe = new gesClinica.lib.bl._reports.factura.rptFactura(_vista.Factura);
                    Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                    informe.setInformeViewer(ref viewer);
                }
                else
                {
                    lib.bl._reports.factura.rptFacturas informe = new gesClinica.lib.bl._reports.factura.rptFacturas(_vista.Facturas, _vista.FormatoFactura);
                    Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                    informe.setInformeViewer(ref viewer);
                }
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
