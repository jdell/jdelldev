using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._aperturacierre
{
    class frmAperturaCierre:template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton rbCerrar;
        internal System.Windows.Forms.RadioButton rbCierreApertura;
        internal System.Windows.Forms.RadioButton rbApertura;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        internal System.Windows.Forms.ComboBox cmbEjercicio;

        public frmAperturaCierre()
        {
            InitializeComponent();
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlAperturaCierre ctrl = new gesClinica.app.pc.frm._aperturacierre.ctrl.ctrlAperturaCierre();
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCierreApertura = new System.Windows.Forms.RadioButton();
            this.rbApertura = new System.Windows.Forms.RadioButton();
            this.rbCerrar = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(340, 11);
            this.btAceptar.Text = "Ejecutar";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(420, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 180);
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
            this.groupBox1.Controls.Add(this.rbCierreApertura);
            this.groupBox1.Controls.Add(this.rbApertura);
            this.groupBox1.Controls.Add(this.rbCerrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 54);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // rbCierreApertura
            // 
            this.rbCierreApertura.AutoSize = true;
            this.rbCierreApertura.Location = new System.Drawing.Point(334, 22);
            this.rbCierreApertura.Name = "rbCierreApertura";
            this.rbCierreApertura.Size = new System.Drawing.Size(118, 18);
            this.rbCierreApertura.TabIndex = 2;
            this.rbCierreApertura.Text = "Cierre y Apertura";
            this.toolTip1.SetToolTip(this.rbCierreApertura, "Asiento de cierre del año seleccionado y asiento de apertura del año siguiente al" +
                    " seleccionado");
            this.rbCierreApertura.UseVisualStyleBackColor = true;
            // 
            // rbApertura
            // 
            this.rbApertura.AutoSize = true;
            this.rbApertura.Location = new System.Drawing.Point(214, 22);
            this.rbApertura.Name = "rbApertura";
            this.rbApertura.Size = new System.Drawing.Size(100, 18);
            this.rbApertura.TabIndex = 1;
            this.rbApertura.Text = "Sólo Apertura";
            this.toolTip1.SetToolTip(this.rbApertura, "Asiento de apertura del año seleccionado");
            this.rbApertura.UseVisualStyleBackColor = true;
            // 
            // rbCerrar
            // 
            this.rbCerrar.AutoSize = true;
            this.rbCerrar.Checked = true;
            this.rbCerrar.Location = new System.Drawing.Point(31, 22);
            this.rbCerrar.Name = "rbCerrar";
            this.rbCerrar.Size = new System.Drawing.Size(163, 18);
            this.rbCerrar.TabIndex = 0;
            this.rbCerrar.TabStop = true;
            this.rbCerrar.Text = "Sólo Cierre (Asiento PyG)";
            this.toolTip1.SetToolTip(this.rbCerrar, "Asiento de cierre del año seleccionado");
            this.rbCerrar.UseVisualStyleBackColor = true;
            // 
            // frmAperturaCierre
            // 
            this.ClientSize = new System.Drawing.Size(507, 223);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEjercicio);
            this.Name = "frmAperturaCierre";
            this.Text = "Cierre/Apertura de Ejercicio";
            this.Load += new System.EventHandler(this.frmAperturaCierre_Load);
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

        private void frmAperturaCierre_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Cierre/Apertura de Ejercicio";
                ctrl.ctrlAperturaCierre ctrl = new gesClinica.app.pc.frm._aperturacierre.ctrl.ctrlAperturaCierre();
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
                ctrl.ctrlAperturaCierre ctrl = new gesClinica.app.pc.frm._aperturacierre.ctrl.ctrlAperturaCierre();
                frmAperturaCierre frm = (frmAperturaCierre)this;
                ctrl.loadEjercicio(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
