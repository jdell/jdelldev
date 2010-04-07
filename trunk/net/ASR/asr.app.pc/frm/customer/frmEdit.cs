using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.customer
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtName;
        internal repsol.forms.controls.TextBoxColor txtAddress;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtPhone;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtFax;
        private System.Windows.Forms.Label label4;
        public repsol.forms.controls.TextBoxColor txtZipCode;
        private System.Windows.Forms.Label label5;
        public repsol.forms.controls.TextBoxColor txtState;
        private System.Windows.Forms.Label label19;
        public repsol.forms.controls.TextBoxColor txtCity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.customer.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Customer());
        }
        public frmEdit(Customer objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.customer.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Customer objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.customer.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.customer.ctrl.ctrlEdit();
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
            this.txtName = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFax = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZipCode = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new repsol.forms.controls.TextBoxColor();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCity = new repsol.forms.controls.TextBoxColor();
            this.label20 = new System.Windows.Forms.Label();
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
            this.panFooter.Location = new System.Drawing.Point(0, 183);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.ActivateStyle = true;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtName.ColorLeave = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(108, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 22);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.ActivateStyle = true;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAddress.ColorLeave = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(108, 75);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(362, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.ActivateStyle = true;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPhone.ColorLeave = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(108, 132);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone";
            // 
            // txtFax
            // 
            this.txtFax.ActivateStyle = true;
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFax.ColorLeave = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(334, 132);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(136, 22);
            this.txtFax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fax";
            // 
            // txtZipCode
            // 
            this.txtZipCode.ActivateStyle = true;
            this.txtZipCode.BackColor = System.Drawing.Color.White;
            this.txtZipCode.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtZipCode.ColorLeave = System.Drawing.Color.White;
            this.txtZipCode.Location = new System.Drawing.Point(424, 104);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(46, 22);
            this.txtZipCode.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 73;
            this.label5.Text = "Zip Code";
            // 
            // txtState
            // 
            this.txtState.ActivateStyle = true;
            this.txtState.BackColor = System.Drawing.Color.White;
            this.txtState.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtState.ColorLeave = System.Drawing.Color.White;
            this.txtState.Location = new System.Drawing.Point(305, 104);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(48, 22);
            this.txtState.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 14);
            this.label19.TabIndex = 71;
            this.label19.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.ActivateStyle = true;
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCity.ColorLeave = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(108, 105);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 22);
            this.txtCity.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 14);
            this.label20.TabIndex = 69;
            this.label20.Text = "City";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 226);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFax, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.txtCity, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.txtState, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtZipCode, 0);
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
