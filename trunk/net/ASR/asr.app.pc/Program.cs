using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace asr.app.pc
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
                asr.lib.common.variables.configpath.DIRECTORY = System.IO.Path.GetFullPath(@"..\..\..\asr.lib.bl\bin\Debug");
#endif
                //**************************************
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                frm._splash.frmSplash vVen = new asr.app.pc.frm._splash.frmSplash();
                asr.lib.bl._common.cache.Processing +=new asr.lib.bl._common.cache.ProcessingHandler(vVen.Avanza);
                vVen.Show(true, false,true);
                Application.DoEvents();

                asr.lib.bl._common.cache.DataBaseUpdating += new asr.lib.bl._common.cache.DataBaseUpdatingHandler(cache_DataBaseUpdating);
                //asr.lib.bl._common.cache.DataBaseUpdated += new asr.lib.bl._common.cache.DataBaseUpdatedHandler(cache_DataBaseUpdated);

                asr.lib.bl._common.cache.Initialize(Environment.UserName);
                //asr.lib.bl._common.cache.Initialize("JOE");
                asr.app.pc._common.cache.Initialize();

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
                asr.app.pc._common.cache.Dispose();
                asr.lib.bl._common.cache.Dispose();
            }

        }

        static void cache_DataBaseUpdated(string mensaje)
        {
            MessageBox.Show(mensaje, "asr");
        }

        static void cache_DataBaseUpdating(string mensaje, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = MessageBox.Show(mensaje, "asr", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) != DialogResult.Yes;
        }
    }
}