namespace ambis1.gui.pc.frm.membership
{
    partial class frmMemberShipEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberShipEdit));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpageGeneralInformation = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.txtDueDate = new repsol.forms.controls.TextBoxColor();
            this.labDueDate = new System.Windows.Forms.Label();
            this.gboxExpired = new System.Windows.Forms.GroupBox();
            this.btRenew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.labStartDate = new System.Windows.Forms.Label();
            this.mviewMember = new ambis1.gui.pc._template.controls.MemberView();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gboxTypeOfMembership = new System.Windows.Forms.GroupBox();
            this.rblistTypeOfMembership = new ambis1.gui.pc._template.controls.RadioListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labPriceValue = new System.Windows.Forms.TextBox();
            this.labPriceDollar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxTypeOfMember = new System.Windows.Forms.GroupBox();
            this.rbTypeOfMemberFamily = new System.Windows.Forms.RadioButton();
            this.rbTypeOfMemberTeam = new System.Windows.Forms.RadioButton();
            this.rbTypeOfMemberPlayer = new System.Windows.Forms.RadioButton();
            this.tpagePlayers = new System.Windows.Forms.TabPage();
            this.gboxPlayersInTeam = new System.Windows.Forms.GroupBox();
            this.dgPlayersInTeam = new System.Windows.Forms.DataGridView();
            this.gboxInfoPlayer = new System.Windows.Forms.GroupBox();
            this.labDOB = new System.Windows.Forms.Label();
            this.txtInTeamDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtInTeamAddress = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.btMoreDetails = new System.Windows.Forms.Button();
            this.txtInTeamFirstName = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInTeamLastName = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddPlayer = new System.Windows.Forms.ToolStripButton();
            this.tsbModifyPlayer = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletePlayer = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.tpageGeneralInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxExpired.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gboxTypeOfMembership.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gboxTypeOfMember.SuspendLayout();
            this.tpagePlayers.SuspendLayout();
            this.gboxPlayersInTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayersInTeam)).BeginInit();
            this.gboxInfoPlayer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpageGeneralInformation);
            this.tabControl.Controls.Add(this.tpagePlayers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 608);
            this.tabControl.TabIndex = 0;
            // 
            // tpageGeneralInformation
            // 
            this.tpageGeneralInformation.BackColor = System.Drawing.SystemColors.Control;
            this.tpageGeneralInformation.Controls.Add(this.panel1);
            this.tpageGeneralInformation.Location = new System.Drawing.Point(4, 22);
            this.tpageGeneralInformation.Name = "tpageGeneralInformation";
            this.tpageGeneralInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpageGeneralInformation.Size = new System.Drawing.Size(786, 582);
            this.tpageGeneralInformation.TabIndex = 0;
            this.tpageGeneralInformation.Text = "General Information";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 557);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPaid);
            this.groupBox1.Controls.Add(this.txtDueDate);
            this.groupBox1.Controls.Add(this.labDueDate);
            this.groupBox1.Controls.Add(this.gboxExpired);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.labStartDate);
            this.groupBox1.Controls.Add(this.mviewMember);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btAccept);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(127, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 557);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Location = new System.Drawing.Point(576, 27);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(47, 17);
            this.chkPaid.TabIndex = 34;
            this.chkPaid.Text = "Paid";
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // txtDueDate
            // 
            this.txtDueDate.ActivateStyle = false;
            this.txtDueDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDueDate.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDueDate.ColorLeave = System.Drawing.Color.White;
            this.txtDueDate.Location = new System.Drawing.Point(349, 25);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(150, 20);
            this.txtDueDate.TabIndex = 33;
            this.txtDueDate.TabStop = false;
            // 
            // labDueDate
            // 
            this.labDueDate.AutoSize = true;
            this.labDueDate.Location = new System.Drawing.Point(269, 28);
            this.labDueDate.Name = "labDueDate";
            this.labDueDate.Size = new System.Drawing.Size(79, 13);
            this.labDueDate.TabIndex = 32;
            this.labDueDate.Text = "Expiration Date";
            // 
            // gboxExpired
            // 
            this.gboxExpired.Controls.Add(this.btRenew);
            this.gboxExpired.Controls.Add(this.label5);
            this.gboxExpired.Location = new System.Drawing.Point(6, 480);
            this.gboxExpired.Name = "gboxExpired";
            this.gboxExpired.Size = new System.Drawing.Size(620, 71);
            this.gboxExpired.TabIndex = 31;
            this.gboxExpired.TabStop = false;
            this.gboxExpired.Visible = false;
            this.gboxExpired.VisibleChanged += new System.EventHandler(this.gboxExpired_VisibleChanged);
            // 
            // btRenew
            // 
            this.btRenew.Location = new System.Drawing.Point(531, 42);
            this.btRenew.Name = "btRenew";
            this.btRenew.Size = new System.Drawing.Size(75, 23);
            this.btRenew.TabIndex = 30;
            this.btRenew.Text = "Renew";
            this.btRenew.UseVisualStyleBackColor = true;
            this.btRenew.Click += new System.EventHandler(this.btRenew_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(614, 36);
            this.label5.TabIndex = 29;
            this.label5.Text = "-- EXPIRED --";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStartDate
            // 
            this.txtStartDate.CustomFormat = "MM/dd/yyyy";
            this.txtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartDate.Location = new System.Drawing.Point(94, 24);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(150, 20);
            this.txtStartDate.TabIndex = 29;
            this.txtStartDate.ValueChanged += new System.EventHandler(this.txtStartDate_ValueChanged);
            // 
            // labStartDate
            // 
            this.labStartDate.AutoSize = true;
            this.labStartDate.Location = new System.Drawing.Point(14, 28);
            this.labStartDate.Name = "labStartDate";
            this.labStartDate.Size = new System.Drawing.Size(55, 13);
            this.labStartDate.TabIndex = 28;
            this.labStartDate.Text = "Start Date";
            // 
            // mviewMember
            // 
            this.mviewMember.Location = new System.Drawing.Point(6, 51);
            this.mviewMember.MinimumSize = new System.Drawing.Size(610, 330);
            this.mviewMember.Name = "mviewMember";
            this.mviewMember.Size = new System.Drawing.Size(620, 471);
            this.mviewMember.TabIndex = 30;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(537, 528);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 27;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(456, 528);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(75, 23);
            this.btAccept.TabIndex = 26;
            this.btAccept.Text = "Save";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gboxTypeOfMembership);
            this.panel2.Controls.Add(this.gboxTypeOfMember);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 557);
            this.panel2.TabIndex = 3;
            // 
            // gboxTypeOfMembership
            // 
            this.gboxTypeOfMembership.Controls.Add(this.rblistTypeOfMembership);
            this.gboxTypeOfMembership.Controls.Add(this.panel3);
            this.gboxTypeOfMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxTypeOfMembership.Location = new System.Drawing.Point(0, 122);
            this.gboxTypeOfMembership.Name = "gboxTypeOfMembership";
            this.gboxTypeOfMembership.Size = new System.Drawing.Size(127, 435);
            this.gboxTypeOfMembership.TabIndex = 1;
            this.gboxTypeOfMembership.TabStop = false;
            this.gboxTypeOfMembership.Text = "Type of Membership";
            // 
            // rblistTypeOfMembership
            // 
            this.rblistTypeOfMembership.BackColor = System.Drawing.SystemColors.Control;
            this.rblistTypeOfMembership.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rblistTypeOfMembership.Dock = System.Windows.Forms.DockStyle.Right;
            this.rblistTypeOfMembership.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rblistTypeOfMembership.FormattingEnabled = true;
            this.rblistTypeOfMembership.ItemHeight = 24;
            this.rblistTypeOfMembership.Location = new System.Drawing.Point(19, 16);
            this.rblistTypeOfMembership.Name = "rblistTypeOfMembership";
            this.rblistTypeOfMembership.Size = new System.Drawing.Size(105, 336);
            this.rblistTypeOfMembership.TabIndex = 0;
            this.rblistTypeOfMembership.SelectedIndexChanged += new System.EventHandler(this.rblistTypeOfMembership_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 74);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labPriceValue);
            this.panel4.Controls.Add(this.labPriceDollar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 43);
            this.panel4.TabIndex = 3;
            // 
            // labPriceValue
            // 
            this.labPriceValue.BackColor = System.Drawing.SystemColors.Control;
            this.labPriceValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labPriceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labPriceValue.ForeColor = System.Drawing.Color.Blue;
            this.labPriceValue.Location = new System.Drawing.Point(25, 0);
            this.labPriceValue.Name = "labPriceValue";
            this.labPriceValue.ReadOnly = true;
            this.labPriceValue.Size = new System.Drawing.Size(96, 24);
            this.labPriceValue.TabIndex = 2;
            this.labPriceValue.Validated += new System.EventHandler(this.labPriceValue_Validated);
            this.labPriceValue.Validating += new System.ComponentModel.CancelEventHandler(this.labPriceValue_Validating);
            // 
            // labPriceDollar
            // 
            this.labPriceDollar.AutoSize = true;
            this.labPriceDollar.Dock = System.Windows.Forms.DockStyle.Left;
            this.labPriceDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPriceDollar.ForeColor = System.Drawing.Color.Blue;
            this.labPriceDollar.Location = new System.Drawing.Point(0, 0);
            this.labPriceDollar.Name = "labPriceDollar";
            this.labPriceDollar.Size = new System.Drawing.Size(25, 25);
            this.labPriceDollar.TabIndex = 1;
            this.labPriceDollar.Text = "$";
            this.labPriceDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // gboxTypeOfMember
            // 
            this.gboxTypeOfMember.Controls.Add(this.rbTypeOfMemberFamily);
            this.gboxTypeOfMember.Controls.Add(this.rbTypeOfMemberTeam);
            this.gboxTypeOfMember.Controls.Add(this.rbTypeOfMemberPlayer);
            this.gboxTypeOfMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxTypeOfMember.Location = new System.Drawing.Point(0, 0);
            this.gboxTypeOfMember.Name = "gboxTypeOfMember";
            this.gboxTypeOfMember.Size = new System.Drawing.Size(127, 122);
            this.gboxTypeOfMember.TabIndex = 0;
            this.gboxTypeOfMember.TabStop = false;
            this.gboxTypeOfMember.Text = "Type of Member";
            // 
            // rbTypeOfMemberFamily
            // 
            this.rbTypeOfMemberFamily.AutoSize = true;
            this.rbTypeOfMemberFamily.Location = new System.Drawing.Point(19, 82);
            this.rbTypeOfMemberFamily.Name = "rbTypeOfMemberFamily";
            this.rbTypeOfMemberFamily.Size = new System.Drawing.Size(54, 17);
            this.rbTypeOfMemberFamily.TabIndex = 2;
            this.rbTypeOfMemberFamily.Text = "Family";
            this.rbTypeOfMemberFamily.UseVisualStyleBackColor = true;
            this.rbTypeOfMemberFamily.Click += new System.EventHandler(this.rbTypeOfMemberFamily_Click);
            // 
            // rbTypeOfMemberTeam
            // 
            this.rbTypeOfMemberTeam.AutoSize = true;
            this.rbTypeOfMemberTeam.Checked = true;
            this.rbTypeOfMemberTeam.Location = new System.Drawing.Point(19, 59);
            this.rbTypeOfMemberTeam.Name = "rbTypeOfMemberTeam";
            this.rbTypeOfMemberTeam.Size = new System.Drawing.Size(52, 17);
            this.rbTypeOfMemberTeam.TabIndex = 1;
            this.rbTypeOfMemberTeam.TabStop = true;
            this.rbTypeOfMemberTeam.Text = "Team";
            this.rbTypeOfMemberTeam.UseVisualStyleBackColor = true;
            this.rbTypeOfMemberTeam.Click += new System.EventHandler(this.rbTypeOfMemberTeam_Click);
            // 
            // rbTypeOfMemberPlayer
            // 
            this.rbTypeOfMemberPlayer.AutoSize = true;
            this.rbTypeOfMemberPlayer.Location = new System.Drawing.Point(19, 36);
            this.rbTypeOfMemberPlayer.Name = "rbTypeOfMemberPlayer";
            this.rbTypeOfMemberPlayer.Size = new System.Drawing.Size(102, 17);
            this.rbTypeOfMemberPlayer.TabIndex = 0;
            this.rbTypeOfMemberPlayer.Text = "Individual Player";
            this.rbTypeOfMemberPlayer.UseVisualStyleBackColor = true;
            this.rbTypeOfMemberPlayer.Click += new System.EventHandler(this.rbTypeOfMemberPlayer_Click);
            // 
            // tpagePlayers
            // 
            this.tpagePlayers.Controls.Add(this.gboxPlayersInTeam);
            this.tpagePlayers.Controls.Add(this.gboxInfoPlayer);
            this.tpagePlayers.Controls.Add(this.toolStrip1);
            this.tpagePlayers.Location = new System.Drawing.Point(4, 22);
            this.tpagePlayers.Name = "tpagePlayers";
            this.tpagePlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tpagePlayers.Size = new System.Drawing.Size(786, 582);
            this.tpagePlayers.TabIndex = 1;
            this.tpagePlayers.Text = "Players";
            this.tpagePlayers.UseVisualStyleBackColor = true;
            // 
            // gboxPlayersInTeam
            // 
            this.gboxPlayersInTeam.Controls.Add(this.dgPlayersInTeam);
            this.gboxPlayersInTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxPlayersInTeam.Location = new System.Drawing.Point(3, 34);
            this.gboxPlayersInTeam.Name = "gboxPlayersInTeam";
            this.gboxPlayersInTeam.Size = new System.Drawing.Size(780, 545);
            this.gboxPlayersInTeam.TabIndex = 3;
            this.gboxPlayersInTeam.TabStop = false;
            this.gboxPlayersInTeam.Text = "Players in the Team";
            // 
            // dgPlayersInTeam
            // 
            this.dgPlayersInTeam.AllowUserToAddRows = false;
            this.dgPlayersInTeam.AllowUserToDeleteRows = false;
            this.dgPlayersInTeam.AllowUserToResizeRows = false;
            this.dgPlayersInTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPlayersInTeam.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPlayersInTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayersInTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPlayersInTeam.Location = new System.Drawing.Point(3, 16);
            this.dgPlayersInTeam.Name = "dgPlayersInTeam";
            this.dgPlayersInTeam.ReadOnly = true;
            this.dgPlayersInTeam.RowHeadersVisible = false;
            this.dgPlayersInTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPlayersInTeam.Size = new System.Drawing.Size(774, 526);
            this.dgPlayersInTeam.TabIndex = 2;
            this.dgPlayersInTeam.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgPlayersInTeam_DataError);
            // 
            // gboxInfoPlayer
            // 
            this.gboxInfoPlayer.Controls.Add(this.labDOB);
            this.gboxInfoPlayer.Controls.Add(this.txtInTeamDateOfBirth);
            this.gboxInfoPlayer.Controls.Add(this.txtInTeamAddress);
            this.gboxInfoPlayer.Controls.Add(this.label3);
            this.gboxInfoPlayer.Controls.Add(this.btMoreDetails);
            this.gboxInfoPlayer.Controls.Add(this.txtInTeamFirstName);
            this.gboxInfoPlayer.Controls.Add(this.label1);
            this.gboxInfoPlayer.Controls.Add(this.txtInTeamLastName);
            this.gboxInfoPlayer.Controls.Add(this.label2);
            this.gboxInfoPlayer.Controls.Add(this.btAdd);
            this.gboxInfoPlayer.Location = new System.Drawing.Point(63, 467);
            this.gboxInfoPlayer.Name = "gboxInfoPlayer";
            this.gboxInfoPlayer.Size = new System.Drawing.Size(647, 119);
            this.gboxInfoPlayer.TabIndex = 2;
            this.gboxInfoPlayer.TabStop = false;
            this.gboxInfoPlayer.Text = "Info Player";
            this.gboxInfoPlayer.Visible = false;
            // 
            // labDOB
            // 
            this.labDOB.AutoSize = true;
            this.labDOB.Location = new System.Drawing.Point(81, 49);
            this.labDOB.Name = "labDOB";
            this.labDOB.Size = new System.Drawing.Size(30, 13);
            this.labDOB.TabIndex = 51;
            this.labDOB.Text = "DOB";
            // 
            // txtInTeamDateOfBirth
            // 
            this.txtInTeamDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtInTeamDateOfBirth.Location = new System.Drawing.Point(162, 45);
            this.txtInTeamDateOfBirth.Name = "txtInTeamDateOfBirth";
            this.txtInTeamDateOfBirth.Size = new System.Drawing.Size(150, 20);
            this.txtInTeamDateOfBirth.TabIndex = 2;
            // 
            // txtInTeamAddress
            // 
            this.txtInTeamAddress.ActivateStyle = true;
            this.txtInTeamAddress.BackColor = System.Drawing.Color.White;
            this.txtInTeamAddress.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtInTeamAddress.ColorLeave = System.Drawing.Color.White;
            this.txtInTeamAddress.Location = new System.Drawing.Point(415, 45);
            this.txtInTeamAddress.Name = "txtInTeamAddress";
            this.txtInTeamAddress.Size = new System.Drawing.Size(150, 20);
            this.txtInTeamAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address";
            // 
            // btMoreDetails
            // 
            this.btMoreDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMoreDetails.Location = new System.Drawing.Point(21, 84);
            this.btMoreDetails.Name = "btMoreDetails";
            this.btMoreDetails.Size = new System.Drawing.Size(139, 21);
            this.btMoreDetails.TabIndex = 10;
            this.btMoreDetails.Text = "More details";
            this.btMoreDetails.UseVisualStyleBackColor = true;
            this.btMoreDetails.Click += new System.EventHandler(this.btMoreDetails_Click);
            // 
            // txtInTeamFirstName
            // 
            this.txtInTeamFirstName.ActivateStyle = true;
            this.txtInTeamFirstName.BackColor = System.Drawing.Color.White;
            this.txtInTeamFirstName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtInTeamFirstName.ColorLeave = System.Drawing.Color.White;
            this.txtInTeamFirstName.Location = new System.Drawing.Point(162, 19);
            this.txtInTeamFirstName.Name = "txtInTeamFirstName";
            this.txtInTeamFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtInTeamFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // txtInTeamLastName
            // 
            this.txtInTeamLastName.ActivateStyle = true;
            this.txtInTeamLastName.BackColor = System.Drawing.Color.White;
            this.txtInTeamLastName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtInTeamLastName.ColorLeave = System.Drawing.Color.White;
            this.txtInTeamLastName.Location = new System.Drawing.Point(415, 19);
            this.txtInTeamLastName.Name = "txtInTeamLastName";
            this.txtInTeamLastName.Size = new System.Drawing.Size(150, 20);
            this.txtInTeamLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(558, 84);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(69, 21);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddPlayer,
            this.tsbModifyPlayer,
            this.tsbDeletePlayer});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(780, 31);
            this.toolStrip1.TabIndex = 4;
            // 
            // tsbAddPlayer
            // 
            this.tsbAddPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddPlayer.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddPlayer.Image")));
            this.tsbAddPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddPlayer.Name = "tsbAddPlayer";
            this.tsbAddPlayer.Size = new System.Drawing.Size(28, 28);
            this.tsbAddPlayer.Tag = "Add Player";
            this.tsbAddPlayer.Text = "Add Player";
            this.tsbAddPlayer.Click += new System.EventHandler(this.tsbAddPlayer_Click);
            // 
            // tsbModifyPlayer
            // 
            this.tsbModifyPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModifyPlayer.Image = global::ambis1.gui.pc.Properties.Resources.Modify;
            this.tsbModifyPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModifyPlayer.Name = "tsbModifyPlayer";
            this.tsbModifyPlayer.Size = new System.Drawing.Size(28, 28);
            this.tsbModifyPlayer.Tag = "Modify Player";
            this.tsbModifyPlayer.Text = "Modify Player";
            this.tsbModifyPlayer.Click += new System.EventHandler(this.tsbModifyPlayer_Click);
            // 
            // tsbDeletePlayer
            // 
            this.tsbDeletePlayer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDeletePlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeletePlayer.Image = global::ambis1.gui.pc.Properties.Resources.Remove;
            this.tsbDeletePlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletePlayer.Name = "tsbDeletePlayer";
            this.tsbDeletePlayer.Size = new System.Drawing.Size(28, 28);
            this.tsbDeletePlayer.Tag = "Delete Player from Team";
            this.tsbDeletePlayer.Text = "Delete Player from Team";
            this.tsbDeletePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbDeletePlayer.Click += new System.EventHandler(this.tsbDeletePlayer_Click);
            // 
            // frmMemberShipEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 608);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemberShipEdit";
            this.Text = "MemberShip";
            this.Load += new System.EventHandler(this.frmMemberShipEdit_Load);
            this.tabControl.ResumeLayout(false);
            this.tpageGeneralInformation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxExpired.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gboxTypeOfMembership.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gboxTypeOfMember.ResumeLayout(false);
            this.gboxTypeOfMember.PerformLayout();
            this.tpagePlayers.ResumeLayout(false);
            this.tpagePlayers.PerformLayout();
            this.gboxPlayersInTeam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayersInTeam)).EndInit();
            this.gboxInfoPlayer.ResumeLayout(false);
            this.gboxInfoPlayer.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpageGeneralInformation;
        private System.Windows.Forms.TabPage tpagePlayers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gboxTypeOfMembership;
        private System.Windows.Forms.GroupBox gboxTypeOfMember;
        private System.Windows.Forms.RadioButton rbTypeOfMemberTeam;
        private System.Windows.Forms.RadioButton rbTypeOfMemberPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.GroupBox gboxPlayersInTeam;
        private System.Windows.Forms.GroupBox gboxInfoPlayer;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMoreDetails;
        private repsol.forms.controls.TextBoxColor txtInTeamFirstName;
        private System.Windows.Forms.Label label1;
        private repsol.forms.controls.TextBoxColor txtInTeamLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.Label labStartDate;
        private ambis1.gui.pc._template.controls.MemberView mviewMember;
        private ambis1.gui.pc._template.controls.RadioListBox rblistTypeOfMembership;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labPriceDollar;
        private System.Windows.Forms.GroupBox gboxExpired;
        private System.Windows.Forms.Button btRenew;
        private System.Windows.Forms.Label label5;
        private repsol.forms.controls.TextBoxColor txtDueDate;
        private System.Windows.Forms.Label labDueDate;
        private repsol.forms.controls.TextBoxColor txtInTeamAddress;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label labDOB;
        internal System.Windows.Forms.DateTimePicker txtInTeamDateOfBirth;
        private System.Windows.Forms.DataGridView dgPlayersInTeam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbModifyPlayer;
        private System.Windows.Forms.ToolStripButton tsbAddPlayer;
        private System.Windows.Forms.ToolStripButton tsbDeletePlayer;
        private System.Windows.Forms.RadioButton rbTypeOfMemberFamily;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.TextBox labPriceValue;
        private System.Windows.Forms.Panel panel4;
    }
}