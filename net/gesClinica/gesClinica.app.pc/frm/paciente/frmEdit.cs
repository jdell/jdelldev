using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.paciente
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtNombre;
        internal repsol.forms.controls.TextBoxColor txtApellido1;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtApellido2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbTarifa;
        internal System.Windows.Forms.RadioButton rbHombre;
        internal System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.GroupBox groupBox1;
        internal gesClinica.app.pc.template.controls.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        internal repsol.forms.controls.TextBoxColor txtNIF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.NumericUpDown txtHijos;
        internal System.Windows.Forms.DateTimePicker dateFechaNacimiento;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtProfesion;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TabControl tabPaciente;
        private System.Windows.Forms.TabPage tpageDatosPersonales;
        internal System.Windows.Forms.TabPage tpageDatosAdministrativos;
        internal System.Windows.Forms.TabPage tpageDatosClinicos;
        private System.Windows.Forms.GroupBox groupBox3;
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        private System.Windows.Forms.Label label17;
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
        internal repsol.forms.controls.TextBoxColor txtRecomendadoPor;
        private System.Windows.Forms.Label label18;
        internal System.Windows.Forms.DataGridView dgCitas;
        internal System.Windows.Forms.DataGridView dgSaldos;
        internal System.Windows.Forms.TabPage tpageDescuentos;
        internal System.Windows.Forms.DataGridView dgDescuentos;
        private System.Windows.Forms.GroupBox groupBox4;
        internal repsol.forms.controls.TextBoxColor txtMuyImportante;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem hisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaSegundaHojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaAurículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaQuiromasajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaSegundaHojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quiromasajesCuerpoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        internal repsol.forms.controls.TextBoxColor txtSubCuenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripMenuItem quiromasajeHojaBlancoToolStripMenuItem;
        internal repsol.forms.controls.TextBoxColor txtAviones;
        private System.Windows.Forms.Label label20;
        internal repsol.forms.controls.TextBoxColor txtNotasDeAgenda;
        private System.Windows.Forms.Label label21;
        internal repsol.forms.controls.TextBoxColor txtSaldo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Paciente());
        }
        public frmEdit(Paciente objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Paciente objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.picFoto.Enabled = !this.OnlyView;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlEdit();
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido2 = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecomendadoPor = new repsol.forms.controls.TextBoxColor();
            this.label18 = new System.Windows.Forms.Label();
            this.txtProfesion = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHijos = new System.Windows.Forms.NumericUpDown();
            this.txtNIF = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picFoto = new gesClinica.app.pc.template.controls.PictureBox();
            this.tabPaciente = new System.Windows.Forms.TabControl();
            this.tpageDatosPersonales = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotasDeAgenda = new repsol.forms.controls.TextBoxColor();
            this.label21 = new System.Windows.Forms.Label();
            this.txtObservaciones = new repsol.forms.controls.TextBoxColor();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelefono3 = new repsol.forms.controls.TextBoxColor();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new repsol.forms.controls.TextBoxColor();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new repsol.forms.controls.TextBoxColor();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProvincia = new repsol.forms.controls.TextBoxColor();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCP = new repsol.forms.controls.TextBoxColor();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLocalidad = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDireccion = new repsol.forms.controls.TextBoxColor();
            this.label10 = new System.Windows.Forms.Label();
            this.tpageDatosAdministrativos = new System.Windows.Forms.TabPage();
            this.dgSaldos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSaldo = new repsol.forms.controls.TextBoxColor();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAviones = new repsol.forms.controls.TextBoxColor();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSubCuenta = new repsol.forms.controls.TextBoxColor();
            this.label19 = new System.Windows.Forms.Label();
            this.tpageDatosClinicos = new System.Windows.Forms.TabPage();
            this.dgCitas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMuyImportante = new repsol.forms.controls.TextBoxColor();
            this.tpageDescuentos = new System.Windows.Forms.TabPage();
            this.dgDescuentos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.hisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClínicaSegundaHojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClínicaAurículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.historiaClínicaQuiromasajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClínicaSegundaHojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quiromasajesCuerpoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiromasajeHojaBlancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHijos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPaciente.SuspendLayout();
            this.tpageDatosPersonales.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpageDatosAdministrativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaldos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpageDatosClinicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tpageDescuentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDescuentos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(877, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(963, 11);
            // 
            // panFooter
            // 
            this.panFooter.Controls.Add(this.toolStrip1);
            this.panFooter.Location = new System.Drawing.Point(0, 540);
            this.panFooter.Size = new System.Drawing.Size(613, 43);
            this.panFooter.Controls.SetChildIndex(this.btCancelar, 0);
            this.panFooter.Controls.SetChildIndex(this.chkCerrar, 0);
            this.panFooter.Controls.SetChildIndex(this.btAceptar, 0);
            this.panFooter.Controls.SetChildIndex(this.toolStrip1, 0);
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
            // txtApellido1
            // 
            this.txtApellido1.ActivateStyle = true;
            this.txtApellido1.BackColor = System.Drawing.Color.White;
            this.txtApellido1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtApellido1.ColorLeave = System.Drawing.Color.White;
            this.txtApellido1.Location = new System.Drawing.Point(111, 49);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(324, 22);
            this.txtApellido1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
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
            this.txtApellido2.Location = new System.Drawing.Point(111, 77);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(324, 22);
            this.txtApellido2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "2do Apellido";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(111, 190);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(124, 22);
            this.cmbEstadoCivil.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tarifa";
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(111, 162);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(324, 22);
            this.cmbTarifa.TabIndex = 8;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(263, 136);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(68, 18);
            this.rbHombre.TabIndex = 6;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Checked = true;
            this.rbMujer.Location = new System.Drawing.Point(380, 136);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(55, 18);
            this.rbMujer.TabIndex = 7;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecomendadoPor);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtProfesion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateFechaNacimiento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEstadoCivil);
            this.groupBox1.Controls.Add(this.rbMujer);
            this.groupBox1.Controls.Add(this.cmbTarifa);
            this.groupBox1.Controls.Add(this.rbHombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHijos);
            this.groupBox1.Controls.Add(this.txtNIF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellido1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellido2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filiación del Paciente";
            // 
            // txtRecomendadoPor
            // 
            this.txtRecomendadoPor.ActivateStyle = true;
            this.txtRecomendadoPor.BackColor = System.Drawing.Color.White;
            this.txtRecomendadoPor.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtRecomendadoPor.ColorLeave = System.Drawing.Color.White;
            this.txtRecomendadoPor.Location = new System.Drawing.Point(111, 218);
            this.txtRecomendadoPor.Name = "txtRecomendadoPor";
            this.txtRecomendadoPor.Size = new System.Drawing.Size(482, 22);
            this.txtRecomendadoPor.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 14);
            this.label18.TabIndex = 33;
            this.label18.Text = "Recomendado";
            // 
            // txtProfesion
            // 
            this.txtProfesion.ActivateStyle = true;
            this.txtProfesion.BackColor = System.Drawing.Color.White;
            this.txtProfesion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProfesion.ColorLeave = System.Drawing.Color.White;
            this.txtProfesion.Location = new System.Drawing.Point(311, 190);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(282, 22);
            this.txtProfesion.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "Profesión";
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.Checked = false;
            this.dateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaNacimiento.Location = new System.Drawing.Point(111, 134);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.ShowCheckBox = true;
            this.dateFechaNacimiento.Size = new System.Drawing.Size(124, 22);
            this.dateFechaNacimiento.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hijos";
            // 
            // txtHijos
            // 
            this.txtHijos.Location = new System.Drawing.Point(311, 105);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(124, 22);
            this.txtHijos.TabIndex = 4;
            // 
            // txtNIF
            // 
            this.txtNIF.ActivateStyle = true;
            this.txtNIF.BackColor = System.Drawing.Color.White;
            this.txtNIF.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNIF.ColorLeave = System.Drawing.Color.White;
            this.txtNIF.Location = new System.Drawing.Point(111, 105);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(124, 22);
            this.txtNIF.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "NIF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picFoto);
            this.groupBox2.Location = new System.Drawing.Point(441, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 170);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Filter = " Fotos (JPG, JPEG, GIF, BMP, TIFF,PNG) |*.jpg;*.jpeg;*.bmp;*.gif;*.tiff;*.png";
            this.picFoto.Image = null;
            this.picFoto.Location = new System.Drawing.Point(3, 18);
            this.picFoto.MaxHeight = 25;
            this.picFoto.MinHeight = 5;
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(146, 149);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 22;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Controls.Add(this.tpageDatosPersonales);
            this.tabPaciente.Controls.Add(this.tpageDatosAdministrativos);
            this.tabPaciente.Controls.Add(this.tpageDatosClinicos);
            this.tabPaciente.Controls.Add(this.tpageDescuentos);
            this.tabPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaciente.Location = new System.Drawing.Point(0, 0);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.SelectedIndex = 0;
            this.tabPaciente.Size = new System.Drawing.Size(613, 540);
            this.tabPaciente.TabIndex = 0;
            // 
            // tpageDatosPersonales
            // 
            this.tpageDatosPersonales.Controls.Add(this.groupBox3);
            this.tpageDatosPersonales.Controls.Add(this.groupBox1);
            this.tpageDatosPersonales.Location = new System.Drawing.Point(4, 23);
            this.tpageDatosPersonales.Name = "tpageDatosPersonales";
            this.tpageDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tpageDatosPersonales.Size = new System.Drawing.Size(605, 513);
            this.tpageDatosPersonales.TabIndex = 0;
            this.tpageDatosPersonales.Text = "Datos Personales";
            this.tpageDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNotasDeAgenda);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtTelefono3);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtTelefono2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtTelefono1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtProvincia);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtCP);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtLocalidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dirección";
            // 
            // txtNotasDeAgenda
            // 
            this.txtNotasDeAgenda.ActivateStyle = true;
            this.txtNotasDeAgenda.BackColor = System.Drawing.Color.White;
            this.txtNotasDeAgenda.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNotasDeAgenda.ColorLeave = System.Drawing.Color.White;
            this.txtNotasDeAgenda.Location = new System.Drawing.Point(9, 211);
            this.txtNotasDeAgenda.Multiline = true;
            this.txtNotasDeAgenda.Name = "txtNotasDeAgenda";
            this.txtNotasDeAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotasDeAgenda.Size = new System.Drawing.Size(581, 45);
            this.txtNotasDeAgenda.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 14);
            this.label21.TabIndex = 35;
            this.label21.Text = "Notas de Agenda";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(9, 148);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(581, 45);
            this.txtObservaciones.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 14);
            this.label17.TabIndex = 33;
            this.label17.Text = "Notas Breves";
            // 
            // txtTelefono3
            // 
            this.txtTelefono3.ActivateStyle = true;
            this.txtTelefono3.BackColor = System.Drawing.Color.White;
            this.txtTelefono3.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono3.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono3.Location = new System.Drawing.Point(489, 105);
            this.txtTelefono3.Name = "txtTelefono3";
            this.txtTelefono3.Size = new System.Drawing.Size(104, 22);
            this.txtTelefono3.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(416, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 31;
            this.label16.Text = "Teléfono 3";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.ActivateStyle = true;
            this.txtTelefono2.BackColor = System.Drawing.Color.White;
            this.txtTelefono2.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono2.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono2.Location = new System.Drawing.Point(298, 105);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(104, 22);
            this.txtTelefono2.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 29;
            this.label15.Text = "Teléfono 2";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.ActivateStyle = true;
            this.txtTelefono1.BackColor = System.Drawing.Color.White;
            this.txtTelefono1.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefono1.ColorLeave = System.Drawing.Color.White;
            this.txtTelefono1.Location = new System.Drawing.Point(111, 105);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(104, 22);
            this.txtTelefono1.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 14);
            this.label14.TabIndex = 27;
            this.label14.Text = "Teléfono 1";
            // 
            // txtProvincia
            // 
            this.txtProvincia.ActivateStyle = true;
            this.txtProvincia.BackColor = System.Drawing.Color.White;
            this.txtProvincia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProvincia.ColorLeave = System.Drawing.Color.White;
            this.txtProvincia.Location = new System.Drawing.Point(111, 77);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(482, 22);
            this.txtProvincia.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Provincia";
            // 
            // txtCP
            // 
            this.txtCP.ActivateStyle = true;
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCP.ColorLeave = System.Drawing.Color.White;
            this.txtCP.Location = new System.Drawing.Point(444, 49);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(149, 22);
            this.txtCP.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(416, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "CP";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.ActivateStyle = true;
            this.txtLocalidad.BackColor = System.Drawing.Color.White;
            this.txtLocalidad.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtLocalidad.ColorLeave = System.Drawing.Color.White;
            this.txtLocalidad.Location = new System.Drawing.Point(111, 49);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(291, 22);
            this.txtLocalidad.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Localidad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.ActivateStyle = true;
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDireccion.ColorLeave = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(111, 21);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(482, 22);
            this.txtDireccion.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dirección";
            // 
            // tpageDatosAdministrativos
            // 
            this.tpageDatosAdministrativos.Controls.Add(this.dgSaldos);
            this.tpageDatosAdministrativos.Controls.Add(this.panel1);
            this.tpageDatosAdministrativos.Location = new System.Drawing.Point(4, 23);
            this.tpageDatosAdministrativos.Name = "tpageDatosAdministrativos";
            this.tpageDatosAdministrativos.Padding = new System.Windows.Forms.Padding(3);
            this.tpageDatosAdministrativos.Size = new System.Drawing.Size(605, 513);
            this.tpageDatosAdministrativos.TabIndex = 1;
            this.tpageDatosAdministrativos.Text = "Datos Administrativos";
            this.tpageDatosAdministrativos.UseVisualStyleBackColor = true;
            // 
            // dgSaldos
            // 
            this.dgSaldos.AllowUserToAddRows = false;
            this.dgSaldos.AllowUserToDeleteRows = false;
            this.dgSaldos.AllowUserToResizeColumns = false;
            this.dgSaldos.AllowUserToResizeRows = false;
            this.dgSaldos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSaldos.Location = new System.Drawing.Point(3, 41);
            this.dgSaldos.Name = "dgSaldos";
            this.dgSaldos.RowHeadersVisible = false;
            this.dgSaldos.Size = new System.Drawing.Size(599, 469);
            this.dgSaldos.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtAviones);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtSubCuenta);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 38);
            this.panel1.TabIndex = 3;
            // 
            // txtSaldo
            // 
            this.txtSaldo.ActivateStyle = true;
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSaldo.ColorLeave = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(310, 10);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(103, 22);
            this.txtSaldo.TabIndex = 33;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(268, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 14);
            this.label22.TabIndex = 32;
            this.label22.Text = "Saldo";
            // 
            // txtAviones
            // 
            this.txtAviones.ActivateStyle = true;
            this.txtAviones.BackColor = System.Drawing.Color.White;
            this.txtAviones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAviones.ColorLeave = System.Drawing.Color.White;
            this.txtAviones.Location = new System.Drawing.Point(493, 10);
            this.txtAviones.Name = "txtAviones";
            this.txtAviones.ReadOnly = true;
            this.txtAviones.Size = new System.Drawing.Size(103, 22);
            this.txtAviones.TabIndex = 29;
            this.toolTip1.SetToolTip(this.txtAviones, "Numero de aviones en los ultimos 6 meses");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(438, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 14);
            this.label20.TabIndex = 30;
            this.label20.Text = "Aviones";
            // 
            // txtSubCuenta
            // 
            this.txtSubCuenta.ActivateStyle = true;
            this.txtSubCuenta.BackColor = System.Drawing.Color.White;
            this.txtSubCuenta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSubCuenta.ColorLeave = System.Drawing.Color.White;
            this.txtSubCuenta.Location = new System.Drawing.Point(97, 10);
            this.txtSubCuenta.Name = "txtSubCuenta";
            this.txtSubCuenta.Size = new System.Drawing.Size(103, 22);
            this.txtSubCuenta.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 14);
            this.label19.TabIndex = 28;
            this.label19.Text = "SubCuenta";
            // 
            // tpageDatosClinicos
            // 
            this.tpageDatosClinicos.Controls.Add(this.dgCitas);
            this.tpageDatosClinicos.Controls.Add(this.groupBox4);
            this.tpageDatosClinicos.Location = new System.Drawing.Point(4, 23);
            this.tpageDatosClinicos.Name = "tpageDatosClinicos";
            this.tpageDatosClinicos.Size = new System.Drawing.Size(605, 513);
            this.tpageDatosClinicos.TabIndex = 2;
            this.tpageDatosClinicos.Text = "Datos Clínicos";
            this.tpageDatosClinicos.UseVisualStyleBackColor = true;
            // 
            // dgCitas
            // 
            this.dgCitas.AllowUserToAddRows = false;
            this.dgCitas.AllowUserToDeleteRows = false;
            this.dgCitas.AllowUserToResizeColumns = false;
            this.dgCitas.AllowUserToResizeRows = false;
            this.dgCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCitas.Location = new System.Drawing.Point(0, 0);
            this.dgCitas.Name = "dgCitas";
            this.dgCitas.RowHeadersVisible = false;
            this.dgCitas.Size = new System.Drawing.Size(605, 388);
            this.dgCitas.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMuyImportante);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 125);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Muy Importante";
            // 
            // txtMuyImportante
            // 
            this.txtMuyImportante.ActivateStyle = true;
            this.txtMuyImportante.BackColor = System.Drawing.Color.White;
            this.txtMuyImportante.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMuyImportante.ColorLeave = System.Drawing.Color.White;
            this.txtMuyImportante.Location = new System.Drawing.Point(8, 21);
            this.txtMuyImportante.Multiline = true;
            this.txtMuyImportante.Name = "txtMuyImportante";
            this.txtMuyImportante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMuyImportante.Size = new System.Drawing.Size(589, 95);
            this.txtMuyImportante.TabIndex = 7;
            // 
            // tpageDescuentos
            // 
            this.tpageDescuentos.Controls.Add(this.dgDescuentos);
            this.tpageDescuentos.Location = new System.Drawing.Point(4, 23);
            this.tpageDescuentos.Name = "tpageDescuentos";
            this.tpageDescuentos.Padding = new System.Windows.Forms.Padding(3);
            this.tpageDescuentos.Size = new System.Drawing.Size(605, 513);
            this.tpageDescuentos.TabIndex = 3;
            this.tpageDescuentos.Text = "Descuentos por terapeuta";
            this.tpageDescuentos.UseVisualStyleBackColor = true;
            // 
            // dgDescuentos
            // 
            this.dgDescuentos.AllowUserToAddRows = false;
            this.dgDescuentos.AllowUserToDeleteRows = false;
            this.dgDescuentos.AllowUserToResizeColumns = false;
            this.dgDescuentos.AllowUserToResizeRows = false;
            this.dgDescuentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDescuentos.Location = new System.Drawing.Point(3, 3);
            this.dgDescuentos.Name = "dgDescuentos";
            this.dgDescuentos.RowHeadersVisible = false;
            this.dgDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgDescuentos.Size = new System.Drawing.Size(599, 507);
            this.dgDescuentos.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(12, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(68, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hisToolStripMenuItem,
            this.historiaClínicaSegundaHojaToolStripMenuItem,
            this.historiaClínicaAurículoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.historiaClínicaQuiromasajesToolStripMenuItem,
            this.historiaClínicaSegundaHojaToolStripMenuItem1,
            this.quiromasajesCuerpoToolStripMenuItem,
            this.quiromasajeHojaBlancoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::gesClinica.app.pc.Properties.Resources.PrintHS;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(74, 22);
            this.toolStripDropDownButton1.Text = "Imprimir";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // hisToolStripMenuItem
            // 
            this.hisToolStripMenuItem.Name = "hisToolStripMenuItem";
            this.hisToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.hisToolStripMenuItem.Text = "Historia Clínica General";
            this.hisToolStripMenuItem.Visible = false;
            this.hisToolStripMenuItem.Click += new System.EventHandler(this.hisToolStripMenuItem_Click);
            // 
            // historiaClínicaSegundaHojaToolStripMenuItem
            // 
            this.historiaClínicaSegundaHojaToolStripMenuItem.Enabled = false;
            this.historiaClínicaSegundaHojaToolStripMenuItem.Name = "historiaClínicaSegundaHojaToolStripMenuItem";
            this.historiaClínicaSegundaHojaToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.historiaClínicaSegundaHojaToolStripMenuItem.Text = "Historia Clínica Segunda Hoja";
            this.historiaClínicaSegundaHojaToolStripMenuItem.Visible = false;
            // 
            // historiaClínicaAurículoToolStripMenuItem
            // 
            this.historiaClínicaAurículoToolStripMenuItem.Enabled = false;
            this.historiaClínicaAurículoToolStripMenuItem.Name = "historiaClínicaAurículoToolStripMenuItem";
            this.historiaClínicaAurículoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.historiaClínicaAurículoToolStripMenuItem.Text = "Historia Clínica Aurículo";
            this.historiaClínicaAurículoToolStripMenuItem.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // historiaClínicaQuiromasajesToolStripMenuItem
            // 
            this.historiaClínicaQuiromasajesToolStripMenuItem.Name = "historiaClínicaQuiromasajesToolStripMenuItem";
            this.historiaClínicaQuiromasajesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.historiaClínicaQuiromasajesToolStripMenuItem.Text = "Historia Clínica Quiromasajes";
            this.historiaClínicaQuiromasajesToolStripMenuItem.Click += new System.EventHandler(this.historiaClínicaQuiromasajesToolStripMenuItem_Click);
            // 
            // historiaClínicaSegundaHojaToolStripMenuItem1
            // 
            this.historiaClínicaSegundaHojaToolStripMenuItem1.Name = "historiaClínicaSegundaHojaToolStripMenuItem1";
            this.historiaClínicaSegundaHojaToolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.historiaClínicaSegundaHojaToolStripMenuItem1.Text = "Quiromasajes Segunda Hoja";
            this.historiaClínicaSegundaHojaToolStripMenuItem1.Click += new System.EventHandler(this.historiaClínicaSegundaHojaToolStripMenuItem1_Click);
            // 
            // quiromasajesCuerpoToolStripMenuItem
            // 
            this.quiromasajesCuerpoToolStripMenuItem.Name = "quiromasajesCuerpoToolStripMenuItem";
            this.quiromasajesCuerpoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.quiromasajesCuerpoToolStripMenuItem.Text = "Quiromasajes Cuerpo";
            this.quiromasajesCuerpoToolStripMenuItem.Click += new System.EventHandler(this.quiromasajesCuerpoToolStripMenuItem_Click);
            // 
            // quiromasajeHojaBlancoToolStripMenuItem
            // 
            this.quiromasajeHojaBlancoToolStripMenuItem.Name = "quiromasajeHojaBlancoToolStripMenuItem";
            this.quiromasajeHojaBlancoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.quiromasajeHojaBlancoToolStripMenuItem.Text = "Quiromasajes Hoja Blanco";
            this.quiromasajeHojaBlancoToolStripMenuItem.Click += new System.EventHandler(this.quiromasajeHojaBlancoToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::gesClinica.app.pc.Properties.Resources.PrintHS;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Imprimir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(613, 583);
            this.Controls.Add(this.tabPaciente);
            this.Name = "frmEdit";
            this.Text = "Paciente";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabPaciente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panFooter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHijos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPaciente.ResumeLayout(false);
            this.tpageDatosPersonales.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpageDatosAdministrativos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaldos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpageDatosClinicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tpageDescuentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDescuentos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void historiaClínicaQuiromasajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrint vVen = new frmPrint((Paciente)this.InnerVO, tTIPOIMPRESION.QUIROMASAJE1);
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void historiaClínicaSegundaHojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrint vVen = new frmPrint((Paciente)this.InnerVO, tTIPOIMPRESION.QUIROMASAJE2);
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void hisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quiromasajesCuerpoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrint vVen = new frmPrint((Paciente)this.InnerVO, tTIPOIMPRESION.QUIROMASAJE3);
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void quiromasajeHojaBlancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrint vVen = new frmPrint((Paciente)this.InnerVO, tTIPOIMPRESION.QUIROMASAJE4);
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _imprimirquiromasaje.frmImprimirQuiromasaje vVen = new gesClinica.app.pc.frm.paciente._imprimirquiromasaje.frmImprimirQuiromasaje((Paciente)this.InnerVO);
                vVen.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
