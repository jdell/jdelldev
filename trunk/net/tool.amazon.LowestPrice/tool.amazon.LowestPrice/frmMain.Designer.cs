namespace tool.amazon.LowestPrice
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
            this.btSearch = new System.Windows.Forms.Button();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.gboxResult = new System.Windows.Forms.GroupBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.txtMarketPlaceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbShowISNOTlowest = new System.Windows.Forms.RadioButton();
            this.rbShowISlowest = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gboxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(758, 40);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 21);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtKeywords
            // 
            this.txtKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeywords.Location = new System.Drawing.Point(81, 41);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(671, 20);
            this.txtKeywords.TabIndex = 0;
            this.txtKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeywords_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keyword";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMarketPlaceID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKeywords);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 654);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(758, 19);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 20);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // gboxResult
            // 
            this.gboxResult.Controls.Add(this.dgResults);
            this.gboxResult.Controls.Add(this.panel1);
            this.gboxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxResult.Location = new System.Drawing.Point(0, 87);
            this.gboxResult.Name = "gboxResult";
            this.gboxResult.Size = new System.Drawing.Size(845, 567);
            this.gboxResult.TabIndex = 1;
            this.gboxResult.TabStop = false;
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(3, 69);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.Size = new System.Drawing.Size(839, 495);
            this.dgResults.TabIndex = 0;
            this.dgResults.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgResults_CellMouseClick);
            // 
            // txtMarketPlaceID
            // 
            this.txtMarketPlaceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarketPlaceID.Location = new System.Drawing.Point(81, 15);
            this.txtMarketPlaceID.Name = "txtMarketPlaceID";
            this.txtMarketPlaceID.Size = new System.Drawing.Size(671, 20);
            this.txtMarketPlaceID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MerchantID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbShowAll);
            this.panel1.Controls.Add(this.rbShowISlowest);
            this.panel1.Controls.Add(this.rbShowISNOTlowest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 53);
            this.panel1.TabIndex = 2;
            // 
            // rbShowISNOTlowest
            // 
            this.rbShowISNOTlowest.AutoSize = true;
            this.rbShowISNOTlowest.Location = new System.Drawing.Point(496, 18);
            this.rbShowISNOTlowest.Name = "rbShowISNOTlowest";
            this.rbShowISNOTlowest.Size = new System.Drawing.Size(332, 17);
            this.rbShowISNOTlowest.TabIndex = 0;
            this.rbShowISNOTlowest.Text = "Show only records where MerchantPrice IS NOT the lowest price";
            this.rbShowISNOTlowest.UseVisualStyleBackColor = true;
            this.rbShowISNOTlowest.CheckedChanged += new System.EventHandler(this.chkLowestPrice_CheckedChanged);
            // 
            // rbShowISlowest
            // 
            this.rbShowISlowest.AutoSize = true;
            this.rbShowISlowest.Location = new System.Drawing.Point(161, 18);
            this.rbShowISlowest.Name = "rbShowISlowest";
            this.rbShowISlowest.Size = new System.Drawing.Size(306, 17);
            this.rbShowISlowest.TabIndex = 1;
            this.rbShowISlowest.Text = "Show only records where MerchantPrice IS the lowest price";
            this.rbShowISlowest.UseVisualStyleBackColor = true;
            this.rbShowISlowest.CheckedChanged += new System.EventHandler(this.chkLowestPrice_CheckedChanged);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(10, 18);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(122, 17);
            this.rbShowAll.TabIndex = 2;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All the records";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.chkLowestPrice_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 710);
            this.Controls.Add(this.gboxResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Tool - Amazon - Lowest Price";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gboxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gboxResult;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.TextBox txtMarketPlaceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbShowISlowest;
        private System.Windows.Forms.RadioButton rbShowISNOTlowest;
        private System.Windows.Forms.RadioButton rbShowAll;
    }
}

