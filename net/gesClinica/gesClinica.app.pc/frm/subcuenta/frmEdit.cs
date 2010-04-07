using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.subcuenta
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        internal repsol.forms.controls.TextBoxColor txtCodigo;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtContrapartida;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.CheckBox chkHaber;
        internal System.Windows.Forms.CheckBox chkBloqueada;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.subcuenta.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new SubCuenta());
        }
        public frmEdit(SubCuenta objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.subcuenta.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(SubCuenta objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.txtCodigo.ReadOnly = true;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.subcuenta.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.subcuenta.ctrl.ctrlEdit();
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
            this.txtCodigo = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrapartida = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.chkHaber = new System.Windows.Forms.CheckBox();
            this.chkBloqueada = new System.Windows.Forms.CheckBox();
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
            this.panFooter.Location = new System.Drawing.Point(0, 146);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(123, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.ActivateStyle = true;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCodigo.ColorLeave = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(123, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo";
            // 
            // txtContrapartida
            // 
            this.txtContrapartida.ActivateStyle = true;
            this.txtContrapartida.BackColor = System.Drawing.Color.White;
            this.txtContrapartida.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtContrapartida.ColorLeave = System.Drawing.Color.White;
            this.txtContrapartida.Location = new System.Drawing.Point(123, 98);
            this.txtContrapartida.Name = "txtContrapartida";
            this.txtContrapartida.Size = new System.Drawing.Size(103, 22);
            this.txtContrapartida.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Contrapartida";
            // 
            // chkHaber
            // 
            this.chkHaber.AutoSize = true;
            this.chkHaber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHaber.Location = new System.Drawing.Point(335, 44);
            this.chkHaber.Name = "chkHaber";
            this.chkHaber.Size = new System.Drawing.Size(138, 18);
            this.chkHaber.TabIndex = 3;
            this.chkHaber.Text = "Saldo Habitual Haber";
            this.chkHaber.UseVisualStyleBackColor = true;
            // 
            // chkBloqueada
            // 
            this.chkBloqueada.AutoSize = true;
            this.chkBloqueada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBloqueada.Location = new System.Drawing.Point(391, 100);
            this.chkBloqueada.Name = "chkBloqueada";
            this.chkBloqueada.Size = new System.Drawing.Size(82, 18);
            this.chkBloqueada.TabIndex = 4;
            this.chkBloqueada.Text = "Bloqueada";
            this.chkBloqueada.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 189);
            this.Controls.Add(this.chkBloqueada);
            this.Controls.Add(this.chkHaber);
            this.Controls.Add(this.txtContrapartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "SubCuenta";
            this.Load += new System.EventHandler(this.frmsubcuentaEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtContrapartida, 0);
            this.Controls.SetChildIndex(this.chkHaber, 0);
            this.Controls.SetChildIndex(this.chkBloqueada, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmsubcuentaEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
