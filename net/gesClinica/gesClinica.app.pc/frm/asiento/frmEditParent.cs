using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditParent:template.frm.edicion.EditForm
    {
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        protected internal System.Windows.Forms.ToolStripComboBox cmbRazonSocial;
        private System.Windows.Forms.ToolStrip toolStrip1;

        public frmEditParent()
        {
            InitializeComponent();

            ctrl.ctrlEditParent ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditParent();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }
        public frmEditParent(bool soloconsulta):base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEditParent ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEditParent();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbRazonSocial = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbRazonSocial});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(470, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(147, 22);
            this.toolStripLabel1.Text = "Seleccione Razón Social :";
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(121, 25);
            // 
            // frmEditParent
            // 
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEditParent";
            this.Text = "Asiento";
            this.Load += new System.EventHandler(this.frmEditParent_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmEditParent_Load(object sender, EventArgs e)
        {
            this.cmbRazonSocial.SelectedIndexChanged += new EventHandler(algoCambio);

        }
        protected void algoCambio(object sender, EventArgs e)
        {
            habilitarAcepta();
        }

        protected void habilitarAcepta()
        {
            this.btAceptar.Enabled = true;
        }
    }
}
