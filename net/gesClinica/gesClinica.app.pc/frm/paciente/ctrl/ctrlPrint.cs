using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.paciente.ctrl
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
                Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                lib.bl._reports.Informe informe;
                switch (_vista.Tipo)
                {
                    case tTIPOIMPRESION.QUIROMASAJE1:
                        informe = new gesClinica.lib.bl._reports.quiromasaje.rptQuiromasaje1(_vista.Paciente);
                        informe.setInformeViewer(ref viewer);
                        break;
                    case tTIPOIMPRESION.QUIROMASAJE2:
                        informe = new gesClinica.lib.bl._reports.quiromasaje.rptQuiromasaje2(_vista.Paciente);
                        informe.setInformeViewer(ref viewer);
                        break;
                    case tTIPOIMPRESION.QUIROMASAJE3:
                        informe = new gesClinica.lib.bl._reports.quiromasaje.rptQuiromasaje3(_vista.Paciente);
                        informe.setInformeViewer(ref viewer);
                        break;
                    case tTIPOIMPRESION.QUIROMASAJE4:
                        informe = new gesClinica.lib.bl._reports.quiromasaje.rptQuiromasaje4(_vista.Paciente);
                        informe.setInformeViewer(ref viewer);
                        break;
                    default:
                        break;
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
