using System;
using System.Collections.Generic;
using System.Text;

namespace parteHoras.lib.bl._common.informes
{
    public abstract class informe
    {
        protected abstract object getDataSource();
        protected abstract string getEmbeddedReport();
        public abstract void setInformeIntoViewer(ref Microsoft.Reporting.WebForms.ReportViewer viewer);
        public abstract void setInformeIntoViewer(ref Microsoft.Reporting.WinForms.ReportViewer viewer);
                
        public System.IO.MemoryStream getInformePDF()
        {
            try
            {
                System.IO.MemoryStream res;

                Microsoft.Reporting.WebForms.Warning[] warnings = null;
                string[] streamids = null;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;

                Microsoft.Reporting.WebForms.ReportViewer viewer = new Microsoft.Reporting.WebForms.ReportViewer();
                setInformeIntoViewer(ref viewer);
                res = new System.IO.MemoryStream(viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings));
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