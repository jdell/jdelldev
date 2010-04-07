using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace asr.app.pc.lts.frm._main.ctrl
{
    internal class ctrlMain:template.frm.principal.ctrl.MainCtrl
    {
        frmMain _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmMain)frm;

                _vista.Text += string.Format(" - {0}", lib.bl._common.cache.CompanyName);
                _vista.MainMenuStrip.MdiWindowListItem = _vista.ventanaToolStripMenuItem;
                                
                setStatusBar(ref _vista);

            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private void setStatusBar(ref frmMain frm)
        {
            try
            {

                _vista = frm;

                _vista.tstripEstado.Items.Clear();

                ToolStripItem titem;

                titem = new ToolStripLabel(String.Format("{0} v{1}",Application.ProductName, Application.ProductVersion));

                _vista.tstripEstado.Items.Add(titem);

#if DEBUG
                titem = new ToolStripLabel("Desarrollo");
                _vista.tstripEstado.Items.Add(titem);
#else
                titem = new ToolStripLabel("Producción");
                _vista.tstripEstado.Items.Add(titem);
#endif

                //TODO: Employeer.
                //titem = new ToolStripLabel(lib.bl._common.cache.EMPLEADO.ToString());
                titem = new ToolStripLabel(Environment.UserName);
                _vista.tstripEstado.Items.Add(titem);
                titem.Alignment = ToolStripItemAlignment.Right;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

    }
}
