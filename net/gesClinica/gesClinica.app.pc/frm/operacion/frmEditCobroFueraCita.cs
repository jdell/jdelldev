using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion
{
    class frmEditCobroFueraCita: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDebe;
        internal System.Windows.Forms.Label labDescripcion;
        internal repsol.forms.controls.TextBoxColor txtHaber;
        internal System.Windows.Forms.Label labPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPacienteExaminar;
        internal repsol.forms.controls.TextBoxColor txtPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbFormaPago;
        internal System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtNotas;
        internal repsol.forms.controls.TextBoxColor txtSaldo;
        private System.Windows.Forms.Button btSaldoDetalle;
        internal System.Windows.Forms.Label labIngreso;

        public frmEditCobroFueraCita(tTIPOOPERACION tipo, DateTime fecha)
        {
            InitializeComponent();

            ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Operacion(tipo, fecha));
        }
        public frmEditCobroFueraCita(Empleado empleado)
        {
            InitializeComponent();

            ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Operacion(empleado));
        }
        public frmEditCobroFueraCita(Operacion objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditCobroFueraCita(Operacion objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
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
            this.txtDebe = new repsol.forms.controls.TextBoxColor();
            this.labIngreso = new System.Windows.Forms.Label();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.txtHaber = new repsol.forms.controls.TextBoxColor();
            this.labPago = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPacienteExaminar = new System.Windows.Forms.Button();
            this.txtPaciente = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotas = new repsol.forms.controls.TextBoxColor();
            this.txtSaldo = new repsol.forms.controls.TextBoxColor();
            this.btSaldoDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(345, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(425, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 279);
            this.panFooter.Size = new System.Drawing.Size(492, 43);
            this.panFooter.TabIndex = 6;
            // 
            // txtDebe
            // 
            this.txtDebe.ActivateStyle = true;
            this.txtDebe.BackColor = System.Drawing.Color.White;
            this.txtDebe.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDebe.ColorLeave = System.Drawing.Color.White;
            this.txtDebe.Location = new System.Drawing.Point(102, 142);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(166, 22);
            this.txtDebe.TabIndex = 3;
            this.txtDebe.Text = "0";
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDebe.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtDebe.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // labIngreso
            // 
            this.labIngreso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIngreso.Location = new System.Drawing.Point(16, 145);
            this.labIngreso.Name = "labIngreso";
            this.labIngreso.Size = new System.Drawing.Size(70, 17);
            this.labIngreso.TabIndex = 17;
            this.labIngreso.Text = "Ingresos";
            this.labIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDescripcion
            // 
            this.labDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labDescripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labDescripcion.Location = new System.Drawing.Point(0, 0);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(492, 23);
            this.labDescripcion.TabIndex = 39;
            this.labDescripcion.Text = "labDescripcion";
            // 
            // txtHaber
            // 
            this.txtHaber.ActivateStyle = true;
            this.txtHaber.BackColor = System.Drawing.Color.White;
            this.txtHaber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtHaber.ColorLeave = System.Drawing.Color.White;
            this.txtHaber.Location = new System.Drawing.Point(312, 145);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(166, 22);
            this.txtHaber.TabIndex = 4;
            this.txtHaber.Text = "0";
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHaber.Visible = false;
            this.txtHaber.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtHaber.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // labPago
            // 
            this.labPago.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPago.Location = new System.Drawing.Point(309, 139);
            this.labPago.Name = "labPago";
            this.labPago.Size = new System.Drawing.Size(73, 14);
            this.labPago.TabIndex = 41;
            this.labPago.Text = "Pagos";
            this.labPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labPago.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 43;
            this.label3.Text = "Saldo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btPacienteExaminar
            // 
            this.btPacienteExaminar.Location = new System.Drawing.Point(447, 58);
            this.btPacienteExaminar.Name = "btPacienteExaminar";
            this.btPacienteExaminar.Size = new System.Drawing.Size(31, 22);
            this.btPacienteExaminar.TabIndex = 0;
            this.btPacienteExaminar.Text = "...";
            this.btPacienteExaminar.UseVisualStyleBackColor = true;
            this.btPacienteExaminar.Click += new System.EventHandler(this.btPacienteExaminar_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.ActivateStyle = false;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaciente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPaciente.ColorLeave = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(102, 58);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(339, 22);
            this.txtPaciente.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 45;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "F. Pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(102, 114);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(376, 22);
            this.cmbFormaPago.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Observaciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNotas
            // 
            this.txtNotas.ActivateStyle = true;
            this.txtNotas.BackColor = System.Drawing.Color.White;
            this.txtNotas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNotas.ColorLeave = System.Drawing.Color.White;
            this.txtNotas.Location = new System.Drawing.Point(19, 195);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotas.Size = new System.Drawing.Size(459, 70);
            this.txtNotas.TabIndex = 5;
            // 
            // txtSaldo
            // 
            this.txtSaldo.ActivateStyle = false;
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSaldo.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSaldo.ColorLeave = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(102, 86);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(129, 22);
            this.txtSaldo.TabIndex = 50;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btSaldoDetalle
            // 
            this.btSaldoDetalle.Location = new System.Drawing.Point(237, 85);
            this.btSaldoDetalle.Name = "btSaldoDetalle";
            this.btSaldoDetalle.Size = new System.Drawing.Size(31, 22);
            this.btSaldoDetalle.TabIndex = 51;
            this.btSaldoDetalle.Text = "...";
            this.btSaldoDetalle.UseVisualStyleBackColor = true;
            this.btSaldoDetalle.Click += new System.EventHandler(this.btSaldoDetalle_Click);
            // 
            // frmEditCobroFueraCita
            // 
            this.ClientSize = new System.Drawing.Size(492, 322);
            this.Controls.Add(this.btSaldoDetalle);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.btPacienteExaminar);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.labPago);
            this.Controls.Add(this.labDescripcion);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.labIngreso);
            this.Name = "frmEditCobroFueraCita";
            this.Text = "Operacion";
            this.Load += new System.EventHandler(this.frmoperacionEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.labIngreso, 0);
            this.Controls.SetChildIndex(this.txtDebe, 0);
            this.Controls.SetChildIndex(this.labDescripcion, 0);
            this.Controls.SetChildIndex(this.labPago, 0);
            this.Controls.SetChildIndex(this.txtHaber, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPaciente, 0);
            this.Controls.SetChildIndex(this.btPacienteExaminar, 0);
            this.Controls.SetChildIndex(this.cmbFormaPago, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNotas, 0);
            this.Controls.SetChildIndex(this.txtSaldo, 0);
            this.Controls.SetChildIndex(this.btSaldoDetalle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmoperacionEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Caja : Cobros y Pagos";
                this.txtDebe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
                this.txtHaber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
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

        private void btPacienteExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.frmQuery vVen = new gesClinica.app.pc.frm.paciente.frmQuery();
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
                    frmEditCobroFueraCita frm = this;
                    ctrl.setPaciente(ref frm, (Paciente)vVen.SelectedVO);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btSaldoDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditCobroFueraCita ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditCobroFueraCita();
                frmEditCobroFueraCita frm = this;
                if (ctrl.getPaciente(frm) == null)
                {
                    template._common.messages.ShowWarning("Debe seleccionar un paciente", this.Text);
                    return;
                }

                _detallesaldo.frmDetalleSaldo vVen = new gesClinica.app.pc.frm.operacion._detallesaldo.frmDetalleSaldo(ctrl.getPaciente(frm));
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
