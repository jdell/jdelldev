using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.membership
{
    public partial class frmMemberShipQry : Form
    {
        public frmMemberShipQry()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            try
            {
                model.bl.membership.doGetAll doAction = new ambis1.model.bl.membership.doGetAll();
                List<model.vo.Membership> list = doAction.execute();
                
                this.dgResults.DataSource = list.FindAll(filterActive);
                foreach (DataGridViewColumn c in this.dgResults.Columns)
                {
                    c.Visible = false;
                }
                this.dgResults.Columns["TypeOfMember"].Visible = true;
                this.dgResults.Columns["Number"].Visible = true;
                this.dgResults.Columns["Member"].Visible = true;
                this.dgResults.Columns["TypeOfMembership"].Visible = true;
                this.dgResults.Columns["FromDate"].Visible = true;
                this.dgResults.Columns["ToDate"].Visible = true;
                this.dgResults.Columns["IsExpired"].Visible = true;
                this.dgResults.Columns["PaymentStatus"].Visible = true;

                int i = 0;
                this.dgResults.Columns["TypeOfMember"].DisplayIndex = i++;
                this.dgResults.Columns["Number"].DisplayIndex = i++;
                this.dgResults.Columns["Member"].DisplayIndex = i++;
                this.dgResults.Columns["TypeOfMembership"].DisplayIndex = i++;
                this.dgResults.Columns["FromDate"].DisplayIndex = i++;
                this.dgResults.Columns["ToDate"].DisplayIndex = i++;
                this.dgResults.Columns["PaymentStatus"].DisplayIndex = i++;
                //this.dgResults.Columns["IsExpired"].DisplayIndex = i++;


                this.dgResults.Columns["FromDate"].CellTemplate.Style.Format = _common.constants.format.DATE;
                this.dgResults.Columns["ToDate"].CellTemplate.Style.Format = _common.constants.format.DATE;
              }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        private bool filterActive(model.vo.Membership one)
        {
            return one.Active;
        }

        private void frmMemberShipQry_Load(object sender, EventArgs e)
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

        private void dgResults_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                    if (dgv.Rows[e.RowIndex] != null)
                    {
                        model.vo.Membership membership = (model.vo.Membership)dgv.Rows[e.RowIndex].DataBoundItem;
                        if (membership.IsGoingToExpire) e.CellStyle.BackColor = Color.LightYellow;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgResults_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                btModify_Click(null, null);
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgResults.CurrentRow == null)
                {
                    template._common.messages.ShowWarning(_common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(ambis1.gui.pc._common.constants.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    model.vo.Membership vo = (model.vo.Membership)this.dgResults.CurrentRow.DataBoundItem;
                    model.bl.membership.doDelete doAction = new ambis1.model.bl.membership.doDelete(vo);
                    doAction.execute();

                    tsbRefresh_Click(null, null);
                }
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
                 
                model.vo.Membership membership = (model.vo.Membership)this.dgResults.CurrentRow.DataBoundItem;
                membership.frmMemberShipEdit vVen = new ambis1.gui.pc.frm.membership.frmMemberShipEdit(membership);
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
                
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
                membership.frmMemberShipEdit vVen = new ambis1.gui.pc.frm.membership.frmMemberShipEdit();
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


    }
}
