using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.producto.productodetalle
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDosis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btComponenteExaminar;
        internal repsol.forms.controls.TextBoxColor txtComponente;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.productodetalle.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new ProductoDetalle());
        }
        public frmEdit(ProductoDetalle objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.productodetalle.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(ProductoDetalle objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.productodetalle.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.productodetalle.ctrl.ctrlEdit();
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
            this.txtDosis = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btComponenteExaminar = new System.Windows.Forms.Button();
            this.txtComponente = new repsol.forms.controls.TextBoxColor();
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
            this.panFooter.Location = new System.Drawing.Point(0, 118);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtDosis
            // 
            this.txtDosis.ActivateStyle = true;
            this.txtDosis.BackColor = System.Drawing.Color.White;
            this.txtDosis.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDosis.ColorLeave = System.Drawing.Color.White;
            this.txtDosis.Location = new System.Drawing.Point(123, 72);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(352, 22);
            this.txtDosis.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Componente";
            // 
            // btComponenteExaminar
            // 
            this.btComponenteExaminar.Image = global::gesClinica.app.pc.Properties.Resources.search16x16;
            this.btComponenteExaminar.Location = new System.Drawing.Point(444, 44);
            this.btComponenteExaminar.Name = "btComponenteExaminar";
            this.btComponenteExaminar.Size = new System.Drawing.Size(31, 22);
            this.btComponenteExaminar.TabIndex = 88;
            this.btComponenteExaminar.UseVisualStyleBackColor = true;
            this.btComponenteExaminar.Click += new System.EventHandler(this.btComponenteExaminar_Click);
            // 
            // txtComponente
            // 
            this.txtComponente.ActivateStyle = false;
            this.txtComponente.BackColor = System.Drawing.SystemColors.Control;
            this.txtComponente.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtComponente.ColorLeave = System.Drawing.Color.White;
            this.txtComponente.Location = new System.Drawing.Point(123, 44);
            this.txtComponente.Name = "txtComponente";
            this.txtComponente.ReadOnly = true;
            this.txtComponente.Size = new System.Drawing.Size(315, 22);
            this.txtComponente.TabIndex = 87;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 161);
            this.Controls.Add(this.btComponenteExaminar);
            this.Controls.Add(this.txtComponente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Componentes del Producto";
            this.Load += new System.EventHandler(this.frmproductodetalleEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDosis, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtComponente, 0);
            this.Controls.SetChildIndex(this.btComponenteExaminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmproductodetalleEdit_Load(object sender, EventArgs e)
        {

        }

        private void btComponenteExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                componente.frmQuery vVen = new gesClinica.app.pc.frm.componente.frmQuery();
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.productodetalle.ctrl.ctrlEdit();
                    frmEdit frm = this;
                    ctrl.setComponente(ref frm, (Componente)vVen.SelectedVO);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
