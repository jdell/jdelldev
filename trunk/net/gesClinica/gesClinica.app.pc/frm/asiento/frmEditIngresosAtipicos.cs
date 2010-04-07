using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditIngresosAtipicos: frmEditParent//template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtConcepto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbRetencion;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbServicio;
        internal repsol.forms.controls.TextBoxColor txtImporteRetencion;
        internal repsol.forms.controls.TextBoxColor txtImporteCliente;
        internal repsol.forms.controls.TextBoxColor txtImporteServicio;
        private System.Windows.Forms.Label label2;

        public frmEditIngresosAtipicos()
        {
            InitializeComponent();

            ctrl.ctrlEditIngresosAtipicos ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditIngresosAtipicos();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Asiento());
        }
        public frmEditIngresosAtipicos(Asiento objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditIngresosAtipicos ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditIngresosAtipicos();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditIngresosAtipicos(Asiento objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEditIngresosAtipicos ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditIngresosAtipicos();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditIngresosAtipicos ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditIngresosAtipicos();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImporteRetencion = new repsol.forms.controls.TextBoxColor();
            this.txtImporteCliente = new repsol.forms.controls.TextBoxColor();
            this.txtImporteServicio = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRetencion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panFooter.Location = new System.Drawing.Point(0, 264);
            this.panFooter.Size = new System.Drawing.Size(629, 43);
            this.panFooter.TabIndex = 2;
            // 
            // txtConcepto
            // 
            this.txtConcepto.ActivateStyle = true;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(90, 150);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(517, 22);
            this.txtConcepto.TabIndex = 7;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Operación";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(151, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ingresos con retención";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImporteRetencion);
            this.groupBox2.Controls.Add(this.txtImporteCliente);
            this.groupBox2.Controls.Add(this.txtImporteServicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbRetencion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbServicio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateFecha);
            this.groupBox2.Controls.Add(this.txtConcepto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtImporteRetencion
            // 
            this.txtImporteRetencion.ActivateStyle = true;
            this.txtImporteRetencion.BackColor = System.Drawing.Color.White;
            this.txtImporteRetencion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporteRetencion.ColorLeave = System.Drawing.Color.White;
            this.txtImporteRetencion.Location = new System.Drawing.Point(504, 122);
            this.txtImporteRetencion.Name = "txtImporteRetencion";
            this.txtImporteRetencion.Size = new System.Drawing.Size(103, 22);
            this.txtImporteRetencion.TabIndex = 6;
            this.txtImporteRetencion.Text = "0";
            this.txtImporteRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteRetencion.Validated += new System.EventHandler(this.importe_Validated);
            this.txtImporteRetencion.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // txtImporteCliente
            // 
            this.txtImporteCliente.ActivateStyle = true;
            this.txtImporteCliente.BackColor = System.Drawing.Color.White;
            this.txtImporteCliente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporteCliente.ColorLeave = System.Drawing.Color.White;
            this.txtImporteCliente.Location = new System.Drawing.Point(504, 94);
            this.txtImporteCliente.Name = "txtImporteCliente";
            this.txtImporteCliente.Size = new System.Drawing.Size(103, 22);
            this.txtImporteCliente.TabIndex = 4;
            this.txtImporteCliente.Text = "0";
            this.txtImporteCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteCliente.Validated += new System.EventHandler(this.importe_Validated);
            this.txtImporteCliente.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // txtImporteServicio
            // 
            this.txtImporteServicio.ActivateStyle = true;
            this.txtImporteServicio.BackColor = System.Drawing.Color.White;
            this.txtImporteServicio.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporteServicio.ColorLeave = System.Drawing.Color.White;
            this.txtImporteServicio.Location = new System.Drawing.Point(504, 66);
            this.txtImporteServicio.Name = "txtImporteServicio";
            this.txtImporteServicio.Size = new System.Drawing.Size(103, 22);
            this.txtImporteServicio.TabIndex = 2;
            this.txtImporteServicio.Text = "0";
            this.txtImporteServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteServicio.Validated += new System.EventHandler(this.importe_Validated);
            this.txtImporteServicio.Validating += new System.ComponentModel.CancelEventHandler(this.importe_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Retención";
            // 
            // cmbRetencion
            // 
            this.cmbRetencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRetencion.FormattingEnabled = true;
            this.cmbRetencion.Location = new System.Drawing.Point(89, 122);
            this.cmbRetencion.Name = "cmbRetencion";
            this.cmbRetencion.Size = new System.Drawing.Size(409, 22);
            this.cmbRetencion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(89, 94);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(409, 22);
            this.cmbCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Servicio";
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(89, 66);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(409, 22);
            this.cmbServicio.TabIndex = 1;
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
            this.dateFecha.Location = new System.Drawing.Point(90, 38);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 0;
            // 
            // frmEditIngresosAtipicos
            // 
            this.ClientSize = new System.Drawing.Size(629, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditIngresosAtipicos";
            this.Text = "Ingresos Atípicos";
            this.Load += new System.EventHandler(this.frmasientoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmasientoEdit_Load(object sender, EventArgs e)
        {
            this.Text = "Ingresos Atípicos";
            this.txtImporteCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporteRetencion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporteServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);

            this.cmbCliente.SelectedIndexChanged += new EventHandler(algoCambio);
            this.cmbRetencion.SelectedIndexChanged += new EventHandler(algoCambio);
            this.cmbServicio.SelectedIndexChanged += new EventHandler(algoCambio);

            this.txtConcepto.LostFocus += new EventHandler(lostFocus);
            this.txtImporteCliente.LostFocus += new EventHandler(lostFocus);
            this.txtImporteRetencion.LostFocus += new EventHandler(lostFocus);
            this.txtImporteServicio.LostFocus += new EventHandler(lostFocus);

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
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
