using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._reports.receta
{
    public class rptReceta: Informe
    {
        private vo.Receta _receta = null;
        public rptReceta(lib.vo.Receta receta)
        {
            _receta = receta;
        }

        protected override object getDataSource()
        {
            try
            {
                //lib.bl.receta.doGet lnReceta = new gesClinica.lib.bl.receta.doGet(_receta);
                //vo.Receta tmp = lnReceta.execute();

                //lib.bl.recetadetalle.doGetAll lnRecetaDetalle = new gesClinica.lib.bl.recetadetalle.doGetAll(_receta);
                //_receta.Detalle = lnRecetaDetalle.execute();

                lib.bl.cita.doGet lnCita = new gesClinica.lib.bl.cita.doGet(_receta.Cita);
                _receta.Cita = lnCita.execute();

                return new vo.Receta[] { _receta };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override string getEmbeddedReport()
        {
            try
            {
                string res = string.Empty;

                res = "gesClinica.lib.bl._reports.receta.rdlReceta.rdlc";

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void setInformeViewer(ref Microsoft.Reporting.WinForms.ReportViewer viewer)
        {
            try
            {
                viewer.LocalReport.DataSources.Clear();

                vo.Receta[] aObjVO = (vo.Receta[])getDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rdsReceta = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsReceta.Name = typeof(lib.vo.Receta).FullName.Replace(".", "_");
                rdsReceta.Value = aObjVO;
                viewer.LocalReport.DataSources.Add(rdsReceta);

                Microsoft.Reporting.WinForms.ReportDataSource rdsRecetaDetalle = new Microsoft.Reporting.WinForms.ReportDataSource();
                rdsRecetaDetalle.Name = typeof(lib.vo.RecetaDetalle).FullName.Replace(".", "_");
                rdsRecetaDetalle.Value = _receta.Detalle.ToArray();
                viewer.LocalReport.DataSources.Add(rdsRecetaDetalle);
                
                viewer.LocalReport.ReportEmbeddedResource = getEmbeddedReport();

                Microsoft.Reporting.WinForms.ReportParameter param;
                param = new Microsoft.Reporting.WinForms.ReportParameter("empleado", _receta.Cita.Empleado.ToString());
                viewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { param });

                viewer.LocalReport.EnableExternalImages = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
