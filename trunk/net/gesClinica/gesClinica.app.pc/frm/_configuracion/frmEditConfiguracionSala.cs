using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._configuracion
{
    class frmEditConfiguracionSala: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbTerapia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;

        public frmEditConfiguracionSala()
        {
            InitializeComponent();

            ctrl.ctrlEditConfiguracionSala ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionSala();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, this.InnerVO);
            this.chkCerrar.Checked = false;
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditConfiguracionSala ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionSala();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTerapia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEmpleado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTerapia);
            this.groupBox1.Location = new System.Drawing.Point(11, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 115);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "Terapeuta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(99, 37);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpleado.TabIndex = 30;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 29;
            this.label4.Text = "Terapia";
            // 
            // cmbTerapia
            // 
            this.cmbTerapia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerapia.FormattingEnabled = true;
            this.cmbTerapia.Location = new System.Drawing.Point(99, 65);
            this.cmbTerapia.Name = "cmbTerapia";
            this.cmbTerapia.Size = new System.Drawing.Size(376, 22);
            this.cmbTerapia.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Sala";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(98, 21);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(376, 22);
            this.cmbSala.TabIndex = 35;
            this.cmbSala.SelectedIndexChanged += new System.EventHandler(this.cmbSala_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSala);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 57);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // frmEditConfiguracionSala
            // 
            this.ClientSize = new System.Drawing.Size(516, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditConfiguracionSala";
            this.Text = "Configuracion - Sala";
            this.Load += new System.EventHandler(this.frmconfiguracionEditConfiguracion_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmconfiguracionEditConfiguracion_Load(object sender, EventArgs e)
        {
            this.Text = "Configuracion - Sala";

        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditConfiguracionSala ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionSala();
                frmEditConfiguracionSala frm = this;
                ctrl.cargarTerapias(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditConfiguracionSala ctrl = new gesClinica.app.pc.frm._configuracion.ctrl.ctrlEditConfiguracionSala();
                frmEditConfiguracionSala frm = this;
                ctrl.recuperarConfiguracion(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
