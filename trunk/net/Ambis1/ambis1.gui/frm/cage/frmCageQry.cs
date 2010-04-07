using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.cage
{
    public partial class frmCageQry : Form
    {
        public frmCageQry()
        {
            InitializeComponent();
        }

        private void frmCageQry_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                model.bl.cage.doGetAll doAction = new ambis1.model.bl.cage.doGetAll();
                this.dgResults.DataSource = doAction.execute();
                if (this.dgResults.Columns.Contains("ID")) this.dgResults.Columns["ID"].Visible = false;

                if (this.dgResults.Columns.Contains("Description")) this.dgResults.Columns["Description"].DisplayIndex= 0;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cage.frmCageEdit vVen = new frmCageEdit();
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
             }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgResults.CurrentRow == null)
                {
                    template._common.messages.ShowWarning(_common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                model.vo.Cage vo = (model.vo.Cage)this.dgResults.CurrentRow.DataBoundItem;

                cage.frmCageEdit vVen = new frmCageEdit(vo);
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgResults.CurrentRow == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(ambis1.gui.pc._common.constants.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    model.vo.Cage vo = (model.vo.Cage)this.dgResults.CurrentRow.DataBoundItem;
                    model.bl.cage.doDelete doAction = new ambis1.model.bl.cage.doDelete(vo);
                    doAction.execute();

                    tsbRefresh_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
