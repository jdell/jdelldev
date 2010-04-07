using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.recetadetalle
{
    class frmEditBusqueda: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.Button btProductoAñadir;
        private System.Windows.Forms.GroupBox gboxProductosSeleccionados;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btProductoQuitar;
        internal gesClinica.app.pc.template.controls.TextEditor txtPosologia;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.SplitContainer splitContainer4;
        internal repsol.forms.controls.TextBoxColor txtIndicacionDescripcion;
        private System.Windows.Forms.Label label4;
        internal repsol.forms.controls.TextBoxColor txtProductoLaboratorio;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtProductoDescripcion;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button btBuscar;
        internal System.Windows.Forms.DataGridView dgProductosSeleccionados;
        private System.Windows.Forms.GroupBox groupBox1;

        public frmEditBusqueda()
        {
            InitializeComponent();

            ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new RecetaDetalle());
        }
        public frmEditBusqueda(RecetaDetalle objVO)
        {
            InitializeComponent();

            ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditBusqueda(RecetaDetalle objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btProductoAñadir.Enabled = !this.OnlyView;

            ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditBusqueda));
            this.btProductoAñadir = new System.Windows.Forms.Button();
            this.gboxProductosSeleccionados = new System.Windows.Forms.GroupBox();
            this.dgProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPosologia = new gesClinica.app.pc.template.controls.TextEditor();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtIndicacionDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductoLaboratorio = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductoDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btProductoQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.gboxProductosSeleccionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosSeleccionados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(1910, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1991, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 607);
            this.panFooter.Size = new System.Drawing.Size(872, 43);
            // 
            // btProductoAñadir
            // 
            this.btProductoAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btProductoAñadir.Image")));
            this.btProductoAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProductoAñadir.Location = new System.Drawing.Point(296, 6);
            this.btProductoAñadir.Name = "btProductoAñadir";
            this.btProductoAñadir.Size = new System.Drawing.Size(123, 22);
            this.btProductoAñadir.TabIndex = 86;
            this.btProductoAñadir.Text = "Añadir a receta";
            this.btProductoAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProductoAñadir.UseVisualStyleBackColor = true;
            this.btProductoAñadir.Click += new System.EventHandler(this.btProductoAñadir_Click);
            // 
            // gboxProductosSeleccionados
            // 
            this.gboxProductosSeleccionados.Controls.Add(this.dgProductosSeleccionados);
            this.gboxProductosSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxProductosSeleccionados.Location = new System.Drawing.Point(0, 0);
            this.gboxProductosSeleccionados.Name = "gboxProductosSeleccionados";
            this.gboxProductosSeleccionados.Size = new System.Drawing.Size(872, 141);
            this.gboxProductosSeleccionados.TabIndex = 87;
            this.gboxProductosSeleccionados.TabStop = false;
            this.gboxProductosSeleccionados.Text = "Productos Seleccionados";
            // 
            // dgProductosSeleccionados
            // 
            this.dgProductosSeleccionados.AllowUserToAddRows = false;
            this.dgProductosSeleccionados.AllowUserToDeleteRows = false;
            this.dgProductosSeleccionados.AllowUserToResizeColumns = false;
            this.dgProductosSeleccionados.AllowUserToResizeRows = false;
            this.dgProductosSeleccionados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgProductosSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductosSeleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductosSeleccionados.Location = new System.Drawing.Point(3, 18);
            this.dgProductosSeleccionados.MultiSelect = false;
            this.dgProductosSeleccionados.Name = "dgProductosSeleccionados";
            this.dgProductosSeleccionados.ReadOnly = true;
            this.dgProductosSeleccionados.RowHeadersVisible = false;
            this.dgProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductosSeleccionados.Size = new System.Drawing.Size(866, 120);
            this.dgProductosSeleccionados.TabIndex = 2;
            this.dgProductosSeleccionados.TabStop = false;
            this.dgProductosSeleccionados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgProductosSeleccionados_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosologia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 423);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txtPosologia
            // 
            this.txtPosologia.AcceptsTab = false;
            this.txtPosologia.AutoWordSelection = true;
            this.txtPosologia.BackColor = System.Drawing.SystemColors.Control;
            this.txtPosologia.DetectURLs = true;
            this.txtPosologia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosologia.Location = new System.Drawing.Point(3, 18);
            this.txtPosologia.Name = "txtPosologia";
            this.txtPosologia.ReadOnly = true;
            // 
            // 
            // 
            this.txtPosologia.RichTextBox.AutoWordSelection = true;
            this.txtPosologia.RichTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.txtPosologia.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtPosologia.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtPosologia.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosologia.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtPosologia.RichTextBox.Name = "rtb1";
            this.txtPosologia.RichTextBox.PrintDocument = null;
            this.txtPosologia.RichTextBox.ReadOnly = true;
            this.txtPosologia.RichTextBox.Size = new System.Drawing.Size(226, 402);
            this.txtPosologia.RichTextBox.TabIndex = 1;
            this.txtPosologia.ShowBold = true;
            this.txtPosologia.ShowCenterJustify = true;
            this.txtPosologia.ShowColors = true;
            this.txtPosologia.ShowCopy = true;
            this.txtPosologia.ShowCut = true;
            this.txtPosologia.ShowFont = true;
            this.txtPosologia.ShowFontSize = true;
            this.txtPosologia.ShowItalic = true;
            this.txtPosologia.ShowLeftJustify = true;
            this.txtPosologia.ShowOpen = false;
            this.txtPosologia.ShowPaste = true;
            this.txtPosologia.ShowRedo = true;
            this.txtPosologia.ShowRightJustify = true;
            this.txtPosologia.ShowSave = false;
            this.txtPosologia.ShowStamp = true;
            this.txtPosologia.ShowStrikeout = true;
            this.txtPosologia.ShowToolBarText = false;
            this.txtPosologia.ShowUnderline = true;
            this.txtPosologia.ShowUndo = true;
            this.txtPosologia.Size = new System.Drawing.Size(226, 402);
            this.txtPosologia.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtPosologia.StampColor = System.Drawing.Color.Blue;
            this.txtPosologia.TabIndex = 2;
            this.txtPosologia.TextRTF = resources.GetString("txtPosologia.TextRTF");
            // 
            // 
            // 
            this.txtPosologia.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtPosologia.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtPosologia.Toolbar.Divider = false;
            this.txtPosologia.Toolbar.DropDownArrows = true;
            this.txtPosologia.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtPosologia.Toolbar.Name = "tb1";
            this.txtPosologia.Toolbar.ShowToolTips = true;
            this.txtPosologia.Toolbar.Size = new System.Drawing.Size(784, 20);
            this.txtPosologia.Toolbar.TabIndex = 0;
            this.txtPosologia.Toolbar.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gboxProductosSeleccionados);
            this.splitContainer1.Size = new System.Drawing.Size(872, 607);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 90;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btProductoQuitar);
            this.splitContainer3.Panel2.Controls.Add(this.btProductoAñadir);
            this.splitContainer3.Size = new System.Drawing.Size(872, 462);
            this.splitContainer3.SplitterDistance = 423;
            this.splitContainer3.TabIndex = 92;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(872, 423);
            this.splitContainer2.SplitterDistance = 636;
            this.splitContainer2.TabIndex = 91;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btBuscar);
            this.splitContainer4.Panel1.Controls.Add(this.txtIndicacionDescripcion);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.txtProductoLaboratorio);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            this.splitContainer4.Panel1.Controls.Add(this.txtProductoDescripcion);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgProductos);
            this.splitContainer4.Size = new System.Drawing.Size(636, 423);
            this.splitContainer4.SplitterDistance = 107;
            this.splitContainer4.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(541, 18);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(76, 69);
            this.btBuscar.TabIndex = 87;
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtIndicacionDescripcion
            // 
            this.txtIndicacionDescripcion.ActivateStyle = true;
            this.txtIndicacionDescripcion.BackColor = System.Drawing.Color.White;
            this.txtIndicacionDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtIndicacionDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtIndicacionDescripcion.Location = new System.Drawing.Point(158, 70);
            this.txtIndicacionDescripcion.Name = "txtIndicacionDescripcion";
            this.txtIndicacionDescripcion.Size = new System.Drawing.Size(362, 22);
            this.txtIndicacionDescripcion.TabIndex = 2;
            this.txtIndicacionDescripcion.TextChanged += new System.EventHandler(this.productoFilterHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 14);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion Indicación";
            // 
            // txtProductoLaboratorio
            // 
            this.txtProductoLaboratorio.ActivateStyle = true;
            this.txtProductoLaboratorio.BackColor = System.Drawing.Color.White;
            this.txtProductoLaboratorio.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProductoLaboratorio.ColorLeave = System.Drawing.Color.White;
            this.txtProductoLaboratorio.Location = new System.Drawing.Point(158, 42);
            this.txtProductoLaboratorio.Name = "txtProductoLaboratorio";
            this.txtProductoLaboratorio.Size = new System.Drawing.Size(362, 22);
            this.txtProductoLaboratorio.TabIndex = 1;
            this.txtProductoLaboratorio.TextChanged += new System.EventHandler(this.productoFilterHandler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Laboratorio";
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.ActivateStyle = true;
            this.txtProductoDescripcion.BackColor = System.Drawing.Color.White;
            this.txtProductoDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtProductoDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtProductoDescripcion.Location = new System.Drawing.Point(158, 14);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.Size = new System.Drawing.Size(362, 22);
            this.txtProductoDescripcion.TabIndex = 0;
            this.txtProductoDescripcion.TextChanged += new System.EventHandler(this.productoFilterHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Descripcion Producto";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AllowUserToResizeColumns = false;
            this.dgProductos.AllowUserToResizeRows = false;
            this.dgProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductos.Location = new System.Drawing.Point(0, 0);
            this.dgProductos.MultiSelect = false;
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(636, 312);
            this.dgProductos.TabIndex = 1;
            this.dgProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgProductos_MouseDoubleClick);
            this.dgProductos.CurrentCellChanged += new System.EventHandler(this.dgProductos_CurrentCellChanged);
            // 
            // btProductoQuitar
            // 
            this.btProductoQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btProductoQuitar.Image")));
            this.btProductoQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProductoQuitar.Location = new System.Drawing.Point(454, 6);
            this.btProductoQuitar.Name = "btProductoQuitar";
            this.btProductoQuitar.Size = new System.Drawing.Size(123, 22);
            this.btProductoQuitar.TabIndex = 87;
            this.btProductoQuitar.Text = "Quitar de receta";
            this.btProductoQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProductoQuitar.UseVisualStyleBackColor = true;
            this.btProductoQuitar.Click += new System.EventHandler(this.btProductoQuitar_Click);
            // 
            // frmEditBusqueda
            // 
            this.ClientSize = new System.Drawing.Size(872, 650);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEditBusqueda";
            this.Text = "Productos de la Receta";
            this.Load += new System.EventHandler(this.frmrecetadetalleEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.gboxProductosSeleccionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosSeleccionados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmrecetadetalleEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Productos para la receta"; 
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                System.Windows.Forms.DataGridView dg = this.dgProductos;
                ctrl.ProductoSetEstiloGridRegistros(ref dg);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
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

        private void productoFilterHandler(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                frmEditBusqueda frm = this;
                ctrl.ProductoFiltrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgProductos_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                frmEditBusqueda frm = this;
                ctrl.ProductoSetPosologia(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                frmEditBusqueda frm = this;
                ctrl.ProductoConsultaRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btProductoAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                frmEditBusqueda frm = this;
                ctrl.ProductoAñadir(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btProductoQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                frmEditBusqueda frm = this;
                ctrl.ProductoQuitar(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgProductosSeleccionados_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                ctrl.ctrlEditBusqueda ctrl = new gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl.ctrlEditBusqueda();
                System.Windows.Forms.DataGridView dg = (System.Windows.Forms.DataGridView)sender;
                if (ctrl.RecetaDetalleGetRegistroSeleccionado(dg) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEditPosologia vVen = new frmEditPosologia(ctrl.RecetaDetalleGetRegistroSeleccionado(dg), false);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ctrl.RecetaDetalleSetRegistroSeleccionado(ref dg, (RecetaDetalle)vVen.InnerVO);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgProductos_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                btProductoAñadir_Click(null, null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
