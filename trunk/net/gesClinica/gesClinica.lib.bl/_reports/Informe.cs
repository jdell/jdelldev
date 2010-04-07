using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports
{
    public abstract class Informe
    {
        protected abstract object getDataSource();
        protected abstract string getEmbeddedReport();

        public abstract void setInformeViewer(ref Microsoft.Reporting.WinForms.ReportViewer viewer);

        public System.IO.MemoryStream getInformePDF()
        {
            try
            {
                System.IO.MemoryStream res;

                Microsoft.Reporting.WinForms.Warning[] warnings = null;
                string[] streamIds = null;
                string mimeType = string.Empty;
                string enconding = string.Empty;
                string extension = string.Empty;

                Microsoft.Reporting.WinForms.ReportViewer viewer = new Microsoft.Reporting.WinForms.ReportViewer();
                setInformeViewer(ref viewer);
                res = new System.IO.MemoryStream(viewer.LocalReport.Render("PDF", null, out mimeType,out enconding,out extension,out streamIds,out warnings));
                res.Seek(0, System.IO.SeekOrigin.Begin);
                
                return res;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
