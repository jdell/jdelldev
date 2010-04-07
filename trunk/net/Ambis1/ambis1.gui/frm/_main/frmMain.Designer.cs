namespace ambis1.gui.pc.frm._main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbar = new System.Windows.Forms.ToolStrip();
            this.tsbCalendar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPlayer = new System.Windows.Forms.ToolStripButton();
            this.tsbTeam = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMembership = new System.Windows.Forms.ToolStripDropDownButton();
            this.newMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.typeOfMembershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWindow = new System.Windows.Forms.ToolStripDropDownButton();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbarStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbar.SuspendLayout();
            this.tbarStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbar
            // 
            this.tbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCalendar,
            this.toolStripSeparator1,
            this.tsbPlayer,
            this.tsbTeam,
            this.toolStripSeparator6,
            this.tsbMembership,
            this.toolStripSeparator7,
            this.tsbAdmin,
            this.toolStripSeparator8,
            this.tsbWindow});
            this.tbar.Location = new System.Drawing.Point(0, 0);
            this.tbar.Name = "tbar";
            this.tbar.Size = new System.Drawing.Size(1016, 39);
            this.tbar.TabIndex = 0;
            this.tbar.Text = "toolStrip1";
            // 
            // tsbCalendar
            // 
            this.tsbCalendar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalendar.Image")));
            this.tsbCalendar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalendar.Name = "tsbCalendar";
            this.tsbCalendar.Size = new System.Drawing.Size(86, 36);
            this.tsbCalendar.Text = "Calendar";
            this.tsbCalendar.Click += new System.EventHandler(this.tsbCalendar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbPlayer
            // 
            this.tsbPlayer.Image = global::ambis1.gui.pc.Properties.Resources.baseball_icon_100px;
            this.tsbPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlayer.Name = "tsbPlayer";
            this.tsbPlayer.Size = new System.Drawing.Size(78, 36);
            this.tsbPlayer.Text = "Players";
            this.tsbPlayer.Click += new System.EventHandler(this.tsbPlayer_Click);
            // 
            // tsbTeam
            // 
            this.tsbTeam.Image = ((System.Drawing.Image)(resources.GetObject("tsbTeam.Image")));
            this.tsbTeam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTeam.Name = "tsbTeam";
            this.tsbTeam.Size = new System.Drawing.Size(74, 36);
            this.tsbTeam.Text = "Teams";
            this.tsbTeam.Click += new System.EventHandler(this.tsbTeam_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbMembership
            // 
            this.tsbMembership.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMembershipToolStripMenuItem,
            this.viewAllToolStripMenuItem});
            this.tsbMembership.Image = ((System.Drawing.Image)(resources.GetObject("tsbMembership.Image")));
            this.tsbMembership.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMembership.Name = "tsbMembership";
            this.tsbMembership.Size = new System.Drawing.Size(109, 36);
            this.tsbMembership.Text = "Membership";
            // 
            // newMembershipToolStripMenuItem
            // 
            this.newMembershipToolStripMenuItem.Name = "newMembershipToolStripMenuItem";
            this.newMembershipToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newMembershipToolStripMenuItem.Text = "New membership";
            this.newMembershipToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewAllToolStripMenuItem.Text = "View All";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAdmin
            // 
            this.tsbAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeOfMembershipsToolStripMenuItem,
            this.cagesToolStripMenuItem});
            this.tsbAdmin.Image = global::ambis1.gui.pc.Properties.Resources.key_icon;
            this.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdmin.Name = "tsbAdmin";
            this.tsbAdmin.Size = new System.Drawing.Size(81, 36);
            this.tsbAdmin.Text = "Admin";
            // 
            // typeOfMembershipsToolStripMenuItem
            // 
            this.typeOfMembershipsToolStripMenuItem.Name = "typeOfMembershipsToolStripMenuItem";
            this.typeOfMembershipsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.typeOfMembershipsToolStripMenuItem.Text = "Types Of Membership";
            this.typeOfMembershipsToolStripMenuItem.Click += new System.EventHandler(this.typeOfMembershipsToolStripMenuItem_Click);
            // 
            // cagesToolStripMenuItem
            // 
            this.cagesToolStripMenuItem.Name = "cagesToolStripMenuItem";
            this.cagesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cagesToolStripMenuItem.Text = "Cages";
            this.cagesToolStripMenuItem.Click += new System.EventHandler(this.cagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbWindow
            // 
            this.tsbWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.tsbWindow.Image = global::ambis1.gui.pc.Properties.Resources.Application;
            this.tsbWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWindow.Name = "tsbWindow";
            this.tsbWindow.Size = new System.Drawing.Size(90, 36);
            this.tsbWindow.Text = "Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Image = global::ambis1.gui.pc.Properties.Resources.Application_cascade;
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Image = global::ambis1.gui.pc.Properties.Resources.Application_tile_vertical;
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Image = global::ambis1.gui.pc.Properties.Resources.Application_tile_horizontal;
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tbarStatus
            // 
            this.tbarStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbarStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbarStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.tbarStatus.Location = new System.Drawing.Point(0, 709);
            this.tbarStatus.Name = "tbarStatus";
            this.tbarStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tbarStatus.Size = new System.Drawing.Size(1016, 25);
            this.tbarStatus.TabIndex = 1;
            this.tbarStatus.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(246, 22);
            this.toolStripLabel1.Text = "Go to Double Play Training Center website!";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(271, 22);
            this.toolStripButton1.Text = "--> View Events/Alerts/Notifications Here! <--";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.tbarStatus);
            this.Controls.Add(this.tbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Double Play Training Center";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbar.ResumeLayout(false);
            this.tbar.PerformLayout();
            this.tbarStatus.ResumeLayout(false);
            this.tbarStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbar;
        private System.Windows.Forms.ToolStrip tbarStatus;
        private System.Windows.Forms.ToolStripButton tsbPlayer;
        private System.Windows.Forms.ToolStripButton tsbTeam;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbCalendar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbMembership;
        private System.Windows.Forms.ToolStripMenuItem newMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton tsbAdmin;
        private System.Windows.Forms.ToolStripMenuItem typeOfMembershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsbWindow;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}