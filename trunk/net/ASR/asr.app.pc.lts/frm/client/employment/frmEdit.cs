using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.client.employment
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtAddress;
        public repsol.forms.controls.TextBoxColor txtZipCode;
        public repsol.forms.controls.TextBoxColor txtState;
        public repsol.forms.controls.TextBoxColor txtCity;
        internal System.Windows.Forms.DateTimePicker dateStartDate;
        public repsol.forms.controls.TextBoxColor txtBaseSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton rbProvideNoticeNo;
        internal System.Windows.Forms.RadioButton rbProvideNoticeYes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        internal System.Windows.Forms.DateTimePicker dateStartPay;
        private System.Windows.Forms.GroupBox groupBox10;
        internal System.Windows.Forms.DateTimePicker dateEndDate;
        private System.Windows.Forms.GroupBox groupBox11;
        internal System.Windows.Forms.DateTimePicker dateEndPay;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        public repsol.forms.controls.TextBoxColor txtBonus;
        private System.Windows.Forms.GroupBox groupBox14;
        public repsol.forms.controls.TextBoxColor txtAdditionalCompensation;
        private System.Windows.Forms.GroupBox groupBox15;
        public repsol.forms.controls.TextBoxColor txtPositionHeld;
        private System.Windows.Forms.GroupBox groupBox16;
        public repsol.forms.controls.TextBoxColor txtPrimaryResponsibilities;
        private System.Windows.Forms.GroupBox groupBox17;
        public repsol.forms.controls.TextBoxColor txtContactAndTitle;
        private System.Windows.Forms.GroupBox groupBox18;
        public repsol.forms.controls.TextBoxColor txtPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox19;
        internal System.Windows.Forms.RadioButton rbRelationshipSubordinate;
        internal System.Windows.Forms.RadioButton rbRelationshipSupervisor;
        private System.Windows.Forms.GroupBox groupBox20;
        internal System.Windows.Forms.RadioButton rbMayContactNo;
        internal System.Windows.Forms.RadioButton rbMayContactYes;
        private System.Windows.Forms.GroupBox groupBox21;
        public repsol.forms.controls.TextBoxColor txtReasonIfNot;
        internal System.Windows.Forms.RadioButton rbRelationshipCoWorker;
        private System.Windows.Forms.GroupBox groupBox22;
        internal repsol.forms.controls.TextBoxColor txtGap;
        public repsol.forms.controls.TextBoxColor txtReasonForLeaving;

        private Client _client = null;
        protected internal asr.app.pc.template.controls.TextBoxKDBII txtCompany;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        private Customer _customer = null;

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }


        public frmEdit(Client client)
        {
            InitializeComponent();

            _client = client;

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.client.employment.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Employment());
        }
        public frmEdit(Employment objVO)
        {
            InitializeComponent();

            _client = objVO.Client;

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.client.employment.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Employment objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            _client = objVO.Client;

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.client.employment.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.client.employment.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
                base.btAceptar_Click(sender, e);
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtAddress = new repsol.forms.controls.TextBoxColor();
            this.txtZipCode = new repsol.forms.controls.TextBoxColor();
            this.txtState = new repsol.forms.controls.TextBoxColor();
            this.txtCity = new repsol.forms.controls.TextBoxColor();
            this.dateStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtBaseSalary = new repsol.forms.controls.TextBoxColor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProvideNoticeNo = new System.Windows.Forms.RadioButton();
            this.rbProvideNoticeYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReasonForLeaving = new repsol.forms.controls.TextBoxColor();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCompany = new asr.app.pc.template.controls.TextBoxKDBII();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dateStartPay = new System.Windows.Forms.DateTimePicker();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dateEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dateEndPay = new System.Windows.Forms.DateTimePicker();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.txtBonus = new repsol.forms.controls.TextBoxColor();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtAdditionalCompensation = new repsol.forms.controls.TextBoxColor();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtPositionHeld = new repsol.forms.controls.TextBoxColor();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.txtPrimaryResponsibilities = new repsol.forms.controls.TextBoxColor();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.txtContactAndTitle = new repsol.forms.controls.TextBoxColor();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new repsol.forms.controls.TextBoxColor();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rbRelationshipCoWorker = new System.Windows.Forms.RadioButton();
            this.rbRelationshipSubordinate = new System.Windows.Forms.RadioButton();
            this.rbRelationshipSupervisor = new System.Windows.Forms.RadioButton();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.rbMayContactNo = new System.Windows.Forms.RadioButton();
            this.rbMayContactYes = new System.Windows.Forms.RadioButton();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.txtReasonIfNot = new repsol.forms.controls.TextBoxColor();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.txtGap = new repsol.forms.controls.TextBoxColor();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(1135, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1215, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 526);
            this.panFooter.Size = new System.Drawing.Size(618, 43);
            this.panFooter.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.ActivateStyle = true;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAddress.ColorLeave = System.Drawing.Color.White;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(3, 18);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // txtZipCode
            // 
            this.txtZipCode.ActivateStyle = true;
            this.txtZipCode.BackColor = System.Drawing.Color.White;
            this.txtZipCode.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtZipCode.ColorLeave = System.Drawing.Color.White;
            this.txtZipCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZipCode.Location = new System.Drawing.Point(3, 18);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(75, 22);
            this.txtZipCode.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.ActivateStyle = true;
            this.txtState.BackColor = System.Drawing.Color.White;
            this.txtState.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtState.ColorLeave = System.Drawing.Color.White;
            this.txtState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtState.Location = new System.Drawing.Point(3, 18);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(82, 22);
            this.txtState.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.ActivateStyle = true;
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCity.ColorLeave = System.Drawing.Color.White;
            this.txtCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCity.Location = new System.Drawing.Point(3, 18);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(124, 22);
            this.txtCity.TabIndex = 2;
            // 
            // dateStartDate
            // 
            this.dateStartDate.Checked = false;
            this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartDate.Location = new System.Drawing.Point(3, 16);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.ShowCheckBox = true;
            this.dateStartDate.Size = new System.Drawing.Size(109, 22);
            this.dateStartDate.TabIndex = 74;
            // 
            // txtBaseSalary
            // 
            this.txtBaseSalary.ActivateStyle = true;
            this.txtBaseSalary.BackColor = System.Drawing.Color.White;
            this.txtBaseSalary.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtBaseSalary.ColorLeave = System.Drawing.Color.White;
            this.txtBaseSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaseSalary.Location = new System.Drawing.Point(3, 18);
            this.txtBaseSalary.Name = "txtBaseSalary";
            this.txtBaseSalary.Size = new System.Drawing.Size(109, 22);
            this.txtBaseSalary.TabIndex = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProvideNoticeNo);
            this.groupBox1.Controls.Add(this.rbProvideNoticeYes);
            this.groupBox1.Location = new System.Drawing.Point(412, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Did you provide notice?";
            // 
            // rbProvideNoticeNo
            // 
            this.rbProvideNoticeNo.AutoSize = true;
            this.rbProvideNoticeNo.Checked = true;
            this.rbProvideNoticeNo.Location = new System.Drawing.Point(154, 21);
            this.rbProvideNoticeNo.Name = "rbProvideNoticeNo";
            this.rbProvideNoticeNo.Size = new System.Drawing.Size(40, 18);
            this.rbProvideNoticeNo.TabIndex = 1;
            this.rbProvideNoticeNo.TabStop = true;
            this.rbProvideNoticeNo.Text = "No";
            this.rbProvideNoticeNo.UseVisualStyleBackColor = true;
            // 
            // rbProvideNoticeYes
            // 
            this.rbProvideNoticeYes.AutoSize = true;
            this.rbProvideNoticeYes.Location = new System.Drawing.Point(81, 21);
            this.rbProvideNoticeYes.Name = "rbProvideNoticeYes";
            this.rbProvideNoticeYes.Size = new System.Drawing.Size(45, 18);
            this.rbProvideNoticeYes.TabIndex = 0;
            this.rbProvideNoticeYes.Text = "Yes";
            this.rbProvideNoticeYes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReasonForLeaving);
            this.groupBox2.Location = new System.Drawing.Point(3, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 51);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reason for Leaving";
            // 
            // txtReasonForLeaving
            // 
            this.txtReasonForLeaving.ActivateStyle = true;
            this.txtReasonForLeaving.BackColor = System.Drawing.Color.White;
            this.txtReasonForLeaving.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReasonForLeaving.ColorLeave = System.Drawing.Color.White;
            this.txtReasonForLeaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReasonForLeaving.Location = new System.Drawing.Point(3, 18);
            this.txtReasonForLeaving.Name = "txtReasonForLeaving";
            this.txtReasonForLeaving.Size = new System.Drawing.Size(397, 22);
            this.txtReasonForLeaving.TabIndex = 87;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCompany);
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 47);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.ActivateStyle = true;
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCompany.ColorLeave = System.Drawing.Color.White;
            this.txtCompany.DataSource = null;
            this.txtCompany.Location = new System.Drawing.Point(3, 21);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(606, 22);
            this.txtCompany.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Location = new System.Drawing.Point(3, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 44);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Address";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCity);
            this.groupBox5.Location = new System.Drawing.Point(304, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 44);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "City";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtState);
            this.groupBox6.Location = new System.Drawing.Point(440, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(88, 44);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "State";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtZipCode);
            this.groupBox7.Location = new System.Drawing.Point(534, 53);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(81, 44);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Zip Code";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dateStartDate);
            this.groupBox8.Location = new System.Drawing.Point(3, 99);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(115, 44);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Start Date";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dateStartPay);
            this.groupBox9.Location = new System.Drawing.Point(124, 99);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(115, 44);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Start Pay";
            // 
            // dateStartPay
            // 
            this.dateStartPay.Checked = false;
            this.dateStartPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStartPay.Location = new System.Drawing.Point(3, 16);
            this.dateStartPay.Name = "dateStartPay";
            this.dateStartPay.ShowCheckBox = true;
            this.dateStartPay.Size = new System.Drawing.Size(109, 22);
            this.dateStartPay.TabIndex = 74;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dateEndDate);
            this.groupBox10.Location = new System.Drawing.Point(3, 143);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(115, 44);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "End Date";
            // 
            // dateEndDate
            // 
            this.dateEndDate.Checked = false;
            this.dateEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndDate.Location = new System.Drawing.Point(3, 16);
            this.dateEndDate.Name = "dateEndDate";
            this.dateEndDate.ShowCheckBox = true;
            this.dateEndDate.Size = new System.Drawing.Size(109, 22);
            this.dateEndDate.TabIndex = 74;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dateEndPay);
            this.groupBox11.Location = new System.Drawing.Point(124, 143);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(115, 44);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "End Pay";
            // 
            // dateEndPay
            // 
            this.dateEndPay.Checked = false;
            this.dateEndPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndPay.Location = new System.Drawing.Point(3, 16);
            this.dateEndPay.Name = "dateEndPay";
            this.dateEndPay.ShowCheckBox = true;
            this.dateEndPay.Size = new System.Drawing.Size(109, 22);
            this.dateEndPay.TabIndex = 74;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtBaseSalary);
            this.groupBox12.Location = new System.Drawing.Point(245, 99);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(115, 44);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Base Salary";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.txtBonus);
            this.groupBox13.Location = new System.Drawing.Point(245, 143);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(115, 44);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Bonus / Comm.";
            // 
            // txtBonus
            // 
            this.txtBonus.ActivateStyle = true;
            this.txtBonus.BackColor = System.Drawing.Color.White;
            this.txtBonus.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtBonus.ColorLeave = System.Drawing.Color.White;
            this.txtBonus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBonus.Location = new System.Drawing.Point(3, 18);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(109, 22);
            this.txtBonus.TabIndex = 82;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtAdditionalCompensation);
            this.groupBox14.Location = new System.Drawing.Point(366, 99);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(249, 88);
            this.groupBox14.TabIndex = 11;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Additional Compensation";
            // 
            // txtAdditionalCompensation
            // 
            this.txtAdditionalCompensation.ActivateStyle = true;
            this.txtAdditionalCompensation.BackColor = System.Drawing.Color.White;
            this.txtAdditionalCompensation.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAdditionalCompensation.ColorLeave = System.Drawing.Color.White;
            this.txtAdditionalCompensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdditionalCompensation.Location = new System.Drawing.Point(3, 18);
            this.txtAdditionalCompensation.Multiline = true;
            this.txtAdditionalCompensation.Name = "txtAdditionalCompensation";
            this.txtAdditionalCompensation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdditionalCompensation.Size = new System.Drawing.Size(243, 67);
            this.txtAdditionalCompensation.TabIndex = 3;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtPositionHeld);
            this.groupBox15.Location = new System.Drawing.Point(3, 193);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(609, 51);
            this.groupBox15.TabIndex = 12;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Position(s) Held";
            // 
            // txtPositionHeld
            // 
            this.txtPositionHeld.ActivateStyle = true;
            this.txtPositionHeld.BackColor = System.Drawing.Color.White;
            this.txtPositionHeld.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPositionHeld.ColorLeave = System.Drawing.Color.White;
            this.txtPositionHeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPositionHeld.Location = new System.Drawing.Point(3, 18);
            this.txtPositionHeld.Name = "txtPositionHeld";
            this.txtPositionHeld.Size = new System.Drawing.Size(603, 22);
            this.txtPositionHeld.TabIndex = 87;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.txtPrimaryResponsibilities);
            this.groupBox16.Location = new System.Drawing.Point(3, 250);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(609, 51);
            this.groupBox16.TabIndex = 13;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Primary Responsibilities";
            // 
            // txtPrimaryResponsibilities
            // 
            this.txtPrimaryResponsibilities.ActivateStyle = true;
            this.txtPrimaryResponsibilities.BackColor = System.Drawing.Color.White;
            this.txtPrimaryResponsibilities.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPrimaryResponsibilities.ColorLeave = System.Drawing.Color.White;
            this.txtPrimaryResponsibilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrimaryResponsibilities.Location = new System.Drawing.Point(3, 18);
            this.txtPrimaryResponsibilities.Name = "txtPrimaryResponsibilities";
            this.txtPrimaryResponsibilities.Size = new System.Drawing.Size(603, 22);
            this.txtPrimaryResponsibilities.TabIndex = 87;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.txtContactAndTitle);
            this.groupBox17.Location = new System.Drawing.Point(3, 364);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(204, 51);
            this.groupBox17.TabIndex = 16;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Contact and Title";
            // 
            // txtContactAndTitle
            // 
            this.txtContactAndTitle.ActivateStyle = true;
            this.txtContactAndTitle.BackColor = System.Drawing.Color.White;
            this.txtContactAndTitle.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtContactAndTitle.ColorLeave = System.Drawing.Color.White;
            this.txtContactAndTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContactAndTitle.Location = new System.Drawing.Point(3, 18);
            this.txtContactAndTitle.Name = "txtContactAndTitle";
            this.txtContactAndTitle.Size = new System.Drawing.Size(198, 22);
            this.txtContactAndTitle.TabIndex = 87;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.txtPhoneNumber);
            this.groupBox18.Location = new System.Drawing.Point(213, 364);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(110, 51);
            this.groupBox18.TabIndex = 17;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.ActivateStyle = true;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPhoneNumber.ColorLeave = System.Drawing.Color.White;
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.Location = new System.Drawing.Point(3, 18);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(104, 22);
            this.txtPhoneNumber.TabIndex = 87;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rbRelationshipCoWorker);
            this.groupBox19.Controls.Add(this.rbRelationshipSubordinate);
            this.groupBox19.Controls.Add(this.rbRelationshipSupervisor);
            this.groupBox19.Location = new System.Drawing.Point(329, 364);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(283, 51);
            this.groupBox19.TabIndex = 18;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Relationship";
            // 
            // rbRelationshipCoWorker
            // 
            this.rbRelationshipCoWorker.AutoSize = true;
            this.rbRelationshipCoWorker.Location = new System.Drawing.Point(194, 19);
            this.rbRelationshipCoWorker.Name = "rbRelationshipCoWorker";
            this.rbRelationshipCoWorker.Size = new System.Drawing.Size(83, 18);
            this.rbRelationshipCoWorker.TabIndex = 2;
            this.rbRelationshipCoWorker.Text = "Co-Worker";
            this.rbRelationshipCoWorker.UseVisualStyleBackColor = true;
            // 
            // rbRelationshipSubordinate
            // 
            this.rbRelationshipSubordinate.AutoSize = true;
            this.rbRelationshipSubordinate.Location = new System.Drawing.Point(97, 19);
            this.rbRelationshipSubordinate.Name = "rbRelationshipSubordinate";
            this.rbRelationshipSubordinate.Size = new System.Drawing.Size(91, 18);
            this.rbRelationshipSubordinate.TabIndex = 1;
            this.rbRelationshipSubordinate.Text = "Subordinate";
            this.rbRelationshipSubordinate.UseVisualStyleBackColor = true;
            // 
            // rbRelationshipSupervisor
            // 
            this.rbRelationshipSupervisor.AutoSize = true;
            this.rbRelationshipSupervisor.Checked = true;
            this.rbRelationshipSupervisor.Location = new System.Drawing.Point(10, 18);
            this.rbRelationshipSupervisor.Name = "rbRelationshipSupervisor";
            this.rbRelationshipSupervisor.Size = new System.Drawing.Size(81, 18);
            this.rbRelationshipSupervisor.TabIndex = 0;
            this.rbRelationshipSupervisor.TabStop = true;
            this.rbRelationshipSupervisor.Text = "Supervisor";
            this.rbRelationshipSupervisor.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.rbMayContactNo);
            this.groupBox20.Controls.Add(this.rbMayContactYes);
            this.groupBox20.Location = new System.Drawing.Point(3, 419);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(256, 51);
            this.groupBox20.TabIndex = 19;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "May we contact for reference";
            // 
            // rbMayContactNo
            // 
            this.rbMayContactNo.AutoSize = true;
            this.rbMayContactNo.Checked = true;
            this.rbMayContactNo.Location = new System.Drawing.Point(183, 21);
            this.rbMayContactNo.Name = "rbMayContactNo";
            this.rbMayContactNo.Size = new System.Drawing.Size(40, 18);
            this.rbMayContactNo.TabIndex = 1;
            this.rbMayContactNo.TabStop = true;
            this.rbMayContactNo.Text = "No";
            this.rbMayContactNo.UseVisualStyleBackColor = true;
            // 
            // rbMayContactYes
            // 
            this.rbMayContactYes.AutoSize = true;
            this.rbMayContactYes.Location = new System.Drawing.Point(81, 21);
            this.rbMayContactYes.Name = "rbMayContactYes";
            this.rbMayContactYes.Size = new System.Drawing.Size(45, 18);
            this.rbMayContactYes.TabIndex = 0;
            this.rbMayContactYes.Text = "Yes";
            this.rbMayContactYes.UseVisualStyleBackColor = true;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.txtReasonIfNot);
            this.groupBox21.Location = new System.Drawing.Point(265, 419);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(347, 51);
            this.groupBox21.TabIndex = 20;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "If no, reason";
            // 
            // txtReasonIfNot
            // 
            this.txtReasonIfNot.ActivateStyle = true;
            this.txtReasonIfNot.BackColor = System.Drawing.Color.White;
            this.txtReasonIfNot.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReasonIfNot.ColorLeave = System.Drawing.Color.White;
            this.txtReasonIfNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReasonIfNot.Location = new System.Drawing.Point(3, 18);
            this.txtReasonIfNot.Name = "txtReasonIfNot";
            this.txtReasonIfNot.Size = new System.Drawing.Size(341, 22);
            this.txtReasonIfNot.TabIndex = 87;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.txtGap);
            this.groupBox22.Location = new System.Drawing.Point(3, 473);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(612, 51);
            this.groupBox22.TabIndex = 21;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "GAP";
            // 
            // txtGap
            // 
            this.txtGap.ActivateStyle = true;
            this.txtGap.BackColor = System.Drawing.Color.White;
            this.txtGap.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtGap.ColorLeave = System.Drawing.Color.White;
            this.txtGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGap.Location = new System.Drawing.Point(3, 18);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(606, 22);
            this.txtGap.TabIndex = 0;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(618, 569);
            this.Controls.Add(this.groupBox22);
            this.Controls.Add(this.groupBox21);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox19);
            this.Controls.Add(this.groupBox18);
            this.Controls.Add(this.groupBox17);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEdit";
            this.Text = "Employment";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.Controls.SetChildIndex(this.groupBox10, 0);
            this.Controls.SetChildIndex(this.groupBox7, 0);
            this.Controls.SetChildIndex(this.groupBox8, 0);
            this.Controls.SetChildIndex(this.groupBox9, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox11, 0);
            this.Controls.SetChildIndex(this.groupBox12, 0);
            this.Controls.SetChildIndex(this.groupBox13, 0);
            this.Controls.SetChildIndex(this.groupBox14, 0);
            this.Controls.SetChildIndex(this.groupBox15, 0);
            this.Controls.SetChildIndex(this.groupBox16, 0);
            this.Controls.SetChildIndex(this.groupBox17, 0);
            this.Controls.SetChildIndex(this.groupBox18, 0);
            this.Controls.SetChildIndex(this.groupBox19, 0);
            this.Controls.SetChildIndex(this.groupBox20, 0);
            this.Controls.SetChildIndex(this.groupBox21, 0);
            this.Controls.SetChildIndex(this.groupBox22, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            try
            {
                //this.chkCerrar.Visible = true;
                //this.chkCerrar.Checked = false;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
