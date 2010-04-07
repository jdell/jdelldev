namespace ambis1.gui.pc.frm.membership
{
    partial class frmMemberShipQry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberShipQry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.tbarMain = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btModify = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tbarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgResults);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 703);
            this.groupBox2.TabIndex = 4;
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
            this.dgResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(3, 16);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.RowHeadersVisible = false;
            this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResults.Size = new System.Drawing.Size(1010, 684);
            this.dgResults.TabIndex = 2;
            this.dgResults.DoubleClick += new System.EventHandler(this.dgResults_DoubleClick);
            this.dgResults.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgResults_CellPainting);
            // 
            // tbarMain
            // 
            this.tbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbarMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btModify,
            this.btDelete,
            this.toolStripSeparator1,
            this.tsbRefresh});
            this.tbarMain.Location = new System.Drawing.Point(0, 0);
            this.tbarMain.Name = "tbarMain";
            this.tbarMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbarMain.Size = new System.Drawing.Size(1016, 31);
            this.tbarMain.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAdd.Image = global::ambis1.gui.pc.Properties.Resources.Add;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(28, 28);
            this.btAdd.Tag = "Add Membership";
            this.btAdd.Text = "Add Membership";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModify
            // 
            this.btModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btModify.Image = global::ambis1.gui.pc.Properties.Resources.Modify;
            this.btModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(28, 28);
            this.btModify.Tag = "Modify Membership";
            this.btModify.Text = "Modify Membership";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btDelete
            // 
            this.btDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDelete.Image = global::ambis1.gui.pc.Properties.Resources.Remove;
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(28, 28);
            this.btDelete.Tag = "Delete Membership";
            this.btDelete.Text = "Delete Membership";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::ambis1.gui.pc.Properties.Resources.Refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(28, 28);
            this.tsbRefresh.Tag = "Refresh data";
            this.tsbRefresh.Text = "Refresh data";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // frmMemberShipQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemberShipQry";
            this.Text = "Memberships";
            this.Load += new System.EventHandler(this.frmMemberShipQry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tbarMain.ResumeLayout(false);
            this.tbarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.ToolStrip tbarMain;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btModify;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
    }
}