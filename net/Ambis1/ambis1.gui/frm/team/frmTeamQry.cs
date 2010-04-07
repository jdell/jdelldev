using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.team
{
    public partial class frmTeamQry : Form
    {
        public frmTeamQry()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            try
            {
                model.bl.member.doGetAllByType doAction = new ambis1.model.bl.member.doGetAllByType(ambis1.model.vo.tMEMBER.TEAM);
                this.dgResults.DataSource = doAction.execute();
                foreach (DataGridViewColumn c in this.dgResults.Columns)
                {
                    c.Visible = false;
                }
                this.dgResults.Columns["FirstName"].Visible = true;
                this.dgResults.Columns["MiddleName"].Visible = true;
                //this.dgResults.Columns["LastName"].Visible = true;
                this.dgResults.Columns["Phone"].Visible = true;
                this.dgResults.Columns["Email"].Visible = true;
                //this.dgResults.Columns["SSN"].Visible = true;

                this.dgResults.Columns["FirstName"].HeaderText = "Team Name";
                this.dgResults.Columns["MiddleName"].HeaderText = "Manager Name";
                //if (this.dgResults.Columns.Contains("ID")) this.dgResults.Columns["ID"].Visible = false;
                ////if (this.dgResults.Columns.Contains("Price"))
                ////{
                ////    this.dgResults.Columns["Price"].CellTemplate.Style.Format = _common.constants.format.PRICE;
                ////    this.dgResults.Columns["Price"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                ////}
                //if (this.dgResults.Columns.Contains("Photo")) this.dgResults.Columns["Photo"].Visible = false;
                //if (this.dgResults.Columns.Contains("Parent")) this.dgResults.Columns["Parent"].Visible = false;
                ////if (this.dgResults.Columns.Contains("Description")) this.dgResults.Columns["Description"].DisplayIndex = 0;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmTeamQry_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void seeMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgResults.CurrentRow != null)
                {
                    model.vo.Member selectedMember = (model.vo.Member)this.dgResults.CurrentRow.DataBoundItem;
                    model.bl.membership.doGetByMember doGet = new ambis1.model.bl.membership.doGetByMember(selectedMember);
                    model.vo.Membership membership = doGet.execute();
                    if (membership != null)
                    {
                        membership.frmMemberShipEdit vVen = new ambis1.gui.pc.frm.membership.frmMemberShipEdit(membership);
                        vVen.MdiParent = this.MdiParent;
                        vVen.Show();
                    }
                }
                else
                    template._common.messages.ShowWarning(_common.constants.messages.NO_RECORD_SELECTED, this.Text);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgResults_DoubleClick(object sender, EventArgs e)
        {
            seeMembershipToolStripMenuItem_Click(null, null);
        }
    }
}
