namespace ambis1.gui.pc.frm.team
{
    partial class frmTeamQry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamQry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.menuResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new repsol.forms.controls.TextBoxColor();
            this.labFirstName = new System.Windows.Forms.Label();
            this.txtSSN = new repsol.forms.controls.TextBoxColor();
            this.labSSN = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbarMain = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btModify = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.menuResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgResults);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 650);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            this.dgResults.AllowUserToResizeRows = false;
            this.dgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.ContextMenuStrip = this.menuResults;
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(3, 16);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.RowHeadersVisible = false;
            this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResults.Size = new System.Drawing.Size(1010, 631);
            this.dgResults.TabIndex = 2;
            this.dgResults.DoubleClick += new System.EventHandler(this.dgResults_DoubleClick);
            // 
            // menuResults
            // 
            this.menuResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeMembershipToolStripMenuItem});
            this.menuResults.Name = "menuResults";
            this.menuResults.Size = new System.Drawing.Size(164, 26);
            // 
            // seeMembershipToolStripMenuItem
            // 
            this.seeMembershipToolStripMenuItem.Name = "seeMembershipToolStripMenuItem";
            this.seeMembershipToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.seeMembershipToolStripMenuItem.Text = "See membership";
            this.seeMembershipToolStripMenuItem.Click += new System.EventHandler(this.seeMembershipToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.labFirstName);
            this.groupBox1.Controls.Add(this.txtSSN);
            this.groupBox1.Controls.Add(this.labSSN);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.ActivateStyle = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFirstName.ColorLeave = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(96, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(12, 34);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(65, 13);
            this.labFirstName.TabIndex = 9;
            this.labFirstName.Text = "Team Name";
            // 
            // txtSSN
            // 
            this.txtSSN.ActivateStyle = true;
            this.txtSSN.BackColor = System.Drawing.Color.White;
            this.txtSSN.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSSN.ColorLeave = System.Drawing.Color.White;
            this.txtSSN.Location = new System.Drawing.Point(336, 31);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(109, 20);
            this.txtSSN.TabIndex = 14;
            // 
            // labSSN
            // 
            this.labSSN.AutoSize = true;
            this.labSSN.Location = new System.Drawing.Point(252, 34);
            this.labSSN.Name = "labSSN";
            this.labSSN.Size = new System.Drawing.Size(78, 13);
            this.labSSN.TabIndex = 15;
            this.labSSN.Text = "Phone Number";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(934, 31);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(76, 22);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbarMain
            // 
            this.tbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbarMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btModify,
            this.btDelete});
            this.tbarMain.Location = new System.Drawing.Point(0, 0);
            this.tbarMain.Name = "tbarMain";
            this.tbarMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbarMain.Size = new System.Drawing.Size(547, 31);
            this.tbarMain.TabIndex = 6;
            this.tbarMain.Visible = false;
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdd.Image = global::ambis1.gui.pc.Properties.Resources.Add;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(28, 28);
            this.btAdd.Tag = "Add Type";
            this.btAdd.Text = "Add Type";
            // 
            // btModify
            // 
            this.btModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btModify.Image = global::ambis1.gui.pc.Properties.Resources.Modify;
            this.btModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(28, 28);
            this.btModify.Tag = "Modify Type";
            this.btModify.Text = "Modify Type";
            // 
            // btDelete
            // 
            this.btDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDelete.Image = global::ambis1.gui.pc.Properties.Resources.Remove;
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(28, 28);
            this.btDelete.Tag = "Delete Type";
            this.btDelete.Text = "Delete Type";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTeamQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeamQry";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.frmTeamQry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.menuResults.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbarMain.ResumeLayout(false);
            this.tbarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private repsol.forms.controls.TextBoxColor txtFirstName;
        private System.Windows.Forms.Label labFirstName;
        private repsol.forms.controls.TextBoxColor txtSSN;
        private System.Windows.Forms.Label labSSN;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.ContextMenuStrip menuResults;
        private System.Windows.Forms.ToolStripMenuItem seeMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tbarMain;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btModify;
        private System.Windows.Forms.ToolStripButton btDelete;
    }
}