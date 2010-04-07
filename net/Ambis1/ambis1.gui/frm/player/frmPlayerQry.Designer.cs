namespace ambis1.gui.pc.frm.player
{
    partial class frmPlayerQry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerQry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.menuResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSSN = new repsol.forms.controls.TextBoxColor();
            this.labFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new repsol.forms.controls.TextBoxColor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labSSN = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.menuResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgResults);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 650);
            this.groupBox2.TabIndex = 1;
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
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(3, 16);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.RowHeadersVisible = false;
            this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResults.Size = new System.Drawing.Size(1010, 631);
            this.dgResults.TabIndex = 1;
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
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(928, 19);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(76, 50);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSSN
            // 
            this.txtSSN.ActivateStyle = true;
            this.txtSSN.BackColor = System.Drawing.Color.White;
            this.txtSSN.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSSN.ColorLeave = System.Drawing.Color.White;
            this.txtSSN.Location = new System.Drawing.Point(112, 49);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(150, 20);
            this.txtSSN.TabIndex = 14;
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(31, 25);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(35, 13);
            this.labFirstName.TabIndex = 9;
            this.labFirstName.Text = "Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.ActivateStyle = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFirstName.ColorLeave = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(112, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 8;
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Visible = false;
            // 
            // labSSN
            // 
            this.labSSN.AutoSize = true;
            this.labSSN.Location = new System.Drawing.Point(31, 52);
            this.labSSN.Name = "labSSN";
            this.labSSN.Size = new System.Drawing.Size(29, 13);
            this.labSSN.TabIndex = 15;
            this.labSSN.Text = "SSN";
            // 
            // frmPlayerQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlayerQry";
            this.Text = "Players";
            this.Load += new System.EventHandler(this.frmPlayerQry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.menuResults.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearch;
        private repsol.forms.controls.TextBoxColor txtSSN;
        private System.Windows.Forms.Label labFirstName;
        private repsol.forms.controls.TextBoxColor txtFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSSN;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.ContextMenuStrip menuResults;
        private System.Windows.Forms.ToolStripMenuItem seeMembershipToolStripMenuItem;
    }
}