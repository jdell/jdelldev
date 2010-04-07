using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ambis1.gui.pc
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
               ambis1.model.common.variables.configpath.DIRECTORY = System.IO.Path.GetFullPath(@"..\..\..\ambis1.model\bin\Debug");
#endif
                //**************************************
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //frm._splash.frmSplash vVen = new ambis1.gui.pc.frm._splash.frmSplash();
                //ambis1.model.bl._common.cache.Processing +=new ambis1.model.bl._common.cache.ProcessingHandler(vVen.Avanza);
                //vVen.Show(true, false,true);
                Application.DoEvents();

                ambis1.model.bl._common.cache.DataBaseUpdating += new ambis1.model.bl._common.cache.DataBaseUpdatingHandler(cache_DataBaseUpdating);
                //TODO: HERE
                ambis1.model.bl._common.cache.Initialize(Environment.UserName);
                ambis1.gui.pc._common.cache.Initialize();

                //vVen.Close();

                Application.Run(new frm._main.frmMain());

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
            finally
            {
                ambis1.gui.pc._common.cache.Dispose();
                ambis1.model.bl._common.cache.Dispose();
            }

        }

        static void cache_DataBaseUpdated(string mensaje)
        {
            MessageBox.Show(mensaje, Application.ProductName);
        }

        static void cache_DataBaseUpdating(string mensaje, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) != DialogResult.OK;
        }
    }
}