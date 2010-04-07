using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.laboratorio
{
    class frmEdit: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.TabControl tabLaboratorio;
        private System.Windows.Forms.TabPage tpageLaboratorio;
        private System.Windows.Forms.GroupBox groupBox3;
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        internal repsol.forms.controls.TextBoxColor txtTelefono3;
        private System.Windows.Forms.Label label16;
        internal repsol.forms.controls.TextBoxColor txtTelefono2;
        private System.Windows.Forms.Label label15;
        internal repsol.forms.controls.TextBoxColor txtTelefono1;
        private System.Windows.Forms.Label label14;
        internal repsol.forms.controls.TextBoxColor txtProvincia;
        private System.Windows.Forms.Label label13;
        internal repsol.forms.controls.TextBoxColor txtCP;
        private System.Windows.Forms.Label label12;
        internal repsol.forms.controls.TextBoxColor txtLocalidad;
        private System.Windows.Forms.Label label11;
        internal repsol.forms.controls.TextBoxColor txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        internal repsol.forms.controls.TextBoxColor txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpageVisitador;
        private System.Windows.Forms.GroupBox groupBox4;
        internal repsol.forms.controls.TextBoxColor txtVisitadorObservaciones;
        private System.Windows.Forms.GroupBox groupBox5;
        internal repsol.forms.controls.TextBoxColor txtVisitadorFax;
        private System.Windows.Forms.Label label28;
        internal repsol.forms.controls.TextBoxColor txtVisitadorMail;
        private System.Windows.Forms.Label label27;
        internal repsol.forms.controls.TextBoxColor txtVisitadorTelefono3;
        internal repsol.forms.controls.TextBoxColor txtVisitadorNombre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label34;
        internal repsol.forms.controls.TextBoxColor txtVisitadorTelefono2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label21;
        internal repsol.forms.controls.TextBoxColor txtVisitadorApellido1;
        internal repsol.forms.controls.TextBoxColor txtVisitadorTelefono1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label36;
        internal repsol.forms.controls.TextBoxColor txtFax;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtWeb;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtMail;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtVisitadorApellido2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.laboratorio.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Laboratorio());
        }
        public frmEdit(Laboratorio objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.laboratorio.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Laboratorio objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.laboratorio.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.laboratorio.ctrl.ctrlEdit();
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
            this.tabLaboratorio = new System.Windows.Forms.TabControl();
            this.tpageLaboratorio = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new repsol.forms.controls.TextBoxColor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWeb = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFax = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono3 = new repsol.forms.controls.TextBoxColor();
            this.txtDireccion = new repsol.forms.controls.TextBoxColor();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLocalidad = new repsol.forms.controls.TextBoxColor();
            this.txtTelefono1 = new repsol.forms.controls.TextBoxColor();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCP = new repsol.forms.controls.TextBoxColor();
            this.txtProvincia = new repsol.forms.controls.TextBoxColor();
            this.label13 = new System.Windows.Forms.Label();
            this.tpageVisitador = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtVisitadorObservaciones = new repsol.forms.controls.TextBoxColor();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVisitadorFax = new repsol.forms.controls.TextBoxColor();
            this.label28 = new System.Windows.Forms.Label();
            this.txtVisitadorMail = new repsol.forms.controls.TextBoxColor();
            this.label27 = new System.Windows.Forms.Label();
            this.txtVisitadorTelefono3 = new repsol.forms.controls.TextBoxColor();
            this.txtVisitadorNombre = new repsol.forms.controls.TextBoxColor();
            this.label20 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtVisitadorTelefono2 = new repsol.forms.controls.TextBoxColor();
            this.label35 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtVisitadorApellido1 = new repsol.forms.controls.TextBoxColor();
            this.txtVisitadorTelefono1 = new repsol.forms.controls.TextBoxColor();
            this.label22 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtVisitadorApellido2 = new repsol.forms.controls.TextBoxColor();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabLaboratorio.SuspendLayout();
            this.tpageLaboratorio.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpageVisitador.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(309, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(389, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 439);
            this.panFooter.Size = new System.Drawing.Size(476, 43);
            // 
            // tabLaboratorio
            // 
            this.tabLaboratorio.Controls.Add(this.tpageLaboratorio);
            this.tabLaboratorio.Controls.Add(this.tpageVisitador);
            this.tabLaboratorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLaboratorio.Location = new System.Drawing.Point(0, 0);
            this.tabLaboratorio.Name = "tabLaboratorio";
            this.tabLaboratorio.SelectedIndex = 0;
            this.tabLaboratorio.Size = new System.Drawing.Size(476, 439);
            this.tabLaboratorio.TabIndex = 0;
            // 
            // tpageLaboratorio
            // 
            this.tpageLaboratorio.Controls.Add(this.groupBox3);
            this.tpageLaboratorio.Controls.Add(this.groupBox1);
            this.tpageLaboratorio.Location = new System.Drawing.Point(4, 23);
            this.tpageLaboratorio.Name = "tpageLaboratorio";
            this.tpageLaboratorio.Padding = new System.Windows.Forms.Padding(3);
            this.tpageLaboratorio.Size = new System.Drawing.Size(468, 412);
            this.tpageLaboratorio.TabIndex = 0;
            this.tpageLaboratorio.Text = "Laboratorio";
            this.tpageLaboratorio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 158);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Location = new System.Drawing.Point(3, 18);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(456, 137);
            this.txtObservaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWeb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefono3);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefono2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.txtTelefono1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCP);
            this.groupBox1.Controls.Add(this.txtProvincia);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laboratorio";
            // 
            // txtWeb
            // 
            this.txtWeb.ActivateStyle = true;
            this.txtWeb.BackColor = System.Drawing.Color.White;
            this.txtWeb.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtWeb.ColorLeave = System.Drawing.Color.White;
            this.txtWeb.Location = new System.Drawing.Point(111, 217);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(324, 22);
            this.txtWeb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 37;
            this.label4.Text = "Web";
            // 
            // txtMail
            // 
            this.txtMail.ActivateStyle = true;
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMail.ColorLeave = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(111, 189);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(324, 22);
            this.txtMail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Correo Elect.";
            // 
            // txtFax
            // 
            this.txtFax.ActivateStyle = true;
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFax.ColorLeave = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(331, 161);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(104, 22);
            this.txtFax.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fáx";
            // 
            // txtNombre
            // 
            this.txtNombre.ActivateStyle = true;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNombre.ColorLeave = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(111, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // txtTelefono3
            // 
            this.txtTelefono3.ActivateStyle = true;
            this.txtTelefono3.BackColor = System.Drawing.Color.White;
            this.txtTelefono3.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono3.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono3.Location = new System.Drawing.Point(111, 161);
            this.txtTelefono3.Name = "txtTelefono3";
            this.txtTelefono3.Size = new System.Drawing.Size(104, 22);
            this.txtTelefono3.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.ActivateStyle = true;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDireccion.ColorLeave = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(111, 49);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(324, 22);
            this.txtDireccion.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 31;
            this.label16.Text = "Teléfono 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dirección";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.ActivateStyle = true;
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono2.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono2.Location = new System.Drawing.Point(331, 133);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(104, 22);
            this.txtTelefono2.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Localidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(258, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 29;
            this.label15.Text = "Teléfono 2";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.ActivateStyle = true;
            this.txtLocalidad.BackColor = System.Drawing.Color.White;
            this.txtLocalidad.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtLocalidad.ColorLeave = System.Drawing.Color.White;
            this.txtLocalidad.Location = new System.Drawing.Point(111, 77);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(187, 22);
            this.txtLocalidad.TabIndex = 2;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.ActivateStyle = true;
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono1.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono1.Location = new System.Drawing.Point(111, 133);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(104, 22);
            this.txtTelefono1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "CP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 14);
            this.label14.TabIndex = 27;
            this.label14.Text = "Teléfono 1";
            // 
            // txtCP
            // 
            this.txtCP.ActivateStyle = true;
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCP.ColorLeave = System.Drawing.Color.White;
            this.txtCP.Location = new System.Drawing.Point(331, 77);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(104, 22);
            this.txtCP.TabIndex = 3;
            // 
            // txtProvincia
            // 
            this.txtProvincia.ActivateStyle = true;
            this.txtProvincia.BackColor = System.Drawing.Color.White;
            this.txtProvincia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProvincia.ColorLeave = System.Drawing.Color.White;
            this.txtProvincia.Location = new System.Drawing.Point(111, 105);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(324, 22);
            this.txtProvincia.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Provincia";
            // 
            // tpageVisitador
            // 
            this.tpageVisitador.Controls.Add(this.groupBox4);
            this.tpageVisitador.Controls.Add(this.groupBox5);
            this.tpageVisitador.Location = new System.Drawing.Point(4, 23);
            this.tpageVisitador.Name = "tpageVisitador";
            this.tpageVisitador.Padding = new System.Windows.Forms.Padding(3);
            this.tpageVisitador.Size = new System.Drawing.Size(468, 412);
            this.tpageVisitador.TabIndex = 1;
            this.tpageVisitador.Text = "Visitador Médico";
            this.tpageVisitador.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtVisitadorObservaciones);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 211);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observaciones";
            // 
            // txtVisitadorObservaciones
            // 
            this.txtVisitadorObservaciones.ActivateStyle = true;
            this.txtVisitadorObservaciones.BackColor = System.Drawing.Color.White;
            this.txtVisitadorObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVisitadorObservaciones.Location = new System.Drawing.Point(3, 18);
            this.txtVisitadorObservaciones.Multiline = true;
            this.txtVisitadorObservaciones.Name = "txtVisitadorObservaciones";
            this.txtVisitadorObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVisitadorObservaciones.Size = new System.Drawing.Size(456, 190);
            this.txtVisitadorObservaciones.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtVisitadorFax);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtVisitadorMail);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtVisitadorTelefono3);
            this.groupBox5.Controls.Add(this.txtVisitadorNombre);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.txtVisitadorTelefono2);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtVisitadorApellido1);
            this.groupBox5.Controls.Add(this.txtVisitadorTelefono1);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.txtVisitadorApellido2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 195);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Visitador Médico";
            // 
            // txtVisitadorFax
            // 
            this.txtVisitadorFax.ActivateStyle = true;
            this.txtVisitadorFax.BackColor = System.Drawing.Color.White;
            this.txtVisitadorFax.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorFax.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorFax.Location = new System.Drawing.Point(331, 133);
            this.txtVisitadorFax.Name = "txtVisitadorFax";
            this.txtVisitadorFax.Size = new System.Drawing.Size(104, 22);
            this.txtVisitadorFax.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(258, 136);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 14);
            this.label28.TabIndex = 35;
            this.label28.Text = "Fáx";
            // 
            // txtVisitadorMail
            // 
            this.txtVisitadorMail.ActivateStyle = true;
            this.txtVisitadorMail.BackColor = System.Drawing.Color.White;
            this.txtVisitadorMail.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorMail.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorMail.Location = new System.Drawing.Point(111, 161);
            this.txtVisitadorMail.Name = "txtVisitadorMail";
            this.txtVisitadorMail.Size = new System.Drawing.Size(324, 22);
            this.txtVisitadorMail.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 164);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 14);
            this.label27.TabIndex = 33;
            this.label27.Text = "Correo Elect.";
            // 
            // txtVisitadorTelefono3
            // 
            this.txtVisitadorTelefono3.ActivateStyle = true;
            this.txtVisitadorTelefono3.BackColor = System.Drawing.Color.White;
            this.txtVisitadorTelefono3.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorTelefono3.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorTelefono3.Location = new System.Drawing.Point(111, 133);
            this.txtVisitadorTelefono3.Name = "txtVisitadorTelefono3";
            this.txtVisitadorTelefono3.Size = new System.Drawing.Size(104, 22);
            this.txtVisitadorTelefono3.TabIndex = 5;
            // 
            // txtVisitadorNombre
            // 
            this.txtVisitadorNombre.ActivateStyle = true;
            this.txtVisitadorNombre.BackColor = System.Drawing.Color.White;
            this.txtVisitadorNombre.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorNombre.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorNombre.Location = new System.Drawing.Point(111, 21);
            this.txtVisitadorNombre.Name = "txtVisitadorNombre";
            this.txtVisitadorNombre.Size = new System.Drawing.Size(324, 22);
            this.txtVisitadorNombre.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 14);
            this.label20.TabIndex = 31;
            this.label20.Text = "Teléfono 3";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 24);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 14);
            this.label34.TabIndex = 17;
            this.label34.Text = "Nombre";
            // 
            // txtVisitadorTelefono2
            // 
            this.txtVisitadorTelefono2.ActivateStyle = true;
            this.txtVisitadorTelefono2.BackColor = System.Drawing.Color.White;
            this.txtVisitadorTelefono2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorTelefono2.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorTelefono2.Location = new System.Drawing.Point(331, 105);
            this.txtVisitadorTelefono2.Name = "txtVisitadorTelefono2";
            this.txtVisitadorTelefono2.Size = new System.Drawing.Size(104, 22);
            this.txtVisitadorTelefono2.TabIndex = 4;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 14);
            this.label35.TabIndex = 19;
            this.label35.Text = "1er Apellido";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(258, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 14);
            this.label21.TabIndex = 29;
            this.label21.Text = "Teléfono 2";
            // 
            // txtVisitadorApellido1
            // 
            this.txtVisitadorApellido1.ActivateStyle = true;
            this.txtVisitadorApellido1.BackColor = System.Drawing.Color.White;
            this.txtVisitadorApellido1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorApellido1.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorApellido1.Location = new System.Drawing.Point(111, 49);
            this.txtVisitadorApellido1.Name = "txtVisitadorApellido1";
            this.txtVisitadorApellido1.Size = new System.Drawing.Size(324, 22);
            this.txtVisitadorApellido1.TabIndex = 1;
            // 
            // txtVisitadorTelefono1
            // 
            this.txtVisitadorTelefono1.ActivateStyle = true;
            this.txtVisitadorTelefono1.BackColor = System.Drawing.Color.White;
            this.txtVisitadorTelefono1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorTelefono1.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorTelefono1.Location = new System.Drawing.Point(111, 105);
            this.txtVisitadorTelefono1.Name = "txtVisitadorTelefono1";
            this.txtVisitadorTelefono1.Size = new System.Drawing.Size(104, 22);
            this.txtVisitadorTelefono1.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 14);
            this.label22.TabIndex = 27;
            this.label22.Text = "Teléfono 1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 80);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(74, 14);
            this.label36.TabIndex = 21;
            this.label36.Text = "2do Apellido";
            // 
            // txtVisitadorApellido2
            // 
            this.txtVisitadorApellido2.ActivateStyle = true;
            this.txtVisitadorApellido2.BackColor = System.Drawing.Color.White;
            this.txtVisitadorApellido2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVisitadorApellido2.ColorLeave = System.Drawing.Color.White;
            this.txtVisitadorApellido2.Location = new System.Drawing.Point(111, 77);
            this.txtVisitadorApellido2.Name = "txtVisitadorApellido2";
            this.txtVisitadorApellido2.Size = new System.Drawing.Size(324, 22);
            this.txtVisitadorApellido2.TabIndex = 2;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(476, 482);
            this.Controls.Add(this.tabLaboratorio);
            this.Name = "frmEdit";
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.frmlaboratorioEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabLaboratorio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabLaboratorio.ResumeLayout(false);
            this.tpageLaboratorio.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpageVisitador.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmlaboratorioEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
