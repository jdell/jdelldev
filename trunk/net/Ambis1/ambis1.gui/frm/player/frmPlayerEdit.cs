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
    public partial class frmPlayerEdit : Form
    {
        public model.vo.Member Member
        {
            get
            {
                return mviewMember.getMember(model.vo.tMEMBER.PLAYER);
            }
        }
        public frmPlayerEdit()
        {
            InitializeComponent();
        }
        model.vo.Member _player = null;
        public frmPlayerEdit(model.vo.Member player)
        {
            InitializeComponent();
            _player = player;
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmPlayerEdit_Load(object sender, EventArgs e)
        {
            try
            {
                mviewMember.setMember(_player);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                player.frmPlayerQry vVen = new frmPlayerQry();
                vVen.ShowDialog();
                if (vVen.DialogResult == DialogResult.OK)
                    mviewMember.setMember(vVen.SelectedPlayer);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
