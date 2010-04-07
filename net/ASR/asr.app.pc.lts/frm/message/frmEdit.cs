using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.message
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtText;
        protected internal System.Windows.Forms.CheckBox chkChecked;
        protected internal System.Windows.Forms.CheckBox chkCalledToSeeYou;
        protected internal System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.DateTimePicker dtpTime;
        internal repsol.forms.controls.TextBoxColor txtFrom;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtOf;
        private System.Windows.Forms.Label label6;
        internal repsol.forms.controls.TextBoxColor txtPhone;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.CheckBox chkPleaseCall;
        protected internal System.Windows.Forms.CheckBox chkReturnedYourCall;
        protected internal System.Windows.Forms.CheckBox chkTelephoned;
        protected internal System.Windows.Forms.CheckBox chkWillCallAgain;
        protected internal System.Windows.Forms.CheckBox chkWantsToSeeYou;
        protected internal System.Windows.Forms.CheckBox chkVisitedYourOffice;
        protected internal System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Message());
        }
        public frmEdit(Message objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Message objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlEdit();
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
            this.txtText = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.chkChecked = new System.Windows.Forms.CheckBox();
            this.chkCalledToSeeYou = new System.Windows.Forms.CheckBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtFrom = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOf = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.chkPleaseCall = new System.Windows.Forms.CheckBox();
            this.chkReturnedYourCall = new System.Windows.Forms.CheckBox();
            this.chkTelephoned = new System.Windows.Forms.CheckBox();
            this.chkWillCallAgain = new System.Windows.Forms.CheckBox();
            this.chkWantsToSeeYou = new System.Windows.Forms.CheckBox();
            this.chkVisitedYourOffice = new System.Windows.Forms.CheckBox();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
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
            this.panFooter.Location = new System.Drawing.Point(0, 344);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 7;
            // 
            // txtText
            // 
            this.txtText.ActivateStyle = true;
            this.txtText.BackColor = System.Drawing.Color.White;
            this.txtText.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtText.ColorLeave = System.Drawing.Color.White;
            this.txtText.Location = new System.Drawing.Point(111, 277);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(362, 61);
            this.txtText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // chkChecked
            // 
            this.chkChecked.AutoSize = true;
            this.chkChecked.Location = new System.Drawing.Point(400, 12);
            this.chkChecked.Name = "chkChecked";
            this.chkChecked.Size = new System.Drawing.Size(73, 18);
            this.chkChecked.TabIndex = 18;
            this.chkChecked.Text = "Checked";
            this.chkChecked.UseVisualStyleBackColor = true;
            // 
            // chkCalledToSeeYou
            // 
            this.chkCalledToSeeYou.AutoSize = true;
            this.chkCalledToSeeYou.Location = new System.Drawing.Point(111, 175);
            this.chkCalledToSeeYou.Name = "chkCalledToSeeYou";
            this.chkCalledToSeeYou.Size = new System.Drawing.Size(120, 18);
            this.chkCalledToSeeYou.TabIndex = 19;
            this.chkCalledToSeeYou.Text = "Called to see you";
            this.chkCalledToSeeYou.UseVisualStyleBackColor = true;
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(111, 34);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(362, 22);
            this.cmbStaff.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(111, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 22);
            this.dtpDate.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Date";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(337, 63);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(136, 22);
            this.dtpTime.TabIndex = 31;
            // 
            // txtFrom
            // 
            this.txtFrom.ActivateStyle = true;
            this.txtFrom.BackColor = System.Drawing.Color.White;
            this.txtFrom.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFrom.ColorLeave = System.Drawing.Color.White;
            this.txtFrom.Location = new System.Drawing.Point(111, 91);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(362, 22);
            this.txtFrom.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "From";
            // 
            // txtOf
            // 
            this.txtOf.ActivateStyle = true;
            this.txtOf.BackColor = System.Drawing.Color.White;
            this.txtOf.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtOf.ColorLeave = System.Drawing.Color.White;
            this.txtOf.Location = new System.Drawing.Point(111, 119);
            this.txtOf.Name = "txtOf";
            this.txtOf.Size = new System.Drawing.Size(362, 22);
            this.txtOf.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "Of";
            // 
            // txtPhone
            // 
            this.txtPhone.ActivateStyle = true;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPhone.ColorLeave = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(111, 147);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(362, 22);
            this.txtPhone.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone";
            // 
            // chkPleaseCall
            // 
            this.chkPleaseCall.AutoSize = true;
            this.chkPleaseCall.Location = new System.Drawing.Point(111, 199);
            this.chkPleaseCall.Name = "chkPleaseCall";
            this.chkPleaseCall.Size = new System.Drawing.Size(80, 18);
            this.chkPleaseCall.TabIndex = 39;
            this.chkPleaseCall.Text = "Please call";
            this.chkPleaseCall.UseVisualStyleBackColor = true;
            // 
            // chkReturnedYourCall
            // 
            this.chkReturnedYourCall.AutoSize = true;
            this.chkReturnedYourCall.Location = new System.Drawing.Point(111, 223);
            this.chkReturnedYourCall.Name = "chkReturnedYourCall";
            this.chkReturnedYourCall.Size = new System.Drawing.Size(125, 18);
            this.chkReturnedYourCall.TabIndex = 40;
            this.chkReturnedYourCall.Text = "Returned your call";
            this.chkReturnedYourCall.UseVisualStyleBackColor = true;
            // 
            // chkTelephoned
            // 
            this.chkTelephoned.AutoSize = true;
            this.chkTelephoned.Location = new System.Drawing.Point(111, 247);
            this.chkTelephoned.Name = "chkTelephoned";
            this.chkTelephoned.Size = new System.Drawing.Size(92, 18);
            this.chkTelephoned.TabIndex = 41;
            this.chkTelephoned.Text = "Telephoned";
            this.chkTelephoned.UseVisualStyleBackColor = true;
            // 
            // chkWillCallAgain
            // 
            this.chkWillCallAgain.AutoSize = true;
            this.chkWillCallAgain.Location = new System.Drawing.Point(359, 247);
            this.chkWillCallAgain.Name = "chkWillCallAgain";
            this.chkWillCallAgain.Size = new System.Drawing.Size(96, 18);
            this.chkWillCallAgain.TabIndex = 42;
            this.chkWillCallAgain.Text = "Will call again";
            this.chkWillCallAgain.UseVisualStyleBackColor = true;
            // 
            // chkWantsToSeeYou
            // 
            this.chkWantsToSeeYou.AutoSize = true;
            this.chkWantsToSeeYou.Location = new System.Drawing.Point(359, 223);
            this.chkWantsToSeeYou.Name = "chkWantsToSeeYou";
            this.chkWantsToSeeYou.Size = new System.Drawing.Size(124, 18);
            this.chkWantsToSeeYou.TabIndex = 43;
            this.chkWantsToSeeYou.Text = "Wants to see you";
            this.chkWantsToSeeYou.UseVisualStyleBackColor = true;
            // 
            // chkVisitedYourOffice
            // 
            this.chkVisitedYourOffice.AutoSize = true;
            this.chkVisitedYourOffice.Location = new System.Drawing.Point(359, 199);
            this.chkVisitedYourOffice.Name = "chkVisitedYourOffice";
            this.chkVisitedYourOffice.Size = new System.Drawing.Size(124, 18);
            this.chkVisitedYourOffice.TabIndex = 44;
            this.chkVisitedYourOffice.Text = "Visited your office";
            this.chkVisitedYourOffice.UseVisualStyleBackColor = true;
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(359, 175);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(64, 18);
            this.chkUrgent.TabIndex = 45;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 387);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.chkVisitedYourOffice);
            this.Controls.Add(this.chkWantsToSeeYou);
            this.Controls.Add(this.chkWillCallAgain);
            this.Controls.Add(this.chkTelephoned);
            this.Controls.Add(this.chkReturnedYourCall);
            this.Controls.Add(this.chkPleaseCall);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.chkCalledToSeeYou);
            this.Controls.Add(this.chkChecked);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtText, 0);
            this.Controls.SetChildIndex(this.chkChecked, 0);
            this.Controls.SetChildIndex(this.chkCalledToSeeYou, 0);
            this.Controls.SetChildIndex(this.cmbStaff, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtpTime, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFrom, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtOf, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.chkPleaseCall, 0);
            this.Controls.SetChildIndex(this.chkReturnedYourCall, 0);
            this.Controls.SetChildIndex(this.chkTelephoned, 0);
            this.Controls.SetChildIndex(this.chkWillCallAgain, 0);
            this.Controls.SetChildIndex(this.chkWantsToSeeYou, 0);
            this.Controls.SetChildIndex(this.chkVisitedYourOffice, 0);
            this.Controls.SetChildIndex(this.chkUrgent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
        }
    }
}
