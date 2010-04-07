using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.lts.frm._splash.ctrl
{
    class ctrlSplash
    {
        frmSplash _vista;

        public void inicializar(ref frmSplash frm)
        {
            try
            {
                _vista = frm;

                _vista.Status = "Iniciando aplicación...";
                _vista.appName = string.Format("{0} {1}", System.Windows.Forms.Application.ProductName, System.Windows.Forms.Application.ProductVersion);
                _vista.OperatingSystem = Environment.OSVersion.VersionString;
                _vista.StatusDetails = "cargando componentes...";
                _vista.IndustrialComplex = System.Windows.Forms.Application.CompanyName;

#if DEBUG
                _vista.Release = "Desarrollo";
#else
                _vista.Release = "Producción";
#endif
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
