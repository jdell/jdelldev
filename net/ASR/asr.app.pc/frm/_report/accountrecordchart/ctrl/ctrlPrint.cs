using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm._report.accountrecordchart.ctrl
{
    class ctrlPrint : template.frm.impresion.ctrl.PrintCtrl
    {
        private frmPrint _vista;

        public override void imprimir(ref repsol.forms.template.informe.ReportForm frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                if (_vista.cmbClient.SelectedItem != null)
                {
                    _vista.viewer.Reset();

                    lib.bl._reports.accountrecord.rptAccountRecordChart informe = new asr.lib.bl._reports.accountrecord.rptAccountRecordChart(_vista.dtpDateFrom.Value, _vista.dtpDateTo.Value, (lib.vo.Client)_vista.cmbClient.SelectedItem);
                    Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                    informe.setInformeViewer(ref viewer);
                    _vista.viewer.RefreshReport();
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
                _vista = (frmPrint)frm;

                _vista.dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                _vista.dtpDateTo.Value = _vista.dtpDateFrom.Value.AddMonths(1).AddDays(-1);
                _vista.dtpDateFrom.Value = _vista.dtpDateFrom.Value.AddMonths(lib.bl._common.cache.AccountRecordChartsHistory);

                // ********************* Client *********************
                lib.bl.client.doGetAllAccountRecord lnClient = new asr.lib.bl.client.doGetAllAccountRecord();
                List<lib.vo.Client> listClient = lnClient.execute();
                _vista.cmbClient.DataSource = listClient;
                _vista.cmbClient.DisplayMember = "FullName";
                _vista.cmbClient.ValueMember = "ID";
                _vista.cmbClient.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
