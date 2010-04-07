using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm._main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                membership.frmMemberShipEdit vVen = new ambis1.gui.pc.frm.membership.frmMemberShipEdit();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                membership.frmMemberShipQry vVen = new ambis1.gui.pc.frm.membership.frmMemberShipQry();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (System.Windows.Forms.Control c in this.Controls)
                {
                    if (c.GetType().FullName == typeof(System.Windows.Forms.MdiClient).FullName)
                    {
                        String path = System.IO.Path.GetFullPath(@"_template\_images\logo.png");
                        if (System.IO.File.Exists(path))
                        {
                            c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            c.BackgroundImage = new System.Drawing.Bitmap(path);
                        }
                        else
                            c.BackColor = System.Drawing.Color.LightSteelBlue;
                        break;
                    }
                }
#if DEBUG
                this.Text += " - (TEST MODE)";
#endif
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void newCageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cage.frmCageEdit vVen = new ambis1.gui.pc.frm.cage.frmCageEdit();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                reservation.frmReservation vVen = new ambis1.gui.pc.frm.reservation.frmReservation();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbTeam_Click(object sender, EventArgs e)
        {
            try
            {
                team.frmTeamQry vVen = new ambis1.gui.pc.frm.team.frmTeamQry();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                player.frmPlayerQry vVen = new ambis1.gui.pc.frm.player.frmPlayerQry();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cage.frmCageQry vVen = new ambis1.gui.pc.frm.cage.frmCageQry();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void typeOfMembershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                typeofmembership.frmTypeOfMemberShipQry vVen = new ambis1.gui.pc.frm.typeofmembership.frmTypeOfMemberShipQry();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _alert.frmAlertQry vVen = new ambis1.gui.pc.frm._alert.frmAlertQry();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.doubleplaytrainingcenter.com/");
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
