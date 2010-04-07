using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.terapia._dependiente
{
    class frmEdit: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbTerapiaDependiente;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia._dependiente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Terapia());
        }
        public frmEdit(Terapia objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia._dependiente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Terapia objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia._dependiente.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia._dependiente.ctrl.ctrlEdit();
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTerapiaDependiente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(441, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(521, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 117);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Actividad Dep.";
            // 
            // cmbTerapiaDependiente
            // 
            this.cmbTerapiaDependiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerapiaDependiente.FormattingEnabled = true;
            this.cmbTerapiaDependiente.Location = new System.Drawing.Point(126, 41);
            this.cmbTerapiaDependiente.Name = "cmbTerapiaDependiente";
            this.cmbTerapiaDependiente.Size = new System.Drawing.Size(358, 22);
            this.cmbTerapiaDependiente.TabIndex = 28;
            this.cmbTerapiaDependiente.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTerapia_SelectedIndexChanged);
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 160);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTerapiaDependiente);
            this.Name = "frmEdit";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.cmbTerapiaDependiente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoTerapia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
