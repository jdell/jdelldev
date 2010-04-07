using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.client
{
    class frmEdit : template.frm.edicion.EditForm, template.interfaces.IPresentation
    {
        internal repsol.forms.controls.TextBoxColor txtFirstName;
        internal repsol.forms.controls.TextBoxColor txtMiddleName;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtLastName;
        private System.Windows.Forms.Label label5;
        internal asr.app.pc.template.controls.AddressBox homeAddress;
        internal System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtPreferredFirstName;
        internal System.Windows.Forms.TabPage tpageComments;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtSSN;
        internal asr.app.pc.template.controls.AddressBox mailingAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        internal repsol.forms.controls.TextBoxColor txtEmergencyContact;
        private System.Windows.Forms.Label label7;
        internal repsol.forms.controls.TextBoxColor txtEmailAddress;
        internal repsol.forms.controls.TextBoxColor txtAdditionalContactPhone;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtCellPhoneNumber;
        internal repsol.forms.controls.TextBoxColor txtHomePhoneNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.DateTimePicker dateDateOfBirth;
        internal System.Windows.Forms.TabPage tpageEmploymentHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal repsol.forms.controls.TextBoxColor txtComments;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.GroupBox gboxCreditScore;
        private System.Windows.Forms.Label label13;
        internal repsol.forms.controls.TextBoxColor txtCreditScore;
        private System.Windows.Forms.Label label14;
        internal repsol.forms.controls.TextBoxColor txtCompanyName;
        protected internal System.Windows.Forms.TabPage tpageSkillScore;

        internal employment.frmQuery _frmEmployment = null;
        private System.Windows.Forms.TabPage tpagePicture;
        protected internal asr.app.pc.template.controls.PictureBox picPhoto;
        internal skillscore.frmQuery _frmSkillScore = null;

        public frmEdit()
        {
            InitializeComponent();

            _frmEmployment = new asr.app.pc.frm.client.employment.frmQuery();
            _frmSkillScore = new asr.app.pc.frm.client.skillscore.frmQuery();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.client.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Client());
        }
        public frmEdit(Client objVO)
        {
            InitializeComponent();

            _frmEmployment = new asr.app.pc.frm.client.employment.frmQuery();
            _frmSkillScore = new asr.app.pc.frm.client.skillscore.frmQuery();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.client.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Client objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            _frmEmployment = new asr.app.pc.frm.client.employment.frmQuery();
            _frmSkillScore = new asr.app.pc.frm.client.skillscore.frmQuery();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.client.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea guardar los cambios realizados?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2))
                {
                    ctrl.ctrlEdit ctrl = new asr.app.pc.frm.client.ctrl.ctrlEdit();
                    repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                    ctrl.guardarDatos(ref frm, this.IsNewRecord);
                    base.btAceptar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.homeAddress = new asr.app.pc.template.controls.AddressBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new repsol.forms.controls.TextBoxColor();
            this.txtAdditionalContactPhone = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCellPhoneNumber = new repsol.forms.controls.TextBoxColor();
            this.txtHomePhoneNumber = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mailingAddress = new asr.app.pc.template.controls.AddressBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCompanyName = new repsol.forms.controls.TextBoxColor();
            this.label12 = new System.Windows.Forms.Label();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSSN = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreferredFirstName = new repsol.forms.controls.TextBoxColor();
            this.tpageComments = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtComments = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.gboxCreditScore = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCreditScore = new repsol.forms.controls.TextBoxColor();
            this.tpageEmploymentHistory = new System.Windows.Forms.TabPage();
            this.tpageSkillScore = new System.Windows.Forms.TabPage();
            this.tpagePicture = new System.Windows.Forms.TabPage();
            this.picPhoto = new asr.app.pc.template.controls.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpageComments.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gboxCreditScore.SuspendLayout();
            this.tpagePicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(1242, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1322, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 535);
            this.panFooter.Size = new System.Drawing.Size(547, 43);
            this.panFooter.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.ActivateStyle = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFirstName.ColorLeave = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(84, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.ActivateStyle = true;
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMiddleName.ColorLeave = System.Drawing.Color.White;
            this.txtMiddleName.Location = new System.Drawing.Point(84, 49);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(66, 22);
            this.txtMiddleName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Middle Name";
            // 
            // txtLastName
            // 
            this.txtLastName.ActivateStyle = true;
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtLastName.ColorLeave = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(379, 21);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last Name";
            // 
            // homeAddress
            // 
            this.homeAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeAddress.Location = new System.Drawing.Point(3, 143);
            this.homeAddress.Name = "homeAddress";
            this.homeAddress.Size = new System.Drawing.Size(533, 102);
            this.homeAddress.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpageComments);
            this.tabControl1.Controls.Add(this.tpageEmploymentHistory);
            this.tabControl1.Controls.Add(this.tpageSkillScore);
            this.tabControl1.Controls.Add(this.tpagePicture);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 530);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.mailingAddress);
            this.tabPage1.Controls.Add(this.homeAddress);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contact Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEmergencyContact);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmailAddress);
            this.groupBox2.Controls.Add(this.txtAdditionalContactPhone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCellPhoneNumber);
            this.groupBox2.Controls.Add(this.txtHomePhoneNumber);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Emergency Contact (Name / Relationship and Phone Number)";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.ActivateStyle = true;
            this.txtEmergencyContact.BackColor = System.Drawing.Color.White;
            this.txtEmergencyContact.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtEmergencyContact.ColorLeave = System.Drawing.Color.White;
            this.txtEmergencyContact.Location = new System.Drawing.Point(11, 108);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(504, 22);
            this.txtEmergencyContact.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.ActivateStyle = true;
            this.txtEmailAddress.BackColor = System.Drawing.Color.White;
            this.txtEmailAddress.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtEmailAddress.ColorLeave = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(336, 49);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(179, 22);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // txtAdditionalContactPhone
            // 
            this.txtAdditionalContactPhone.ActivateStyle = true;
            this.txtAdditionalContactPhone.BackColor = System.Drawing.Color.White;
            this.txtAdditionalContactPhone.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAdditionalContactPhone.ColorLeave = System.Drawing.Color.White;
            this.txtAdditionalContactPhone.Location = new System.Drawing.Point(424, 21);
            this.txtAdditionalContactPhone.Name = "txtAdditionalContactPhone";
            this.txtAdditionalContactPhone.Size = new System.Drawing.Size(91, 22);
            this.txtAdditionalContactPhone.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Home Phone Number";
            // 
            // txtCellPhoneNumber
            // 
            this.txtCellPhoneNumber.ActivateStyle = true;
            this.txtCellPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtCellPhoneNumber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCellPhoneNumber.ColorLeave = System.Drawing.Color.White;
            this.txtCellPhoneNumber.Location = new System.Drawing.Point(139, 49);
            this.txtCellPhoneNumber.Name = "txtCellPhoneNumber";
            this.txtCellPhoneNumber.Size = new System.Drawing.Size(91, 22);
            this.txtCellPhoneNumber.TabIndex = 2;
            // 
            // txtHomePhoneNumber
            // 
            this.txtHomePhoneNumber.ActivateStyle = true;
            this.txtHomePhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtHomePhoneNumber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtHomePhoneNumber.ColorLeave = System.Drawing.Color.White;
            this.txtHomePhoneNumber.Location = new System.Drawing.Point(139, 21);
            this.txtHomePhoneNumber.Name = "txtHomePhoneNumber";
            this.txtHomePhoneNumber.Size = new System.Drawing.Size(91, 22);
            this.txtHomePhoneNumber.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 14);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cell Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Additional Contact Phone";
            // 
            // mailingAddress
            // 
            this.mailingAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.mailingAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailingAddress.Location = new System.Drawing.Point(3, 245);
            this.mailingAddress.Name = "mailingAddress";
            this.mailingAddress.Size = new System.Drawing.Size(533, 102);
            this.mailingAddress.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateDateOfBirth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSSN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPreferredFirstName);
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 14);
            this.label14.TabIndex = 33;
            this.label14.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.ActivateStyle = true;
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCompanyName.ColorLeave = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(84, 105);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(431, 22);
            this.txtCompanyName.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 31;
            this.label12.Text = "Date of Birth";
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Checked = false;
            this.dateDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateOfBirth.Location = new System.Drawing.Point(379, 78);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.ShowCheckBox = true;
            this.dateDateOfBirth.Size = new System.Drawing.Size(136, 22);
            this.dateDateOfBirth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 29;
            this.label4.Text = "SSN";
            // 
            // txtSSN
            // 
            this.txtSSN.ActivateStyle = true;
            this.txtSSN.BackColor = System.Drawing.Color.White;
            this.txtSSN.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSSN.ColorLeave = System.Drawing.Color.White;
            this.txtSSN.Location = new System.Drawing.Point(84, 77);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(136, 22);
            this.txtSSN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Preferred F. Name";
            // 
            // txtPreferredFirstName
            // 
            this.txtPreferredFirstName.ActivateStyle = true;
            this.txtPreferredFirstName.BackColor = System.Drawing.Color.White;
            this.txtPreferredFirstName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPreferredFirstName.ColorLeave = System.Drawing.Color.White;
            this.txtPreferredFirstName.Location = new System.Drawing.Point(379, 49);
            this.txtPreferredFirstName.Name = "txtPreferredFirstName";
            this.txtPreferredFirstName.Size = new System.Drawing.Size(136, 22);
            this.txtPreferredFirstName.TabIndex = 3;
            // 
            // tpageComments
            // 
            this.tpageComments.Controls.Add(this.groupBox3);
            this.tpageComments.Controls.Add(this.gboxCreditScore);
            this.tpageComments.Location = new System.Drawing.Point(4, 23);
            this.tpageComments.Name = "tpageComments";
            this.tpageComments.Padding = new System.Windows.Forms.Padding(3);
            this.tpageComments.Size = new System.Drawing.Size(539, 503);
            this.tpageComments.TabIndex = 1;
            this.tpageComments.Text = "Comments & Credit Score";
            this.tpageComments.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtComments);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 443);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // txtComments
            // 
            this.txtComments.ActivateStyle = true;
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtComments.ColorLeave = System.Drawing.Color.White;
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComments.Location = new System.Drawing.Point(3, 32);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(527, 408);
            this.txtComments.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Comments";
            // 
            // gboxCreditScore
            // 
            this.gboxCreditScore.Controls.Add(this.label13);
            this.gboxCreditScore.Controls.Add(this.txtCreditScore);
            this.gboxCreditScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxCreditScore.Location = new System.Drawing.Point(3, 3);
            this.gboxCreditScore.Name = "gboxCreditScore";
            this.gboxCreditScore.Size = new System.Drawing.Size(533, 54);
            this.gboxCreditScore.TabIndex = 23;
            this.gboxCreditScore.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Credit Score";
            // 
            // txtCreditScore
            // 
            this.txtCreditScore.ActivateStyle = true;
            this.txtCreditScore.BackColor = System.Drawing.Color.White;
            this.txtCreditScore.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCreditScore.ColorLeave = System.Drawing.Color.White;
            this.txtCreditScore.Location = new System.Drawing.Point(89, 21);
            this.txtCreditScore.Name = "txtCreditScore";
            this.txtCreditScore.Size = new System.Drawing.Size(136, 22);
            this.txtCreditScore.TabIndex = 18;
            this.txtCreditScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCreditScore.Validated += new System.EventHandler(this.txtCreditScore_Validated);
            this.txtCreditScore.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreditScore_Validating);
            // 
            // tpageEmploymentHistory
            // 
            this.tpageEmploymentHistory.Location = new System.Drawing.Point(4, 23);
            this.tpageEmploymentHistory.Name = "tpageEmploymentHistory";
            this.tpageEmploymentHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpageEmploymentHistory.Size = new System.Drawing.Size(539, 503);
            this.tpageEmploymentHistory.TabIndex = 2;
            this.tpageEmploymentHistory.Text = "Employment History";
            this.tpageEmploymentHistory.UseVisualStyleBackColor = true;
            // 
            // tpageSkillScore
            // 
            this.tpageSkillScore.Location = new System.Drawing.Point(4, 23);
            this.tpageSkillScore.Name = "tpageSkillScore";
            this.tpageSkillScore.Padding = new System.Windows.Forms.Padding(3);
            this.tpageSkillScore.Size = new System.Drawing.Size(539, 503);
            this.tpageSkillScore.TabIndex = 3;
            this.tpageSkillScore.Text = "Skill Score";
            this.tpageSkillScore.UseVisualStyleBackColor = true;
            // 
            // tpagePicture
            // 
            this.tpagePicture.Controls.Add(this.picPhoto);
            this.tpagePicture.Location = new System.Drawing.Point(4, 23);
            this.tpagePicture.Name = "tpagePicture";
            this.tpagePicture.Padding = new System.Windows.Forms.Padding(3);
            this.tpagePicture.Size = new System.Drawing.Size(539, 503);
            this.tpagePicture.TabIndex = 4;
            this.tpagePicture.Text = "Picture";
            this.tpagePicture.UseVisualStyleBackColor = true;
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.Filter = " Fotos (JPG, JPEG, GIF, BMP, TIFF,PNG) |*.jpg;*.jpeg;*.bmp;*.gif;*.tiff;*.png";
            this.picPhoto.Image = null;
            this.picPhoto.Location = new System.Drawing.Point(137, 107);
            this.picPhoto.MaxHeight = 25;
            this.picPhoto.MinHeight = 5;
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(265, 288);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 0;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(547, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdit";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpageComments.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gboxCreditScore.ResumeLayout(false);
            this.gboxCreditScore.PerformLayout();
            this.tpagePicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void txtCreditScore_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtCreditScore.Text))
                {
                    Single score = 0;
                    e.Cancel = !Single.TryParse(this.txtCreditScore.Text, out score);
                    if (e.Cancel) template._common.messages.ShowWarning("Incorrect format!", this.Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtCreditScore_Validated(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCreditScore.Text))
                    this.txtCreditScore.Text = "0";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        private void frmEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.SetUpPresentation();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.tabControl1.SelectedTab == this.tpageSkillScore) _frmSkillScore.btRefresh_record();
                if (this.tabControl1.SelectedTab == this.tpageEmploymentHistory) _frmEmployment.btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #region Miembros de IPresentation

        public void SetUpPresentation()
        {
            if (lib.bl._common.cache.IsPresentationMode)
            {
                this.tabControl1.TabPages.Remove(this.tpageEmploymentHistory);
                this.tabControl1.TabPages.Remove(this.tpageSkillScore);
                this.gboxCreditScore.Visible = false;
            }
        }

        #endregion
    }
}
