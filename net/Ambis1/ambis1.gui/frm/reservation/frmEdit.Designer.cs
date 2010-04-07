namespace ambis1.gui.pc.frm.reservation
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.gboxContainer = new System.Windows.Forms.GroupBox();
            this.txtCage = new System.Windows.Forms.Label();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.txtDuration = new System.Windows.Forms.DateTimePicker();
            this.labDOB = new System.Windows.Forms.Label();
            this.txtDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxContainer
            // 
            this.gboxContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxContainer.Controls.Add(this.txtCage);
            this.gboxContainer.Controls.Add(this.cmbTeam);
            this.gboxContainer.Controls.Add(this.txtDuration);
            this.gboxContainer.Controls.Add(this.labDOB);
            this.gboxContainer.Controls.Add(this.txtDateAndTime);
            this.gboxContainer.Controls.Add(this.btCancel);
            this.gboxContainer.Controls.Add(this.btAccept);
            this.gboxContainer.Controls.Add(this.label2);
            this.gboxContainer.Controls.Add(this.label1);
            this.gboxContainer.Location = new System.Drawing.Point(12, 13);
            this.gboxContainer.Name = "gboxContainer";
            this.gboxContainer.Size = new System.Drawing.Size(572, 229);
            this.gboxContainer.TabIndex = 8;
            this.gboxContainer.TabStop = false;
            // 
            // txtCage
            // 
            this.txtCage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCage.Location = new System.Drawing.Point(77, 16);
            this.txtCage.Name = "txtCage";
            this.txtCage.Size = new System.Drawing.Size(422, 60);
            this.txtCage.TabIndex = 54;
            this.txtCage.Text = "Cage";
            this.txtCage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTeam
            // 
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(131, 115);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(368, 21);
            this.cmbTeam.TabIndex = 53;
            // 
            // txtDuration
            // 
            this.txtDuration.CustomFormat = "HH:mm";
            this.txtDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDuration.Location = new System.Drawing.Point(356, 89);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ShowUpDown = true;
            this.txtDuration.Size = new System.Drawing.Size(143, 20);
            this.txtDuration.TabIndex = 52;
            // 
            // labDOB
            // 
            this.labDOB.AutoSize = true;
            this.labDOB.Location = new System.Drawing.Point(74, 93);
            this.labDOB.Name = "labDOB";
            this.labDOB.Size = new System.Drawing.Size(30, 13);
            this.labDOB.TabIndex = 51;
            this.labDOB.Text = "Date";
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.CustomFormat = "MM/dd/yyyy - hh:mm tt";
            this.txtDateAndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateAndTime.Location = new System.Drawing.Point(131, 89);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Size = new System.Drawing.Size(150, 20);
            this.txtDateAndTime.TabIndex = 50;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(491, 200);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(410, 200);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(75, 23);
            this.btAccept.TabIndex = 1;
            this.btAccept.Text = "Save";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 254);
            this.Controls.Add(this.gboxContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdit";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.gboxContainer.ResumeLayout(false);
            this.gboxContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxContainer;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label labDOB;
        internal System.Windows.Forms.DateTimePicker txtDateAndTime;
        internal System.Windows.Forms.DateTimePicker txtDuration;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label txtCage;
    }
}