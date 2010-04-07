using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._imprimirfacturas
{
    class frmImprimirFacturas:template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        internal repsol.forms.controls.TextBoxColor txtNumeroDesde;
        private System.Windows.Forms.Label label5;
        internal repsol.forms.controls.TextBoxColor txtNumeroHasta;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbEjercicio;

        public frmImprimirFacturas()
        {
            InitializeComponent();
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlImprimirFacturas ctrl = new gesClinica.app.pc.frm._imprimirfacturas.ctrl.ctrlImprimirFacturas();
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
            this.txtNumeroDesde = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroHasta = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(340, 11);
            this.btAceptar.Text = "Imprimir";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(420, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 178);
            this.panFooter.Size = new System.Drawing.Size(507, 43);
            this.panFooter.TabIndex = 4;
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
            // txtNumeroDesde
            // 
            this.txtNumeroDesde.ActivateStyle = true;
            this.txtNumeroDesde.BackColor = System.Drawing.Color.White;
            this.txtNumeroDesde.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNumeroDesde.ColorLeave = System.Drawing.Color.White;
            this.txtNumeroDesde.Location = new System.Drawing.Point(102, 103);
            this.txtNumeroDesde.Name = "txtNumeroDesde";
            this.txtNumeroDesde.Size = new System.Drawing.Size(123, 22);
            this.txtNumeroDesde.TabIndex = 2;
            this.txtNumeroDesde.Text = "0";
            this.txtNumeroDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 49;
            this.label5.Text = "Desde";
            // 
            // txtNumeroHasta
            // 
            this.txtNumeroHasta.ActivateStyle = true;
            this.txtNumeroHasta.BackColor = System.Drawing.Color.White;
            this.txtNumeroHasta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNumeroHasta.ColorLeave = System.Drawing.Color.White;
            this.txtNumeroHasta.Location = new System.Drawing.Point(355, 103);
            this.txtNumeroHasta.Name = "txtNumeroHasta";
            this.txtNumeroHasta.Size = new System.Drawing.Size(123, 22);
            this.txtNumeroHasta.TabIndex = 3;
            this.txtNumeroHasta.Text = "0";
            this.txtNumeroHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hasta";
            // 
            // frmImprimirFacturas
            // 
            this.ClientSize = new System.Drawing.Size(507, 221);
            this.Controls.Add(this.txtNumeroDesde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEjercicio);
            this.Name = "frmImprimirFacturas";
            this.Text = "Imprimir Facturas";
            this.Load += new System.EventHandler(this.frmImprimirFacturas_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.cmbEjercicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbEmpresa, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNumeroHasta, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNumeroDesde, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmImprimirFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Imprimir facturas de pacientes";
                ctrl.ctrlImprimirFacturas ctrl = new gesClinica.app.pc.frm._imprimirfacturas.ctrl.ctrlImprimirFacturas();
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
                ctrl.ctrlImprimirFacturas ctrl = new gesClinica.app.pc.frm._imprimirfacturas.ctrl.ctrlImprimirFacturas();
                frmImprimirFacturas frm = (frmImprimirFacturas)this;
                ctrl.loadEjercicio(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
