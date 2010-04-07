using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.factura
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtImporte;
        internal repsol.forms.controls.TextBoxColor txtIVA;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtTerapeuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        internal repsol.forms.controls.TextBoxColor txtConcepto;
        internal repsol.forms.controls.TextBoxColor txtCliente;
        private System.Windows.Forms.Label label6;
        internal repsol.forms.controls.TextBoxColor txtCodigo;
        private System.Windows.Forms.Label label7;
        internal repsol.forms.controls.TextBoxColor txtDescuento;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtTotal;
        private System.Windows.Forms.Label label9;
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.RadioButton rbClientePaciente;
        internal System.Windows.Forms.RadioButton rbClienteTerapeuta;
        internal System.Windows.Forms.RadioButton rbConceptoTerapeuta;
        internal System.Windows.Forms.RadioButton rbConceptoTerapia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;

        public frmEdit(Operacion operacion)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Factura(operacion));
        }
        public frmEdit(Factura objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Factura objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlEdit();
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
            this.txtImporte = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIVA = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTerapeuta = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtConcepto = new repsol.forms.controls.TextBoxColor();
            this.txtCliente = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescuento = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservaciones = new repsol.forms.controls.TextBoxColor();
            this.label10 = new System.Windows.Forms.Label();
            this.rbClientePaciente = new System.Windows.Forms.RadioButton();
            this.rbClienteTerapeuta = new System.Windows.Forms.RadioButton();
            this.rbConceptoTerapeuta = new System.Windows.Forms.RadioButton();
            this.rbConceptoTerapia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(342, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(422, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 525);
            this.panFooter.Size = new System.Drawing.Size(509, 43);
            this.panFooter.TabIndex = 2;
            // 
            // txtImporte
            // 
            this.txtImporte.ActivateStyle = false;
            this.txtImporte.BackColor = System.Drawing.SystemColors.Control;
            this.txtImporte.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporte.ColorLeave = System.Drawing.Color.White;
            this.txtImporte.Location = new System.Drawing.Point(111, 21);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(136, 22);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.TabStop = false;
            this.txtImporte.Text = "0";
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtImporte.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Importe";
            // 
            // txtIVA
            // 
            this.txtIVA.ActivateStyle = false;
            this.txtIVA.BackColor = System.Drawing.SystemColors.Control;
            this.txtIVA.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtIVA.ColorLeave = System.Drawing.Color.White;
            this.txtIVA.Location = new System.Drawing.Point(111, 49);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(136, 22);
            this.txtIVA.TabIndex = 4;
            this.txtIVA.TabStop = false;
            this.txtIVA.Text = "0";
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIVA.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtIVA.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "IVA";
            // 
            // txtTerapeuta
            // 
            this.txtTerapeuta.ActivateStyle = false;
            this.txtTerapeuta.BackColor = System.Drawing.SystemColors.Control;
            this.txtTerapeuta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTerapeuta.ColorLeave = System.Drawing.Color.White;
            this.txtTerapeuta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerapeuta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTerapeuta.Location = new System.Drawing.Point(106, 52);
            this.txtTerapeuta.Name = "txtTerapeuta";
            this.txtTerapeuta.ReadOnly = true;
            this.txtTerapeuta.Size = new System.Drawing.Size(364, 22);
            this.txtTerapeuta.TabIndex = 42;
            this.txtTerapeuta.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 43;
            this.label3.Text = "Terapeuta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "Concepto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(334, 24);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 0;
            // 
            // txtConcepto
            // 
            this.txtConcepto.ActivateStyle = true;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(106, 44);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConcepto.Size = new System.Drawing.Size(364, 64);
            this.txtConcepto.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.ActivateStyle = true;
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCliente.ColorLeave = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(106, 44);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCliente.Size = new System.Drawing.Size(364, 36);
            this.txtCliente.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 50;
            this.label6.Text = "Cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.ActivateStyle = false;
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodigo.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCodigo.ColorLeave = System.Drawing.Color.White;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodigo.Location = new System.Drawing.Point(106, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(136, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 53;
            this.label7.Text = "Código";
            // 
            // txtDescuento
            // 
            this.txtDescuento.ActivateStyle = false;
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescuento.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescuento.ColorLeave = System.Drawing.Color.White;
            this.txtDescuento.Location = new System.Drawing.Point(111, 77);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(136, 22);
            this.txtDescuento.TabIndex = 5;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 14);
            this.label8.TabIndex = 55;
            this.label8.Text = "Descuento";
            // 
            // txtTotal
            // 
            this.txtTotal.ActivateStyle = false;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTotal.ColorLeave = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(313, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(136, 22);
            this.txtTotal.TabIndex = 56;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 14);
            this.label9.TabIndex = 57;
            this.label9.Text = "TOTAL";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(28, 31);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservaciones.Size = new System.Drawing.Size(442, 64);
            this.txtObservaciones.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 14);
            this.label10.TabIndex = 58;
            this.label10.Text = "Observaciones";
            // 
            // rbClientePaciente
            // 
            this.rbClientePaciente.AutoSize = true;
            this.rbClientePaciente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClientePaciente.Location = new System.Drawing.Point(106, 21);
            this.rbClientePaciente.Name = "rbClientePaciente";
            this.rbClientePaciente.Size = new System.Drawing.Size(158, 17);
            this.rbClientePaciente.TabIndex = 0;
            this.rbClientePaciente.TabStop = true;
            this.rbClientePaciente.Text = "Ver datos ficha del paciente";
            this.rbClientePaciente.UseVisualStyleBackColor = true;
            this.rbClientePaciente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbClienteTerapeuta
            // 
            this.rbClienteTerapeuta.AutoSize = true;
            this.rbClienteTerapeuta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClienteTerapeuta.Location = new System.Drawing.Point(305, 21);
            this.rbClienteTerapeuta.Name = "rbClienteTerapeuta";
            this.rbClienteTerapeuta.Size = new System.Drawing.Size(165, 17);
            this.rbClienteTerapeuta.TabIndex = 1;
            this.rbClienteTerapeuta.TabStop = true;
            this.rbClienteTerapeuta.Text = "Ver datos ficha del terapeuta";
            this.rbClienteTerapeuta.UseVisualStyleBackColor = true;
            this.rbClienteTerapeuta.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbConceptoTerapeuta
            // 
            this.rbConceptoTerapeuta.AutoSize = true;
            this.rbConceptoTerapeuta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConceptoTerapeuta.Location = new System.Drawing.Point(305, 21);
            this.rbConceptoTerapeuta.Name = "rbConceptoTerapeuta";
            this.rbConceptoTerapeuta.Size = new System.Drawing.Size(165, 17);
            this.rbConceptoTerapeuta.TabIndex = 1;
            this.rbConceptoTerapeuta.TabStop = true;
            this.rbConceptoTerapeuta.Text = "Ver datos ficha del terapeuta";
            this.rbConceptoTerapeuta.UseVisualStyleBackColor = true;
            this.rbConceptoTerapeuta.CheckedChanged += new System.EventHandler(this.rbConcepto_CheckedChanged);
            // 
            // rbConceptoTerapia
            // 
            this.rbConceptoTerapia.AutoSize = true;
            this.rbConceptoTerapia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConceptoTerapia.Location = new System.Drawing.Point(106, 21);
            this.rbConceptoTerapia.Name = "rbConceptoTerapia";
            this.rbConceptoTerapia.Size = new System.Drawing.Size(108, 17);
            this.rbConceptoTerapia.TabIndex = 0;
            this.rbConceptoTerapia.TabStop = true;
            this.rbConceptoTerapia.Text = "Ver datos terapia";
            this.rbConceptoTerapia.UseVisualStyleBackColor = true;
            this.rbConceptoTerapia.CheckedChanged += new System.EventHandler(this.rbConcepto_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbClientePaciente);
            this.groupBox1.Controls.Add(this.rbClienteTerapeuta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConcepto);
            this.groupBox2.Controls.Add(this.rbConceptoTerapia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbConceptoTerapeuta);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTerapeuta);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateFecha);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 90);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtImporte);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtIVA);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDescuento);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 109);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(455, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 14);
            this.label14.TabIndex = 61;
            this.label14.Text = "€";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 14);
            this.label11.TabIndex = 58;
            this.label11.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 59;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(253, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 14);
            this.label13.TabIndex = 60;
            this.label13.Text = "%";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtObservaciones);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 412);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(509, 113);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(509, 568);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmEdit";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmfacturaEdit_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmfacturaEdit_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtNumerico_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                if (!string.IsNullOrEmpty(txt.Text))
                {
                    float valor = 0;
                    if (!float.TryParse(txt.Text, out valor))
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

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlEdit();
                frmEdit edit = (frmEdit)this;
                ctrl.setCliente(ref edit);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void rbConcepto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlEdit();
                frmEdit edit = (frmEdit)this;
                ctrl.setConcepto(ref edit);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
