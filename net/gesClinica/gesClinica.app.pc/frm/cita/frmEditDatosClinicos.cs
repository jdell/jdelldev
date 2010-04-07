using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita
{
    class frmEditDatosClinicos: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.DataGridView dgCitas;
        internal System.Windows.Forms.TabControl tabDatosClinicos;
        internal System.Windows.Forms.TabPage tpageSintomas;
        internal System.Windows.Forms.TabPage tpageDiagnostico;
        internal System.Windows.Forms.TabPage tpageTratamiento;
        internal System.Windows.Forms.TabPage tpageResumen;
        internal System.Windows.Forms.TabPage tpageHistoriaCompleta;
        private System.ComponentModel.IContainer components;
        internal gesClinica.app.pc.template.controls.TextEditor txtDiagnostico;
        internal gesClinica.app.pc.template.controls.TextEditor txtResumen;
        internal gesClinica.app.pc.template.controls.TextEditor txtHistoriaCompleta;
        internal gesClinica.app.pc.template.controls.TextEditor txtSintomas;
        internal gesClinica.app.pc.template.controls.TextEditor txtTratamiento;
        internal System.Windows.Forms.TabPage tpageDatosGinecologicos;
        private System.Windows.Forms.Button btDatosGinecologicos;
        internal repsol.forms.controls.TextBoxColor txtPartos;
        internal repsol.forms.controls.TextBoxColor txtVivos;
        internal repsol.forms.controls.TextBoxColor txtAbortos;
        private System.Windows.Forms.Label label7;
        internal repsol.forms.controls.TextBoxColor txtGestaciones;
        private System.Windows.Forms.Label label6;
        internal repsol.forms.controls.TextBoxColor txtMolestiasPelvicas;
        private System.Windows.Forms.Label label5;
        internal repsol.forms.controls.TextBoxColor txtSindromePremenstrual;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtDismenorrea;
        internal repsol.forms.controls.TextBoxColor txtMenopausia;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtMenarquia;
        private System.Windows.Forms.Label label2;
        internal repsol.forms.controls.TextBoxColor txtCesareas;
        internal repsol.forms.controls.TextBoxColor txtTratamientosHormonales;
        private System.Windows.Forms.Label label9;
        internal repsol.forms.controls.TextBoxColor txtDispareunemia;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtReglaFrecuencia;
        internal repsol.forms.controls.TextBoxColor txtReglaDuracion;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        private System.Windows.Forms.Label label11;
        internal repsol.forms.controls.TextBoxColor txtAnticonceptivos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TabPage tpageAnexos;


        internal receta.frmQuery _frmRecetas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbAsistenteSintomas;
        internal System.Windows.Forms.Label labPaciente;
        private System.Windows.Forms.Button btGuardar;
        internal System.Windows.Forms.Label labInfoGuardado;
        private System.Windows.Forms.ToolStripButton tsbNuevaCitaTelefonica;
        internal System.Windows.Forms.CheckBox chkSoloMio;
        private System.Windows.Forms.GroupBox groupBox1;
        internal repsol.forms.controls.TextBoxColor txtMuyImportante;
        internal anexo.frmQuery _frmAnexos;
        private System.Windows.Forms.ToolStripButton tsbEditarDatosImportantes;
        private System.Windows.Forms.ToolStripButton tsbRecetas;

        private Paciente _paciente;
        public Paciente Paciente
        {
            get
            {
                return this._paciente;
            }
            set
            {
                this._paciente = value;
            }
        }

        private bool _loaded = false;

        public bool Loaded
        {
            get { return _loaded; }
        }

        public frmEditDatosClinicos(Paciente objVO)
        {
            InitializeComponent();

            this.newRecord = false;
            this.Paciente = objVO;

            _frmRecetas = new gesClinica.app.pc.frm.cita.receta.frmQuery();
            _frmAnexos = new gesClinica.app.pc.frm.cita.anexo.frmQuery();

            ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita(objVO));
        }

        public frmEditDatosClinicos(Cita objVO)
        {
            InitializeComponent();

            this.newRecord = false;

            this.Paciente = objVO.Paciente;

            _frmRecetas = new gesClinica.app.pc.frm.cita.receta.frmQuery();
            _frmAnexos = new gesClinica.app.pc.frm.cita.anexo.frmQuery();

            ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
                base.btAceptar_Click(sender, e);
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        protected override void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea salir? Los datos no guardados se borrarán.", "Salir", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    //this.Close();
                }
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDatosClinicos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgCitas = new System.Windows.Forms.DataGridView();
            this.chkSoloMio = new System.Windows.Forms.CheckBox();
            this.tabDatosClinicos = new System.Windows.Forms.TabControl();
            this.tpageHistoriaCompleta = new System.Windows.Forms.TabPage();
            this.txtHistoriaCompleta = new gesClinica.app.pc.template.controls.TextEditor();
            this.tpageSintomas = new System.Windows.Forms.TabPage();
            this.txtSintomas = new gesClinica.app.pc.template.controls.TextEditor();
            this.tpageDiagnostico = new System.Windows.Forms.TabPage();
            this.txtDiagnostico = new gesClinica.app.pc.template.controls.TextEditor();
            this.tpageTratamiento = new System.Windows.Forms.TabPage();
            this.txtTratamiento = new gesClinica.app.pc.template.controls.TextEditor();
            this.tpageDatosGinecologicos = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservaciones = new repsol.forms.controls.TextBoxColor();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAnticonceptivos = new repsol.forms.controls.TextBoxColor();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTratamientosHormonales = new repsol.forms.controls.TextBoxColor();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDispareunemia = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReglaFrecuencia = new repsol.forms.controls.TextBoxColor();
            this.txtReglaDuracion = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCesareas = new repsol.forms.controls.TextBoxColor();
            this.txtPartos = new repsol.forms.controls.TextBoxColor();
            this.txtVivos = new repsol.forms.controls.TextBoxColor();
            this.txtAbortos = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGestaciones = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMolestiasPelvicas = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSindromePremenstrual = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDismenorrea = new repsol.forms.controls.TextBoxColor();
            this.txtMenopausia = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenarquia = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.btDatosGinecologicos = new System.Windows.Forms.Button();
            this.tpageAnexos = new System.Windows.Forms.TabPage();
            this.tpageResumen = new System.Windows.Forms.TabPage();
            this.txtResumen = new gesClinica.app.pc.template.controls.TextEditor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAsistenteSintomas = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevaCitaTelefonica = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarDatosImportantes = new System.Windows.Forms.ToolStripButton();
            this.tsbRecetas = new System.Windows.Forms.ToolStripButton();
            this.labPaciente = new System.Windows.Forms.Label();
            this.labInfoGuardado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMuyImportante = new repsol.forms.controls.TextBoxColor();
            this.btGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).BeginInit();
            this.tabDatosClinicos.SuspendLayout();
            this.tpageHistoriaCompleta.SuspendLayout();
            this.tpageSintomas.SuspendLayout();
            this.tpageDiagnostico.SuspendLayout();
            this.tpageTratamiento.SuspendLayout();
            this.tpageDatosGinecologicos.SuspendLayout();
            this.tpageResumen.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(1080, 8);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1161, 8);
            // 
            // panFooter
            // 
            this.panFooter.Controls.Add(this.labInfoGuardado);
            this.panFooter.Controls.Add(this.btGuardar);
            this.panFooter.Location = new System.Drawing.Point(0, 543);
            this.panFooter.Size = new System.Drawing.Size(855, 43);
            this.panFooter.Controls.SetChildIndex(this.btCancelar, 0);
            this.panFooter.Controls.SetChildIndex(this.chkCerrar, 0);
            this.panFooter.Controls.SetChildIndex(this.btAceptar, 0);
            this.panFooter.Controls.SetChildIndex(this.btGuardar, 0);
            this.panFooter.Controls.SetChildIndex(this.labInfoGuardado, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgCitas);
            this.splitContainer1.Panel1.Controls.Add(this.chkSoloMio);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabDatosClinicos);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.labPaciente);
            this.splitContainer1.Size = new System.Drawing.Size(855, 444);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 35;
            // 
            // dgCitas
            // 
            this.dgCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCitas.Location = new System.Drawing.Point(0, 18);
            this.dgCitas.Name = "dgCitas";
            this.dgCitas.Size = new System.Drawing.Size(170, 426);
            this.dgCitas.TabIndex = 0;
            // 
            // chkSoloMio
            // 
            this.chkSoloMio.AutoSize = true;
            this.chkSoloMio.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSoloMio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkSoloMio.Location = new System.Drawing.Point(0, 0);
            this.chkSoloMio.Name = "chkSoloMio";
            this.chkSoloMio.Size = new System.Drawing.Size(170, 18);
            this.chkSoloMio.TabIndex = 6;
            this.chkSoloMio.Text = "Ver sólo lo mio";
            this.chkSoloMio.UseVisualStyleBackColor = true;
            this.chkSoloMio.CheckedChanged += new System.EventHandler(this.chkSoloMio_CheckedChanged);
            // 
            // tabDatosClinicos
            // 
            this.tabDatosClinicos.Controls.Add(this.tpageHistoriaCompleta);
            this.tabDatosClinicos.Controls.Add(this.tpageSintomas);
            this.tabDatosClinicos.Controls.Add(this.tpageDiagnostico);
            this.tabDatosClinicos.Controls.Add(this.tpageTratamiento);
            this.tabDatosClinicos.Controls.Add(this.tpageResumen);
            this.tabDatosClinicos.Controls.Add(this.tpageDatosGinecologicos);
            this.tabDatosClinicos.Controls.Add(this.tpageAnexos);
            this.tabDatosClinicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDatosClinicos.Location = new System.Drawing.Point(0, 49);
            this.tabDatosClinicos.Multiline = true;
            this.tabDatosClinicos.Name = "tabDatosClinicos";
            this.tabDatosClinicos.SelectedIndex = 0;
            this.tabDatosClinicos.Size = new System.Drawing.Size(681, 395);
            this.tabDatosClinicos.TabIndex = 36;
            this.tabDatosClinicos.SelectedIndexChanged += new System.EventHandler(this.tabDatosClinicos_SelectedIndexChanged);
            // 
            // tpageHistoriaCompleta
            // 
            this.tpageHistoriaCompleta.Controls.Add(this.txtHistoriaCompleta);
            this.tpageHistoriaCompleta.Location = new System.Drawing.Point(4, 23);
            this.tpageHistoriaCompleta.Name = "tpageHistoriaCompleta";
            this.tpageHistoriaCompleta.Size = new System.Drawing.Size(673, 368);
            this.tpageHistoriaCompleta.TabIndex = 5;
            this.tpageHistoriaCompleta.Text = "Historia Clínica Completa";
            this.tpageHistoriaCompleta.UseVisualStyleBackColor = true;
            // 
            // txtHistoriaCompleta
            // 
            this.txtHistoriaCompleta.AcceptsTab = false;
            this.txtHistoriaCompleta.AutoWordSelection = true;
            this.txtHistoriaCompleta.BackColor = System.Drawing.SystemColors.Control;
            this.txtHistoriaCompleta.DetectURLs = true;
            this.txtHistoriaCompleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHistoriaCompleta.Location = new System.Drawing.Point(0, 0);
            this.txtHistoriaCompleta.Name = "txtHistoriaCompleta";
            this.txtHistoriaCompleta.ReadOnly = true;
            // 
            // 
            // 
            this.txtHistoriaCompleta.RichTextBox.AutoWordSelection = true;
            this.txtHistoriaCompleta.RichTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.txtHistoriaCompleta.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtHistoriaCompleta.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtHistoriaCompleta.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHistoriaCompleta.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtHistoriaCompleta.RichTextBox.Name = "rtb1";
            this.txtHistoriaCompleta.RichTextBox.PrintDocument = null;
            this.txtHistoriaCompleta.RichTextBox.ReadOnly = true;
            this.txtHistoriaCompleta.RichTextBox.Size = new System.Drawing.Size(673, 368);
            this.txtHistoriaCompleta.RichTextBox.TabIndex = 1;
            this.txtHistoriaCompleta.ShowBold = true;
            this.txtHistoriaCompleta.ShowCenterJustify = true;
            this.txtHistoriaCompleta.ShowColors = true;
            this.txtHistoriaCompleta.ShowCopy = true;
            this.txtHistoriaCompleta.ShowCut = true;
            this.txtHistoriaCompleta.ShowFont = true;
            this.txtHistoriaCompleta.ShowFontSize = true;
            this.txtHistoriaCompleta.ShowItalic = true;
            this.txtHistoriaCompleta.ShowLeftJustify = true;
            this.txtHistoriaCompleta.ShowOpen = false;
            this.txtHistoriaCompleta.ShowPaste = true;
            this.txtHistoriaCompleta.ShowRedo = true;
            this.txtHistoriaCompleta.ShowRightJustify = true;
            this.txtHistoriaCompleta.ShowSave = false;
            this.txtHistoriaCompleta.ShowStamp = true;
            this.txtHistoriaCompleta.ShowStrikeout = true;
            this.txtHistoriaCompleta.ShowToolBarText = false;
            this.txtHistoriaCompleta.ShowUnderline = true;
            this.txtHistoriaCompleta.ShowUndo = true;
            this.txtHistoriaCompleta.Size = new System.Drawing.Size(673, 368);
            this.txtHistoriaCompleta.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtHistoriaCompleta.StampColor = System.Drawing.Color.Blue;
            this.txtHistoriaCompleta.TabIndex = 1;
            this.txtHistoriaCompleta.TextRTF = resources.GetString("txtHistoriaCompleta.TextRTF");
            // 
            // 
            // 
            this.txtHistoriaCompleta.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtHistoriaCompleta.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtHistoriaCompleta.Toolbar.Divider = false;
            this.txtHistoriaCompleta.Toolbar.DropDownArrows = true;
            this.txtHistoriaCompleta.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtHistoriaCompleta.Toolbar.Name = "tb1";
            this.txtHistoriaCompleta.Toolbar.ShowToolTips = true;
            this.txtHistoriaCompleta.Toolbar.Size = new System.Drawing.Size(784, 20);
            this.txtHistoriaCompleta.Toolbar.TabIndex = 0;
            this.txtHistoriaCompleta.Toolbar.Visible = false;
            // 
            // tpageSintomas
            // 
            this.tpageSintomas.Controls.Add(this.txtSintomas);
            this.tpageSintomas.Location = new System.Drawing.Point(4, 23);
            this.tpageSintomas.Name = "tpageSintomas";
            this.tpageSintomas.Padding = new System.Windows.Forms.Padding(3);
            this.tpageSintomas.Size = new System.Drawing.Size(673, 368);
            this.tpageSintomas.TabIndex = 0;
            this.tpageSintomas.Text = "Síntomas";
            this.tpageSintomas.UseVisualStyleBackColor = true;
            // 
            // txtSintomas
            // 
            this.txtSintomas.AcceptsTab = false;
            this.txtSintomas.AutoWordSelection = true;
            this.txtSintomas.DetectURLs = true;
            this.txtSintomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSintomas.Location = new System.Drawing.Point(3, 3);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.ReadOnly = false;
            // 
            // 
            // 
            this.txtSintomas.RichTextBox.AutoWordSelection = true;
            this.txtSintomas.RichTextBox.BackColor = System.Drawing.Color.White;
            this.txtSintomas.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtSintomas.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtSintomas.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSintomas.RichTextBox.Location = new System.Drawing.Point(0, 25);
            this.txtSintomas.RichTextBox.Name = "rtb1";
            this.txtSintomas.RichTextBox.PrintDocument = null;
            this.txtSintomas.RichTextBox.Size = new System.Drawing.Size(667, 337);
            this.txtSintomas.RichTextBox.TabIndex = 1;
            this.txtSintomas.ShowBold = true;
            this.txtSintomas.ShowCenterJustify = true;
            this.txtSintomas.ShowColors = true;
            this.txtSintomas.ShowCopy = true;
            this.txtSintomas.ShowCut = true;
            this.txtSintomas.ShowFont = true;
            this.txtSintomas.ShowFontSize = true;
            this.txtSintomas.ShowItalic = true;
            this.txtSintomas.ShowLeftJustify = true;
            this.txtSintomas.ShowOpen = false;
            this.txtSintomas.ShowPaste = true;
            this.txtSintomas.ShowRedo = true;
            this.txtSintomas.ShowRightJustify = true;
            this.txtSintomas.ShowSave = false;
            this.txtSintomas.ShowStamp = true;
            this.txtSintomas.ShowStrikeout = true;
            this.txtSintomas.ShowToolBarText = false;
            this.txtSintomas.ShowUnderline = true;
            this.txtSintomas.ShowUndo = true;
            this.txtSintomas.Size = new System.Drawing.Size(667, 362);
            this.txtSintomas.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtSintomas.StampColor = System.Drawing.Color.Blue;
            this.txtSintomas.TabIndex = 3;
            this.txtSintomas.TextRTF = resources.GetString("txtSintomas.TextRTF");
            // 
            // 
            // 
            this.txtSintomas.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtSintomas.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtSintomas.Toolbar.Divider = false;
            this.txtSintomas.Toolbar.DropDownArrows = true;
            this.txtSintomas.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtSintomas.Toolbar.Name = "tb1";
            this.txtSintomas.Toolbar.ShowToolTips = true;
            this.txtSintomas.Toolbar.Size = new System.Drawing.Size(778, 20);
            this.txtSintomas.Toolbar.TabIndex = 0;
            this.txtSintomas.Toolbar.Visible = false;
            // 
            // tpageDiagnostico
            // 
            this.tpageDiagnostico.Controls.Add(this.txtDiagnostico);
            this.tpageDiagnostico.Location = new System.Drawing.Point(4, 23);
            this.tpageDiagnostico.Name = "tpageDiagnostico";
            this.tpageDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tpageDiagnostico.Size = new System.Drawing.Size(673, 368);
            this.tpageDiagnostico.TabIndex = 1;
            this.tpageDiagnostico.Text = "Diagnóstico";
            this.tpageDiagnostico.UseVisualStyleBackColor = true;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AcceptsTab = false;
            this.txtDiagnostico.AutoWordSelection = true;
            this.txtDiagnostico.DetectURLs = true;
            this.txtDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiagnostico.Location = new System.Drawing.Point(3, 3);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ReadOnly = false;
            // 
            // 
            // 
            this.txtDiagnostico.RichTextBox.AutoWordSelection = true;
            this.txtDiagnostico.RichTextBox.BackColor = System.Drawing.Color.White;
            this.txtDiagnostico.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtDiagnostico.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtDiagnostico.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiagnostico.RichTextBox.Location = new System.Drawing.Point(0, 25);
            this.txtDiagnostico.RichTextBox.Name = "rtb1";
            this.txtDiagnostico.RichTextBox.PrintDocument = null;
            this.txtDiagnostico.RichTextBox.Size = new System.Drawing.Size(667, 337);
            this.txtDiagnostico.RichTextBox.TabIndex = 1;
            this.txtDiagnostico.ShowBold = true;
            this.txtDiagnostico.ShowCenterJustify = true;
            this.txtDiagnostico.ShowColors = true;
            this.txtDiagnostico.ShowCopy = true;
            this.txtDiagnostico.ShowCut = true;
            this.txtDiagnostico.ShowFont = true;
            this.txtDiagnostico.ShowFontSize = true;
            this.txtDiagnostico.ShowItalic = true;
            this.txtDiagnostico.ShowLeftJustify = true;
            this.txtDiagnostico.ShowOpen = false;
            this.txtDiagnostico.ShowPaste = true;
            this.txtDiagnostico.ShowRedo = true;
            this.txtDiagnostico.ShowRightJustify = true;
            this.txtDiagnostico.ShowSave = false;
            this.txtDiagnostico.ShowStamp = true;
            this.txtDiagnostico.ShowStrikeout = true;
            this.txtDiagnostico.ShowToolBarText = false;
            this.txtDiagnostico.ShowUnderline = true;
            this.txtDiagnostico.ShowUndo = true;
            this.txtDiagnostico.Size = new System.Drawing.Size(667, 362);
            this.txtDiagnostico.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtDiagnostico.StampColor = System.Drawing.Color.Blue;
            this.txtDiagnostico.TabIndex = 1;
            this.txtDiagnostico.TextRTF = resources.GetString("txtDiagnostico.TextRTF");
            // 
            // 
            // 
            this.txtDiagnostico.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtDiagnostico.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtDiagnostico.Toolbar.Divider = false;
            this.txtDiagnostico.Toolbar.DropDownArrows = true;
            this.txtDiagnostico.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtDiagnostico.Toolbar.Name = "tb1";
            this.txtDiagnostico.Toolbar.ShowToolTips = true;
            this.txtDiagnostico.Toolbar.Size = new System.Drawing.Size(778, 20);
            this.txtDiagnostico.Toolbar.TabIndex = 0;
            this.txtDiagnostico.Toolbar.Visible = false;
            // 
            // tpageTratamiento
            // 
            this.tpageTratamiento.Controls.Add(this.txtTratamiento);
            this.tpageTratamiento.Location = new System.Drawing.Point(4, 23);
            this.tpageTratamiento.Name = "tpageTratamiento";
            this.tpageTratamiento.Size = new System.Drawing.Size(673, 368);
            this.tpageTratamiento.TabIndex = 2;
            this.tpageTratamiento.Text = "Tratamiento";
            this.tpageTratamiento.UseVisualStyleBackColor = true;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.AcceptsTab = false;
            this.txtTratamiento.AutoWordSelection = true;
            this.txtTratamiento.DetectURLs = true;
            this.txtTratamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTratamiento.Location = new System.Drawing.Point(0, 0);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.ReadOnly = false;
            // 
            // 
            // 
            this.txtTratamiento.RichTextBox.AutoWordSelection = true;
            this.txtTratamiento.RichTextBox.BackColor = System.Drawing.Color.White;
            this.txtTratamiento.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtTratamiento.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtTratamiento.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTratamiento.RichTextBox.Location = new System.Drawing.Point(0, 25);
            this.txtTratamiento.RichTextBox.Name = "rtb1";
            this.txtTratamiento.RichTextBox.PrintDocument = null;
            this.txtTratamiento.RichTextBox.Size = new System.Drawing.Size(673, 343);
            this.txtTratamiento.RichTextBox.TabIndex = 1;
            this.txtTratamiento.ShowBold = true;
            this.txtTratamiento.ShowCenterJustify = true;
            this.txtTratamiento.ShowColors = true;
            this.txtTratamiento.ShowCopy = true;
            this.txtTratamiento.ShowCut = true;
            this.txtTratamiento.ShowFont = true;
            this.txtTratamiento.ShowFontSize = true;
            this.txtTratamiento.ShowItalic = true;
            this.txtTratamiento.ShowLeftJustify = true;
            this.txtTratamiento.ShowOpen = false;
            this.txtTratamiento.ShowPaste = true;
            this.txtTratamiento.ShowRedo = true;
            this.txtTratamiento.ShowRightJustify = true;
            this.txtTratamiento.ShowSave = false;
            this.txtTratamiento.ShowStamp = true;
            this.txtTratamiento.ShowStrikeout = true;
            this.txtTratamiento.ShowToolBarText = false;
            this.txtTratamiento.ShowUnderline = true;
            this.txtTratamiento.ShowUndo = true;
            this.txtTratamiento.Size = new System.Drawing.Size(673, 368);
            this.txtTratamiento.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtTratamiento.StampColor = System.Drawing.Color.Blue;
            this.txtTratamiento.TabIndex = 3;
            this.txtTratamiento.TextRTF = resources.GetString("txtTratamiento.TextRTF");
            // 
            // 
            // 
            this.txtTratamiento.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtTratamiento.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtTratamiento.Toolbar.Divider = false;
            this.txtTratamiento.Toolbar.DropDownArrows = true;
            this.txtTratamiento.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtTratamiento.Toolbar.Name = "tb1";
            this.txtTratamiento.Toolbar.ShowToolTips = true;
            this.txtTratamiento.Toolbar.Size = new System.Drawing.Size(784, 20);
            this.txtTratamiento.Toolbar.TabIndex = 0;
            this.txtTratamiento.Toolbar.Visible = false;
            // 
            // tpageDatosGinecologicos
            // 
            this.tpageDatosGinecologicos.Controls.Add(this.label16);
            this.tpageDatosGinecologicos.Controls.Add(this.label15);
            this.tpageDatosGinecologicos.Controls.Add(this.label14);
            this.tpageDatosGinecologicos.Controls.Add(this.label13);
            this.tpageDatosGinecologicos.Controls.Add(this.label12);
            this.tpageDatosGinecologicos.Controls.Add(this.txtObservaciones);
            this.tpageDatosGinecologicos.Controls.Add(this.label11);
            this.tpageDatosGinecologicos.Controls.Add(this.txtAnticonceptivos);
            this.tpageDatosGinecologicos.Controls.Add(this.label10);
            this.tpageDatosGinecologicos.Controls.Add(this.txtTratamientosHormonales);
            this.tpageDatosGinecologicos.Controls.Add(this.label9);
            this.tpageDatosGinecologicos.Controls.Add(this.txtDispareunemia);
            this.tpageDatosGinecologicos.Controls.Add(this.label8);
            this.tpageDatosGinecologicos.Controls.Add(this.txtReglaFrecuencia);
            this.tpageDatosGinecologicos.Controls.Add(this.txtReglaDuracion);
            this.tpageDatosGinecologicos.Controls.Add(this.label3);
            this.tpageDatosGinecologicos.Controls.Add(this.txtCesareas);
            this.tpageDatosGinecologicos.Controls.Add(this.txtPartos);
            this.tpageDatosGinecologicos.Controls.Add(this.txtVivos);
            this.tpageDatosGinecologicos.Controls.Add(this.txtAbortos);
            this.tpageDatosGinecologicos.Controls.Add(this.label7);
            this.tpageDatosGinecologicos.Controls.Add(this.txtGestaciones);
            this.tpageDatosGinecologicos.Controls.Add(this.label6);
            this.tpageDatosGinecologicos.Controls.Add(this.txtMolestiasPelvicas);
            this.tpageDatosGinecologicos.Controls.Add(this.label5);
            this.tpageDatosGinecologicos.Controls.Add(this.txtSindromePremenstrual);
            this.tpageDatosGinecologicos.Controls.Add(this.label4);
            this.tpageDatosGinecologicos.Controls.Add(this.txtDismenorrea);
            this.tpageDatosGinecologicos.Controls.Add(this.txtMenopausia);
            this.tpageDatosGinecologicos.Controls.Add(this.label1);
            this.tpageDatosGinecologicos.Controls.Add(this.txtMenarquia);
            this.tpageDatosGinecologicos.Controls.Add(this.label2);
            this.tpageDatosGinecologicos.Controls.Add(this.btDatosGinecologicos);
            this.tpageDatosGinecologicos.Location = new System.Drawing.Point(4, 23);
            this.tpageDatosGinecologicos.Name = "tpageDatosGinecologicos";
            this.tpageDatosGinecologicos.Padding = new System.Windows.Forms.Padding(3);
            this.tpageDatosGinecologicos.Size = new System.Drawing.Size(673, 368);
            this.tpageDatosGinecologicos.TabIndex = 6;
            this.tpageDatosGinecologicos.Text = "Datos Ginecológicos";
            this.tpageDatosGinecologicos.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 14);
            this.label16.TabIndex = 52;
            this.label16.Text = "/";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 14);
            this.label15.TabIndex = 51;
            this.label15.Text = "/";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 14);
            this.label14.TabIndex = 50;
            this.label14.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(554, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 14);
            this.label13.TabIndex = 49;
            this.label13.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 14);
            this.label12.TabIndex = 48;
            this.label12.Text = "/";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(180, 238);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(446, 87);
            this.txtObservaciones.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 14);
            this.label11.TabIndex = 46;
            this.label11.Text = "Observaciones";
            // 
            // txtAnticonceptivos
            // 
            this.txtAnticonceptivos.ActivateStyle = true;
            this.txtAnticonceptivos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAnticonceptivos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAnticonceptivos.ColorLeave = System.Drawing.Color.White;
            this.txtAnticonceptivos.Location = new System.Drawing.Point(180, 210);
            this.txtAnticonceptivos.Name = "txtAnticonceptivos";
            this.txtAnticonceptivos.ReadOnly = true;
            this.txtAnticonceptivos.Size = new System.Drawing.Size(446, 22);
            this.txtAnticonceptivos.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 14);
            this.label10.TabIndex = 44;
            this.label10.Text = "Anticonceptivos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTratamientosHormonales
            // 
            this.txtTratamientosHormonales.ActivateStyle = true;
            this.txtTratamientosHormonales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTratamientosHormonales.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTratamientosHormonales.ColorLeave = System.Drawing.Color.White;
            this.txtTratamientosHormonales.Location = new System.Drawing.Point(180, 182);
            this.txtTratamientosHormonales.Name = "txtTratamientosHormonales";
            this.txtTratamientosHormonales.ReadOnly = true;
            this.txtTratamientosHormonales.Size = new System.Drawing.Size(446, 22);
            this.txtTratamientosHormonales.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 14);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tratamientos Hormonales";
            // 
            // txtDispareunemia
            // 
            this.txtDispareunemia.ActivateStyle = true;
            this.txtDispareunemia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDispareunemia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDispareunemia.ColorLeave = System.Drawing.Color.White;
            this.txtDispareunemia.Location = new System.Drawing.Point(482, 42);
            this.txtDispareunemia.Name = "txtDispareunemia";
            this.txtDispareunemia.ReadOnly = true;
            this.txtDispareunemia.Size = new System.Drawing.Size(66, 22);
            this.txtDispareunemia.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 14);
            this.label8.TabIndex = 40;
            this.label8.Text = "Dispareunemia";
            // 
            // txtReglaFrecuencia
            // 
            this.txtReglaFrecuencia.ActivateStyle = true;
            this.txtReglaFrecuencia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtReglaFrecuencia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReglaFrecuencia.ColorLeave = System.Drawing.Color.White;
            this.txtReglaFrecuencia.Location = new System.Drawing.Point(572, 42);
            this.txtReglaFrecuencia.Name = "txtReglaFrecuencia";
            this.txtReglaFrecuencia.ReadOnly = true;
            this.txtReglaFrecuencia.Size = new System.Drawing.Size(54, 22);
            this.txtReglaFrecuencia.TabIndex = 39;
            // 
            // txtReglaDuracion
            // 
            this.txtReglaDuracion.ActivateStyle = true;
            this.txtReglaDuracion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtReglaDuracion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReglaDuracion.ColorLeave = System.Drawing.Color.White;
            this.txtReglaDuracion.Location = new System.Drawing.Point(482, 14);
            this.txtReglaDuracion.Name = "txtReglaDuracion";
            this.txtReglaDuracion.ReadOnly = true;
            this.txtReglaDuracion.Size = new System.Drawing.Size(66, 22);
            this.txtReglaDuracion.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 14);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ciclos Duración/Frecuencia";
            // 
            // txtCesareas
            // 
            this.txtCesareas.ActivateStyle = true;
            this.txtCesareas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCesareas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCesareas.ColorLeave = System.Drawing.Color.White;
            this.txtCesareas.Location = new System.Drawing.Point(257, 154);
            this.txtCesareas.Name = "txtCesareas";
            this.txtCesareas.ReadOnly = true;
            this.txtCesareas.Size = new System.Drawing.Size(54, 22);
            this.txtCesareas.TabIndex = 36;
            // 
            // txtPartos
            // 
            this.txtPartos.ActivateStyle = true;
            this.txtPartos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPartos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPartos.ColorLeave = System.Drawing.Color.White;
            this.txtPartos.Location = new System.Drawing.Point(180, 154);
            this.txtPartos.Name = "txtPartos";
            this.txtPartos.ReadOnly = true;
            this.txtPartos.Size = new System.Drawing.Size(53, 22);
            this.txtPartos.TabIndex = 34;
            // 
            // txtVivos
            // 
            this.txtVivos.ActivateStyle = true;
            this.txtVivos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVivos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVivos.ColorLeave = System.Drawing.Color.White;
            this.txtVivos.Location = new System.Drawing.Point(334, 126);
            this.txtVivos.Name = "txtVivos";
            this.txtVivos.ReadOnly = true;
            this.txtVivos.Size = new System.Drawing.Size(54, 22);
            this.txtVivos.TabIndex = 32;
            // 
            // txtAbortos
            // 
            this.txtAbortos.ActivateStyle = true;
            this.txtAbortos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAbortos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAbortos.ColorLeave = System.Drawing.Color.White;
            this.txtAbortos.Location = new System.Drawing.Point(257, 126);
            this.txtAbortos.Name = "txtAbortos";
            this.txtAbortos.ReadOnly = true;
            this.txtAbortos.Size = new System.Drawing.Size(54, 22);
            this.txtAbortos.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 31;
            this.label7.Text = "Partos/Cesareas";
            // 
            // txtGestaciones
            // 
            this.txtGestaciones.ActivateStyle = true;
            this.txtGestaciones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtGestaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtGestaciones.ColorLeave = System.Drawing.Color.White;
            this.txtGestaciones.Location = new System.Drawing.Point(180, 126);
            this.txtGestaciones.Name = "txtGestaciones";
            this.txtGestaciones.ReadOnly = true;
            this.txtGestaciones.Size = new System.Drawing.Size(53, 22);
            this.txtGestaciones.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Gestaciones/Abortos/Viv";
            // 
            // txtMolestiasPelvicas
            // 
            this.txtMolestiasPelvicas.ActivateStyle = true;
            this.txtMolestiasPelvicas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMolestiasPelvicas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMolestiasPelvicas.ColorLeave = System.Drawing.Color.White;
            this.txtMolestiasPelvicas.Location = new System.Drawing.Point(180, 98);
            this.txtMolestiasPelvicas.Name = "txtMolestiasPelvicas";
            this.txtMolestiasPelvicas.ReadOnly = true;
            this.txtMolestiasPelvicas.Size = new System.Drawing.Size(446, 22);
            this.txtMolestiasPelvicas.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Molestias Pélvicas";
            // 
            // txtSindromePremenstrual
            // 
            this.txtSindromePremenstrual.ActivateStyle = true;
            this.txtSindromePremenstrual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSindromePremenstrual.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSindromePremenstrual.ColorLeave = System.Drawing.Color.White;
            this.txtSindromePremenstrual.Location = new System.Drawing.Point(180, 70);
            this.txtSindromePremenstrual.Name = "txtSindromePremenstrual";
            this.txtSindromePremenstrual.ReadOnly = true;
            this.txtSindromePremenstrual.Size = new System.Drawing.Size(131, 22);
            this.txtSindromePremenstrual.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Síndrome Premenstrual";
            // 
            // txtDismenorrea
            // 
            this.txtDismenorrea.ActivateStyle = true;
            this.txtDismenorrea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDismenorrea.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDismenorrea.ColorLeave = System.Drawing.Color.White;
            this.txtDismenorrea.Location = new System.Drawing.Point(180, 42);
            this.txtDismenorrea.Name = "txtDismenorrea";
            this.txtDismenorrea.ReadOnly = true;
            this.txtDismenorrea.Size = new System.Drawing.Size(131, 22);
            this.txtDismenorrea.TabIndex = 22;
            // 
            // txtMenopausia
            // 
            this.txtMenopausia.ActivateStyle = true;
            this.txtMenopausia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMenopausia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMenopausia.ColorLeave = System.Drawing.Color.White;
            this.txtMenopausia.Location = new System.Drawing.Point(257, 14);
            this.txtMenopausia.Name = "txtMenopausia";
            this.txtMenopausia.ReadOnly = true;
            this.txtMenopausia.Size = new System.Drawing.Size(54, 22);
            this.txtMenopausia.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dismenorrea";
            // 
            // txtMenarquia
            // 
            this.txtMenarquia.ActivateStyle = true;
            this.txtMenarquia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMenarquia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMenarquia.ColorLeave = System.Drawing.Color.White;
            this.txtMenarquia.Location = new System.Drawing.Point(180, 14);
            this.txtMenarquia.Name = "txtMenarquia";
            this.txtMenarquia.ReadOnly = true;
            this.txtMenarquia.Size = new System.Drawing.Size(53, 22);
            this.txtMenarquia.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Menarquia/Menopausia";
            // 
            // btDatosGinecologicos
            // 
            this.btDatosGinecologicos.Location = new System.Drawing.Point(414, 338);
            this.btDatosGinecologicos.Name = "btDatosGinecologicos";
            this.btDatosGinecologicos.Size = new System.Drawing.Size(212, 23);
            this.btDatosGinecologicos.TabIndex = 0;
            this.btDatosGinecologicos.Text = "Editar datos ginecologicos";
            this.btDatosGinecologicos.UseVisualStyleBackColor = true;
            this.btDatosGinecologicos.Click += new System.EventHandler(this.btDatosGinecologicos_Click);
            // 
            // tpageAnexos
            // 
            this.tpageAnexos.Location = new System.Drawing.Point(4, 23);
            this.tpageAnexos.Name = "tpageAnexos";
            this.tpageAnexos.Padding = new System.Windows.Forms.Padding(3);
            this.tpageAnexos.Size = new System.Drawing.Size(673, 368);
            this.tpageAnexos.TabIndex = 7;
            this.tpageAnexos.Text = "Anexos/Analiticas";
            this.tpageAnexos.UseVisualStyleBackColor = true;
            // 
            // tpageResumen
            // 
            this.tpageResumen.Controls.Add(this.txtResumen);
            this.tpageResumen.Location = new System.Drawing.Point(4, 23);
            this.tpageResumen.Name = "tpageResumen";
            this.tpageResumen.Size = new System.Drawing.Size(673, 368);
            this.tpageResumen.TabIndex = 4;
            this.tpageResumen.Text = "Resumen";
            this.tpageResumen.UseVisualStyleBackColor = true;
            // 
            // txtResumen
            // 
            this.txtResumen.AcceptsTab = false;
            this.txtResumen.AutoWordSelection = true;
            this.txtResumen.DetectURLs = true;
            this.txtResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResumen.Location = new System.Drawing.Point(0, 0);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ReadOnly = true;
            // 
            // 
            // 
            this.txtResumen.RichTextBox.AutoWordSelection = true;
            this.txtResumen.RichTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.txtResumen.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtResumen.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtResumen.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResumen.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtResumen.RichTextBox.Name = "rtb1";
            this.txtResumen.RichTextBox.PrintDocument = null;
            this.txtResumen.RichTextBox.ReadOnly = true;
            this.txtResumen.RichTextBox.Size = new System.Drawing.Size(673, 368);
            this.txtResumen.RichTextBox.TabIndex = 1;
            this.txtResumen.ShowBold = true;
            this.txtResumen.ShowCenterJustify = true;
            this.txtResumen.ShowColors = true;
            this.txtResumen.ShowCopy = true;
            this.txtResumen.ShowCut = true;
            this.txtResumen.ShowFont = true;
            this.txtResumen.ShowFontSize = true;
            this.txtResumen.ShowItalic = true;
            this.txtResumen.ShowLeftJustify = true;
            this.txtResumen.ShowOpen = false;
            this.txtResumen.ShowPaste = true;
            this.txtResumen.ShowRedo = true;
            this.txtResumen.ShowRightJustify = true;
            this.txtResumen.ShowSave = false;
            this.txtResumen.ShowStamp = true;
            this.txtResumen.ShowStrikeout = true;
            this.txtResumen.ShowToolBarText = false;
            this.txtResumen.ShowUnderline = true;
            this.txtResumen.ShowUndo = true;
            this.txtResumen.Size = new System.Drawing.Size(673, 368);
            this.txtResumen.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtResumen.StampColor = System.Drawing.Color.Blue;
            this.txtResumen.TabIndex = 1;
            this.txtResumen.TextRTF = resources.GetString("txtResumen.TextRTF");
            // 
            // 
            // 
            this.txtResumen.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtResumen.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtResumen.Toolbar.Divider = false;
            this.txtResumen.Toolbar.DropDownArrows = true;
            this.txtResumen.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtResumen.Toolbar.Name = "tb1";
            this.txtResumen.Toolbar.ShowToolTips = true;
            this.txtResumen.Toolbar.Size = new System.Drawing.Size(784, 20);
            this.txtResumen.Toolbar.TabIndex = 0;
            this.txtResumen.Toolbar.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbAsistenteSintomas,
            this.tsbNuevaCitaTelefonica,
            this.tsbEditarDatosImportantes,
            this.tsbRecetas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(681, 31);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 28);
            this.toolStripLabel1.Text = "Opciones :";
            // 
            // tsbAsistenteSintomas
            // 
            this.tsbAsistenteSintomas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAsistenteSintomas.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsistenteSintomas.Image")));
            this.tsbAsistenteSintomas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAsistenteSintomas.Name = "tsbAsistenteSintomas";
            this.tsbAsistenteSintomas.Size = new System.Drawing.Size(159, 28);
            this.tsbAsistenteSintomas.Text = "Asistente sintomático";
            this.tsbAsistenteSintomas.Click += new System.EventHandler(this.tsbAsistenteSintomas_Click);
            // 
            // tsbNuevaCitaTelefonica
            // 
            this.tsbNuevaCitaTelefonica.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNuevaCitaTelefonica.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevaCitaTelefonica.Image")));
            this.tsbNuevaCitaTelefonica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaCitaTelefonica.Name = "tsbNuevaCitaTelefonica";
            this.tsbNuevaCitaTelefonica.Size = new System.Drawing.Size(118, 28);
            this.tsbNuevaCitaTelefonica.Text = "Cita Telefónica";
            this.tsbNuevaCitaTelefonica.Click += new System.EventHandler(this.tsbNuevaCitaTelefonica_Click);
            // 
            // tsbEditarDatosImportantes
            // 
            this.tsbEditarDatosImportantes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEditarDatosImportantes.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarDatosImportantes.Image")));
            this.tsbEditarDatosImportantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarDatosImportantes.Name = "tsbEditarDatosImportantes";
            this.tsbEditarDatosImportantes.Size = new System.Drawing.Size(193, 28);
            this.tsbEditarDatosImportantes.Text = "Datos importantes paciente";
            this.tsbEditarDatosImportantes.Click += new System.EventHandler(this.tsbEditarDatosImportantes_Click);
            // 
            // tsbRecetas
            // 
            this.tsbRecetas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbRecetas.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecetas.Image")));
            this.tsbRecetas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecetas.Name = "tsbRecetas";
            this.tsbRecetas.Size = new System.Drawing.Size(75, 28);
            this.tsbRecetas.Text = "Receta";
            this.tsbRecetas.Click += new System.EventHandler(this.tsbRecetas_Click);
            // 
            // labPaciente
            // 
            this.labPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.labPaciente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labPaciente.Location = new System.Drawing.Point(0, 0);
            this.labPaciente.Name = "labPaciente";
            this.labPaciente.Size = new System.Drawing.Size(681, 18);
            this.labPaciente.TabIndex = 38;
            this.labPaciente.Text = "Datos del Paciente";
            // 
            // labInfoGuardado
            // 
            this.labInfoGuardado.AutoSize = true;
            this.labInfoGuardado.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfoGuardado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labInfoGuardado.Location = new System.Drawing.Point(134, 17);
            this.labInfoGuardado.Name = "labInfoGuardado";
            this.labInfoGuardado.Size = new System.Drawing.Size(0, 13);
            this.labInfoGuardado.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMuyImportante);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 99);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información muy importante sobre este paciente";
            // 
            // txtMuyImportante
            // 
            this.txtMuyImportante.ActivateStyle = false;
            this.txtMuyImportante.BackColor = System.Drawing.SystemColors.Control;
            this.txtMuyImportante.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMuyImportante.ColorLeave = System.Drawing.Color.White;
            this.txtMuyImportante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMuyImportante.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuyImportante.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMuyImportante.Location = new System.Drawing.Point(3, 18);
            this.txtMuyImportante.Multiline = true;
            this.txtMuyImportante.Name = "txtMuyImportante";
            this.txtMuyImportante.ReadOnly = true;
            this.txtMuyImportante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMuyImportante.Size = new System.Drawing.Size(849, 78);
            this.txtMuyImportante.TabIndex = 8;
            // 
            // btGuardar
            // 
            this.btGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btGuardar.Image")));
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(12, 7);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(111, 30);
            this.btGuardar.TabIndex = 8;
            this.btGuardar.Text = "guardar datos";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // frmEditDatosClinicos
            // 
            this.ClientSize = new System.Drawing.Size(855, 586);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditDatosClinicos";
            this.Text = "Cita - Datos Clínicos";
            this.Load += new System.EventHandler(this.frmEditDatosClinicos_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panFooter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCitas)).EndInit();
            this.tabDatosClinicos.ResumeLayout(false);
            this.tpageHistoriaCompleta.ResumeLayout(false);
            this.tpageSintomas.ResumeLayout(false);
            this.tpageDiagnostico.ResumeLayout(false);
            this.tpageTratamiento.ResumeLayout(false);
            this.tpageDatosGinecologicos.ResumeLayout(false);
            this.tpageDatosGinecologicos.PerformLayout();
            this.tpageResumen.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmEditDatosClinicos_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Datos Clínicos";
                _loaded = true;
                this.btAceptar.Visible = false;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btDatosGinecologicos_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                frmEditDatosClinicos frm = (frmEditDatosClinicos)this;
                ctrl.editarDatosGinecologicos(ref frm);
            }
            catch (Exception ex)
            {   
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbAsistenteSintomas_Click(object sender, EventArgs e)
        {
            try
            {
                _sintoma.frmEditASintoma vVen = new gesClinica.app.pc.frm.cita._sintoma.frmEditASintoma();
                if (vVen.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtSintomas.AppendRtf(vVen.txtSintomas.TextRTF);
                    this.tabDatosClinicos.SelectedTab = this.tpageSintomas;
                }
            }
            catch (Exception ex)
            {   
                template._common.messages.ShowError(ex);
            }
        }


        private void tabDatosClinicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loaded)
                {
                    ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                    frmEditDatosClinicos frm = (frmEditDatosClinicos)this;
                    ctrl.updateHistorial(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }

        }

        internal void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loaded)
                {
                    _loaded = false;
                    ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                    repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                    ctrl.guardarDatos(ref frm, this.IsNewRecord);
                    _loaded = true;
                }
            }
            catch (Exception ex)
            {   
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbNuevaCitaTelefonica_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                frmEditDatosClinicos frm = (frmEditDatosClinicos)this;
                cita.frmEditTelefonica vVen = new frmEditTelefonica(ctrl.getCitaTelefonica(ref frm));
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    btGuardar_Click(null, null);
                    _loaded = false;
                    repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
                    ctrl.cargarDatos(ref edit, (Cita)vVen.InnerVO);
                    _loaded = true;
                }
                
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void chkSoloMio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Loaded)
                {
                    _loaded = false;
                    ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                    repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
                    ctrl.cargarDatos(ref edit, this.InnerVO);
                    _loaded = true;
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbEditarDatosImportantes_Click(object sender, EventArgs e)
        {
            try
            {
                _loaded = false;
                ctrl.ctrlEditDatosClinicos ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditDatosClinicos();
                frmEditDatosClinicos frm = (frmEditDatosClinicos)this;
                paciente.frmEditMuyImportante vVen = new gesClinica.app.pc.frm.paciente.frmEditMuyImportante(ctrl.getPaciente(ref frm));
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
                    ctrl.cargarDatosPaciente(ref edit, (lib.vo.Paciente)vVen.InnerVO);
                    ctrl.cargarDatos(ref edit, new lib.vo.Cita((lib.vo.Paciente)vVen.InnerVO));
                }
                _loaded = true;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbRecetas_Click(object sender, EventArgs e)
        {
            try
            {
                //Esto no debe ir aqui. Son pruebas "rapidas"
                receta.frmEditEmitirReceta vVen;
                if (((Cita)this.InnerVO).Receta.Count>0)
                    vVen = new gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta(((Cita)this.InnerVO).Receta[0],false);
                else
                    vVen = new gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta((Cita)this.InnerVO);
                vVen.ShowDialog(this);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
