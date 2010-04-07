using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tercero
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtSubCuenta;
        internal repsol.forms.controls.TextBoxColor txtNombre;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtNIF;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtDomicilio;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtEscalera;
        private System.Windows.Forms.Label label5;
        internal repsol.forms.controls.TextBoxColor txtPiso;
        private System.Windows.Forms.Label label6;
        internal repsol.forms.controls.TextBoxColor txtNumero;
        private System.Windows.Forms.Label label7;
        internal repsol.forms.controls.TextBoxColor txtPoblacion;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtCP;
        private System.Windows.Forms.Label label9;
        internal repsol.forms.controls.TextBoxColor txtProvincia;
        private System.Windows.Forms.Label label10;
        internal repsol.forms.controls.TextBoxColor txtPuerta;
        private System.Windows.Forms.Label label11;
        internal repsol.forms.controls.TextBoxColor txtNacionalidad;
        private System.Windows.Forms.Label label12;
        internal repsol.forms.controls.TextBoxColor txtPersona;
        private System.Windows.Forms.Label label13;
        internal repsol.forms.controls.TextBoxColor txtTelefono2;
        private System.Windows.Forms.Label label14;
        internal repsol.forms.controls.TextBoxColor txtTelefono1;
        private System.Windows.Forms.Label label15;
        internal repsol.forms.controls.TextBoxColor txtFax2;
        private System.Windows.Forms.Label label16;
        internal repsol.forms.controls.TextBoxColor txtFax1;
        private System.Windows.Forms.Label label17;
        internal repsol.forms.controls.TextBoxColor txtFormaPago;
        private System.Windows.Forms.Label label18;
        internal repsol.forms.controls.TextBoxColor txtActividad;
        private System.Windows.Forms.Label label19;
        internal repsol.forms.controls.TextBoxColor txtSigla;
        private System.Windows.Forms.Label label20;
        internal System.Windows.Forms.CheckBox chkRecargo;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tercero.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Tercero());
        }
        public frmEdit(Tercero objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tercero.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Tercero objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tercero.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tercero.ctrl.ctrlEdit();
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
            this.txtSubCuenta = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNIF = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomicilio = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEscalera = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPiso = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPoblacion = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCP = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProvincia = new repsol.forms.controls.TextBoxColor();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPuerta = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new repsol.forms.controls.TextBoxColor();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPersona = new repsol.forms.controls.TextBoxColor();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new repsol.forms.controls.TextBoxColor();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new repsol.forms.controls.TextBoxColor();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFax2 = new repsol.forms.controls.TextBoxColor();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFax1 = new repsol.forms.controls.TextBoxColor();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFormaPago = new repsol.forms.controls.TextBoxColor();
            this.label18 = new System.Windows.Forms.Label();
            this.txtActividad = new repsol.forms.controls.TextBoxColor();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSigla = new repsol.forms.controls.TextBoxColor();
            this.label20 = new System.Windows.Forms.Label();
            this.chkRecargo = new System.Windows.Forms.CheckBox();
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
            this.panFooter.Location = new System.Drawing.Point(0, 419);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 21;
            // 
            // txtSubCuenta
            // 
            this.txtSubCuenta.ActivateStyle = true;
            this.txtSubCuenta.BackColor = System.Drawing.Color.White;
            this.txtSubCuenta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSubCuenta.ColorLeave = System.Drawing.Color.White;
            this.txtSubCuenta.Location = new System.Drawing.Point(106, 47);
            this.txtSubCuenta.Name = "txtSubCuenta";
            this.txtSubCuenta.Size = new System.Drawing.Size(110, 22);
            this.txtSubCuenta.TabIndex = 0;
            this.txtSubCuenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubCuenta_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "SubCuenta";
            // 
            // txtNombre
            // 
            this.txtNombre.ActivateStyle = true;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNombre.ColorLeave = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(106, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(364, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // txtNIF
            // 
            this.txtNIF.ActivateStyle = true;
            this.txtNIF.BackColor = System.Drawing.Color.White;
            this.txtNIF.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNIF.ColorLeave = System.Drawing.Color.White;
            this.txtNIF.Location = new System.Drawing.Point(360, 47);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(110, 22);
            this.txtNIF.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "NIF";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.ActivateStyle = true;
            this.txtDomicilio.BackColor = System.Drawing.Color.White;
            this.txtDomicilio.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDomicilio.ColorLeave = System.Drawing.Color.White;
            this.txtDomicilio.Location = new System.Drawing.Point(106, 103);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(364, 22);
            this.txtDomicilio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Domicilio";
            // 
            // txtEscalera
            // 
            this.txtEscalera.ActivateStyle = true;
            this.txtEscalera.BackColor = System.Drawing.Color.White;
            this.txtEscalera.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtEscalera.ColorLeave = System.Drawing.Color.White;
            this.txtEscalera.Location = new System.Drawing.Point(220, 131);
            this.txtEscalera.Name = "txtEscalera";
            this.txtEscalera.Size = new System.Drawing.Size(50, 22);
            this.txtEscalera.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "Escalera";
            // 
            // txtPiso
            // 
            this.txtPiso.ActivateStyle = true;
            this.txtPiso.BackColor = System.Drawing.Color.White;
            this.txtPiso.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPiso.ColorLeave = System.Drawing.Color.White;
            this.txtPiso.Location = new System.Drawing.Point(315, 131);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(50, 22);
            this.txtPiso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "Piso";
            // 
            // txtNumero
            // 
            this.txtNumero.ActivateStyle = true;
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNumero.ColorLeave = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(106, 131);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(50, 22);
            this.txtNumero.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 29;
            this.label7.Text = "Número";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.ActivateStyle = true;
            this.txtPoblacion.BackColor = System.Drawing.Color.White;
            this.txtPoblacion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPoblacion.ColorLeave = System.Drawing.Color.White;
            this.txtPoblacion.Location = new System.Drawing.Point(106, 160);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(259, 22);
            this.txtPoblacion.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 31;
            this.label8.Text = "Población";
            // 
            // txtCP
            // 
            this.txtCP.ActivateStyle = true;
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCP.ColorLeave = System.Drawing.Color.White;
            this.txtCP.Location = new System.Drawing.Point(420, 160);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(50, 22);
            this.txtCP.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 14);
            this.label9.TabIndex = 33;
            this.label9.Text = "CP";
            // 
            // txtProvincia
            // 
            this.txtProvincia.ActivateStyle = true;
            this.txtProvincia.BackColor = System.Drawing.Color.White;
            this.txtProvincia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProvincia.ColorLeave = System.Drawing.Color.White;
            this.txtProvincia.Location = new System.Drawing.Point(106, 188);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(364, 22);
            this.txtProvincia.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 14);
            this.label10.TabIndex = 35;
            this.label10.Text = "Provincia";
            // 
            // txtPuerta
            // 
            this.txtPuerta.ActivateStyle = true;
            this.txtPuerta.BackColor = System.Drawing.Color.White;
            this.txtPuerta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPuerta.ColorLeave = System.Drawing.Color.White;
            this.txtPuerta.Location = new System.Drawing.Point(420, 132);
            this.txtPuerta.Name = "txtPuerta";
            this.txtPuerta.Size = new System.Drawing.Size(50, 22);
            this.txtPuerta.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 37;
            this.label11.Text = "Puerta";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.ActivateStyle = true;
            this.txtNacionalidad.BackColor = System.Drawing.Color.White;
            this.txtNacionalidad.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNacionalidad.ColorLeave = System.Drawing.Color.White;
            this.txtNacionalidad.Location = new System.Drawing.Point(106, 328);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(364, 22);
            this.txtNacionalidad.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 14);
            this.label12.TabIndex = 39;
            this.label12.Text = "Nacionalidad";
            // 
            // txtPersona
            // 
            this.txtPersona.ActivateStyle = true;
            this.txtPersona.BackColor = System.Drawing.Color.White;
            this.txtPersona.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPersona.ColorLeave = System.Drawing.Color.White;
            this.txtPersona.Location = new System.Drawing.Point(106, 356);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(364, 22);
            this.txtPersona.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 14);
            this.label13.TabIndex = 41;
            this.label13.Text = "Persona";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.ActivateStyle = true;
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono2.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono2.Location = new System.Drawing.Point(360, 216);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(110, 22);
            this.txtTelefono2.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 14);
            this.label14.TabIndex = 45;
            this.label14.Text = "Teléfono 2";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.ActivateStyle = true;
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono1.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono1.Location = new System.Drawing.Point(106, 216);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(110, 22);
            this.txtTelefono1.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 43;
            this.label15.Text = "Teléfono 1";
            // 
            // txtFax2
            // 
            this.txtFax2.ActivateStyle = true;
            this.txtFax2.BackColor = System.Drawing.Color.White;
            this.txtFax2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFax2.ColorLeave = System.Drawing.Color.White;
            this.txtFax2.Location = new System.Drawing.Point(360, 244);
            this.txtFax2.Name = "txtFax2";
            this.txtFax2.Size = new System.Drawing.Size(110, 22);
            this.txtFax2.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(288, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 14);
            this.label16.TabIndex = 49;
            this.label16.Text = "Fax 2";
            // 
            // txtFax1
            // 
            this.txtFax1.ActivateStyle = true;
            this.txtFax1.BackColor = System.Drawing.Color.White;
            this.txtFax1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFax1.ColorLeave = System.Drawing.Color.White;
            this.txtFax1.Location = new System.Drawing.Point(106, 244);
            this.txtFax1.Name = "txtFax1";
            this.txtFax1.Size = new System.Drawing.Size(110, 22);
            this.txtFax1.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 14);
            this.label17.TabIndex = 47;
            this.label17.Text = "Fax 1";
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.ActivateStyle = true;
            this.txtFormaPago.BackColor = System.Drawing.Color.White;
            this.txtFormaPago.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFormaPago.ColorLeave = System.Drawing.Color.White;
            this.txtFormaPago.Location = new System.Drawing.Point(106, 300);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(364, 22);
            this.txtFormaPago.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 14);
            this.label18.TabIndex = 53;
            this.label18.Text = "Forma Pago";
            // 
            // txtActividad
            // 
            this.txtActividad.ActivateStyle = true;
            this.txtActividad.BackColor = System.Drawing.Color.White;
            this.txtActividad.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtActividad.ColorLeave = System.Drawing.Color.White;
            this.txtActividad.Location = new System.Drawing.Point(106, 272);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(364, 22);
            this.txtActividad.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 14);
            this.label19.TabIndex = 51;
            this.label19.Text = "Actividad";
            // 
            // txtSigla
            // 
            this.txtSigla.ActivateStyle = true;
            this.txtSigla.BackColor = System.Drawing.Color.White;
            this.txtSigla.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSigla.ColorLeave = System.Drawing.Color.White;
            this.txtSigla.Location = new System.Drawing.Point(106, 384);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(110, 22);
            this.txtSigla.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 387);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 14);
            this.label20.TabIndex = 55;
            this.label20.Text = "Sigla";
            // 
            // chkRecargo
            // 
            this.chkRecargo.AutoSize = true;
            this.chkRecargo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRecargo.Location = new System.Drawing.Point(400, 386);
            this.chkRecargo.Name = "chkRecargo";
            this.chkRecargo.Size = new System.Drawing.Size(70, 18);
            this.chkRecargo.TabIndex = 20;
            this.chkRecargo.Text = "Recargo";
            this.chkRecargo.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 462);
            this.Controls.Add(this.chkRecargo);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtFax2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtFax1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPuerta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEscalera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubCuenta);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Tercero";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSubCuenta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNIF, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDomicilio, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtEscalera, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPiso, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtPoblacion, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtCP, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtProvincia, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtPuerta, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtNacionalidad, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtPersona, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtTelefono1, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtTelefono2, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtFax1, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtFax2, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.txtActividad, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.txtFormaPago, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.chkRecargo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtSubCuenta_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tercero.ctrl.ctrlEdit();
                frmEdit edit = (frmEdit)this;
                string msg = "";
                e.Cancel = !ctrl.existsSubCuenta(ref edit,out msg);
                if (e.Cancel) template._common.messages.ShowWarning(msg, this.Text);
      
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
