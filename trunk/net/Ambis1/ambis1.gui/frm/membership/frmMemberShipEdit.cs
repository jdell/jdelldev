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
    public partial class frmMemberShipEdit : Form
    {
        model.vo.Membership _innerVO = null;
        List<model.vo.Member> _players = new List<ambis1.model.vo.Member>();
        public frmMemberShipEdit()
        {
            InitializeComponent();
        }
        public frmMemberShipEdit(model.vo.Membership innerVO)
        {
            InitializeComponent();

            this._innerVO = innerVO;
        }

        private void SetStyle()
        {
                foreach (DataGridViewColumn c in this.dgPlayersInTeam.Columns)
                {
                    c.Visible = false;
                }
                if (this.dgPlayersInTeam.Columns.Contains("FirstName")) this.dgPlayersInTeam.Columns["FirstName"].Visible = true;
                if (this.dgPlayersInTeam.Columns.Contains("MiddleName")) this.dgPlayersInTeam.Columns["MiddleName"].Visible = true;
                if (this.dgPlayersInTeam.Columns.Contains("LastName")) this.dgPlayersInTeam.Columns["LastName"].Visible = true;
                if (this.dgPlayersInTeam.Columns.Contains("Phone")) this.dgPlayersInTeam.Columns["Phone"].Visible = true;
                if (this.dgPlayersInTeam.Columns.Contains("Email")) this.dgPlayersInTeam.Columns["Email"].Visible = true;
                if (this.dgPlayersInTeam.Columns.Contains("SSN")) this.dgPlayersInTeam.Columns["SSN"].Visible = true;
        }

        private void frmMemberShipEdit_Load(object sender, EventArgs e)
        {
            try
            {
                model.bl.typeofmembership.doGetAll types = new ambis1.model.bl.typeofmembership.doGetAll();
                List<model.vo.TypeOfMembership> list = types.execute();
                rblistTypeOfMembership.DataSource = list;

                if (list.Count > 0) rblistTypeOfMembership.SelectedIndex = 0;

                loadData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
                MessageBox.Show(_common.constants.messages.RECORD_SAVED);
                this.Close();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        

        private void loadData()
        {
            if (_innerVO != null)
            {
                this.txtStartDate.Value = _innerVO.FromDate;
                this.rblistTypeOfMembership.SelectedItem = _innerVO.TypeOfMembership;
              
                model.bl.member.doGet doGet = new ambis1.model.bl.member.doGet(_innerVO.Member);
                _innerVO.Member = doGet.execute();

                this.mviewMember.setMember(_innerVO.Member);

                this.rbTypeOfMemberPlayer.Checked = _innerVO.Member.TypeOfMember == ambis1.model.vo.tMEMBER.PLAYER;
                this.rbTypeOfMemberTeam.Checked = _innerVO.Member.TypeOfMember == ambis1.model.vo.tMEMBER.TEAM;
                this.rbTypeOfMemberFamily.Checked = _innerVO.Member.TypeOfMember == ambis1.model.vo.tMEMBER.FAMILY;
              
                this.chkPaid.Checked = _innerVO.Paid;

                this.gboxExpired.Visible = _innerVO.IsExpired;

                gboxTypeOfMember.Enabled = false;
                if (!_innerVO.IsExpired) gboxTypeOfMembership.Enabled = false;

                if (_innerVO.Member.TypeOfMember == ambis1.model.vo.tMEMBER.TEAM)
                {
                    model.bl.member.doGetAllPlayersByTeam doGetAllPlayers = new ambis1.model.bl.member.doGetAllPlayersByTeam((model.vo.Team)_innerVO.Member);
                    _players = doGetAllPlayers.execute();
                    //this.dgPlayersInTeam.DataSource = null;
                    //this.dgPlayersInTeam.DataSource = _players;

                    this.mviewMember.switchTo(ambis1.model.vo.tMEMBER.TEAM);
                }
                SetMViewMember();
                this.labPriceValue.Text = _innerVO.Price.ToString(_common.constants.format.PRICE);
            }
            else
            {
                this.rbTypeOfMemberPlayer.Checked = true;
                SetMViewMember();
            }
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _players;
            this.dgPlayersInTeam.DataSource = bindingSource;
            SetStyle();

        }
        private void saveData()
        {
            model.vo.Membership tmpVO = new ambis1.model.vo.Membership();
            tmpVO.Paid = this.chkPaid.Checked;
            tmpVO.CreationDate = DateTime.Now;
            tmpVO.FromDate = this.txtStartDate.Value;
            tmpVO.Member = mviewMember.getMember(this.rbTypeOfMemberPlayer.Checked ? model.vo.tMEMBER.PLAYER : ambis1.model.vo.tMEMBER.TEAM);
            if (rblistTypeOfMembership.SelectedItem != null)
            {
                tmpVO.TypeOfMembership = (model.vo.TypeOfMembership)rblistTypeOfMembership.SelectedItem;
                tmpVO.NumOfMonths = tmpVO.TypeOfMembership.NumOfMonths;
                if (this.rbTypeOfMemberPlayer.Checked)
                    tmpVO.Price = tmpVO.TypeOfMembership.IndividualPrice;
                else
                {
                    if (this.rbTypeOfMemberFamily.Checked)
                        tmpVO.Price = tmpVO.TypeOfMembership.FamilyPrice;
                    else
                    {
                        Single price = 0;
                        Single.TryParse(this.labPriceValue.Text, out price);
                        tmpVO.Price = price;//tmpVO.TypeOfMembership.TeamPrice;
                    }
                }
            }


            if (_innerVO != null)
            {
                tmpVO.ID = _innerVO.ID;
                tmpVO.Member.ID = _innerVO.Member.ID;

                if (tmpVO.Member.TypeOfMember == ambis1.model.vo.tMEMBER.TEAM)
                {
                    model.vo.Team team = (model.vo.Team)tmpVO.Member;
                    foreach (model.vo.Member member in _players)
                    {
                        team.Players.Add((model.vo.Player)member);
                    }
                    tmpVO.Member = team;
                }
                
                model.bl.membership.doUpdate doAction = new ambis1.model.bl.membership.doUpdate(tmpVO);
                doAction.execute();
            }
            else
            {
                if (tmpVO.Member.TypeOfMember == ambis1.model.vo.tMEMBER.TEAM)
                {
                    model.vo.Team team = (model.vo.Team)tmpVO.Member;
                    foreach (model.vo.Member member in _players)
                    {
                        team.Players.Add((model.vo.Player)member);
                    }
                    tmpVO.Member = team;
                }
                model.bl.membership.doAdd doAction = new ambis1.model.bl.membership.doAdd(tmpVO);
                doAction.execute();
            }
        }
        private void rblistTypeOfMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rblistTypeOfMembership.SelectedItem != null)
                {
                    model.vo.TypeOfMembership typeOfMembership = (model.vo.TypeOfMembership)rblistTypeOfMembership.SelectedItem;
                    //this.labPriceValue.Text = this.rbTypeOfMemberPlayer.Checked ? typeOfMembership.IndividualPrice.ToString(_common.constants.format.CURRENCY) : (this.rbTypeOfMemberFamily.Checked ? typeOfMembership.FamilyPrice.ToString(_common.constants.format.CURRENCY) : typeOfMembership.TeamPrice.ToString(_common.constants.format.CURRENCY));
                    this.labPriceValue.Text = this.rbTypeOfMemberPlayer.Checked ? typeOfMembership.IndividualPrice.ToString(_common.constants.format.PRICE) : (this.rbTypeOfMemberFamily.Checked ? typeOfMembership.FamilyPrice.ToString(_common.constants.format.PRICE) : typeOfMembership.TeamPrice.ToString(_common.constants.format.PRICE));
                    this.txtDueDate.Text = this.txtStartDate.Value.AddMonths(typeOfMembership.NumOfMonths).ToString(_common.constants.format.DATE);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btRenew_Click(object sender, EventArgs e)
        {
            try
            {
                _innerVO.Active = false;
                model.bl.membership.doUpdate doUpdate = new ambis1.model.bl.membership.doUpdate(_innerVO);
                doUpdate.execute();
                _innerVO = null;

                this.txtStartDate.Value = DateTime.Now;
                this.gboxExpired.Visible = false;

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void gboxExpired_VisibleChanged(object sender, EventArgs e)
        {
            this.txtStartDate.Enabled = !this.gboxExpired.Visible;
            this.txtDueDate.Enabled = !this.gboxExpired.Visible;
            this.labStartDate.Enabled = !this.gboxExpired.Visible;
            this.labDueDate.Enabled = !this.gboxExpired.Visible;
            this.mviewMember.Enabled = !this.gboxExpired.Visible;
            this.gboxTypeOfMember.Enabled = !this.gboxExpired.Visible;
            this.gboxTypeOfMembership.Enabled = !this.gboxExpired.Visible;


            this.chkPaid.Enabled = !this.gboxExpired.Visible;

            this.gboxInfoPlayer.Enabled = !this.gboxExpired.Visible;
            this.gboxPlayersInTeam.Enabled = !this.gboxExpired.Visible;
            this.toolStrip1.Enabled = !this.gboxExpired.Visible;
        }

        private void txtStartDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rblistTypeOfMembership.SelectedItem != null)
                {
                    model.vo.TypeOfMembership typeOfMembership = (model.vo.TypeOfMembership)rblistTypeOfMembership.SelectedItem;
                    this.txtDueDate.Text = this.txtStartDate.Value.AddMonths(typeOfMembership.NumOfMonths).ToString(_common.constants.format.DATE);
                }
                else
                    this.txtDueDate.Text = this.txtStartDate.Value.AddMonths(0).ToString(_common.constants.format.DATE);
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
                model.vo.Player player = new ambis1.model.vo.Player();
                player.FirstName = this.txtInTeamFirstName.Text;
                player.DateOfBirth = this.txtInTeamDateOfBirth.Value;
                player.LastName = this.txtInTeamLastName.Text;
                player.Address = this.txtInTeamAddress.Text;
                if ((!String.IsNullOrEmpty(player.FirstName)) && (!String.IsNullOrEmpty(player.LastName)))
                {
                    savePlayerInTeam(player);

                    this.txtInTeamDateOfBirth.ResetText();
                    this.txtInTeamFirstName.ResetText();
                    this.txtInTeamLastName.ResetText();
                    this.txtInTeamAddress.ResetText();
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }   
        }

        private void btMoreDetails_Click(object sender, EventArgs e)
        {
            try
            {
                player.frmPlayerEdit vVen = new ambis1.gui.pc.frm.player.frmPlayerEdit();
                vVen.ShowDialog();
                if (vVen.DialogResult == DialogResult.OK)
                    savePlayerInTeam((model.vo.Player)vVen.Member);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void savePlayerInTeam(model.vo.Player player)
        {
            try
            {
                //_players.Sort();
                try
                {
                    int index = _players.IndexOf(player);
                    if (index > -1)
                        _players[index] = player;
                    else
                        _players.Add(player);
                }
                catch (Exception ex)
                {
                }
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = _players;
                this.dgPlayersInTeam.DataSource = bindingSource;
                SetStyle();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tsbModifyPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgPlayersInTeam.CurrentRow == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                model.vo.Member vo = (model.vo.Member)this.dgPlayersInTeam.CurrentRow.DataBoundItem;
                    
                player.frmPlayerEdit vVen = new ambis1.gui.pc.frm.player.frmPlayerEdit(vo);
                vVen.ShowDialog();
                if (vVen.DialogResult == DialogResult.OK)
                    savePlayerInTeam((model.vo.Player)vVen.Member);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                player.frmPlayerEdit vVen = new ambis1.gui.pc.frm.player.frmPlayerEdit();
                vVen.ShowDialog();
                if (vVen.DialogResult == DialogResult.OK)
                    savePlayerInTeam((model.vo.Player)vVen.Member);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void rbTypeOfMemberFamily_Click(object sender, EventArgs e)
        {
            SetMViewMember(); 
        }

        private void rbTypeOfMemberTeam_Click(object sender, EventArgs e)
        {
            SetMViewMember();
        }

        private void rbTypeOfMemberPlayer_Click(object sender, EventArgs e)
        {
            SetMViewMember();
        }

        private void SetMViewMember()
        {
            try
            {
                if ((this.rbTypeOfMemberPlayer.Checked) || (this.rbTypeOfMemberFamily.Checked))
                {
                    if (this.tabControl.TabPages.Contains(this.tpagePlayers))
                        this.tabControl.TabPages.Remove(this.tpagePlayers);
                    if (this.rbTypeOfMemberPlayer.Checked)
                        this.mviewMember.switchTo(ambis1.model.vo.tMEMBER.PLAYER);
                    else
                        this.mviewMember.switchTo(ambis1.model.vo.tMEMBER.FAMILY);
                    this.labPriceValue.ReadOnly = true;
                    this.labPriceValue.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    if (!this.tabControl.TabPages.Contains(this.tpagePlayers))
                        this.tabControl.TabPages.Add(this.tpagePlayers);

                    this.mviewMember.switchTo(ambis1.model.vo.tMEMBER.TEAM);

                    this.dgPlayersInTeam.DataSource = _players;
                    SetStyle();
                    this.labPriceValue.ReadOnly = false;
                    this.labPriceValue.BackColor = System.Drawing.Color.White;
                }
                rblistTypeOfMembership_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void labPriceValue_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.labPriceValue.Text))
                {
                    Single price = 0;
                    e.Cancel = !Single.TryParse(this.labPriceValue.Text, out price);
                    if (e.Cancel) template._common.messages.ShowWarning(_common.constants.messages.INCORRECT_NUMERIC_VALUE, "Price");
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void labPriceValue_Validated(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.labPriceValue.Text)) this.labPriceValue.Text = "0";

                this.labPriceValue.Text = Convert.ToSingle(this.labPriceValue.Text).ToString(_common.constants.format.PRICE);
                
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbDeletePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgPlayersInTeam.CurrentRow == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(ambis1.gui.pc._common.constants.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    model.vo.Member vo = (model.vo.Member)this.dgPlayersInTeam.CurrentRow.DataBoundItem;
                    if (!model.common.constants.empty.IsEmpty((Int32)vo.ID))
                    {
                        vo.Parent = null;
                        model.bl.member.doUpdate doUpdate = new ambis1.model.bl.member.doUpdate(vo);
                        doUpdate.execute();
                    }
                    _players.Remove(vo);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = _players;
                    this.dgPlayersInTeam.DataSource = bindingSource;
                    //MessageBox.Show("Under construction"); 
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgPlayersInTeam_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                //throw;
            }
        }
    }
}
