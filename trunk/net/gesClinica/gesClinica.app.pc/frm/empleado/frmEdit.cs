using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.empleado
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtNombre;
        internal repsol.forms.controls.TextBoxColor txtApellido1;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtApellido2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.CheckBox chkAdministrativo;
        internal System.Windows.Forms.CheckBox chkTerapeuta;
        internal repsol.forms.controls.TextBoxColor txtComision;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpageEmpleado;
        private System.Windows.Forms.TabPage tpageActividades;
        internal System.Windows.Forms.ListBox lboxTarget;
        internal System.Windows.Forms.ListBox lboxSource;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btQuitar;
        internal System.Windows.Forms.CheckBox chkGerente;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cmbRazonSocial;
        internal repsol.forms.controls.TextBoxColor txtFirma;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.CheckBox chkVerSoloLoMio;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.PictureBox picColorSample2;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cmbColor2;
        internal System.Windows.Forms.PictureBox picColorSample1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cmbColor1;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empleado.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Empleado());
        }
        public frmEdit(Empleado objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empleado.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Empleado objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btAñadir.Enabled = !this.OnlyView;
            this.btQuitar.Enabled = !this.OnlyView;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empleado.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empleado.ctrl.ctrlEdit();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.txtNombre = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido2 = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAdministrativo = new System.Windows.Forms.CheckBox();
            this.chkTerapeuta = new System.Windows.Forms.CheckBox();
            this.txtComision = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageEmpleado = new System.Windows.Forms.TabPage();
            this.chkVerSoloLoMio = new System.Windows.Forms.CheckBox();
            this.txtFirma = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
            this.chkGerente = new System.Windows.Forms.CheckBox();
            this.tpageActividades = new System.Windows.Forms.TabPage();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btAñadir = new System.Windows.Forms.Button();
            this.lboxTarget = new System.Windows.Forms.ListBox();
            this.lboxSource = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picColorSample2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbColor2 = new System.Windows.Forms.ComboBox();
            this.picColorSample1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbColor1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpageEmpleado.SuspendLayout();
            this.tpageActividades.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(395, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(475, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 296);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtNombre
            // 
            this.txtNombre.ActivateStyle = true;
            this.txtNombre.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombre.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNombre.ColorLeave = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(124, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(348, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // txtApellido1
            // 
            this.txtApellido1.ActivateStyle = true;
            this.txtApellido1.BackColor = System.Drawing.Color.White;
            this.txtApellido1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtApellido1.ColorLeave = System.Drawing.Color.White;
            this.txtApellido1.Location = new System.Drawing.Point(124, 75);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(348, 22);
            this.txtApellido1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "1er Apellido";
            // 
            // txtApellido2
            // 
            this.txtApellido2.ActivateStyle = true;
            this.txtApellido2.BackColor = System.Drawing.Color.White;
            this.txtApellido2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtApellido2.ColorLeave = System.Drawing.Color.White;
            this.txtApellido2.Location = new System.Drawing.Point(124, 103);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(348, 22);
            this.txtApellido2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "2do Apellido";
            // 
            // chkAdministrativo
            // 
            this.chkAdministrativo.AutoSize = true;
            this.chkAdministrativo.Location = new System.Drawing.Point(124, 159);
            this.chkAdministrativo.Name = "chkAdministrativo";
            this.chkAdministrativo.Size = new System.Drawing.Size(102, 18);
            this.chkAdministrativo.TabIndex = 5;
            this.chkAdministrativo.Text = "Administrativo";
            this.chkAdministrativo.UseVisualStyleBackColor = true;
            // 
            // chkTerapeuta
            // 
            this.chkTerapeuta.AutoSize = true;
            this.chkTerapeuta.Location = new System.Drawing.Point(265, 159);
            this.chkTerapeuta.Name = "chkTerapeuta";
            this.chkTerapeuta.Size = new System.Drawing.Size(83, 18);
            this.chkTerapeuta.TabIndex = 6;
            this.chkTerapeuta.Text = "Terapeuta";
            this.chkTerapeuta.UseVisualStyleBackColor = true;
            // 
            // txtComision
            // 
            this.txtComision.ActivateStyle = true;
            this.txtComision.BackColor = System.Drawing.Color.White;
            this.txtComision.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtComision.ColorLeave = System.Drawing.Color.White;
            this.txtComision.Location = new System.Drawing.Point(124, 131);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(146, 22);
            this.txtComision.TabIndex = 4;
            this.txtComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComision.Validated += new System.EventHandler(this.txtComision_Validated);
            this.txtComision.Validating += new System.ComponentModel.CancelEventHandler(this.txtComision_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Comisión (%)";
            // 
            // txtLogin
            // 
            this.txtLogin.ActivateStyle = true;
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtLogin.ColorLeave = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(124, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(146, 22);
            this.txtLogin.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Codigo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageEmpleado);
            this.tabControl1.Controls.Add(this.tpageActividades);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tpageEmpleado
            // 
            this.tpageEmpleado.Controls.Add(this.chkVerSoloLoMio);
            this.tpageEmpleado.Controls.Add(this.txtFirma);
            this.tpageEmpleado.Controls.Add(this.label6);
            this.tpageEmpleado.Controls.Add(this.label10);
            this.tpageEmpleado.Controls.Add(this.cmbRazonSocial);
            this.tpageEmpleado.Controls.Add(this.chkGerente);
            this.tpageEmpleado.Controls.Add(this.txtNombre);
            this.tpageEmpleado.Controls.Add(this.txtLogin);
            this.tpageEmpleado.Controls.Add(this.label2);
            this.tpageEmpleado.Controls.Add(this.label5);
            this.tpageEmpleado.Controls.Add(this.label1);
            this.tpageEmpleado.Controls.Add(this.txtComision);
            this.tpageEmpleado.Controls.Add(this.txtApellido1);
            this.tpageEmpleado.Controls.Add(this.label4);
            this.tpageEmpleado.Controls.Add(this.label3);
            this.tpageEmpleado.Controls.Add(this.chkTerapeuta);
            this.tpageEmpleado.Controls.Add(this.txtApellido2);
            this.tpageEmpleado.Controls.Add(this.chkAdministrativo);
            this.tpageEmpleado.Location = new System.Drawing.Point(4, 23);
            this.tpageEmpleado.Name = "tpageEmpleado";
            this.tpageEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tpageEmpleado.Size = new System.Drawing.Size(508, 269);
            this.tpageEmpleado.TabIndex = 0;
            this.tpageEmpleado.Text = "Datos Terapeuta";
            this.tpageEmpleado.UseVisualStyleBackColor = true;
            // 
            // chkVerSoloLoMio
            // 
            this.chkVerSoloLoMio.AutoSize = true;
            this.chkVerSoloLoMio.Location = new System.Drawing.Point(124, 239);
            this.chkVerSoloLoMio.Name = "chkVerSoloLoMio";
            this.chkVerSoloLoMio.Size = new System.Drawing.Size(190, 18);
            this.chkVerSoloLoMio.TabIndex = 49;
            this.chkVerSoloLoMio.Text = "Por defecto, ver solo mis citas";
            this.chkVerSoloLoMio.UseVisualStyleBackColor = true;
            // 
            // txtFirma
            // 
            this.txtFirma.ActivateStyle = true;
            this.txtFirma.BackColor = System.Drawing.Color.White;
            this.txtFirma.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtFirma.ColorLeave = System.Drawing.Color.White;
            this.txtFirma.Location = new System.Drawing.Point(124, 211);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(348, 22);
            this.txtFirma.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 48;
            this.label6.Text = "Firma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 14);
            this.label10.TabIndex = 46;
            this.label10.Text = "Razon Social";
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(124, 183);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(348, 22);
            this.cmbRazonSocial.TabIndex = 8;
            // 
            // chkGerente
            // 
            this.chkGerente.AutoSize = true;
            this.chkGerente.Location = new System.Drawing.Point(401, 159);
            this.chkGerente.Name = "chkGerente";
            this.chkGerente.Size = new System.Drawing.Size(71, 18);
            this.chkGerente.TabIndex = 7;
            this.chkGerente.Text = "Gerente";
            this.chkGerente.UseVisualStyleBackColor = true;
            // 
            // tpageActividades
            // 
            this.tpageActividades.Controls.Add(this.btQuitar);
            this.tpageActividades.Controls.Add(this.btAñadir);
            this.tpageActividades.Controls.Add(this.lboxTarget);
            this.tpageActividades.Controls.Add(this.lboxSource);
            this.tpageActividades.Location = new System.Drawing.Point(4, 23);
            this.tpageActividades.Name = "tpageActividades";
            this.tpageActividades.Padding = new System.Windows.Forms.Padding(3);
            this.tpageActividades.Size = new System.Drawing.Size(508, 269);
            this.tpageActividades.TabIndex = 1;
            this.tpageActividades.Text = "Actividades Asociadas";
            this.tpageActividades.UseVisualStyleBackColor = true;
            // 
            // btQuitar
            // 
            this.btQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btQuitar.Image")));
            this.btQuitar.Location = new System.Drawing.Point(232, 159);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(47, 21);
            this.btQuitar.TabIndex = 3;
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // btAñadir
            // 
            this.btAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btAñadir.Image")));
            this.btAñadir.Location = new System.Drawing.Point(232, 37);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(47, 21);
            this.btAñadir.TabIndex = 2;
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // lboxTarget
            // 
            this.lboxTarget.Dock = System.Windows.Forms.DockStyle.Right;
            this.lboxTarget.FormattingEnabled = true;
            this.lboxTarget.ItemHeight = 14;
            this.lboxTarget.Location = new System.Drawing.Point(285, 3);
            this.lboxTarget.Name = "lboxTarget";
            this.lboxTarget.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxTarget.Size = new System.Drawing.Size(220, 256);
            this.lboxTarget.TabIndex = 1;
            // 
            // lboxSource
            // 
            this.lboxSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.lboxSource.FormattingEnabled = true;
            this.lboxSource.ItemHeight = 14;
            this.lboxSource.Location = new System.Drawing.Point(3, 3);
            this.lboxSource.Name = "lboxSource";
            this.lboxSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxSource.Size = new System.Drawing.Size(223, 256);
            this.lboxSource.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picColorSample2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbColor2);
            this.tabPage1.Controls.Add(this.picColorSample1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbColor1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 269);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Otros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picColorSample2
            // 
            this.picColorSample2.Location = new System.Drawing.Point(426, 99);
            this.picColorSample2.Name = "picColorSample2";
            this.picColorSample2.Size = new System.Drawing.Size(51, 22);
            this.picColorSample2.TabIndex = 34;
            this.picColorSample2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 14);
            this.label8.TabIndex = 33;
            this.label8.Text = "Color Factura";
            // 
            // cmbColor2
            // 
            this.cmbColor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor2.FormattingEnabled = true;
            this.cmbColor2.Location = new System.Drawing.Point(138, 99);
            this.cmbColor2.Name = "cmbColor2";
            this.cmbColor2.Size = new System.Drawing.Size(282, 23);
            this.cmbColor2.TabIndex = 32;
            this.cmbColor2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbColor_DrawItem);
            this.cmbColor2.SelectedIndexChanged += new System.EventHandler(this.cmbColor2_SelectedIndexChanged);
            // 
            // picColorSample1
            // 
            this.picColorSample1.Location = new System.Drawing.Point(426, 70);
            this.picColorSample1.Name = "picColorSample1";
            this.picColorSample1.Size = new System.Drawing.Size(51, 22);
            this.picColorSample1.TabIndex = 31;
            this.picColorSample1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "Color Operación";
            // 
            // cmbColor1
            // 
            this.cmbColor1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor1.FormattingEnabled = true;
            this.cmbColor1.Location = new System.Drawing.Point(138, 70);
            this.cmbColor1.Name = "cmbColor1";
            this.cmbColor1.Size = new System.Drawing.Size(282, 23);
            this.cmbColor1.TabIndex = 29;
            this.cmbColor1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbColor_DrawItem);
            this.cmbColor1.SelectedIndexChanged += new System.EventHandler(this.cmbColor1_SelectedIndexChanged);
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 339);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdit";
            this.Text = "Terapeuta";
            this.Load += new System.EventHandler(this.frmempleadoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpageEmpleado.ResumeLayout(false);
            this.tpageEmpleado.PerformLayout();
            this.tpageActividades.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample1)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmempleadoEdit_Load(object sender, EventArgs e)
        {
        }

        private void txtComision_Validated(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtComision.Text))
                    this.txtComision.Text = "0";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtComision_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtComision.Text))
                {
                    byte valor;
                    if (!byte.TryParse(this.txtComision.Text, out valor))
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

        private void btAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empleado.ctrl.ctrlEdit();
                ctrl.moverActividades(ref lboxSource, ref lboxTarget);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.empleado.ctrl.ctrlEdit();
                ctrl.moverActividades(ref lboxTarget, ref lboxSource);
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

        private void cmbColor_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;

                e.Graphics.DrawImage(repsol.util.image.CreateImage(16, e.Bounds.Height - 2, System.Drawing.Color.FromName(cmb.Items[e.Index].ToString())), e.Bounds.Left, e.Bounds.Top + 1);

                bool estado =
                    (e.State == (System.Windows.Forms.DrawItemState.Selected | System.Windows.Forms.DrawItemState.Focus | System.Windows.Forms.DrawItemState.NoAccelerator | System.Windows.Forms.DrawItemState.NoFocusRect))
                    ||
                    (e.State == (System.Windows.Forms.DrawItemState.Selected | System.Windows.Forms.DrawItemState.Focus | System.Windows.Forms.DrawItemState.NoAccelerator | System.Windows.Forms.DrawItemState.NoFocusRect | System.Windows.Forms.DrawItemState.ComboBoxEdit));
                e.Graphics.DrawString(cmb.Items[e.Index].ToString(), cmb.Font, new System.Drawing.SolidBrush(estado ? cmb.BackColor : cmb.ForeColor), e.Bounds.Left + 16, e.Bounds.Top);
            }
        }

        private void cmbColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbColor1.SelectedItem != null)
                    this.picColorSample1.Image = repsol.util.image.CreateImage(this.picColorSample1.Width, this.picColorSample1.Height, System.Drawing.Color.FromName(this.cmbColor1.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        private void cmbColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbColor2.SelectedItem != null)
                    this.picColorSample2.Image = repsol.util.image.CreateImage(this.picColorSample2.Width, this.picColorSample2.Height, System.Drawing.Color.FromName(this.cmbColor2.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
