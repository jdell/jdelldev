using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtPaciente;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPacienteExaminar;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbTerapia;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbEstadoCita;
        internal System.Windows.Forms.NumericUpDown txtDuracion;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.CheckBox chkPresencial;
        internal System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita());
        }
        public frmEdit(DateTime fecha, lib.vo.Sala sala)
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita());

            this.dateFecha.Value = fecha;
            if (sala!=null) this.cmbSala.SelectedValue = sala.ID;
        }
        public frmEdit(DateTime fecha, lib.vo.Sala sala, lib.vo.Paciente paciente)
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita());

            this.dateFecha.Value = fecha;
            if (sala != null) this.cmbSala.SelectedValue = sala.ID;
            frmEdit editCita = (frmEdit)this;
            ctrl.setPaciente(ref editCita, paciente);
        }
        public frmEdit(Cita objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO.GetCopy());
        }
        public frmEdit(Cita objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btPacienteExaminar.Enabled = !this.OnlyView;
            
            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
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
            this.txtPaciente = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btPacienteExaminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTerapia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstadoCita = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkPresencial = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(336, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(416, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 243);
            this.panFooter.Size = new System.Drawing.Size(503, 43);
            // 
            // txtPaciente
            // 
            this.txtPaciente.ActivateStyle = false;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaciente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPaciente.ColorLeave = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(96, 65);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(339, 22);
            this.txtPaciente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Paciente";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(96, 37);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha";
            // 
            // btPacienteExaminar
            // 
            this.btPacienteExaminar.Location = new System.Drawing.Point(441, 65);
            this.btPacienteExaminar.Name = "btPacienteExaminar";
            this.btPacienteExaminar.Size = new System.Drawing.Size(31, 22);
            this.btPacienteExaminar.TabIndex = 20;
            this.btPacienteExaminar.Text = "...";
            this.btPacienteExaminar.UseVisualStyleBackColor = true;
            this.btPacienteExaminar.Click += new System.EventHandler(this.btPacienteExaminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Terapia";
            // 
            // cmbTerapia
            // 
            this.cmbTerapia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerapia.FormattingEnabled = true;
            this.cmbTerapia.Location = new System.Drawing.Point(96, 121);
            this.cmbTerapia.Name = "cmbTerapia";
            this.cmbTerapia.Size = new System.Drawing.Size(376, 22);
            this.cmbTerapia.TabIndex = 24;
            this.cmbTerapia.SelectedIndexChanged += new System.EventHandler(this.cmbTerapia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Terapeuta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(96, 93);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpleado.TabIndex = 26;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sala";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(96, 149);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(376, 22);
            this.cmbSala.TabIndex = 28;
            this.cmbSala.SelectedIndexChanged += new System.EventHandler(this.cmbSala_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 31;
            this.label6.Text = "Estado";
            // 
            // cmbEstadoCita
            // 
            this.cmbEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCita.FormattingEnabled = true;
            this.cmbEstadoCita.Location = new System.Drawing.Point(96, 177);
            this.cmbEstadoCita.Name = "cmbEstadoCita";
            this.cmbEstadoCita.Size = new System.Drawing.Size(376, 22);
            this.cmbEstadoCita.TabIndex = 30;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtDuracion.Location = new System.Drawing.Point(96, 205);
            this.txtDuracion.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txtDuracion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(120, 22);
            this.txtDuracion.TabIndex = 32;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDuracion.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Duración";
            // 
            // chkPresencial
            // 
            this.chkPresencial.AutoSize = true;
            this.chkPresencial.Location = new System.Drawing.Point(389, 37);
            this.chkPresencial.Name = "chkPresencial";
            this.chkPresencial.Size = new System.Drawing.Size(79, 18);
            this.chkPresencial.TabIndex = 34;
            this.chkPresencial.Text = "Presencial";
            this.chkPresencial.UseVisualStyleBackColor = true;
            this.chkPresencial.Visible = false;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(503, 286);
            this.Controls.Add(this.chkPresencial);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstadoCita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTerapia);
            this.Controls.Add(this.btPacienteExaminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Cita";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPaciente, 0);
            this.Controls.SetChildIndex(this.dateFecha, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btPacienteExaminar, 0);
            this.Controls.SetChildIndex(this.cmbTerapia, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbEmpleado, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbSala, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbEstadoCita, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.chkPresencial, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btPacienteExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.frmQuery vVen = new gesClinica.app.pc.frm.paciente.frmQuery();
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
                    frmEdit frm = this;
                    ctrl.setPaciente(ref frm, (Paciente)vVen.SelectedVO);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbTerapia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbTerapia.SelectedItem != null)
                {
                    ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
                    frmEdit frm = this;
                    ctrl.setDuracion(ref frm, (Terapia)this.cmbTerapia.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
                frmEdit frm = this;
                ctrl.cargarTerapias(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.IsNewRecord)
                {
                    ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEdit();
                    frmEdit frm = this;
                    ctrl.cargarConfiguracion(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
