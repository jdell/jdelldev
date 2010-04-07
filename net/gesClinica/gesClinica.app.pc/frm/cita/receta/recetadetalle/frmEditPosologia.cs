using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.recetadetalle
{
    class frmEditPosologia: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.GroupBox groupBox1;
        internal gesClinica.app.pc.template.controls.TextEditor txtPosologiaInfo;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btProductoExaminar;
        internal repsol.forms.controls.TextBoxColor txtProducto;
        internal repsol.forms.controls.TextBoxColor txtCantidad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        internal repsol.forms.controls.TextBoxColor txtPosologia;
        private System.Windows.Forms.Label label2;

        public frmEditPosologia()
        {
            InitializeComponent();

            ctrl.ctrlEditPosologia ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditPosologia();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new RecetaDetalle());
        }
        public frmEditPosologia(RecetaDetalle objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditPosologia ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditPosologia();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditPosologia(RecetaDetalle objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btProductoExaminar.Enabled = !this.OnlyView;

            ctrl.ctrlEditPosologia ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditPosologia();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditPosologia ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditPosologia();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPosologia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPosologiaInfo = new gesClinica.app.pc.template.controls.TextEditor();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btProductoExaminar = new System.Windows.Forms.Button();
            this.txtProducto = new repsol.forms.controls.TextBoxColor();
            this.txtCantidad = new repsol.forms.controls.TextBoxColor();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosologia = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(541, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(622, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 245);
            this.panFooter.Size = new System.Drawing.Size(709, 43);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosologiaInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(477, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 245);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txtPosologiaInfo
            // 
            this.txtPosologiaInfo.AcceptsTab = false;
            this.txtPosologiaInfo.AutoWordSelection = true;
            this.txtPosologiaInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtPosologiaInfo.DetectURLs = true;
            this.txtPosologiaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosologiaInfo.Location = new System.Drawing.Point(3, 18);
            this.txtPosologiaInfo.Name = "txtPosologiaInfo";
            this.txtPosologiaInfo.ReadOnly = true;
            // 
            // 
            // 
            this.txtPosologiaInfo.RichTextBox.AutoWordSelection = true;
            this.txtPosologiaInfo.RichTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.txtPosologiaInfo.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtPosologiaInfo.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtPosologiaInfo.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosologiaInfo.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtPosologiaInfo.RichTextBox.Name = "rtb1";
            this.txtPosologiaInfo.RichTextBox.PrintDocument = null;
            this.txtPosologiaInfo.RichTextBox.ReadOnly = true;
            this.txtPosologiaInfo.RichTextBox.Size = new System.Drawing.Size(226, 224);
            this.txtPosologiaInfo.RichTextBox.TabIndex = 1;
            this.txtPosologiaInfo.ShowBold = true;
            this.txtPosologiaInfo.ShowCenterJustify = true;
            this.txtPosologiaInfo.ShowColors = true;
            this.txtPosologiaInfo.ShowCopy = true;
            this.txtPosologiaInfo.ShowCut = true;
            this.txtPosologiaInfo.ShowFont = true;
            this.txtPosologiaInfo.ShowFontSize = true;
            this.txtPosologiaInfo.ShowItalic = true;
            this.txtPosologiaInfo.ShowLeftJustify = true;
            this.txtPosologiaInfo.ShowOpen = false;
            this.txtPosologiaInfo.ShowPaste = true;
            this.txtPosologiaInfo.ShowRedo = true;
            this.txtPosologiaInfo.ShowRightJustify = true;
            this.txtPosologiaInfo.ShowSave = false;
            this.txtPosologiaInfo.ShowStamp = true;
            this.txtPosologiaInfo.ShowStrikeout = true;
            this.txtPosologiaInfo.ShowToolBarText = false;
            this.txtPosologiaInfo.ShowUnderline = true;
            this.txtPosologiaInfo.ShowUndo = true;
            this.txtPosologiaInfo.Size = new System.Drawing.Size(226, 224);
            this.txtPosologiaInfo.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtPosologiaInfo.StampColor = System.Drawing.Color.Blue;
            this.txtPosologiaInfo.TabIndex = 2;
            this.txtPosologiaInfo.TextRTF = resources.GetString("txtPosologiaInfo.TextRTF");
            // 
            // 
            // 
            this.txtPosologiaInfo.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtPosologiaInfo.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtPosologiaInfo.Toolbar.Divider = false;
            this.txtPosologiaInfo.Toolbar.DropDownArrows = true;
            this.txtPosologiaInfo.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtPosologiaInfo.Toolbar.Name = "tb1";
            this.txtPosologiaInfo.Toolbar.ShowToolTips = true;
            this.txtPosologiaInfo.Toolbar.Size = new System.Drawing.Size(784, 20);
            this.txtPosologiaInfo.Toolbar.TabIndex = 0;
            this.txtPosologiaInfo.Toolbar.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btProductoExaminar);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPosologia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 245);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            // 
            // btProductoExaminar
            // 
            this.btProductoExaminar.Location = new System.Drawing.Point(425, 39);
            this.btProductoExaminar.Name = "btProductoExaminar";
            this.btProductoExaminar.Size = new System.Drawing.Size(31, 22);
            this.btProductoExaminar.TabIndex = 93;
            this.btProductoExaminar.Text = "...";
            this.btProductoExaminar.UseVisualStyleBackColor = true;
            this.btProductoExaminar.Click += new System.EventHandler(this.btProductoExaminar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.ActivateStyle = false;
            this.txtProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProducto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProducto.ColorLeave = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(104, 39);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(315, 22);
            this.txtProducto.TabIndex = 92;
            // 
            // txtCantidad
            // 
            this.txtCantidad.ActivateStyle = true;
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCantidad.ColorLeave = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(104, 67);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(109, 22);
            this.txtCantidad.TabIndex = 87;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.Validated += new System.EventHandler(this.txtInt32_Validated);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt32_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 14);
            this.label17.TabIndex = 91;
            this.label17.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 90;
            this.label5.Text = "Producto";
            // 
            // txtPosologia
            // 
            this.txtPosologia.ActivateStyle = true;
            this.txtPosologia.BackColor = System.Drawing.Color.White;
            this.txtPosologia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPosologia.ColorLeave = System.Drawing.Color.White;
            this.txtPosologia.Location = new System.Drawing.Point(104, 95);
            this.txtPosologia.Multiline = true;
            this.txtPosologia.Name = "txtPosologia";
            this.txtPosologia.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPosologia.Size = new System.Drawing.Size(352, 110);
            this.txtPosologia.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 89;
            this.label2.Text = "Posologia";
            // 
            // frmEditPosologia
            // 
            this.ClientSize = new System.Drawing.Size(709, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditPosologia";
            this.Text = "Productos de la Receta";
            this.Load += new System.EventHandler(this.frmrecetadetalleEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
                    ctrl.ctrlEditPosologia ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditPosologia();
                    frmEditPosologia frm = this;
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
