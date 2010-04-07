using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.sintoma
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbTipoSintoma;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            this.chkCerrar.Visible = true;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sintoma.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Sintoma());
        }
        public frmEdit(Sintoma objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sintoma.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Sintoma objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sintoma.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sintoma.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
                base.btAceptar_Click(sender, e);

                if (!this.chkCerrar.Checked)
                    ctrl.recuperarDatos(ref frm);
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoSintoma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
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
            this.panFooter.Location = new System.Drawing.Point(0, 255);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(114, 66);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(362, 183);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria";
            // 
            // cmbTipoSintoma
            // 
            this.cmbTipoSintoma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSintoma.FormattingEnabled = true;
            this.cmbTipoSintoma.Location = new System.Drawing.Point(114, 38);
            this.cmbTipoSintoma.Name = "cmbTipoSintoma";
            this.cmbTipoSintoma.Size = new System.Drawing.Size(362, 22);
            this.cmbTipoSintoma.TabIndex = 0;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoSintoma);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Sintoma";
            this.Load += new System.EventHandler(this.frmsintomaEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cmbTipoSintoma, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmsintomaEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
