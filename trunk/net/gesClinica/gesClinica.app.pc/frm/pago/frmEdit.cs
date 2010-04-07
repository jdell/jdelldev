using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.pago
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtNotas;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbFormaPago;
        internal repsol.forms.controls.TextBoxColor txtDebe;
        internal System.Windows.Forms.Label labIngreso;

        private lib.vo.Operacion _operacion;

        public lib.vo.Operacion Operacion
        {
            get { return _operacion; }
        }

        public frmEdit(Operacion operacion)
        {
            InitializeComponent();

            _operacion = operacion;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.pago.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Pago(operacion));
        }
        public frmEdit(Pago objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.pago.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Pago objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.pago.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.pago.ctrl.ctrlEdit();
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
            this.txtNotas = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.txtDebe = new repsol.forms.controls.TextBoxColor();
            this.labIngreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(363, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(443, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 216);
            this.panFooter.Size = new System.Drawing.Size(530, 43);
            this.panFooter.TabIndex = 2;
            // 
            // txtNotas
            // 
            this.txtNotas.ActivateStyle = true;
            this.txtNotas.BackColor = System.Drawing.Color.White;
            this.txtNotas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNotas.ColorLeave = System.Drawing.Color.White;
            this.txtNotas.Location = new System.Drawing.Point(30, 120);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotas.Size = new System.Drawing.Size(459, 70);
            this.txtNotas.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Observaciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = "F. Pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(113, 39);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(376, 22);
            this.cmbFormaPago.TabIndex = 3;
            // 
            // txtDebe
            // 
            this.txtDebe.ActivateStyle = true;
            this.txtDebe.BackColor = System.Drawing.Color.White;
            this.txtDebe.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDebe.ColorLeave = System.Drawing.Color.White;
            this.txtDebe.Location = new System.Drawing.Point(113, 67);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(166, 22);
            this.txtDebe.TabIndex = 0;
            this.txtDebe.Text = "0";
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDebe.Validated += new System.EventHandler(this.txtNumerico_Validated);
            this.txtDebe.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumerico_Validating);
            // 
            // labIngreso
            // 
            this.labIngreso.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIngreso.Location = new System.Drawing.Point(27, 70);
            this.labIngreso.Name = "labIngreso";
            this.labIngreso.Size = new System.Drawing.Size(70, 17);
            this.labIngreso.TabIndex = 54;
            this.labIngreso.Text = "Ingresos";
            this.labIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(530, 259);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.labIngreso);
            this.Name = "frmEdit";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.frmpagoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.labIngreso, 0);
            this.Controls.SetChildIndex(this.txtDebe, 0);
            this.Controls.SetChildIndex(this.cmbFormaPago, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNotas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmpagoEdit_Load(object sender, EventArgs e)
        {
            this.txtDebe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
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
