using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.paciente
{
    class frmEditMuyImportante : template.frm.edicion.EditForm
    {
        private System.Windows.Forms.GroupBox groupBox4;
        internal repsol.forms.controls.TextBoxColor txtMuyImportante;
    
        public frmEditMuyImportante(lib.vo.Paciente objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditMuyImportante ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlEditMuyImportante();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMuyImportante = new repsol.forms.controls.TextBoxColor();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMuyImportante);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 198);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Muy Importante";
            // 
            // txtMuyImportante
            // 
            this.txtMuyImportante.ActivateStyle = true;
            this.txtMuyImportante.BackColor = System.Drawing.Color.White;
            this.txtMuyImportante.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtMuyImportante.ColorLeave = System.Drawing.Color.White;
            this.txtMuyImportante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMuyImportante.Location = new System.Drawing.Point(3, 18);
            this.txtMuyImportante.Multiline = true;
            this.txtMuyImportante.Name = "txtMuyImportante";
            this.txtMuyImportante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMuyImportante.Size = new System.Drawing.Size(464, 177);
            this.txtMuyImportante.TabIndex = 7;
            // 
            // frmEditMuyImportante
            // 
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmEditMuyImportante";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frmEditMuyImportante_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmEditMuyImportante_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Paciente - Muy Importante";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditMuyImportante ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlEditMuyImportante();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                base.btAceptar_Click(sender, e);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
