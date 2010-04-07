using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace gesClinica.app.pc.frm._principal.ctrl
{
    internal class ctrlPrincipal:template.frm.principal.ctrl.MainCtrl
    {
        frmPrincipal _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmPrincipal)frm;

//#if DEBUG 
                _vista.agendaGeneralotraFormaToolStripMenuItem.Enabled = true;
//#endif

                _vista.MainMenuStrip.MdiWindowListItem = _vista.ventanaToolStripMenuItem;

                _vista.facturasToolStripMenuItem.Enabled = lib.bl._common.cache.EMPLEADO.Gerente;
                _vista.contabilidadToolStripMenuItem.Enabled = lib.bl._common.cache.EMPLEADO.Gerente;
                _vista.importacionToolStripMenuItem.Visible = pc._common.cache.IsImportEnabled;

                setStatusBar(ref _vista);

            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private void setStatusBar(ref frmPrincipal frm)
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

                titem = new ToolStripLabel(lib.bl._common.cache.EMPLEADO.ToString());
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
