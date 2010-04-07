using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditSueldosYSalarios: frmEditParent//template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtConcepto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbSeguridadSocial;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbSalario;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbMedioPago;
        internal repsol.forms.controls.TextBoxColor txtSeguridadSocialEmpresa;
        internal repsol.forms.controls.TextBoxColor txtRetencionTrabajador;
        internal repsol.forms.controls.TextBoxColor txtSueldoBruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtSeguridadSocialtotal;
        internal repsol.forms.controls.TextBoxColor txtSueldoNeto;
        internal repsol.forms.controls.TextBoxColor txtSeguridadSocialTrabajador;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.ComboBox cmbSeguridadSocialAcreedora;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cmbRetencion;
        private System.Windows.Forms.Label label2;

        public frmEditSueldosYSalarios()
        {
            InitializeComponent();

            ctrl.ctrlEditSueldosYSalarios ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditSueldosYSalarios();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Asiento());
        }
        public frmEditSueldosYSalarios(Asiento objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditSueldosYSalarios ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditSueldosYSalarios();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditSueldosYSalarios(Asiento objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEditSueldosYSalarios ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditSueldosYSalarios();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditSueldosYSalarios ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditSueldosYSalarios();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                //base.btAceptar_Click(sender, e);
                this.btAceptar.Enabled = false;
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtConcepto = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSeguridadSocialAcreedora = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbRetencion = new System.Windows.Forms.ComboBox();
            this.txtRetencionTrabajador = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeguridadSocialtotal = new repsol.forms.controls.TextBoxColor();
            this.txtSueldoNeto = new repsol.forms.controls.TextBoxColor();
            this.txtSeguridadSocialTrabajador = new repsol.forms.controls.TextBoxColor();
            this.txtSeguridadSocialEmpresa = new repsol.forms.controls.TextBoxColor();
            this.txtSueldoBruto = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSeguridadSocial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSalario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(356, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(436, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 382);
            this.panFooter.Size = new System.Drawing.Size(523, 43);
            this.panFooter.TabIndex = 1;
            // 
            // txtConcepto
            // 
            this.txtConcepto.ActivateStyle = true;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(110, 318);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(388, 22);
            this.txtConcepto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Concepto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbSeguridadSocialAcreedora);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbRetencion);
            this.groupBox2.Controls.Add(this.txtRetencionTrabajador);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSeguridadSocialtotal);
            this.groupBox2.Controls.Add(this.txtSueldoNeto);
            this.groupBox2.Controls.Add(this.txtSeguridadSocialTrabajador);
            this.groupBox2.Controls.Add(this.txtSeguridadSocialEmpresa);
            this.groupBox2.Controls.Add(this.txtSueldoBruto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbSeguridadSocial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbSalario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbMedioPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateFecha);
            this.groupBox2.Controls.Add(this.txtConcepto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 357);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 14);
            this.label12.TabIndex = 68;
            this.label12.Text = "Seg. Social Acr.";
            // 
            // cmbSeguridadSocialAcreedora
            // 
            this.cmbSeguridadSocialAcreedora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguridadSocialAcreedora.FormattingEnabled = true;
            this.cmbSeguridadSocialAcreedora.Location = new System.Drawing.Point(110, 178);
            this.cmbSeguridadSocialAcreedora.Name = "cmbSeguridadSocialAcreedora";
            this.cmbSeguridadSocialAcreedora.Size = new System.Drawing.Size(388, 22);
            this.cmbSeguridadSocialAcreedora.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 14);
            this.label13.TabIndex = 67;
            this.label13.Text = "Retención";
            // 
            // cmbRetencion
            // 
            this.cmbRetencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetencion.FormattingEnabled = true;
            this.cmbRetencion.Location = new System.Drawing.Point(110, 150);
            this.cmbRetencion.Name = "cmbRetencion";
            this.cmbRetencion.Size = new System.Drawing.Size(388, 22);
            this.cmbRetencion.TabIndex = 65;
            // 
            // txtRetencionTrabajador
            // 
            this.txtRetencionTrabajador.ActivateStyle = true;
            this.txtRetencionTrabajador.BackColor = System.Drawing.Color.White;
            this.txtRetencionTrabajador.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtRetencionTrabajador.ColorLeave = System.Drawing.Color.White;
            this.txtRetencionTrabajador.Location = new System.Drawing.Point(110, 249);
            this.txtRetencionTrabajador.Name = "txtRetencionTrabajador";
            this.txtRetencionTrabajador.Size = new System.Drawing.Size(103, 22);
            this.txtRetencionTrabajador.TabIndex = 6;
            this.txtRetencionTrabajador.Text = "0";
            this.txtRetencionTrabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetencionTrabajador.Validated += new System.EventHandler(this.importe_Validated);
            this.txtRetencionTrabajador.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 64;
            this.label9.Text = "S. Social Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 14);
            this.label10.TabIndex = 63;
            this.label10.Text = "Sueldo Neto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 62;
            this.label11.Text = "S.S. Trabajador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 14);
            this.label6.TabIndex = 61;
            this.label6.Text = "S.S. Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 14);
            this.label7.TabIndex = 60;
            this.label7.Text = "Retención Trab.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 14);
            this.label8.TabIndex = 59;
            this.label8.Text = "Sueldo Bruto";
            // 
            // txtSeguridadSocialtotal
            // 
            this.txtSeguridadSocialtotal.ActivateStyle = true;
            this.txtSeguridadSocialtotal.BackColor = System.Drawing.Color.White;
            this.txtSeguridadSocialtotal.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSeguridadSocialtotal.ColorLeave = System.Drawing.Color.White;
            this.txtSeguridadSocialtotal.Location = new System.Drawing.Point(395, 277);
            this.txtSeguridadSocialtotal.Name = "txtSeguridadSocialtotal";
            this.txtSeguridadSocialtotal.ReadOnly = true;
            this.txtSeguridadSocialtotal.Size = new System.Drawing.Size(103, 22);
            this.txtSeguridadSocialtotal.TabIndex = 9;
            this.txtSeguridadSocialtotal.TabStop = false;
            this.txtSeguridadSocialtotal.Text = "0";
            this.txtSeguridadSocialtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.ActivateStyle = true;
            this.txtSueldoNeto.BackColor = System.Drawing.Color.White;
            this.txtSueldoNeto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSueldoNeto.ColorLeave = System.Drawing.Color.White;
            this.txtSueldoNeto.Location = new System.Drawing.Point(395, 249);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(103, 22);
            this.txtSueldoNeto.TabIndex = 7;
            this.txtSueldoNeto.TabStop = false;
            this.txtSueldoNeto.Text = "0";
            this.txtSueldoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSeguridadSocialTrabajador
            // 
            this.txtSeguridadSocialTrabajador.ActivateStyle = true;
            this.txtSeguridadSocialTrabajador.BackColor = System.Drawing.Color.White;
            this.txtSeguridadSocialTrabajador.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSeguridadSocialTrabajador.ColorLeave = System.Drawing.Color.White;
            this.txtSeguridadSocialTrabajador.Location = new System.Drawing.Point(395, 221);
            this.txtSeguridadSocialTrabajador.Name = "txtSeguridadSocialTrabajador";
            this.txtSeguridadSocialTrabajador.Size = new System.Drawing.Size(103, 22);
            this.txtSeguridadSocialTrabajador.TabIndex = 5;
            this.txtSeguridadSocialTrabajador.Text = "0";
            this.txtSeguridadSocialTrabajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeguridadSocialTrabajador.Validated += new System.EventHandler(this.importe_Validated);
            this.txtSeguridadSocialTrabajador.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // txtSeguridadSocialEmpresa
            // 
            this.txtSeguridadSocialEmpresa.ActivateStyle = true;
            this.txtSeguridadSocialEmpresa.BackColor = System.Drawing.Color.White;
            this.txtSeguridadSocialEmpresa.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSeguridadSocialEmpresa.ColorLeave = System.Drawing.Color.White;
            this.txtSeguridadSocialEmpresa.Location = new System.Drawing.Point(110, 277);
            this.txtSeguridadSocialEmpresa.Name = "txtSeguridadSocialEmpresa";
            this.txtSeguridadSocialEmpresa.Size = new System.Drawing.Size(103, 22);
            this.txtSeguridadSocialEmpresa.TabIndex = 8;
            this.txtSeguridadSocialEmpresa.Text = "0";
            this.txtSeguridadSocialEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeguridadSocialEmpresa.Validated += new System.EventHandler(this.importe_Validated);
            this.txtSeguridadSocialEmpresa.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.ActivateStyle = true;
            this.txtSueldoBruto.BackColor = System.Drawing.Color.White;
            this.txtSueldoBruto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSueldoBruto.ColorLeave = System.Drawing.Color.White;
            this.txtSueldoBruto.Location = new System.Drawing.Point(110, 221);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(103, 22);
            this.txtSueldoBruto.TabIndex = 4;
            this.txtSueldoBruto.Text = "0";
            this.txtSueldoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSueldoBruto.Validated += new System.EventHandler(this.importe_Validated);
            this.txtSueldoBruto.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Seg. Social";
            // 
            // cmbSeguridadSocial
            // 
            this.cmbSeguridadSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguridadSocial.FormattingEnabled = true;
            this.cmbSeguridadSocial.Location = new System.Drawing.Point(110, 122);
            this.cmbSeguridadSocial.Name = "cmbSeguridadSocial";
            this.cmbSeguridadSocial.Size = new System.Drawing.Size(388, 22);
            this.cmbSeguridadSocial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Salario";
            // 
            // cmbSalario
            // 
            this.cmbSalario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalario.FormattingEnabled = true;
            this.cmbSalario.Location = new System.Drawing.Point(110, 94);
            this.cmbSalario.Name = "cmbSalario";
            this.cmbSalario.Size = new System.Drawing.Size(388, 22);
            this.cmbSalario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Medio de Pago";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(110, 66);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(388, 22);
            this.cmbMedioPago.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fecha";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(110, 38);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 0;
            // 
            // frmEditSueldosYSalarios
            // 
            this.ClientSize = new System.Drawing.Size(523, 425);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEditSueldosYSalarios";
            this.Text = "Sueldos y Salarios";
            this.Load += new System.EventHandler(this.frmasientoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmasientoEdit_Load(object sender, EventArgs e)
        {
            this.Text = "Ingresos Atípicos";

            this.txtRetencionTrabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtSeguridadSocialEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtSeguridadSocialtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtSeguridadSocialTrabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtSueldoBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtSueldoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
        }

        private void importe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (!String.IsNullOrEmpty(textBox.Text))
                {
                    float importe;
                    if (!float.TryParse(textBox.Text, out importe))
                    {
                        e.Cancel = true;
                        template._common.messages.ShowWarning("Formato numérico incorrecto.", "Validación");
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void importe_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (String.IsNullOrEmpty(textBox.Text))
                    textBox.Text = "0";

                ctrl.ctrlEditSueldosYSalarios ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditSueldosYSalarios();
                frmEditSueldosYSalarios frm = (frmEditSueldosYSalarios)this;
                ctrl.updateTotal(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
