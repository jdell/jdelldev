using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita
{
    class frmEditNotas: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtPaciente;
        internal repsol.forms.controls.TextBoxColor txtNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        public frmEditNotas(Cita objVO):base(false)
        {
            InitializeComponent();

            ctrl.ctrlEditNotas ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditNotas();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditNotas ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlEditNotas();
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
            this.txtPaciente = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotas = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(336, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(416, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 243);
            this.panFooter.Size = new System.Drawing.Size(503, 43);
            // 
            // txtPaciente
            // 
            this.txtPaciente.ActivateStyle = false;
            this.txtPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtPaciente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPaciente.ColorLeave = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(97, 30);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(364, 22);
            this.txtPaciente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Paciente";
            // 
            // txtNotas
            // 
            this.txtNotas.ActivateStyle = true;
            this.txtNotas.BackColor = System.Drawing.Color.White;
            this.txtNotas.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNotas.ColorLeave = System.Drawing.Color.White;
            this.txtNotas.Location = new System.Drawing.Point(97, 58);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotas.Size = new System.Drawing.Size(364, 179);
            this.txtNotas.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Notas";
            // 
            // frmEditNotas
            // 
            this.ClientSize = new System.Drawing.Size(503, 286);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label2);
            this.Name = "frmEditNotas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.frmEditNotas_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPaciente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNotas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEditNotas_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Cita - Notas";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
