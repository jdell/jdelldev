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
    public partial class frmTypeOfMemberShipQry : Form
    {
        public frmTypeOfMemberShipQry()
        {
            InitializeComponent();
        }

        private void frmTypeOfMemberShipQry_Load(object sender, EventArgs e)
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

        private void loadData()
        {
            try
            {
                model.bl.typeofmembership.doGetAll doAction = new ambis1.model.bl.typeofmembership.doGetAll();
                this.dgResults.DataSource = doAction.execute();
                if (this.dgResults.Columns.Contains("ID")) this.dgResults.Columns["ID"].Visible = false;
                if (this.dgResults.Columns.Contains("IndividualPrice"))
                {
                    this.dgResults.Columns["IndividualPrice"].CellTemplate.Style.Format = _common.constants.format.PRICE;
                    this.dgResults.Columns["IndividualPrice"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (this.dgResults.Columns.Contains("TeamPrice"))
                {
                    this.dgResults.Columns["TeamPrice"].CellTemplate.Style.Format = _common.constants.format.PRICE;
                    this.dgResults.Columns["TeamPrice"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (this.dgResults.Columns.Contains("FamilyPrice"))
                {
                    this.dgResults.Columns["FamilyPrice"].CellTemplate.Style.Format = _common.constants.format.PRICE;
                    this.dgResults.Columns["FamilyPrice"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (this.dgResults.Columns.Contains("NumOfMonths")) this.dgResults.Columns["NumOfMonths"].Visible = false;
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
                typeofmembership.frmTypeOfMemberShipEdit vVen = new ambis1.gui.pc.frm.typeofmembership.frmTypeOfMemberShipEdit();
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
                    model.vo.TypeOfMembership type = (model.vo.TypeOfMembership)this.dgResults.CurrentRow.DataBoundItem;
                    model.bl.typeofmembership.doDelete doAction = new ambis1.model.bl.typeofmembership.doDelete(type);
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
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                model.vo.TypeOfMembership vo = (model.vo.TypeOfMembership)this.dgResults.CurrentRow.DataBoundItem;

                typeofmembership.frmTypeOfMemberShipEdit vVen = new frmTypeOfMemberShipEdit(vo);
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
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
