using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.accountrecord
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtAmount;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtReference;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal repsol.forms.controls.TextBoxColor txtClient;
        protected internal System.Windows.Forms.RadioButton rbIncoming;
        protected internal System.Windows.Forms.RadioButton rbOutgoing;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Button btAddActivity;

        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public frmEdit(Client client)
        {
            InitializeComponent();

            this.Client = client;

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.accountrecord.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new AccountRecord());
        }
        public frmEdit(AccountRecord objVO)
        {
            InitializeComponent();

            this.Client = objVO.Client;

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.accountrecord.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(AccountRecord objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.Client = objVO.Client;
            this.btAddActivity.Enabled = !soloconsulta;

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.accountrecord.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.accountrecord.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);

                AccountRecord obj = (AccountRecord)ctrl.getObject(ref frm, this.IsNewRecord);
              
                if (this.IsNewRecord) ((frmQuery)((_principal.frmPrincipal)this.Owner).ActiveMdiChild).btRefresh_record();
                base.btAceptar_Click(sender, e);

                if (this.Client != null)
                {
                    this.txtClient.Tag = this.Client;
                    this.txtClient.Text = this.Client.FullName;

                    this.dtpDate.Value = obj.Date;
                    this.rbIncoming.Checked = obj.Incoming;
                    this.rbOutgoing.Checked = !obj.Incoming;
                    this.txtAmount.Text = "0";
                    this.cmbActivity.Focus();
                }
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtAmount = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReference = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClient = new repsol.forms.controls.TextBoxColor();
            this.rbIncoming = new System.Windows.Forms.RadioButton();
            this.rbOutgoing = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.btAddActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(441, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(521, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 153);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.ActivateStyle = true;
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAmount.ColorLeave = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(108, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 22);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.Validated += new System.EventHandler(this.txtAmount_Validated);
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Amount";
            // 
            // txtReference
            // 
            this.txtReference.ActivateStyle = true;
            this.txtReference.BackColor = System.Drawing.Color.White;
            this.txtReference.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReference.ColorLeave = System.Drawing.Color.White;
            this.txtReference.Location = new System.Drawing.Point(334, 105);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(136, 22);
            this.txtReference.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Reference";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(108, 49);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 22);
            this.dtpDate.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date";
            // 
            // txtClient
            // 
            this.txtClient.ActivateStyle = false;
            this.txtClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtClient.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtClient.ColorLeave = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(108, 21);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(362, 22);
            this.txtClient.TabIndex = 29;
            // 
            // rbIncoming
            // 
            this.rbIncoming.AutoSize = true;
            this.rbIncoming.Checked = true;
            this.rbIncoming.Location = new System.Drawing.Point(302, 53);
            this.rbIncoming.Name = "rbIncoming";
            this.rbIncoming.Size = new System.Drawing.Size(66, 18);
            this.rbIncoming.TabIndex = 30;
            this.rbIncoming.TabStop = true;
            this.rbIncoming.Text = "Income";
            this.rbIncoming.UseVisualStyleBackColor = true;
            this.rbIncoming.CheckedChanged += new System.EventHandler(this.rbIncoming_CheckedChanged);
            // 
            // rbOutgoing
            // 
            this.rbOutgoing.AutoSize = true;
            this.rbOutgoing.Location = new System.Drawing.Point(394, 53);
            this.rbOutgoing.Name = "rbOutgoing";
            this.rbOutgoing.Size = new System.Drawing.Size(71, 18);
            this.rbOutgoing.TabIndex = 31;
            this.rbOutgoing.Text = "Expense";
            this.rbOutgoing.UseVisualStyleBackColor = true;
            this.rbOutgoing.CheckedChanged += new System.EventHandler(this.rbIncoming_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "Activity";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(108, 77);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(323, 22);
            this.cmbActivity.TabIndex = 32;
            // 
            // btAddActivity
            // 
            this.btAddActivity.Location = new System.Drawing.Point(437, 77);
            this.btAddActivity.Name = "btAddActivity";
            this.btAddActivity.Size = new System.Drawing.Size(33, 22);
            this.btAddActivity.TabIndex = 34;
            this.btAddActivity.Tag = "Add new activity";
            this.btAddActivity.Text = "+";
            this.btAddActivity.UseVisualStyleBackColor = true;
            this.btAddActivity.Click += new System.EventHandler(this.btAddActivity_Click);
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 196);
            this.Controls.Add(this.btAddActivity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbActivity);
            this.Controls.Add(this.rbOutgoing);
            this.Controls.Add(this.rbIncoming);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Name = "frmEdit";
            this.Text = "AccountRecord";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtReference, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtClient, 0);
            this.Controls.SetChildIndex(this.rbIncoming, 0);
            this.Controls.SetChildIndex(this.rbOutgoing, 0);
            this.Controls.SetChildIndex(this.cmbActivity, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btAddActivity, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Client != null)
                {
                    this.txtClient.Tag = this.Client;
                    this.txtClient.Text = this.Client.FullName;
                }
                if (this.IsNewRecord)
                {
                    // 
                    // chkCerrar
                    // 
                    this.chkCerrar.Checked = false;
                    this.chkCerrar.CheckState = System.Windows.Forms.CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }

        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                if (String.IsNullOrEmpty(txt.Text))
                    txt.Text = "0";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void rbIncoming_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.accountrecord.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.reloadActivities(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btAddActivity_Click(object sender, EventArgs e)
        {
            try
            {
                activity.frmEdit vVen = new activity.frmEdit(this.Client);
                vVen.CloseOnAccept = true;
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEdit ctrl = new asr.app.pc.frm.accountrecord.ctrl.ctrlEdit();
                    repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                    ctrl.reloadActivities(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


    }
}
