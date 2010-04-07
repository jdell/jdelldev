using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion
{
    class frmEditOperacionPaciente: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDebe;
        internal System.Windows.Forms.Label labDescripcion;
        internal repsol.forms.controls.TextBoxColor txtHaber;
        internal System.Windows.Forms.Label labPago;
        internal System.Windows.Forms.Label labIngreso;

        public frmEditOperacionPaciente(tTIPOOPERACION tipo, DateTime fecha)
        {
            InitializeComponent();

            ctrl.ctrlEditOperacionPaciente ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditOperacionPaciente();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Operacion(tipo, fecha));
        }
        public frmEditOperacionPaciente(Cita cita)
        {
            InitializeComponent();

            ctrl.ctrlEditOperacionPaciente ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditOperacionPaciente();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Operacion(cita));
        }
        public frmEditOperacionPaciente(Operacion objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditOperacionPaciente ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditOperacionPaciente();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditOperacionPaciente(Operacion objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEditOperacionPaciente ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditOperacionPaciente();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditOperacionPaciente ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlEditOperacionPaciente();
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
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(216, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(296, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 139);
            this.panFooter.Size = new System.Drawing.Size(383, 43);
            this.panFooter.TabIndex = 2;
            // 
            // txtDebe
            // 
            this.txtDebe.ActivateStyle = true;
            this.txtDebe.BackColor = System.Drawing.Color.White;
            this.txtDebe.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDebe.ColorLeave = System.Drawing.Color.White;
            this.txtDebe.Location = new System.Drawing.Point(139, 75);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(166, 22);
            this.txtDebe.TabIndex = 1;
            this.txtDebe.Text = "0";
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDebe.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtDebe.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // labIngreso
            // 
            this.labIngreso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIngreso.Location = new System.Drawing.Point(15, 75);
            this.labIngreso.Name = "labIngreso";
            this.labIngreso.Size = new System.Drawing.Size(118, 17);
            this.labIngreso.TabIndex = 17;
            this.labIngreso.Text = "Ingresos :";
            this.labIngreso.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labDescripcion
            // 
            this.labDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labDescripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labDescripcion.Location = new System.Drawing.Point(0, 0);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(383, 23);
            this.labDescripcion.TabIndex = 39;
            this.labDescripcion.Text = "labDescripcion";
            // 
            // txtHaber
            // 
            this.txtHaber.ActivateStyle = true;
            this.txtHaber.BackColor = System.Drawing.Color.White;
            this.txtHaber.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtHaber.ColorLeave = System.Drawing.Color.White;
            this.txtHaber.Location = new System.Drawing.Point(139, 47);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(166, 22);
            this.txtHaber.TabIndex = 0;
            this.txtHaber.Text = "0";
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHaber.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtHaber.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // labPago
            // 
            this.labPago.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPago.Location = new System.Drawing.Point(12, 50);
            this.labPago.Name = "labPago";
            this.labPago.Size = new System.Drawing.Size(121, 14);
            this.labPago.TabIndex = 41;
            this.labPago.Text = "Pagos :";
            this.labPago.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmEditOperacionPaciente
            // 
            this.ClientSize = new System.Drawing.Size(383, 182);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.labPago);
            this.Controls.Add(this.labDescripcion);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.labIngreso);
            this.Name = "frmEditOperacionPaciente";
            this.Text = "Operacion";
            this.Load += new System.EventHandler(this.frmoperacionEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.labIngreso, 0);
            this.Controls.SetChildIndex(this.txtDebe, 0);
            this.Controls.SetChildIndex(this.labDescripcion, 0);
            this.Controls.SetChildIndex(this.labPago, 0);
            this.Controls.SetChildIndex(this.txtHaber, 0);
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
    }
}
