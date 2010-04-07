using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion
{
    class frmEditConfiguracionCita: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbEstadoCita;

        public frmEditConfiguracionCita()
        {
            InitializeComponent();

            ctrl.ctrlEditConfiguracionCita ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionCita();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, this.InnerVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditConfiguracionCita ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionCita();
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
            this.cmbEstadoCita = new System.Windows.Forms.ComboBox();
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
            this.label6.Location = new System.Drawing.Point(33, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "Estado";
            // 
            // cmbEstadoCita
            // 
            this.cmbEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCita.FormattingEnabled = true;
            this.cmbEstadoCita.Location = new System.Drawing.Point(106, 49);
            this.cmbEstadoCita.Name = "cmbEstadoCita";
            this.cmbEstadoCita.Size = new System.Drawing.Size(376, 22);
            this.cmbEstadoCita.TabIndex = 32;
            // 
            // frmEditConfiguracion
            // 
            this.ClientSize = new System.Drawing.Size(516, 152);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstadoCita);
            this.Name = "frmEditConfiguracion";
            this.Text = "Configuracion - Cita";
            this.Load += new System.EventHandler(this.frmconfiguracionEditConfiguracion_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.cmbEstadoCita, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmconfiguracionEditConfiguracion_Load(object sender, EventArgs e)
        {
            this.Text = "Configuracion - Cita";
        }
    }
}
