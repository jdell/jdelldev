using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.apunte
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtSubcuenta;
        internal repsol.forms.controls.TextBoxColor txtConcepto;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtDebe;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtHaber;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtFecha;
        private System.Windows.Forms.Label label5;
        internal repsol.forms.controls.TextBoxColor txtNumeroFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Apunte());
        }
        public frmEdit(Apunte objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Apunte objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlEdit();
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
            this.txtSubcuenta = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConcepto = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDebe = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHaber = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(349, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(429, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 213);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtSubcuenta
            // 
            this.txtSubcuenta.ActivateStyle = true;
            this.txtSubcuenta.BackColor = System.Drawing.Color.White;
            this.txtSubcuenta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSubcuenta.ColorLeave = System.Drawing.Color.White;
            this.txtSubcuenta.Location = new System.Drawing.Point(107, 64);
            this.txtSubcuenta.Name = "txtSubcuenta";
            this.txtSubcuenta.Size = new System.Drawing.Size(92, 22);
            this.txtSubcuenta.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Subcuenta";
            // 
            // txtConcepto
            // 
            this.txtConcepto.ActivateStyle = true;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(107, 92);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConcepto.Size = new System.Drawing.Size(362, 51);
            this.txtConcepto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Concepto";
            // 
            // txtDebe
            // 
            this.txtDebe.ActivateStyle = true;
            this.txtDebe.BackColor = System.Drawing.Color.White;
            this.txtDebe.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDebe.ColorLeave = System.Drawing.Color.White;
            this.txtDebe.Location = new System.Drawing.Point(107, 177);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(92, 22);
            this.txtDebe.TabIndex = 22;
            this.txtDebe.Text = "0";
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Debe";
            // 
            // txtHaber
            // 
            this.txtHaber.ActivateStyle = true;
            this.txtHaber.BackColor = System.Drawing.Color.White;
            this.txtHaber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtHaber.ColorLeave = System.Drawing.Color.White;
            this.txtHaber.Location = new System.Drawing.Point(107, 149);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(92, 22);
            this.txtHaber.TabIndex = 20;
            this.txtHaber.Text = "0";
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Haber";
            // 
            // txtFecha
            // 
            this.txtFecha.ActivateStyle = true;
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFecha.ColorLeave = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(107, 36);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(92, 22);
            this.txtFecha.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.ActivateStyle = true;
            this.txtNumeroFactura.BackColor = System.Drawing.Color.White;
            this.txtNumeroFactura.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNumeroFactura.ColorLeave = System.Drawing.Color.White;
            this.txtNumeroFactura.Location = new System.Drawing.Point(377, 64);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(92, 22);
            this.txtNumeroFactura.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "Referencia";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 256);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubcuenta);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Apunte";
            this.Load += new System.EventHandler(this.frmapunteEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSubcuenta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtHaber, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDebe, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtNumeroFactura, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmapunteEdit_Load(object sender, EventArgs e)
        {

            this.txtDebe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtHaber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
        }
    }
}
