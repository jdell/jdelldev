using System;
using System.Collections.Generic;
using System.Text;

using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditOperacionGastoConPago:frmEditParentOperacionesContables
    {
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.ComboBox cmbMedio;
    
        public frmEditOperacionGastoConPago()
            : base()
        {
            InitializeComponent();

            ctrl.ctrlEditOperacionGastoConPago ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditOperacionGastoConPago();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Asiento());
        }
        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditOperacionGastoConPago ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditOperacionGastoConPago();
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedio = new System.Windows.Forms.ComboBox();
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
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(90, 166);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 169);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 206);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 65;
            this.label3.Text = "Medio";
            // 
            // cmbMedio
            // 
            this.cmbMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedio.FormattingEnabled = true;
            this.cmbMedio.Location = new System.Drawing.Point(90, 138);
            this.cmbMedio.Name = "cmbMedio";
            this.cmbMedio.Size = new System.Drawing.Size(335, 22);
            this.cmbMedio.TabIndex = 64;
            // 
            // frmEditOperacionGastoConPago
            // 
            this.ClientSize = new System.Drawing.Size(447, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMedio);
            this.Name = "frmEditOperacionGastoConPago";
            this.Text = "Asiento - Nuevo registro - Nuevo registro";
            this.Load += new System.EventHandler(this.frmEditOperacionGastoConPago_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.dateFecha, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbSubcuentaHaber, 0);
            this.Controls.SetChildIndex(this.labLabelUno, 0);
            this.Controls.SetChildIndex(this.cmbSubcuentaDebe, 0);
            this.Controls.SetChildIndex(this.labLabelDos, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbMedio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEditOperacionGastoConPago_Load(object sender, EventArgs e)
        {
            this.Text = "Operación Contable - Gasto con Pago";

            this.cmbMedio.SelectedIndexChanged += new EventHandler(algoCambio);
        }
    }
}
