using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.service
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescription;
        internal repsol.forms.controls.TextBoxColor txtPrice;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtStateFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.service.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Service());
        }
        public frmEdit(Service objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.service.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Service objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.service.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.lts.frm.service.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                if (this.IsNewRecord) ((frmQuery)((_main.frmMain)this.Owner).ActiveMdiChild).btRefresh_record();
                base.btAceptar_Click(sender, e);
                this.txtPrice.Text = "0";
                this.txtStateFee.Text = "0";
                this.txtDescription.Focus();

            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtDescription = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStateFee = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
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
            // chkCerrar
            // 
            this.chkCerrar.Checked = false;
            this.chkCerrar.CheckState = System.Windows.Forms.CheckState.Unchecked;
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 132);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.ActivateStyle = true;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescription.ColorLeave = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(108, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(362, 22);
            this.txtDescription.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.ActivateStyle = true;
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPrice.ColorLeave = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(108, 75);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 22);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.Validated += new System.EventHandler(this.txtPrice_Validated);
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price";
            // 
            // txtStateFee
            // 
            this.txtStateFee.ActivateStyle = true;
            this.txtStateFee.BackColor = System.Drawing.Color.White;
            this.txtStateFee.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtStateFee.ColorLeave = System.Drawing.Color.White;
            this.txtStateFee.Location = new System.Drawing.Point(334, 75);
            this.txtStateFee.Name = "txtStateFee";
            this.txtStateFee.Size = new System.Drawing.Size(136, 22);
            this.txtStateFee.TabIndex = 2;
            this.txtStateFee.Text = "0";
            this.txtStateFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStateFee.Visible = false;
            this.txtStateFee.Validated += new System.EventHandler(this.txtPrice_Validated);
            this.txtStateFee.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Other Fee";
            this.label1.Visible = false;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 175);
            this.Controls.Add(this.txtStateFee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtStateFee, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
        }



        private void txtPrice_Validated(object sender, EventArgs e)
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
