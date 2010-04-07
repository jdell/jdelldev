using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion
{
    class frmEditConfiguracionPago: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbFormaPago;

        public frmEditConfiguracionPago()
        {
            InitializeComponent();

            ctrl.ctrlEditConfiguracionPago ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionPago();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, this.InnerVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditConfiguracionPago ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionPago();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(349, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(429, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 109);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 58;
            this.label1.Text = "F. Pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(113, 43);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(376, 22);
            this.cmbFormaPago.TabIndex = 57;
            // 
            // frmEditConfiguracionPago
            // 
            this.ClientSize = new System.Drawing.Size(516, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFormaPago);
            this.Name = "frmEditConfiguracionPago";
            this.Text = "Configuracion - Pago";
            this.Load += new System.EventHandler(this.frmconfiguracionEditConfiguracion_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.cmbFormaPago, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmconfiguracionEditConfiguracion_Load(object sender, EventArgs e)
        {
            this.Text = "Configuracion - Pago";
        }
    }
}
