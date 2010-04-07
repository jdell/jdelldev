using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc._template.controls
{
    public partial class MemberView : UserControl
    {
        public MemberView()
        {
            InitializeComponent();
        }

        public void switchTo(model.vo.tMEMBER type)
        {
            switch (type)
            {
                case ambis1.model.vo.tMEMBER.TEAM:
                    this.labFirstName.Text = "Team Name";
                    this.labMiddleName.Text = "Coach Name";

                    this.labLastName.Visible = false;
                    this.txtNumber.Visible = false;
                    this.labDOB.Visible = false;
                    this.txtLastName.Visible = false;
                    this.txtNumber.Visible = true;
                    this.txtDOB.Visible = false;

                    this.gboxFamily.Visible = false;
                    break;
                case ambis1.model.vo.tMEMBER.PLAYER:
                    this.labFirstName.Text = "First Name";
                    this.labMiddleName.Text = "Middle Name";
                    this.labLastName.Visible = true;
                    this.txtNumber.Visible = true;
                    this.labDOB.Visible = true;

                    this.labLastName.Visible = true;
                    this.txtNumber.Visible = true;
                    this.labDOB.Visible = true;
                    this.txtLastName.Visible = true;
                    this.txtNumber.Visible = true;
                    this.txtDOB.Visible = true;

                    this.gboxFamily.Visible = false;
                    break;
                case ambis1.model.vo.tMEMBER.FAMILY:
                    this.labFirstName.Text = "First Name";
                    this.labMiddleName.Text = "Middle Name";
                    this.labLastName.Visible = true;
                    this.txtNumber.Visible = true;
                    this.labDOB.Visible = true;

                    this.labLastName.Visible = true;
                    this.txtNumber.Visible = true;
                    this.labDOB.Visible = true;
                    this.txtLastName.Visible = true;
                    this.txtNumber.Visible = true;
                    this.txtDOB.Visible = true;

                    this.gboxFamily.Visible = true;
                    break;
                default:
                    break;
            }
        }
        model.vo.Member _innerVO = null;
        public model.vo.Member getMember(model.vo.tMEMBER type)
        {
            model.vo.Member member;
            if (_innerVO == null)
                member = model.vo.Member.getNewMember(type);
            else
                member = _innerVO;

            member.Address = this.txtAddress.Text;
            member.Cell = this.txtCell.Text;
            member.City = this.txtCity.Text;
            member.DateOfBirth = this.txtDOB.Checked ? this.txtDOB.Value : ((type == ambis1.model.vo.tMEMBER.PLAYER)?DateTime.MinValue:DateTime.Now);
            member.Email = this.txtEmail.Text;
            member.FirstName = this.txtFirstName.Text;
            member.LastName = this.txtLastName.Text;
            member.MiddleName = this.txtMiddleName.Text;
            member.Phone = this.txtPhone.Text;
            if (this.picImage.Image != null)
                member.Photo = picImage.Image;
            else
                member.Photo = null;
            int number = 0;
            Int32.TryParse(this.txtNumber.Text, out number);
            member.Number = number;
            member.State = this.txtState.Text;
            member.ZipCode = this.txtZC.Text;

            member.Comments = this.txtComments.Text;
            member.EmergencyContactName = this.txtEmergencyContactName.Text;
            member.EmergencyContactPhone = this.txtEmergencyContactPhone.Text;
            member.EmergencyContactRelationship = this.txtEmergencyContactRelationship.Text;

            if (member.TypeOfMember== ambis1.model.vo.tMEMBER.FAMILY)
                member.Parent = (model.vo.Member)this.cmbFamily.SelectedItem;
            //if (_innerVO != null) member.ID = _innerVO.ID;

            return member;
        }
        public void setMember(model.vo.Member member)
        {
            if (member != null)
            {
                this._innerVO = member;

                this.txtAddress.Text = member.Address;
                this.txtCell.Text = member.Cell;
                this.txtCity.Text = member.City;
                if (!model.common.constants.empty.IsEmpty(member.DateOfBirth))
                {
                    this.txtDOB.Value = member.DateOfBirth;
                    this.txtDOB.Checked = true;
                }
                this.txtEmail.Text = member.Email;
                this.txtFirstName.Text = member.FirstName;
                this.txtLastName.Text = member.LastName;
                this.txtMiddleName.Text = member.MiddleName;
                this.txtPhone.Text = member.Phone;
                if (member.Photo != null) this.picImage.Image = member.Photo;
                this.txtNumber.Text = member.Code;
                this.txtState.Text = member.State;
                this.txtZC.Text = member.ZipCode;

                this.txtComments.Text = member.Comments;
                this.txtEmergencyContactName.Text = member.EmergencyContactName;
                this.txtEmergencyContactPhone.Text = member.EmergencyContactPhone;
                this.txtEmergencyContactRelationship.Text = member.EmergencyContactRelationship;

                if (member.TypeOfMember == ambis1.model.vo.tMEMBER.FAMILY)
                {
                    member.Parent = (model.vo.Member)this.cmbFamily.SelectedItem;
                }
                this.switchTo(member.TypeOfMember);
            }
            else
                this.switchTo(ambis1.model.vo.tMEMBER.PLAYER);
        }

        private void setExpired(bool expire)
        {
            this.txtAddress.Enabled = !expire;
            this.txtCell.Enabled = !expire;
            this.txtCity.Enabled = !expire;
            this.txtDOB.Enabled = !expire;
            this.txtEmail.Enabled = !expire;
            this.txtFirstName.Enabled = !expire;
            this.txtLastName.Enabled = !expire;
            this.txtMiddleName.Enabled = !expire;
            this.txtPhone.Enabled = !expire;
            this.picImage.Enabled = !expire;
            this.txtNumber.Enabled = !expire;
            this.txtState.Enabled = !expire;
            this.txtZC.Enabled = !expire;
        }

        private void MemberView_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtDOB.CustomFormat = pc._common.constants.format.DATE;
                //this.txtDOB.Value = DateTime.Now.AddYears(-12)


                model.bl.member.doGetAllByType doGetAll = new ambis1.model.bl.member.doGetAllByType(ambis1.model.vo.tMEMBER.PLAYER);
                this.cmbFamily.DataSource = doGetAll.execute();
                this.cmbFamily.DisplayMember = "FullName";
                this.cmbFamily.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
