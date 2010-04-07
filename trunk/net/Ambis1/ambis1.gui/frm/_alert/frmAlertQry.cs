using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm._alert
{
    public partial class frmAlertQry : Form
    {
        public frmAlertQry()
        {
            InitializeComponent();
        }

        private void frmAlertQry_Load(object sender, EventArgs e)
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
                model.bl.alert.doGetAllBirthdays doActionBirthdays = new ambis1.model.bl.alert.doGetAllBirthdays();
                this.dgResultBirthdays.DataSource = doActionBirthdays.execute();
                this.dgResultBirthdays.Columns["Message"].HeaderText= "Today's Birthday";

                model.bl.alert.doGetAllExpirations doActionExpirations = new ambis1.model.bl.alert.doGetAllExpirations();
                this.dgResultsExpirations.DataSource = doActionExpirations.execute();
                this.dgResultsExpirations.Columns["Message"].HeaderText = "Today's Birthday";
                //foreach (DataGridViewColumn c in this.dgResults.Columns)
                //    c.Visible = false;

                //this.dgResults.Columns["TypeOfMember"].Visible = true;
                //this.dgResults.Columns["Member"].Visible = true;
                //this.dgResults.Columns["TypeOfMembership"].Visible = true;
                //this.dgResults.Columns["FromDate"].Visible = true;
                //this.dgResults.Columns["ToDate"].Visible = true;
                //this.dgResults.Columns["IsExpired"].Visible = true;

                //int i = 0;
                //this.dgResults.Columns["TypeOfMember"].DisplayIndex = i++;
                //this.dgResults.Columns["Member"].DisplayIndex = i++;
                //this.dgResults.Columns["TypeOfMembership"].DisplayIndex = i++;
                //this.dgResults.Columns["FromDate"].DisplayIndex = i++;
                //this.dgResults.Columns["ToDate"].DisplayIndex = i++;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
