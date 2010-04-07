using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita
{
    class frmEditTelefonica: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtPaciente;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPacienteExaminar;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageSintomas;
        private System.Windows.Forms.TabPage pageDiagnostico;
        private System.Windows.Forms.TabPage pageTratamiento;
        internal gesClinica.app.pc.template.controls.TextEditor txtSintomas;
        private System.ComponentModel.IContainer components;
        internal gesClinica.app.pc.template.controls.TextEditor txtDiagnostico;
        internal gesClinica.app.pc.template.controls.TextEditor txtTratamiento;
        private System.Windows.Forms.Label label2;

        public frmEditTelefonica()
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEditTelefonica ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditTelefonica();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita());
        }
        public frmEditTelefonica(Cita objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditTelefonica ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditTelefonica();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditTelefonica(Cita objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btPacienteExaminar.Enabled = !this.OnlyView;

            ctrl.ctrlEditTelefonica ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditTelefonica();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditTelefonica ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditTelefonica();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
                base.btAceptar_Click(sender, e);

                if (!this.chkCerrar.Checked)
                    ctrl.recuperarDatos(ref frm);
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.txtPaciente = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btPacienteExaminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageSintomas = new System.Windows.Forms.TabPage();
            this.pageDiagnostico = new System.Windows.Forms.TabPage();
            this.pageTratamiento = new System.Windows.Forms.TabPage();
            this.txtSintomas = new gesClinica.app.pc.template.controls.TextEditor();
            this.txtDiagnostico = new gesClinica.app.pc.template.controls.TextEditor();
            this.txtTratamiento = new gesClinica.app.pc.template.controls.TextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageSintomas.SuspendLayout();
            this.pageDiagnostico.SuspendLayout();
            this.pageTratamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(331, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(411, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 466);
            this.panFooter.Size = new System.Drawing.Size(498, 43);
            // 
            // txtPaciente
            // 
            this.txtPaciente.ActivateStyle = false;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaciente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPaciente.ColorLeave = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(98, 56);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(339, 22);
            this.txtPaciente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Paciente";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(98, 28);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha";
            // 
            // btPacienteExaminar
            // 
            this.btPacienteExaminar.Location = new System.Drawing.Point(443, 56);
            this.btPacienteExaminar.Name = "btPacienteExaminar";
            this.btPacienteExaminar.Size = new System.Drawing.Size(31, 22);
            this.btPacienteExaminar.TabIndex = 20;
            this.btPacienteExaminar.Text = "...";
            this.btPacienteExaminar.UseVisualStyleBackColor = true;
            this.btPacienteExaminar.Click += new System.EventHandler(this.btPacienteExaminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Terapeuta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(98, 84);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpleado.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPaciente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbEmpleado);
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.btPacienteExaminar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 135);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 331);
            this.panel2.TabIndex = 29;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageSintomas);
            this.tabControl1.Controls.Add(this.pageDiagnostico);
            this.tabControl1.Controls.Add(this.pageTratamiento);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // pageSintomas
            // 
            this.pageSintomas.Controls.Add(this.txtSintomas);
            this.pageSintomas.Location = new System.Drawing.Point(4, 23);
            this.pageSintomas.Name = "pageSintomas";
            this.pageSintomas.Padding = new System.Windows.Forms.Padding(3);
            this.pageSintomas.Size = new System.Drawing.Size(490, 304);
            this.pageSintomas.TabIndex = 0;
            this.pageSintomas.Text = "Síntomas";
            this.pageSintomas.UseVisualStyleBackColor = true;
            // 
            // pageDiagnostico
            // 
            this.pageDiagnostico.Controls.Add(this.txtDiagnostico);
            this.pageDiagnostico.Location = new System.Drawing.Point(4, 23);
            this.pageDiagnostico.Name = "pageDiagnostico";
            this.pageDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.pageDiagnostico.Size = new System.Drawing.Size(490, 304);
            this.pageDiagnostico.TabIndex = 1;
            this.pageDiagnostico.Text = "Diagnóstico";
            this.pageDiagnostico.UseVisualStyleBackColor = true;
            // 
            // pageTratamiento
            // 
            this.pageTratamiento.Controls.Add(this.txtTratamiento);
            this.pageTratamiento.Location = new System.Drawing.Point(4, 23);
            this.pageTratamiento.Name = "pageTratamiento";
            this.pageTratamiento.Padding = new System.Windows.Forms.Padding(3);
            this.pageTratamiento.Size = new System.Drawing.Size(490, 304);
            this.pageTratamiento.TabIndex = 2;
            this.pageTratamiento.Text = "Tratamiento";
            this.pageTratamiento.UseVisualStyleBackColor = true;
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
            this.txtSintomas.RichTextBox.Size = new System.Drawing.Size(484, 273);
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
            this.txtSintomas.Size = new System.Drawing.Size(484, 298);
            this.txtSintomas.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtSintomas.StampColor = System.Drawing.Color.Blue;
            this.txtSintomas.TabIndex = 4;
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
            this.txtSintomas.Toolbar.Size = new System.Drawing.Size(778, 26);
            this.txtSintomas.Toolbar.TabIndex = 0;
            this.txtSintomas.Toolbar.Visible = false;
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
            this.txtDiagnostico.RichTextBox.Size = new System.Drawing.Size(484, 273);
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
            this.txtDiagnostico.Size = new System.Drawing.Size(484, 298);
            this.txtDiagnostico.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtDiagnostico.StampColor = System.Drawing.Color.Blue;
            this.txtDiagnostico.TabIndex = 2;
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
            this.txtDiagnostico.Toolbar.Size = new System.Drawing.Size(778, 26);
            this.txtDiagnostico.Toolbar.TabIndex = 0;
            this.txtDiagnostico.Toolbar.Visible = false;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.AcceptsTab = false;
            this.txtTratamiento.AutoWordSelection = true;
            this.txtTratamiento.DetectURLs = true;
            this.txtTratamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTratamiento.Location = new System.Drawing.Point(3, 3);
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
            this.txtTratamiento.RichTextBox.Size = new System.Drawing.Size(484, 273);
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
            this.txtTratamiento.Size = new System.Drawing.Size(484, 298);
            this.txtTratamiento.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtTratamiento.StampColor = System.Drawing.Color.Blue;
            this.txtTratamiento.TabIndex = 4;
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
            this.txtTratamiento.Toolbar.Size = new System.Drawing.Size(784, 26);
            this.txtTratamiento.Toolbar.TabIndex = 0;
            this.txtTratamiento.Toolbar.Visible = false;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(498, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEdit";
            this.Text = "Cita Telefónica";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageSintomas.ResumeLayout(false);
            this.pageDiagnostico.ResumeLayout(false);
            this.pageTratamiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btPacienteExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.frmQuery vVen = new gesClinica.app.pc.frm.paciente.frmQuery();
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEditTelefonica ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditTelefonica();
                    frmEditTelefonica frm = this;
                    ctrl.setPaciente(ref frm, (Paciente)vVen.SelectedVO);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
