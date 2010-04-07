using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.skill
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescription;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.skill.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Skill());
        }
        public frmEdit(Skill objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.skill.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Skill objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.skill.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.skill.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                if (this.IsNewRecord) ((frmQuery)((_principal.frmPrincipal)this.Owner).ActiveMdiChild).btRefresh_record();
                base.btAceptar_Click(sender, e);
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
            this.panFooter.Location = new System.Drawing.Point(0, 107);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 7;
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
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 150);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Skill";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
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
