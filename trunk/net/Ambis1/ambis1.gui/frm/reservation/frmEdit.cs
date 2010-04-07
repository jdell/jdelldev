using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.reservation
{
    public partial class frmEdit : Form
    {
        model.vo.Reservation _innerVO = null;
        bool isNew = true;

        public frmEdit(model.vo.Reservation reservation)
        {
            InitializeComponent();
            _innerVO = reservation;
            isNew = false;
        }
        public frmEdit(DateTime date, model.vo.Cage cage)
        {
            InitializeComponent();
            _innerVO = new ambis1.model.vo.Reservation();
            _innerVO.DateAndTime = date;
            _innerVO.Duration = date.Date.AddHours(2);
            _innerVO.Cage = cage;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            model.bl.member.doGetAllByType doGetAll = new ambis1.model.bl.member.doGetAllByType(ambis1.model.vo.tMEMBER.TEAM);
            //model.bl.member.doGetAll doGetAll = new ambis1.model.bl.member.doGetAll();
            this.cmbTeam.DataSource = doGetAll.execute();
            this.cmbTeam.DisplayMember = "FullName";
            this.cmbTeam.ValueMember = "ID";


            this.txtDateAndTime.Value = _innerVO.DateAndTime;
            this.txtCage.Text = _innerVO.Cage.ToString();
            this.txtDuration.Value = _innerVO.Duration;
            if (_innerVO.Member!=null) this.cmbTeam.SelectedValue = _innerVO.Member.ID;
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            try
            {
                //model.vo.Reservation reservation = new ambis1.model.vo.Reservation();
                //_innerVO.Cage = (model.vo.Cage)this.cmbTeam.SelectedItem;
                _innerVO.DateAndTime = this.txtDateAndTime.Value;
                _innerVO.Duration = this.txtDuration.Value;
                _innerVO.Member = (model.vo.Member)this.cmbTeam.SelectedItem;

                if (isNew)
                {
                    model.bl.reservation.doAdd doAction = new ambis1.model.bl.reservation.doAdd(_innerVO);
                    doAction.execute();
                }
                else
                {
                    model.bl.reservation.doUpdate doAction = new ambis1.model.bl.reservation.doUpdate(_innerVO);
                    doAction.execute();
                }

                MessageBox.Show(_common.constants.messages.RECORD_SAVED);
                this.Close();
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
    }
}
