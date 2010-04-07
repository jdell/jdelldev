using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.player
{
    public partial class frmPlayerQry : Form
    {
        public frmPlayerQry()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            try
            {
                model.bl.member.doGetAllByTypes doAction = new ambis1.model.bl.member.doGetAllByTypes(new model.vo.tMEMBER[] { ambis1.model.vo.tMEMBER.PLAYER, ambis1.model.vo.tMEMBER.FAMILY });
                this.dgResults.DataSource = doAction.execute();
                foreach (DataGridViewColumn c in this.dgResults.Columns)
                {
                    c.Visible = false;
                }
                this.dgResults.Columns["TypeOfMember"].Visible = true;
                this.dgResults.Columns["FirstName"].Visible = true;
                this.dgResults.Columns["MiddleName"].Visible = true;
                this.dgResults.Columns["LastName"].Visible = true;
                this.dgResults.Columns["Phone"].Visible = true;
                this.dgResults.Columns["Email"].Visible = true;
                this.dgResults.Columns["Code"].Visible = true;
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
            if (!this.Modal)
                seeMembershipToolStripMenuItem_Click(null, null);
            else
                SelectPlayer();
        }

        private void SelectPlayer()
        {
            if (this.dgResults.CurrentRow != null)
            {
                model.vo.Member selectedMember = (model.vo.Member)this.dgResults.CurrentRow.DataBoundItem;
                _selectedPlayer = (model.vo.Player)selectedMember;
                this.DialogResult = DialogResult.OK;
            }
            else
                template._common.messages.ShowWarning(_common.constants.messages.NO_RECORD_SELECTED, this.Text);

        }

        private model.vo.Player _selectedPlayer = null;

        public model.vo.Player SelectedPlayer
        {
            get { return _selectedPlayer; }
        }

        private void frmPlayerQry_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
