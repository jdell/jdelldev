using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace asr.app.pc.frm._principal.ctrl
{
    internal class ctrlPrincipal:template.frm.principal.ctrl.MainCtrl
    {
        frmPrincipal _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmPrincipal)frm;

                _vista.MainMenuStrip.MdiWindowListItem = _vista.ventanaToolStripMenuItem;
                                
                setStatusBar(ref _vista);


#if CLIENT
                this._vista.Text = string.Format("ASR - {0}", lib.bl._common.cache.CompanyName);

                // Customer
                this._vista.customersToolStripMenuItem.Visible = false;

                // Clients
                this._vista.creditRepairOnlyToolStripMenuItem.Visible = false;
                this._vista.accountRecordOnlyToolStripMenuItem.Visible = false;
                this._vista.separatorClient1.Visible = false;
                this._vista.searchBySkillsToolStripMenuItem.Visible = false;
                this._vista.searchByCustomerToolStripMenuItem.Visible = false;

                // Staff
                //this._vista.staffToolStripMenuItem.Visible = false;

                // Movements/Invoices
                this._vista.invoicesToolStripMenuItem.Visible = false;
                this._vista.expensesToolStripMenuItem.Visible = false;

                // Services
                this._vista.toolStripMenuItem9.Visible = false;
                this._vista.payableToolStripMenuItem.Visible = false;
                this._vista.servicesToolStripMenuItem1.Visible = false;

                // Activity / Skills
                this._vista.toolStripMenuItem5.Visible = false;
                this._vista.activityToolStripMenuItem.Visible = false;
                this._vista.skillsToolStripMenuItem.Visible = false;

                // Reports
                this._vista.reportsToolStripMenuItem.Visible = false;

                // Tools
                this._vista.toolsToolStripMenuItem.Visible = false;
#endif

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
