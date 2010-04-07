using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gesClinica.app.pc
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //**************** Init ****************
#if DEBUG
                gesClinica.lib.common.variables.configpath.DIRECTORY = System.IO.Path.GetFullPath(@"..\..\..\gesClinica.lib.bl\bin\Debug");
#endif
                //**************************************
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                frm._splash.frmSplash vVen = new gesClinica.app.pc.frm._splash.frmSplash();
                gesClinica.lib.bl._common.cache.Processing +=new gesClinica.lib.bl._common.cache.ProcessingHandler(vVen.Avanza);
                vVen.Show(true, false,true);
                Application.DoEvents();

                gesClinica.lib.bl._common.cache.DataBaseUpdating += new gesClinica.lib.bl._common.cache.DataBaseUpdatingHandler(cache_DataBaseUpdating);
                //gesClinica.lib.bl._common.cache.DataBaseUpdated += new gesClinica.lib.bl._common.cache.DataBaseUpdatedHandler(cache_DataBaseUpdated);

                gesClinica.lib.bl._common.cache.Initialize(Environment.UserName);
                //gesClinica.lib.bl._common.cache.Initialize("JOE");
                gesClinica.app.pc._common.cache.Initialize();

                vVen.Close();

                Application.Run(new frm._principal.frmPrincipal());
                //Application.Run(new _test.frmTest());

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
            finally
            {
                gesClinica.app.pc._common.cache.Dispose();
                gesClinica.lib.bl._common.cache.Dispose();
            }

        }

        static void cache_DataBaseUpdated(string mensaje)
        {
            MessageBox.Show(mensaje, "gesClinica");
        }

        static void cache_DataBaseUpdating(string mensaje, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = MessageBox.Show(mensaje, "gesClinica", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) != DialogResult.Yes;
        }
    }
}