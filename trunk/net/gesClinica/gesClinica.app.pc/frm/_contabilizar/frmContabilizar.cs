using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._contabilizar
{
    class frmContabilizar:template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        internal System.Windows.Forms.RadioButton rbContabilizar;
        internal System.Windows.Forms.RadioButton rbDescontabilizar;
        internal System.Windows.Forms.DateTimePicker dateFechaHasta;

        public frmContabilizar()
        {
            InitializeComponent();
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlContabilizar ctrl = new gesClinica.app.pc.frm._contabilizar.ctrl.ctrlContabilizar();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
                //base.btAceptar_Click(sender, e);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.rbContabilizar = new System.Windows.Forms.RadioButton();
            this.rbDescontabilizar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(284, 11);
            this.btAceptar.Text = "Ejecutar";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(364, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 179);
            this.panFooter.Size = new System.Drawing.Size(451, 43);
            this.panFooter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha desde";
            // 
            // dateFechaDesde
            // 
            this.dateFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dateFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaDesde.Location = new System.Drawing.Point(113, 60);
            this.dateFechaDesde.Name = "dateFechaDesde";
            this.dateFechaDesde.Size = new System.Drawing.Size(102, 22);
            this.dateFechaDesde.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha hasta";
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaHasta.Location = new System.Drawing.Point(318, 60);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.Size = new System.Drawing.Size(102, 22);
            this.dateFechaHasta.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Razon Social";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(113, 88);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(307, 22);
            this.cmbEmpresa.TabIndex = 38;
            // 
            // rbContabilizar
            // 
            this.rbContabilizar.AutoSize = true;
            this.rbContabilizar.Checked = true;
            this.rbContabilizar.Location = new System.Drawing.Point(227, 116);
            this.rbContabilizar.Name = "rbContabilizar";
            this.rbContabilizar.Size = new System.Drawing.Size(85, 18);
            this.rbContabilizar.TabIndex = 40;
            this.rbContabilizar.TabStop = true;
            this.rbContabilizar.Text = "Contabilizar";
            this.rbContabilizar.UseVisualStyleBackColor = true;
            // 
            // rbDescontabilizar
            // 
            this.rbDescontabilizar.AutoSize = true;
            this.rbDescontabilizar.Location = new System.Drawing.Point(318, 116);
            this.rbDescontabilizar.Name = "rbDescontabilizar";
            this.rbDescontabilizar.Size = new System.Drawing.Size(104, 18);
            this.rbDescontabilizar.TabIndex = 41;
            this.rbDescontabilizar.Text = "Descontabilizar";
            this.rbDescontabilizar.UseVisualStyleBackColor = true;
            // 
            // frmContabilizar
            // 
            this.ClientSize = new System.Drawing.Size(451, 222);
            this.Controls.Add(this.rbDescontabilizar);
            this.Controls.Add(this.rbContabilizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateFechaHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFechaDesde);
            this.Name = "frmContabilizar";
            this.Text = "Contabilizar/Descontabilizar facturas de pacientes";
            this.Load += new System.EventHandler(this.frmContabilizar_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.dateFechaDesde, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dateFechaHasta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbEmpresa, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.rbContabilizar, 0);
            this.Controls.SetChildIndex(this.rbDescontabilizar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmContabilizar_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Contabilizar/Descontabilizar facturas de pacientes";
                ctrl.ctrlContabilizar ctrl = new gesClinica.app.pc.frm._contabilizar.ctrl.ctrlContabilizar();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
