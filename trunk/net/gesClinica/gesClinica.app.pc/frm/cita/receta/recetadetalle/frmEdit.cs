using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.recetadetalle
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtPosologia;
        internal repsol.forms.controls.TextBoxColor txtCantidad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btProductoExaminar;
        internal repsol.forms.controls.TextBoxColor txtProducto;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new RecetaDetalle());
        }
        public frmEdit(RecetaDetalle objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(RecetaDetalle objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btProductoExaminar.Enabled = !this.OnlyView;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEdit();
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
            this.txtPosologia = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new repsol.forms.controls.TextBoxColor();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btProductoExaminar = new System.Windows.Forms.Button();
            this.txtProducto = new repsol.forms.controls.TextBoxColor();
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
            this.panFooter.Location = new System.Drawing.Point(0, 227);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtPosologia
            // 
            this.txtPosologia.ActivateStyle = true;
            this.txtPosologia.BackColor = System.Drawing.Color.White;
            this.txtPosologia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPosologia.ColorLeave = System.Drawing.Color.White;
            this.txtPosologia.Location = new System.Drawing.Point(123, 100);
            this.txtPosologia.Multiline = true;
            this.txtPosologia.Name = "txtPosologia";
            this.txtPosologia.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPosologia.Size = new System.Drawing.Size(352, 110);
            this.txtPosologia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Posologia";
            // 
            // txtCantidad
            // 
            this.txtCantidad.ActivateStyle = true;
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCantidad.ColorLeave = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(123, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(109, 22);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 14);
            this.label17.TabIndex = 84;
            this.label17.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Producto";
            // 
            // btProductoExaminar
            // 
            this.btProductoExaminar.Image = global::gesClinica.app.pc.Properties.Resources.search16x16;
            this.btProductoExaminar.Location = new System.Drawing.Point(444, 44);
            this.btProductoExaminar.Name = "btProductoExaminar";
            this.btProductoExaminar.Size = new System.Drawing.Size(31, 22);
            this.btProductoExaminar.TabIndex = 86;
            this.btProductoExaminar.UseVisualStyleBackColor = true;
            this.btProductoExaminar.Click += new System.EventHandler(this.btProductoExaminar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.ActivateStyle = false;
            this.txtProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProducto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProducto.ColorLeave = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(123, 44);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(315, 22);
            this.txtProducto.TabIndex = 85;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 270);
            this.Controls.Add(this.btProductoExaminar);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPosologia);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Productos de la Receta";
            this.Load += new System.EventHandler(this.frmrecetadetalleEdit_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPosologia, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.txtProducto, 0);
            this.Controls.SetChildIndex(this.btProductoExaminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmrecetadetalleEdit_Load(object sender, EventArgs e)
        {

        }

        private void txtInt32_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

                if (!String.IsNullOrEmpty(txt.Text))
                {
                    int valor;
                    if (!int.TryParse(txt.Text, out valor))
                    {
                        e.Cancel = true;
                        System.Windows.Forms.MessageBox.Show("Formato numérico incorrecto!", this.Text, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtInt32_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

                if (String.IsNullOrEmpty(txt.Text)) txt.Text = "0";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btProductoExaminar_Click(object sender, EventArgs e)
        {            
            try
            {
                producto.frmQuery vVen = new gesClinica.app.pc.frm.producto.frmQuery();
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEdit();
                    frmEdit frm = this;
                    ctrl.setProducto(ref frm, (Producto)vVen.SelectedVO);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
