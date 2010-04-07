using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.tipooperacion
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        internal System.Windows.Forms.CheckBox chkFacturable;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tipooperacion.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new TipoOperacion());
        }
        public frmEdit(TipoOperacion objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tipooperacion.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(TipoOperacion objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tipooperacion.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.tipooperacion.ctrl.ctrlEdit();
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
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFacturable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(301, 8);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(381, 8);
            // 
            // chkCerrar
            // 
            this.chkCerrar.Location = new System.Drawing.Point(14, 12);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 110);
            this.panFooter.Size = new System.Drawing.Size(489, 43);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(108, 47);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(337, 22);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // chkFacturable
            // 
            this.chkFacturable.AutoSize = true;
            this.chkFacturable.Location = new System.Drawing.Point(363, 23);
            this.chkFacturable.Name = "chkFacturable";
            this.chkFacturable.Size = new System.Drawing.Size(82, 18);
            this.chkFacturable.TabIndex = 23;
            this.chkFacturable.Text = "Facturable";
            this.chkFacturable.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(489, 153);
            this.Controls.Add(this.chkFacturable);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Tipo de Operacion";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.chkFacturable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
