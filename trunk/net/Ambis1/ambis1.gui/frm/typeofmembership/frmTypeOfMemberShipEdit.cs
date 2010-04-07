using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.typeofmembership
{
    public partial class frmTypeOfMemberShipEdit : Form
    {
        model.vo.TypeOfMembership _innerVO = null;

        public frmTypeOfMemberShipEdit()
        {
            InitializeComponent();
        }
        public frmTypeOfMemberShipEdit(model.vo.TypeOfMembership innerVO)
        {
            InitializeComponent();

            this._innerVO = innerVO;
        }

        private void frmTypeOfMemberShipEdit_Load(object sender, EventArgs e)
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
                this.txtNumOfMonths.Value = _innerVO.NumOfMonths;
                this.txtIndividualPrice.Text = _innerVO.IndividualPrice.ToString(_common.constants.format.PRICE);
                this.txtTeamPrice.Text = _innerVO.TeamPrice.ToString(_common.constants.format.PRICE);
                this.txtFamiliarPrice.Text = _innerVO.FamilyPrice.ToString(_common.constants.format.PRICE);
            }
        }
        private void saveData()
        {
            model.vo.TypeOfMembership tmpVO = new ambis1.model.vo.TypeOfMembership();
            tmpVO.NumOfMonths = Convert.ToInt32(this.txtNumOfMonths.Value);
            Single price = 0;
            Single.TryParse(this.txtIndividualPrice.Text, out price);
            tmpVO.IndividualPrice = price;

            price = 0;
            Single.TryParse(this.txtTeamPrice.Text, out price);
            tmpVO.TeamPrice = price;

            price = 0;
            Single.TryParse(this.txtFamiliarPrice.Text, out price);
            tmpVO.FamilyPrice = price;

            if (_innerVO != null)
            {
                tmpVO.ID = _innerVO.ID;

                model.bl.typeofmembership.doUpdate doAction = new ambis1.model.bl.typeofmembership.doUpdate(tmpVO);
                doAction.execute();
            }
            else
            {
                model.bl.typeofmembership.doAdd doAction = new ambis1.model.bl.typeofmembership.doAdd(tmpVO);
                doAction.execute();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
