namespace ambis1.gui.pc.frm.typeofmembership
{
    partial class frmTypeOfMemberShipEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeOfMemberShipEdit));
            this.txtNumOfMonths = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndividualPrice = new System.Windows.Forms.TextBox();
            this.gboxContainer = new System.Windows.Forms.GroupBox();
            this.btAccept = new System.Windows.Forms.Button();
            this.txtTeamPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamiliarPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOfMonths)).BeginInit();
            this.gboxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumOfMonths
            // 
            this.txtNumOfMonths.Location = new System.Drawing.Point(122, 24);
            this.txtNumOfMonths.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtNumOfMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumOfMonths.Name = "txtNumOfMonths";
            this.txtNumOfMonths.Size = new System.Drawing.Size(120, 20);
            this.txtNumOfMonths.TabIndex = 0;
            this.txtNumOfMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num. of Months";
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Image = global::ambis1.gui.pc.Properties.Resources.No;
            this.btCancel.Location = new System.Drawing.Point(208, 149);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 33);
            this.btCancel.TabIndex = 5;
            this.btCancel.Tag = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Individual Price";
            // 
            // txtIndividualPrice
            // 
            this.txtIndividualPrice.Location = new System.Drawing.Point(122, 50);
            this.txtIndividualPrice.Name = "txtIndividualPrice";
            this.txtIndividualPrice.Size = new System.Drawing.Size(120, 20);
            this.txtIndividualPrice.TabIndex = 1;
            // 
            // gboxContainer
            // 
            this.gboxContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxContainer.Controls.Add(this.txtFamiliarPrice);
            this.gboxContainer.Controls.Add(this.label4);
            this.gboxContainer.Controls.Add(this.txtTeamPrice);
            this.gboxContainer.Controls.Add(this.label3);
            this.gboxContainer.Controls.Add(this.btCancel);
            this.gboxContainer.Controls.Add(this.txtIndividualPrice);
            this.gboxContainer.Controls.Add(this.btAccept);
            this.gboxContainer.Controls.Add(this.label2);
            this.gboxContainer.Controls.Add(this.txtNumOfMonths);
            this.gboxContainer.Controls.Add(this.label1);
            this.gboxContainer.Location = new System.Drawing.Point(14, 18);
            this.gboxContainer.Name = "gboxContainer";
            this.gboxContainer.Size = new System.Drawing.Size(289, 188);
            this.gboxContainer.TabIndex = 0;
            this.gboxContainer.TabStop = false;
            // 
            // btAccept
            // 
            this.btAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAccept.Image = global::ambis1.gui.pc.Properties.Resources.Yes;
            this.btAccept.Location = new System.Drawing.Point(127, 149);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(75, 33);
            this.btAccept.TabIndex = 4;
            this.btAccept.Tag = "Save";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // txtTeamPrice
            // 
            this.txtTeamPrice.Location = new System.Drawing.Point(122, 76);
            this.txtTeamPrice.Name = "txtTeamPrice";
            this.txtTeamPrice.Size = new System.Drawing.Size(120, 20);
            this.txtTeamPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Team Price";
            // 
            // txtFamiliarPrice
            // 
            this.txtFamiliarPrice.Location = new System.Drawing.Point(122, 102);
            this.txtFamiliarPrice.Name = "txtFamiliarPrice";
            this.txtFamiliarPrice.Size = new System.Drawing.Size(120, 20);
            this.txtFamiliarPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Family Price";
            // 
            // frmTypeOfMemberShipEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 224);
            this.Controls.Add(this.gboxContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTypeOfMemberShipEdit";
            this.Text = "Type of Membership";
            this.Load += new System.EventHandler(this.frmTypeOfMemberShipEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOfMonths)).EndInit();
            this.gboxContainer.ResumeLayout(false);
            this.gboxContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.NumericUpDown txtNumOfMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndividualPrice;
        private System.Windows.Forms.GroupBox gboxContainer;
        private System.Windows.Forms.TextBox txtFamiliarPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeamPrice;
        private System.Windows.Forms.Label label3;
    }
}