using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion
{
    class frmEditConfiguracionContabilidad: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbRazonSocial;

        public frmEditConfiguracionContabilidad()
        {
            InitializeComponent();

            ctrl.ctrlEditConfiguracionContabilidad ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionContabilidad();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, this.InnerVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditConfiguracionContabilidad ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionContabilidad();
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "Razon Social";
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(106, 49);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(376, 22);
            this.cmbRazonSocial.TabIndex = 32;
            // 
            // frmEditConfiguracionContabilidad
            // 
            this.ClientSize = new System.Drawing.Size(516, 152);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRazonSocial);
            this.Name = "frmEditConfiguracionContabilidad";
            this.Text = "Configuracion - Contabilidad";
            this.Load += new System.EventHandler(this.frmconfiguracionEditConfiguracion_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.cmbRazonSocial, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmconfiguracionEditConfiguracion_Load(object sender, EventArgs e)
        {
            this.Text = "Configuracion - Contabilidad";
        }
    }
}
