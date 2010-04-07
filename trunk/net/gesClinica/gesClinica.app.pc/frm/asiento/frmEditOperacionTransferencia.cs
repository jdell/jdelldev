using System;
using System.Collections.Generic;
using System.Text;

using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditOperacionTransferencia:frmEditParentOperacionesContables
    {
        public frmEditOperacionTransferencia():base()
        {
           // InitializeComponent();

            ctrl.ctrlEditOperacionTransferencia ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditOperacionTransferencia();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Asiento());
        }
        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditOperacionTransferencia ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditOperacionTransferencia();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                //base.btAceptar_Click(sender, e);
                this.btAceptar.Enabled = false;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSubcuentaDebe
            // 
            this.cmbSubcuentaDebe.Size = new System.Drawing.Size(335, 22);
            // 
            // cmbSubcuentaHaber
            // 
            this.cmbSubcuentaHaber.Size = new System.Drawing.Size(335, 22);
            // 
            // frmEditOperacionTransferencia
            // 
            this.ClientSize = new System.Drawing.Size(447, 241);
            this.Name = "frmEditOperacionTransferencia";
            this.Text = "Asiento - Nuevo registro - Nuevo registro";
            this.Load += new System.EventHandler(this.frmEditOperacionTransferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEditOperacionTransferencia_Load(object sender, EventArgs e)
        {
            this.Text = "Operación Contable - Transferencia";
        }
    }
}
