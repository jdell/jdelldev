namespace ambis1.gui.pc.frm._alert
{
    partial class frmAlertQry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlertQry));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgResultBirthdays = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgResultsExpirations = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultBirthdays)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultsExpirations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgResultBirthdays);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 221);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Today\'s Birthdays";
            // 
            // dgResultBirthdays
            // 
            this.dgResultBirthdays.AllowUserToAddRows = false;
            this.dgResultBirthdays.AllowUserToDeleteRows = false;
            this.dgResultBirthdays.AllowUserToResizeRows = false;
            this.dgResultBirthdays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResultBirthdays.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgResultBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgResultBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultBirthdays.ColumnHeadersVisible = false;
            this.dgResultBirthdays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResultBirthdays.Location = new System.Drawing.Point(3, 16);
            this.dgResultBirthdays.Name = "dgResultBirthdays";
            this.dgResultBirthdays.ReadOnly = true;
            this.dgResultBirthdays.RowHeadersVisible = false;
            this.dgResultBirthdays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultBirthdays.Size = new System.Drawing.Size(562, 202);
            this.dgResultBirthdays.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgResultsExpirations);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memberships expirations";
            // 
            // dgResultsExpirations
            // 
            this.dgResultsExpirations.AllowUserToAddRows = false;
            this.dgResultsExpirations.AllowUserToDeleteRows = false;
            this.dgResultsExpirations.AllowUserToResizeRows = false;
            this.dgResultsExpirations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResultsExpirations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgResultsExpirations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgResultsExpirations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultsExpirations.ColumnHeadersVisible = false;
            this.dgResultsExpirations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResultsExpirations.Location = new System.Drawing.Point(3, 16);
            this.dgResultsExpirations.Name = "dgResultsExpirations";
            this.dgResultsExpirations.ReadOnly = true;
            this.dgResultsExpirations.RowHeadersVisible = false;
            this.dgResultsExpirations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultsExpirations.Size = new System.Drawing.Size(562, 263);
            this.dgResultsExpirations.TabIndex = 2;
            // 
            // frmAlertQry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlertQry";
            this.Text = "Alerts/Notifications";
            this.Load += new System.EventHandler(this.frmAlertQry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultBirthdays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultsExpirations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgResultBirthdays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgResultsExpirations;
    }
}