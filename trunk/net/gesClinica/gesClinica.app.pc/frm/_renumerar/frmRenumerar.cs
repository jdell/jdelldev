using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._renumerar
{
    class frmRenumerar:template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton rbFacturasRecibidas;
        internal System.Windows.Forms.RadioButton rbAsientos;
        internal System.Windows.Forms.ComboBox cmbEjercicio;

        public frmRenumerar()
        {
            InitializeComponent();
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlRenumerar ctrl = new gesClinica.app.pc.frm._renumerar.ctrl.ctrlRenumerar();
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
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFacturasRecibidas = new System.Windows.Forms.RadioButton();
            this.rbAsientos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(340, 11);
            this.btAceptar.Text = "Renumerar";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(420, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 178);
            this.panFooter.Size = new System.Drawing.Size(507, 43);
            this.panFooter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(102, 47);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpresa.TabIndex = 0;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ejercicio";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(102, 75);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(376, 22);
            this.cmbEjercicio.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFacturasRecibidas);
            this.groupBox1.Controls.Add(this.rbAsientos);
            this.groupBox1.Location = new System.Drawing.Point(32, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 49);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renumerar";
            // 
            // rbFacturasRecibidas
            // 
            this.rbFacturasRecibidas.AutoSize = true;
            this.rbFacturasRecibidas.Location = new System.Drawing.Point(278, 21);
            this.rbFacturasRecibidas.Name = "rbFacturasRecibidas";
            this.rbFacturasRecibidas.Size = new System.Drawing.Size(123, 18);
            this.rbFacturasRecibidas.TabIndex = 1;
            this.rbFacturasRecibidas.Text = "Facturas Recibidas";
            this.rbFacturasRecibidas.UseVisualStyleBackColor = true;
            // 
            // rbAsientos
            // 
            this.rbAsientos.AutoSize = true;
            this.rbAsientos.Checked = true;
            this.rbAsientos.Location = new System.Drawing.Point(86, 21);
            this.rbAsientos.Name = "rbAsientos";
            this.rbAsientos.Size = new System.Drawing.Size(71, 18);
            this.rbAsientos.TabIndex = 0;
            this.rbAsientos.TabStop = true;
            this.rbAsientos.Text = "Asientos";
            this.rbAsientos.UseVisualStyleBackColor = true;
            // 
            // frmRenumerar
            // 
            this.ClientSize = new System.Drawing.Size(507, 221);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEjercicio);
            this.Name = "frmRenumerar";
            this.Text = "Renumeración";
            this.Load += new System.EventHandler(this.frmRenumerar_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.cmbEjercicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbEmpresa, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmRenumerar_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Imprimir facturas de pacientes";
                ctrl.ctrlRenumerar ctrl = new gesClinica.app.pc.frm._renumerar.ctrl.ctrlRenumerar();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void importe_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (!String.IsNullOrEmpty(textBox.Text))
                {
                    int importe;
                    if (!int.TryParse(textBox.Text, out importe))
                    {
                        e.Cancel = true;
                        template._common.messages.ShowWarning("Formato numérico incorrecto.", "Validación");
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void importe_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (String.IsNullOrEmpty(textBox.Text))
                    textBox.Text = "0";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlRenumerar ctrl = new gesClinica.app.pc.frm._renumerar.ctrl.ctrlRenumerar();
                frmRenumerar frm = (frmRenumerar)this;
                ctrl.loadEjercicio(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
