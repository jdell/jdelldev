using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.empresa
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtRazonSocial;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpageEmpresa;
        private System.Windows.Forms.TabPage tabPage2;
        internal repsol.forms.controls.TextBoxColor txtFacturaConcepto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cmbFacturaFormato;
        internal repsol.forms.controls.TextBoxColor txtFacturaIVA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        internal repsol.forms.controls.TextBoxColor txtFacturaCliente;
        private System.Windows.Forms.TabPage tpageOtrosDatos;
        internal System.Windows.Forms.DataGridView dgEjercicio;
        internal repsol.forms.controls.TextBoxColor txtCIF;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtDireccion;
        internal repsol.forms.controls.TextBoxColor txtOtrosDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.CheckBox chkcontabilizarFactura;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empresa.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Empresa());
        }
        public frmEdit(Empresa objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empresa.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Empresa objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empresa.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empresa.ctrl.ctrlEdit();
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
            this.txtRazonSocial = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageEmpresa = new System.Windows.Forms.TabPage();
            this.txtCIF = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new repsol.forms.controls.TextBoxColor();
            this.txtOtrosDatos = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFacturaCliente = new repsol.forms.controls.TextBoxColor();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFacturaConcepto = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFacturaFormato = new System.Windows.Forms.ComboBox();
            this.txtFacturaIVA = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.tpageOtrosDatos = new System.Windows.Forms.TabPage();
            this.dgEjercicio = new System.Windows.Forms.DataGridView();
            this.chkcontabilizarFactura = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpageEmpresa.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tpageOtrosDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEjercicio)).BeginInit();
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
            this.panFooter.Location = new System.Drawing.Point(0, 252);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.ActivateStyle = true;
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtRazonSocial.ColorLeave = System.Drawing.Color.White;
            this.txtRazonSocial.Location = new System.Drawing.Point(131, 41);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(348, 22);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Razón Social";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageEmpresa);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpageOtrosDatos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tpageEmpresa
            // 
            this.tpageEmpresa.Controls.Add(this.txtCIF);
            this.tpageEmpresa.Controls.Add(this.label8);
            this.tpageEmpresa.Controls.Add(this.txtDireccion);
            this.tpageEmpresa.Controls.Add(this.txtOtrosDatos);
            this.tpageEmpresa.Controls.Add(this.label7);
            this.tpageEmpresa.Controls.Add(this.label6);
            this.tpageEmpresa.Controls.Add(this.txtRazonSocial);
            this.tpageEmpresa.Controls.Add(this.label2);
            this.tpageEmpresa.Location = new System.Drawing.Point(4, 23);
            this.tpageEmpresa.Name = "tpageEmpresa";
            this.tpageEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tpageEmpresa.Size = new System.Drawing.Size(508, 225);
            this.tpageEmpresa.TabIndex = 0;
            this.tpageEmpresa.Text = "Datos Empresa";
            this.tpageEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtCIF
            // 
            this.txtCIF.ActivateStyle = true;
            this.txtCIF.BackColor = System.Drawing.Color.White;
            this.txtCIF.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCIF.ColorLeave = System.Drawing.Color.White;
            this.txtCIF.Location = new System.Drawing.Point(131, 69);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.Size = new System.Drawing.Size(146, 22);
            this.txtCIF.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 44;
            this.label8.Text = "Otros datos";
            // 
            // txtDireccion
            // 
            this.txtDireccion.ActivateStyle = true;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDireccion.ColorLeave = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(131, 97);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDireccion.Size = new System.Drawing.Size(348, 59);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtOtrosDatos
            // 
            this.txtOtrosDatos.ActivateStyle = true;
            this.txtOtrosDatos.BackColor = System.Drawing.Color.White;
            this.txtOtrosDatos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtOtrosDatos.ColorLeave = System.Drawing.Color.White;
            this.txtOtrosDatos.Location = new System.Drawing.Point(131, 162);
            this.txtOtrosDatos.Name = "txtOtrosDatos";
            this.txtOtrosDatos.Size = new System.Drawing.Size(348, 22);
            this.txtOtrosDatos.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 14);
            this.label7.TabIndex = 45;
            this.label7.Text = "CIF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 43;
            this.label6.Text = "Dirección";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkcontabilizarFactura);
            this.tabPage2.Controls.Add(this.txtFacturaCliente);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtFacturaConcepto);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmbFacturaFormato);
            this.tabPage2.Controls.Add(this.txtFacturaIVA);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 225);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Datos de Facturación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFacturaCliente
            // 
            this.txtFacturaCliente.ActivateStyle = true;
            this.txtFacturaCliente.BackColor = System.Drawing.Color.White;
            this.txtFacturaCliente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFacturaCliente.ColorLeave = System.Drawing.Color.White;
            this.txtFacturaCliente.Location = new System.Drawing.Point(131, 165);
            this.txtFacturaCliente.Name = "txtFacturaCliente";
            this.txtFacturaCliente.Size = new System.Drawing.Size(348, 22);
            this.txtFacturaCliente.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 14);
            this.label12.TabIndex = 48;
            this.label12.Text = "Cliente";
            // 
            // txtFacturaConcepto
            // 
            this.txtFacturaConcepto.ActivateStyle = true;
            this.txtFacturaConcepto.BackColor = System.Drawing.Color.White;
            this.txtFacturaConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFacturaConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtFacturaConcepto.Location = new System.Drawing.Point(131, 94);
            this.txtFacturaConcepto.Multiline = true;
            this.txtFacturaConcepto.Name = "txtFacturaConcepto";
            this.txtFacturaConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFacturaConcepto.Size = new System.Drawing.Size(348, 65);
            this.txtFacturaConcepto.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(29, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 40);
            this.label11.TabIndex = 47;
            this.label11.Text = "Concepto de Factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 14);
            this.label10.TabIndex = 44;
            this.label10.Text = "Formato Factura";
            // 
            // cmbFacturaFormato
            // 
            this.cmbFacturaFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturaFormato.FormattingEnabled = true;
            this.cmbFacturaFormato.Location = new System.Drawing.Point(131, 66);
            this.cmbFacturaFormato.Name = "cmbFacturaFormato";
            this.cmbFacturaFormato.Size = new System.Drawing.Size(348, 22);
            this.cmbFacturaFormato.TabIndex = 1;
            // 
            // txtFacturaIVA
            // 
            this.txtFacturaIVA.ActivateStyle = true;
            this.txtFacturaIVA.BackColor = System.Drawing.Color.LightYellow;
            this.txtFacturaIVA.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFacturaIVA.ColorLeave = System.Drawing.Color.White;
            this.txtFacturaIVA.Location = new System.Drawing.Point(131, 38);
            this.txtFacturaIVA.Name = "txtFacturaIVA";
            this.txtFacturaIVA.Size = new System.Drawing.Size(146, 22);
            this.txtFacturaIVA.TabIndex = 0;
            this.txtFacturaIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFacturaIVA.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtFacturaIVA.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 14);
            this.label9.TabIndex = 42;
            this.label9.Text = "IVA";
            // 
            // tpageOtrosDatos
            // 
            this.tpageOtrosDatos.Controls.Add(this.dgEjercicio);
            this.tpageOtrosDatos.Location = new System.Drawing.Point(4, 23);
            this.tpageOtrosDatos.Name = "tpageOtrosDatos";
            this.tpageOtrosDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpageOtrosDatos.Size = new System.Drawing.Size(508, 225);
            this.tpageOtrosDatos.TabIndex = 4;
            this.tpageOtrosDatos.Text = "Otros datos";
            this.tpageOtrosDatos.UseVisualStyleBackColor = true;
            // 
            // dgEjercicio
            // 
            this.dgEjercicio.AllowUserToAddRows = false;
            this.dgEjercicio.AllowUserToDeleteRows = false;
            this.dgEjercicio.AllowUserToResizeColumns = false;
            this.dgEjercicio.AllowUserToResizeRows = false;
            this.dgEjercicio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgEjercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEjercicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEjercicio.Location = new System.Drawing.Point(3, 3);
            this.dgEjercicio.Name = "dgEjercicio";
            this.dgEjercicio.RowHeadersVisible = false;
            this.dgEjercicio.Size = new System.Drawing.Size(502, 219);
            this.dgEjercicio.TabIndex = 1;
            // 
            // chkcontabilizarFactura
            // 
            this.chkcontabilizarFactura.AutoSize = true;
            this.chkcontabilizarFactura.Location = new System.Drawing.Point(314, 37);
            this.chkcontabilizarFactura.Name = "chkcontabilizarFactura";
            this.chkcontabilizarFactura.Size = new System.Drawing.Size(165, 18);
            this.chkcontabilizarFactura.TabIndex = 49;
            this.chkcontabilizarFactura.Text = "Contabilizar FRA automat.";
            this.chkcontabilizarFactura.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 295);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdit";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmempresaEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpageEmpresa.ResumeLayout(false);
            this.tpageEmpresa.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tpageOtrosDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEjercicio)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmempresaEdit_Load(object sender, EventArgs e)
        {
        }

        private void txtNumerico_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                if (!string.IsNullOrEmpty(txt.Text))
                {
                    int valor = 0;
                    if (!int.TryParse(txt.Text, out valor))
                    {
                        e.Cancel = true;
                        template._common.messages.ShowWarning("Formato numérico incorrecto!", this.Text);
                    }

                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtNumerico_Validated(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrEmpty(txt.Text)) txt.Text = "0";
        }
    }
}
