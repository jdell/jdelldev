using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita
{
    class frmEditProgramada: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtPaciente;
        internal System.Windows.Forms.DateTimePicker dateFechaInicio;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.NumericUpDown txtCadaSemana;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.CheckBox chkDomingo;
        internal System.Windows.Forms.CheckBox chkSabado;
        internal System.Windows.Forms.CheckBox chkViernes;
        internal System.Windows.Forms.CheckBox chkJueves;
        internal System.Windows.Forms.CheckBox chkMiercoles;
        internal System.Windows.Forms.CheckBox chkMartes;
        internal System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.Label label2;

        public frmEditProgramada()
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita());
        }
        public frmEditProgramada(DateTime fecha, lib.vo.Sala sala)
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Cita());

            this.dateFechaInicio.Value = fecha;
            if (sala!=null) this.cmbSala.SelectedValue = sala.ID;
        }
        public frmEditProgramada(Cita objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditProgramada(Cita objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btPacienteExaminar.Enabled = !this.OnlyView;
            
            ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
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
            this.txtPaciente = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaInicio = new System.Windows.Forms.DateTimePicker();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.txtCadaSemana = new System.Windows.Forms.NumericUpDown();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadaSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(332, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(412, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 393);
            this.panFooter.Size = new System.Drawing.Size(499, 43);
            // 
            // txtPaciente
            // 
            this.txtPaciente.ActivateStyle = false;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaciente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPaciente.ColorLeave = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(85, 41);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(339, 22);
            this.txtPaciente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Paciente";
            // 
            // dateFechaInicio
            // 
            this.dateFechaInicio.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaInicio.Location = new System.Drawing.Point(85, 21);
            this.dateFechaInicio.Name = "dateFechaInicio";
            this.dateFechaInicio.Size = new System.Drawing.Size(136, 22);
            this.dateFechaInicio.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Inicio";
            // 
            // btPacienteExaminar
            // 
            this.btPacienteExaminar.Location = new System.Drawing.Point(430, 41);
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
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Terapia";
            // 
            // cmbTerapia
            // 
            this.cmbTerapia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerapia.FormattingEnabled = true;
            this.cmbTerapia.Location = new System.Drawing.Point(85, 97);
            this.cmbTerapia.Name = "cmbTerapia";
            this.cmbTerapia.Size = new System.Drawing.Size(376, 22);
            this.cmbTerapia.TabIndex = 24;
            this.cmbTerapia.SelectedIndexChanged += new System.EventHandler(this.cmbTerapia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Terapeuta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(85, 69);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpleado.TabIndex = 26;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sala";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(85, 125);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(376, 22);
            this.cmbSala.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 31;
            this.label6.Text = "Estado";
            // 
            // cmbEstadoCita
            // 
            this.cmbEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCita.FormattingEnabled = true;
            this.cmbEstadoCita.Location = new System.Drawing.Point(85, 153);
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
            this.txtDuracion.Location = new System.Drawing.Point(85, 181);
            this.txtDuracion.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(136, 22);
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
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Duración";
            // 
            // chkPresencial
            // 
            this.chkPresencial.AutoSize = true;
            this.chkPresencial.Location = new System.Drawing.Point(382, 17);
            this.chkPresencial.Name = "chkPresencial";
            this.chkPresencial.Size = new System.Drawing.Size(79, 18);
            this.chkPresencial.TabIndex = 34;
            this.chkPresencial.Text = "Presencial";
            this.chkPresencial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDuracion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkPresencial);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btPacienteExaminar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTerapia);
            this.groupBox1.Controls.Add(this.cmbEstadoCita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEmpleado);
            this.groupBox1.Controls.Add(this.cmbSala);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 222);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cita";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDomingo);
            this.groupBox2.Controls.Add(this.dateFechaFin);
            this.groupBox2.Controls.Add(this.chkSabado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chkViernes);
            this.groupBox2.Controls.Add(this.dateFechaInicio);
            this.groupBox2.Controls.Add(this.chkJueves);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkMiercoles);
            this.groupBox2.Controls.Add(this.txtCadaSemana);
            this.groupBox2.Controls.Add(this.chkMartes);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.chkLunes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 143);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programación";
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(247, 116);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(73, 18);
            this.chkDomingo.TabIndex = 46;
            this.chkDomingo.Text = "domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dateFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaFin.Location = new System.Drawing.Point(325, 21);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(136, 22);
            this.dateFechaFin.TabIndex = 36;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(167, 116);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(64, 18);
            this.chkSabado.TabIndex = 45;
            this.chkSabado.Text = "sabado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 14);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha Fin";
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(84, 116);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(64, 18);
            this.chkViernes.TabIndex = 44;
            this.chkViernes.Text = "viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(329, 92);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(61, 18);
            this.chkJueves.TabIndex = 43;
            this.chkJueves.Text = "jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(247, 92);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(76, 18);
            this.chkMiercoles.TabIndex = 42;
            this.chkMiercoles.Text = "miercoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // txtCadaSemana
            // 
            this.txtCadaSemana.Location = new System.Drawing.Point(85, 63);
            this.txtCadaSemana.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCadaSemana.Name = "txtCadaSemana";
            this.txtCadaSemana.Size = new System.Drawing.Size(136, 22);
            this.txtCadaSemana.TabIndex = 37;
            this.txtCadaSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCadaSemana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(167, 92);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(63, 18);
            this.chkMartes.TabIndex = 41;
            this.chkMartes.Text = "martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 14);
            this.label10.TabIndex = 38;
            this.label10.Text = "Cada";
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(85, 92);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(54, 18);
            this.chkLunes.TabIndex = 40;
            this.chkLunes.Text = "lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "semanas, el:";
            // 
            // frmEditProgramada
            // 
            this.ClientSize = new System.Drawing.Size(499, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditProgramada";
            this.Text = "Cita";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCadaSemana)).EndInit();
            this.ResumeLayout(false);

        }

        private void btPacienteExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.frmQuery vVen = new gesClinica.app.pc.frm.paciente.frmQuery();
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
                    frmEditProgramada frm = this;
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
                    ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
                    frmEditProgramada frm = this;
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
                ctrl.ctrlEditProgramada ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditProgramada();
                frmEditProgramada frm = this;
                ctrl.cargarTerapias(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
