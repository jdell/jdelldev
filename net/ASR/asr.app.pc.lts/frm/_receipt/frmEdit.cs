using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.lts.frm._receipt
{
    class frmEdit:template.frm.edicion.EditForm
    {
        internal System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.TabPage tpageCashClient;
        protected internal asr.app.pc.template.controls.TextBoxKDBII txtCashClient;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal repsol.forms.controls.TextBoxColor txtLastName;
        internal repsol.forms.controls.TextBoxColor txtFirstName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label14;
        internal repsol.forms.controls.TextBoxColor txtCompanyName;
        internal System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtSSN;
        internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.ComboBox cmbService;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.GroupBox groupBox2;
        protected internal System.Windows.Forms.NumericUpDown txtUnits;
        internal repsol.forms.controls.TextBoxColor txtPrice;
        internal System.Windows.Forms.Label label7;
        internal repsol.forms.controls.TextBoxColor txtTotal;
        internal System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtStateFee;
        internal System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.ComboBox cmbPayable;
        internal System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.CheckBox chkPaid;
        internal System.Windows.Forms.GroupBox groupBox3;
        protected internal System.Windows.Forms.ComboBox cmbSerie;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.DateTimePicker dtpDate;
        internal repsol.forms.controls.TextBoxColor txtNumber;
        internal repsol.forms.controls.TextBoxColor txtComments;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TabPage tpageNewClient;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm._receipt.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new lib.vo.Invoice());
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm._receipt.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                base.btAceptar_Click(sender, e);

                lib.bl._reports.invoice.rptInvoice informe = new asr.lib.bl._reports.invoice.rptInvoice((lib.vo.Invoice)this.InnerVO);
                template.frm.impresion.PrintForm vVen = new asr.app.pc.template.frm.impresion.PrintForm();
                Microsoft.Reporting.WinForms.ReportViewer viewer = vVen.viewer;
                informe.setInformeViewer(ref viewer);
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageCashClient = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCashClient = new asr.app.pc.template.controls.TextBoxKDBII();
            this.tpageNewClient = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCompanyName = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSSN = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new repsol.forms.controls.TextBoxColor();
            this.txtFirstName = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnits = new System.Windows.Forms.NumericUpDown();
            this.txtStateFee = new repsol.forms.controls.TextBoxColor();
            this.txtPrice = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.cmbPayable = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtComments = new repsol.forms.controls.TextBoxColor();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumber = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpageCashClient.SuspendLayout();
            this.tpageNewClient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnits)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 458);
            this.panFooter.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageCashClient);
            this.tabControl1.Controls.Add(this.tpageNewClient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 141);
            this.tabControl1.TabIndex = 0;
            // 
            // tpageCashClient
            // 
            this.tpageCashClient.Controls.Add(this.label1);
            this.tpageCashClient.Controls.Add(this.txtCashClient);
            this.tpageCashClient.Location = new System.Drawing.Point(4, 23);
            this.tpageCashClient.Name = "tpageCashClient";
            this.tpageCashClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpageCashClient.Size = new System.Drawing.Size(456, 114);
            this.tpageCashClient.TabIndex = 0;
            this.tpageCashClient.Text = "Cash Client";
            this.tpageCashClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "Client";
            // 
            // txtCashClient
            // 
            this.txtCashClient.ActivateStyle = true;
            this.txtCashClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCashClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCashClient.BackColor = System.Drawing.Color.LightYellow;
            this.txtCashClient.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCashClient.ColorLeave = System.Drawing.Color.White;
            this.txtCashClient.DataSource = null;
            this.txtCashClient.Location = new System.Drawing.Point(94, 46);
            this.txtCashClient.Name = "txtCashClient";
            this.txtCashClient.Size = new System.Drawing.Size(338, 22);
            this.txtCashClient.TabIndex = 0;
            // 
            // tpageNewClient
            // 
            this.tpageNewClient.Controls.Add(this.label14);
            this.tpageNewClient.Controls.Add(this.txtCompanyName);
            this.tpageNewClient.Controls.Add(this.label4);
            this.tpageNewClient.Controls.Add(this.txtSSN);
            this.tpageNewClient.Controls.Add(this.label2);
            this.tpageNewClient.Controls.Add(this.txtLastName);
            this.tpageNewClient.Controls.Add(this.txtFirstName);
            this.tpageNewClient.Controls.Add(this.label5);
            this.tpageNewClient.Location = new System.Drawing.Point(4, 23);
            this.tpageNewClient.Name = "tpageNewClient";
            this.tpageNewClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpageNewClient.Size = new System.Drawing.Size(456, 116);
            this.tpageNewClient.TabIndex = 1;
            this.tpageNewClient.Text = "New Client";
            this.tpageNewClient.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 14);
            this.label14.TabIndex = 42;
            this.label14.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.ActivateStyle = true;
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCompanyName.ColorLeave = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(78, 73);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(353, 22);
            this.txtCompanyName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 41;
            this.label4.Text = "SSN";
            // 
            // txtSSN
            // 
            this.txtSSN.ActivateStyle = true;
            this.txtSSN.BackColor = System.Drawing.Color.White;
            this.txtSSN.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSSN.ColorLeave = System.Drawing.Color.White;
            this.txtSSN.Location = new System.Drawing.Point(78, 45);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(136, 22);
            this.txtSSN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 37;
            this.label2.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.ActivateStyle = true;
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtLastName.ColorLeave = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(295, 17);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.ActivateStyle = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFirstName.ColorLeave = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(78, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 38;
            this.label5.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 40;
            this.label3.Text = "Service";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(101, 21);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(338, 22);
            this.cmbService.TabIndex = 0;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 43;
            this.label6.Text = "Units";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnits);
            this.groupBox2.Controls.Add(this.txtStateFee);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbService);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(101, 49);
            this.txtUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(109, 22);
            this.txtUnits.TabIndex = 1;
            this.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnits.ValueChanged += new System.EventHandler(this.txtUnits_ValueChanged);
            // 
            // txtStateFee
            // 
            this.txtStateFee.ActivateStyle = false;
            this.txtStateFee.BackColor = System.Drawing.SystemColors.Control;
            this.txtStateFee.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtStateFee.ColorLeave = System.Drawing.Color.White;
            this.txtStateFee.Location = new System.Drawing.Point(328, 77);
            this.txtStateFee.Name = "txtStateFee";
            this.txtStateFee.Size = new System.Drawing.Size(111, 22);
            this.txtStateFee.TabIndex = 48;
            this.txtStateFee.TabStop = false;
            this.txtStateFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStateFee.Validated += new System.EventHandler(this.txtPrice_Validated);
            this.txtStateFee.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.ActivateStyle = false;
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPrice.ColorLeave = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(328, 49);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(111, 22);
            this.txtPrice.TabIndex = 44;
            this.txtPrice.TabStop = false;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 14);
            this.label9.TabIndex = 49;
            this.label9.Text = "Fees/Disc.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 45;
            this.label7.Text = "Price";
            // 
            // txtTotal
            // 
            this.txtTotal.ActivateStyle = false;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTotal.ColorLeave = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(328, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 22);
            this.txtTotal.TabIndex = 46;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total";
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPaid.Checked = true;
            this.chkPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPaid.Location = new System.Drawing.Point(391, 31);
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.Size = new System.Drawing.Size(48, 18);
            this.chkPaid.TabIndex = 52;
            this.chkPaid.Text = "Paid";
            this.chkPaid.UseVisualStyleBackColor = true;
            // 
            // cmbPayable
            // 
            this.cmbPayable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayable.FormattingEnabled = true;
            this.cmbPayable.Location = new System.Drawing.Point(101, 56);
            this.cmbPayable.Name = "cmbPayable";
            this.cmbPayable.Size = new System.Drawing.Size(338, 22);
            this.cmbPayable.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 14);
            this.label10.TabIndex = 51;
            this.label10.Text = "Payable";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtComments);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtNumber);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpDate);
            this.groupBox3.Controls.Add(this.chkPaid);
            this.groupBox3.Controls.Add(this.cmbSerie);
            this.groupBox3.Controls.Add(this.cmbPayable);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // txtComments
            // 
            this.txtComments.ActivateStyle = true;
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtComments.ColorLeave = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(101, 84);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(337, 52);
            this.txtComments.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 14);
            this.label12.TabIndex = 59;
            this.label12.Text = "Comment";
            // 
            // txtNumber
            // 
            this.txtNumber.ActivateStyle = false;
            this.txtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNumber.ColorLeave = System.Drawing.Color.White;
            this.txtNumber.Location = new System.Drawing.Point(159, 31);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(83, 22);
            this.txtNumber.TabIndex = 55;
            this.txtNumber.TabStop = false;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 14);
            this.label11.TabIndex = 54;
            this.label11.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(287, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(98, 22);
            this.dtpDate.TabIndex = 53;
            // 
            // cmbSerie
            // 
            this.cmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Location = new System.Drawing.Point(101, 31);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(52, 22);
            this.cmbSerie.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 14);
            this.label15.TabIndex = 40;
            this.label15.Text = "Serie";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(470, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmEdit";
            this.Text = "Invoice/Receipt";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpageCashClient.ResumeLayout(false);
            this.tpageCashClient.PerformLayout();
            this.tpageNewClient.ResumeLayout(false);
            this.tpageNewClient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnits)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm._receipt.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.loadService(ref frm);
                calcTotal();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void calcTotal()
        {
            try
            {
                Single price = 0;
                Single stateFee = 0;
                Single units = 0;

                Single.TryParse(this.txtPrice.Text, out price);
                Single.TryParse(this.txtStateFee.Text, out stateFee);
                Single.TryParse(this.txtUnits.Value.ToString(), out units);

                Single total = (price + stateFee )* units;

                this.txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtUnits_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                if (String.IsNullOrEmpty(txt.Text))
                    txt.Text = "0";

                calcTotal();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

                Single numeric = 0;
                e.Cancel = !Single.TryParse(txt.Text, out numeric);
                if (e.Cancel) template._common.messages.ShowWarning("Incorrect format!", this.Text);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
