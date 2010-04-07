using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.extpaciente
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtPaciente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        private System.Windows.Forms.Label label11;
        internal repsol.forms.controls.TextBoxColor txtAnticonceptivos;
        private System.Windows.Forms.Label label10;
        internal repsol.forms.controls.TextBoxColor txtTratamientosHormonales;
        private System.Windows.Forms.Label label9;
        internal repsol.forms.controls.TextBoxColor txtDispareunemia;
        private System.Windows.Forms.Label label8;
        internal repsol.forms.controls.TextBoxColor txtReglaFrecuencia;
        internal repsol.forms.controls.TextBoxColor txtReglaDuracion;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtCesareas;
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
        private System.Windows.Forms.Label label2;
        internal repsol.forms.controls.TextBoxColor txtMenarquia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;

        public frmEdit(ExtPaciente objVO, Paciente paciente)
        {
            InitializeComponent();

            _paciente = paciente;
            
            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.extpaciente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);            
        }
        private Paciente _paciente;

        public Paciente Paciente
        {
            get { return _paciente; }
        }


        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.extpaciente.ctrl.ctrlEdit();
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
            this.txtPaciente = new repsol.forms.controls.TextBoxColor();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMenarquia = new repsol.forms.controls.TextBoxColor();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btAceptar.Location = new System.Drawing.Point(531, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCancelar.Location = new System.Drawing.Point(612, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 402);
            this.panFooter.Size = new System.Drawing.Size(699, 43);
            this.panFooter.TabIndex = 17;
            // 
            // txtPaciente
            // 
            this.txtPaciente.ActivateStyle = false;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPaciente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPaciente.ColorLeave = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(184, 39);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(476, 22);
            this.txtPaciente.TabIndex = 0;
            this.txtPaciente.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 14);
            this.label14.TabIndex = 80;
            this.label14.Text = "Paciente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(244, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 14);
            this.label16.TabIndex = 112;
            this.label16.Text = "/";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(322, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 14);
            this.label15.TabIndex = 111;
            this.label15.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 14);
            this.label1.TabIndex = 110;
            this.label1.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(589, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 14);
            this.label13.TabIndex = 109;
            this.label13.Text = "/";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 14);
            this.label12.TabIndex = 108;
            this.label12.Text = "/";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(185, 291);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(476, 87);
            this.txtObservaciones.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 14);
            this.label11.TabIndex = 106;
            this.label11.Text = "Observaciones";
            // 
            // txtAnticonceptivos
            // 
            this.txtAnticonceptivos.ActivateStyle = true;
            this.txtAnticonceptivos.BackColor = System.Drawing.Color.White;
            this.txtAnticonceptivos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAnticonceptivos.ColorLeave = System.Drawing.Color.White;
            this.txtAnticonceptivos.Location = new System.Drawing.Point(185, 263);
            this.txtAnticonceptivos.Name = "txtAnticonceptivos";
            this.txtAnticonceptivos.Size = new System.Drawing.Size(476, 22);
            this.txtAnticonceptivos.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 14);
            this.label10.TabIndex = 104;
            this.label10.Text = "Anticonceptivos";
            // 
            // txtTratamientosHormonales
            // 
            this.txtTratamientosHormonales.ActivateStyle = true;
            this.txtTratamientosHormonales.BackColor = System.Drawing.Color.White;
            this.txtTratamientosHormonales.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTratamientosHormonales.ColorLeave = System.Drawing.Color.White;
            this.txtTratamientosHormonales.Location = new System.Drawing.Point(185, 235);
            this.txtTratamientosHormonales.Name = "txtTratamientosHormonales";
            this.txtTratamientosHormonales.Size = new System.Drawing.Size(476, 22);
            this.txtTratamientosHormonales.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 14);
            this.label9.TabIndex = 102;
            this.label9.Text = "Tratamientos Hormonales";
            // 
            // txtDispareunemia
            // 
            this.txtDispareunemia.ActivateStyle = true;
            this.txtDispareunemia.BackColor = System.Drawing.Color.White;
            this.txtDispareunemia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDispareunemia.ColorLeave = System.Drawing.Color.White;
            this.txtDispareunemia.Location = new System.Drawing.Point(530, 95);
            this.txtDispareunemia.Name = "txtDispareunemia";
            this.txtDispareunemia.Size = new System.Drawing.Size(131, 22);
            this.txtDispareunemia.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 14);
            this.label8.TabIndex = 100;
            this.label8.Text = "Dispareunemia";
            // 
            // txtReglaFrecuencia
            // 
            this.txtReglaFrecuencia.ActivateStyle = true;
            this.txtReglaFrecuencia.BackColor = System.Drawing.Color.White;
            this.txtReglaFrecuencia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReglaFrecuencia.ColorLeave = System.Drawing.Color.White;
            this.txtReglaFrecuencia.Location = new System.Drawing.Point(607, 67);
            this.txtReglaFrecuencia.Name = "txtReglaFrecuencia";
            this.txtReglaFrecuencia.Size = new System.Drawing.Size(54, 22);
            this.txtReglaFrecuencia.TabIndex = 4;
            this.txtReglaFrecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReglaFrecuencia.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtReglaFrecuencia.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // txtReglaDuracion
            // 
            this.txtReglaDuracion.ActivateStyle = true;
            this.txtReglaDuracion.BackColor = System.Drawing.Color.White;
            this.txtReglaDuracion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtReglaDuracion.ColorLeave = System.Drawing.Color.White;
            this.txtReglaDuracion.Location = new System.Drawing.Point(530, 67);
            this.txtReglaDuracion.Name = "txtReglaDuracion";
            this.txtReglaDuracion.Size = new System.Drawing.Size(53, 22);
            this.txtReglaDuracion.TabIndex = 3;
            this.txtReglaDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReglaDuracion.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtReglaDuracion.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 14);
            this.label3.TabIndex = 98;
            this.label3.Text = "Ciclos Duración/Frecuencia";
            // 
            // txtCesareas
            // 
            this.txtCesareas.ActivateStyle = true;
            this.txtCesareas.BackColor = System.Drawing.Color.White;
            this.txtCesareas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCesareas.ColorLeave = System.Drawing.Color.White;
            this.txtCesareas.Location = new System.Drawing.Point(262, 207);
            this.txtCesareas.Name = "txtCesareas";
            this.txtCesareas.Size = new System.Drawing.Size(54, 22);
            this.txtCesareas.TabIndex = 13;
            this.txtCesareas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCesareas.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtCesareas.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // txtPartos
            // 
            this.txtPartos.ActivateStyle = true;
            this.txtPartos.BackColor = System.Drawing.Color.White;
            this.txtPartos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPartos.ColorLeave = System.Drawing.Color.White;
            this.txtPartos.Location = new System.Drawing.Point(185, 207);
            this.txtPartos.Name = "txtPartos";
            this.txtPartos.Size = new System.Drawing.Size(53, 22);
            this.txtPartos.TabIndex = 12;
            this.txtPartos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPartos.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtPartos.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // txtVivos
            // 
            this.txtVivos.ActivateStyle = true;
            this.txtVivos.BackColor = System.Drawing.Color.White;
            this.txtVivos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtVivos.ColorLeave = System.Drawing.Color.White;
            this.txtVivos.Location = new System.Drawing.Point(339, 179);
            this.txtVivos.Name = "txtVivos";
            this.txtVivos.Size = new System.Drawing.Size(54, 22);
            this.txtVivos.TabIndex = 11;
            this.txtVivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVivos.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtVivos.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // txtAbortos
            // 
            this.txtAbortos.ActivateStyle = true;
            this.txtAbortos.BackColor = System.Drawing.Color.White;
            this.txtAbortos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAbortos.ColorLeave = System.Drawing.Color.White;
            this.txtAbortos.Location = new System.Drawing.Point(262, 179);
            this.txtAbortos.Name = "txtAbortos";
            this.txtAbortos.Size = new System.Drawing.Size(54, 22);
            this.txtAbortos.TabIndex = 10;
            this.txtAbortos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAbortos.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtAbortos.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 93;
            this.label7.Text = "Partos/Cesareas";
            // 
            // txtGestaciones
            // 
            this.txtGestaciones.ActivateStyle = true;
            this.txtGestaciones.BackColor = System.Drawing.Color.White;
            this.txtGestaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtGestaciones.ColorLeave = System.Drawing.Color.White;
            this.txtGestaciones.Location = new System.Drawing.Point(185, 179);
            this.txtGestaciones.Name = "txtGestaciones";
            this.txtGestaciones.Size = new System.Drawing.Size(53, 22);
            this.txtGestaciones.TabIndex = 9;
            this.txtGestaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGestaciones.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtGestaciones.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 14);
            this.label6.TabIndex = 91;
            this.label6.Text = "Gestaciones/Abortos/Viv";
            // 
            // txtMolestiasPelvicas
            // 
            this.txtMolestiasPelvicas.ActivateStyle = true;
            this.txtMolestiasPelvicas.BackColor = System.Drawing.Color.White;
            this.txtMolestiasPelvicas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMolestiasPelvicas.ColorLeave = System.Drawing.Color.White;
            this.txtMolestiasPelvicas.Location = new System.Drawing.Point(185, 151);
            this.txtMolestiasPelvicas.Name = "txtMolestiasPelvicas";
            this.txtMolestiasPelvicas.Size = new System.Drawing.Size(476, 22);
            this.txtMolestiasPelvicas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 89;
            this.label5.Text = "Molestias Pélvicas";
            // 
            // txtSindromePremenstrual
            // 
            this.txtSindromePremenstrual.ActivateStyle = true;
            this.txtSindromePremenstrual.BackColor = System.Drawing.Color.White;
            this.txtSindromePremenstrual.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSindromePremenstrual.ColorLeave = System.Drawing.Color.White;
            this.txtSindromePremenstrual.Location = new System.Drawing.Point(185, 123);
            this.txtSindromePremenstrual.Name = "txtSindromePremenstrual";
            this.txtSindromePremenstrual.Size = new System.Drawing.Size(131, 22);
            this.txtSindromePremenstrual.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 14);
            this.label4.TabIndex = 87;
            this.label4.Text = "Síndrome Premenstrual";
            // 
            // txtDismenorrea
            // 
            this.txtDismenorrea.ActivateStyle = true;
            this.txtDismenorrea.BackColor = System.Drawing.Color.White;
            this.txtDismenorrea.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDismenorrea.ColorLeave = System.Drawing.Color.White;
            this.txtDismenorrea.Location = new System.Drawing.Point(185, 95);
            this.txtDismenorrea.Name = "txtDismenorrea";
            this.txtDismenorrea.Size = new System.Drawing.Size(131, 22);
            this.txtDismenorrea.TabIndex = 5;
            // 
            // txtMenopausia
            // 
            this.txtMenopausia.ActivateStyle = true;
            this.txtMenopausia.BackColor = System.Drawing.Color.White;
            this.txtMenopausia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMenopausia.ColorLeave = System.Drawing.Color.White;
            this.txtMenopausia.Location = new System.Drawing.Point(262, 67);
            this.txtMenopausia.Name = "txtMenopausia";
            this.txtMenopausia.Size = new System.Drawing.Size(54, 22);
            this.txtMenopausia.TabIndex = 2;
            this.txtMenopausia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMenopausia.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtMenopausia.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 84;
            this.label2.Text = "Dismenorrea";
            // 
            // txtMenarquia
            // 
            this.txtMenarquia.ActivateStyle = true;
            this.txtMenarquia.BackColor = System.Drawing.Color.White;
            this.txtMenarquia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMenarquia.ColorLeave = System.Drawing.Color.White;
            this.txtMenarquia.Location = new System.Drawing.Point(185, 67);
            this.txtMenarquia.Name = "txtMenarquia";
            this.txtMenarquia.Size = new System.Drawing.Size(53, 22);
            this.txtMenarquia.TabIndex = 1;
            this.txtMenarquia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMenarquia.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtMenarquia.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 14);
            this.label17.TabIndex = 82;
            this.label17.Text = "Menarquia/Menopausia";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(699, 445);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAnticonceptivos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTratamientosHormonales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDispareunemia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReglaFrecuencia);
            this.Controls.Add(this.txtReglaDuracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCesareas);
            this.Controls.Add(this.txtPartos);
            this.Controls.Add(this.txtVivos);
            this.Controls.Add(this.txtAbortos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGestaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMolestiasPelvicas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSindromePremenstrual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDismenorrea);
            this.Controls.Add(this.txtMenopausia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMenarquia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label14);
            this.Name = "frmEdit";
            this.Text = "Datos Ginecológicos";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtPaciente, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtMenarquia, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMenopausia, 0);
            this.Controls.SetChildIndex(this.txtDismenorrea, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSindromePremenstrual, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtMolestiasPelvicas, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtGestaciones, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtAbortos, 0);
            this.Controls.SetChildIndex(this.txtVivos, 0);
            this.Controls.SetChildIndex(this.txtPartos, 0);
            this.Controls.SetChildIndex(this.txtCesareas, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtReglaDuracion, 0);
            this.Controls.SetChildIndex(this.txtReglaFrecuencia, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtDispareunemia, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtTratamientosHormonales, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtAnticonceptivos, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtObservaciones, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtInt32_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

                if (!String.IsNullOrEmpty(txt.Text))
                {
                    int valor;
                    if (!int.TryParse(txt.Text, out valor))
                    {
                        e.Cancel = true;
                        System.Windows.Forms.MessageBox.Show("Formato numérico incorrecto!", this.Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtInt32_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

                if (String.IsNullOrEmpty(txt.Text)) txt.Text = "0";
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Datos Ginecológicos";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
