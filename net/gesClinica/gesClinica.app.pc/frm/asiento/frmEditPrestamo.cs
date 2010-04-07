using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditPrestamo: frmEditParent//template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtConcepto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbCuentaCargo;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbAmortizacion;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbIntereses;
        internal repsol.forms.controls.TextBoxColor txtImporteCuentaCargo;
        internal repsol.forms.controls.TextBoxColor txtImporteAmortizacion;
        internal repsol.forms.controls.TextBoxColor txtImporteIntereses;
        private System.Windows.Forms.Label label2;

        public frmEditPrestamo()
        {
            InitializeComponent();

            ctrl.ctrlEditPrestamo ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditPrestamo();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Asiento());
        }
        public frmEditPrestamo(Asiento objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditPrestamo ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditPrestamo();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditPrestamo(Asiento objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEditPrestamo ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditPrestamo();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditPrestamo ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditPrestamo();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
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
            this.txtImporteCuentaCargo = new repsol.forms.controls.TextBoxColor();
            this.txtImporteAmortizacion = new repsol.forms.controls.TextBoxColor();
            this.txtImporteIntereses = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCuentaCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAmortizacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIntereses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(462, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(542, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 214);
            this.panFooter.Size = new System.Drawing.Size(629, 43);
            this.panFooter.TabIndex = 1;
            // 
            // txtConcepto
            // 
            this.txtConcepto.ActivateStyle = true;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(116, 150);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(491, 22);
            this.txtConcepto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Concepto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImporteCuentaCargo);
            this.groupBox2.Controls.Add(this.txtImporteAmortizacion);
            this.groupBox2.Controls.Add(this.txtImporteIntereses);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbCuentaCargo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbAmortizacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbIntereses);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateFecha);
            this.groupBox2.Controls.Add(this.txtConcepto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtImporteCuentaCargo
            // 
            this.txtImporteCuentaCargo.ActivateStyle = true;
            this.txtImporteCuentaCargo.BackColor = System.Drawing.Color.White;
            this.txtImporteCuentaCargo.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporteCuentaCargo.ColorLeave = System.Drawing.Color.White;
            this.txtImporteCuentaCargo.Location = new System.Drawing.Point(504, 122);
            this.txtImporteCuentaCargo.Name = "txtImporteCuentaCargo";
            this.txtImporteCuentaCargo.ReadOnly = true;
            this.txtImporteCuentaCargo.Size = new System.Drawing.Size(103, 22);
            this.txtImporteCuentaCargo.TabIndex = 2;
            this.txtImporteCuentaCargo.Text = "0";
            this.txtImporteCuentaCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteCuentaCargo.Validated += new System.EventHandler(this.importe_Validated);
            this.txtImporteCuentaCargo.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // txtImporteAmortizacion
            // 
            this.txtImporteAmortizacion.ActivateStyle = true;
            this.txtImporteAmortizacion.BackColor = System.Drawing.Color.White;
            this.txtImporteAmortizacion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporteAmortizacion.ColorLeave = System.Drawing.Color.White;
            this.txtImporteAmortizacion.Location = new System.Drawing.Point(504, 94);
            this.txtImporteAmortizacion.Name = "txtImporteAmortizacion";
            this.txtImporteAmortizacion.Size = new System.Drawing.Size(103, 22);
            this.txtImporteAmortizacion.TabIndex = 1;
            this.txtImporteAmortizacion.Text = "0";
            this.txtImporteAmortizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteAmortizacion.Validated += new System.EventHandler(this.importe_Validated);
            this.txtImporteAmortizacion.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // txtImporteIntereses
            // 
            this.txtImporteIntereses.ActivateStyle = true;
            this.txtImporteIntereses.BackColor = System.Drawing.Color.White;
            this.txtImporteIntereses.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporteIntereses.ColorLeave = System.Drawing.Color.White;
            this.txtImporteIntereses.Location = new System.Drawing.Point(504, 66);
            this.txtImporteIntereses.Name = "txtImporteIntereses";
            this.txtImporteIntereses.Size = new System.Drawing.Size(103, 22);
            this.txtImporteIntereses.TabIndex = 0;
            this.txtImporteIntereses.Text = "0";
            this.txtImporteIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteIntereses.Validated += new System.EventHandler(this.importe_Validated);
            this.txtImporteIntereses.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cargo en cuenta";
            // 
            // cmbCuentaCargo
            // 
            this.cmbCuentaCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentaCargo.FormattingEnabled = true;
            this.cmbCuentaCargo.Location = new System.Drawing.Point(116, 122);
            this.cmbCuentaCargo.Name = "cmbCuentaCargo";
            this.cmbCuentaCargo.Size = new System.Drawing.Size(382, 22);
            this.cmbCuentaCargo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Amortización";
            // 
            // cmbAmortizacion
            // 
            this.cmbAmortizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmortizacion.FormattingEnabled = true;
            this.cmbAmortizacion.Location = new System.Drawing.Point(116, 94);
            this.cmbAmortizacion.Name = "cmbAmortizacion";
            this.cmbAmortizacion.Size = new System.Drawing.Size(383, 22);
            this.cmbAmortizacion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Intereses";
            // 
            // cmbIntereses
            // 
            this.cmbIntereses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntereses.FormattingEnabled = true;
            this.cmbIntereses.Location = new System.Drawing.Point(116, 66);
            this.cmbIntereses.Name = "cmbIntereses";
            this.cmbIntereses.Size = new System.Drawing.Size(382, 22);
            this.cmbIntereses.TabIndex = 3;
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
            this.dateFecha.Location = new System.Drawing.Point(115, 38);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 0;
            // 
            // frmEditPrestamo
            // 
            this.ClientSize = new System.Drawing.Size(629, 257);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmEditPrestamo";
            this.Text = "Préstamo";
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
            this.Text = "Préstamo";

            this.txtImporteAmortizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporteCuentaCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporteIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);

            this.cmbAmortizacion.SelectedIndexChanged +=new EventHandler(algoCambio);
            this.cmbCuentaCargo.SelectedIndexChanged += new EventHandler(algoCambio);
            this.cmbIntereses.SelectedIndexChanged += new EventHandler(algoCambio);

            this.txtConcepto.LostFocus += new EventHandler(lostFocus);
            this.txtImporteAmortizacion.LostFocus +=new EventHandler(lostFocus);
            this.txtImporteCuentaCargo.LostFocus += new EventHandler(lostFocus);
            this.txtImporteIntereses.LostFocus += new EventHandler(lostFocus);

            this.dateFecha.ValueChanged += new EventHandler(dateFecha_ValueChanged);
        }

        void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            habilitarAcepta();
        }

        void lostFocus(object sender, EventArgs e)
        {
            habilitarAcepta();
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

                ctrl.ctrlEditPrestamo ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditPrestamo();
                frmEditPrestamo frm = (frmEditPrestamo)this;
                ctrl.updateCuentaCargo(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
