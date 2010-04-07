using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.operacion._operacionpaciente
{
    class frmOperacionPacienteOpcion : template.frm.edicion.EditForm
    {
        internal System.Windows.Forms.RadioButton rbNuevoPago;
        internal System.Windows.Forms.RadioButton rbVerPagos;
        private System.Windows.Forms.Label label1;
    
        public frmOperacionPacienteOpcion()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rbNuevoPago = new System.Windows.Forms.RadioButton();
            this.rbVerPagos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(189, 11);
            this.btAceptar.Text = "Aceptar";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(269, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 145);
            this.panFooter.Size = new System.Drawing.Size(356, 43);
            // 
            // rbNuevoPago
            // 
            this.rbNuevoPago.AutoSize = true;
            this.rbNuevoPago.Checked = true;
            this.rbNuevoPago.Location = new System.Drawing.Point(70, 82);
            this.rbNuevoPago.Name = "rbNuevoPago";
            this.rbNuevoPago.Size = new System.Drawing.Size(91, 18);
            this.rbNuevoPago.TabIndex = 9;
            this.rbNuevoPago.TabStop = true;
            this.rbNuevoPago.Text = "Nuevo Pago";
            this.rbNuevoPago.UseVisualStyleBackColor = true;
            // 
            // rbVerPagos
            // 
            this.rbVerPagos.AutoSize = true;
            this.rbVerPagos.Location = new System.Drawing.Point(233, 82);
            this.rbVerPagos.Name = "rbVerPagos";
            this.rbVerPagos.Size = new System.Drawing.Size(80, 18);
            this.rbVerPagos.TabIndex = 10;
            this.rbVerPagos.TabStop = true;
            this.rbVerPagos.Text = "Ver Pagos";
            this.rbVerPagos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione una opción:";
            // 
            // frmOperacionPacienteOpcion
            // 
            this.ClientSize = new System.Drawing.Size(356, 188);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbVerPagos);
            this.Controls.Add(this.rbNuevoPago);
            this.Name = "frmOperacionPacienteOpcion";
            this.Text = "1";
            this.Load += new System.EventHandler(this.frmOperacionPacienteOpcion_Load);
            this.Controls.SetChildIndex(this.rbNuevoPago, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.rbVerPagos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmOperacionPacienteOpcion_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Empty;
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                this.btAceptar.Location = new System.Drawing.Point(189, 11);
                this.btCancelar.Location = new System.Drawing.Point(269, 11);
            }
            catch (Exception ex)
            {
                app.pc.template._common.messages.ShowError(ex);
            }
        }
        protected override void btCancelar_Click(object sender, EventArgs e)
        {
            //base.btCancelar_Click(sender, e);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
