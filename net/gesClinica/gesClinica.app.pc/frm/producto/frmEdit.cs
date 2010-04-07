using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.producto
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        internal repsol.forms.controls.TextBoxColor txtPosologia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbLaboratorio;
        internal repsol.forms.controls.TextBoxColor txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducto;
        internal System.Windows.Forms.TabPage tabDetalleProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpageIndicaciones;
        private System.Windows.Forms.TabPage tpageContraIndicaciones;
        private System.Windows.Forms.Button btQuitarIndicacion;
        private System.Windows.Forms.Button btAñadirIndicacion;
        internal System.Windows.Forms.ListBox lboxTargetIndicacion;
        internal System.Windows.Forms.ListBox lboxSourceIndicacion;
        private System.Windows.Forms.Button btQuitarContraindicacion;
        private System.Windows.Forms.Button btAñadirContraindicacion;
        internal System.Windows.Forms.ListBox lboxTargetContraindicacion;
        internal System.Windows.Forms.ListBox lboxSourceContraindicacion;
        internal repsol.forms.controls.TextBoxColor txtPrecio;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.CheckBox chkRetirado;
        internal repsol.forms.controls.TextBoxColor txtUnidades;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbTipoUnidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBuscarIndicacion;
        internal repsol.forms.controls.TextBoxColor txtBusquedaIndicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btBuscarContraIndicacion;
        internal repsol.forms.controls.TextBoxColor txtBusquedaContraIndicacion;
        private System.Windows.Forms.Label label8;

        internal productodetalle.frmQuery _frmDetalle;

        public frmEdit()
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.producto.productodetalle.frmQuery();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Producto());
        }
        public frmEdit(Producto objVO)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.producto.productodetalle.frmQuery();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Producto objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.producto.productodetalle.frmQuery(this.OnlyView);

            this.btAñadirContraindicacion.Enabled = !this.OnlyView;
            this.btQuitarContraindicacion.Enabled = !this.OnlyView;
            this.btAñadirIndicacion.Enabled = !this.OnlyView;
            this.btQuitarIndicacion.Enabled = !this.OnlyView;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosologia = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.cmbTipoUnidad = new System.Windows.Forms.ComboBox();
            this.txtUnidades = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRetirado = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.tabDetalleProducto = new System.Windows.Forms.TabPage();
            this.tpageIndicaciones = new System.Windows.Forms.TabPage();
            this.btQuitarIndicacion = new System.Windows.Forms.Button();
            this.btAñadirIndicacion = new System.Windows.Forms.Button();
            this.lboxTargetIndicacion = new System.Windows.Forms.ListBox();
            this.lboxSourceIndicacion = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBuscarIndicacion = new System.Windows.Forms.Button();
            this.txtBusquedaIndicacion = new repsol.forms.controls.TextBoxColor();
            this.label7 = new System.Windows.Forms.Label();
            this.tpageContraIndicaciones = new System.Windows.Forms.TabPage();
            this.btQuitarContraindicacion = new System.Windows.Forms.Button();
            this.btAñadirContraindicacion = new System.Windows.Forms.Button();
            this.lboxTargetContraindicacion = new System.Windows.Forms.ListBox();
            this.lboxSourceContraindicacion = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBuscarContraIndicacion = new System.Windows.Forms.Button();
            this.txtBusquedaContraIndicacion = new repsol.forms.controls.TextBoxColor();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.tpageIndicaciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpageContraIndicaciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(395, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(475, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 299);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(103, 39);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(362, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // txtPosologia
            // 
            this.txtPosologia.ActivateStyle = true;
            this.txtPosologia.BackColor = System.Drawing.Color.White;
            this.txtPosologia.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPosologia.ColorLeave = System.Drawing.Color.White;
            this.txtPosologia.Location = new System.Drawing.Point(103, 95);
            this.txtPosologia.Multiline = true;
            this.txtPosologia.Name = "txtPosologia";
            this.txtPosologia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPosologia.Size = new System.Drawing.Size(362, 64);
            this.txtPosologia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Posología";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Laboratorio";
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Location = new System.Drawing.Point(103, 67);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(362, 22);
            this.cmbLaboratorio.TabIndex = 1;
            // 
            // txtDocumento
            // 
            this.txtDocumento.ActivateStyle = true;
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDocumento.ColorLeave = System.Drawing.Color.White;
            this.txtDocumento.Location = new System.Drawing.Point(103, 165);
            this.txtDocumento.Multiline = true;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDocumento.Size = new System.Drawing.Size(362, 64);
            this.txtDocumento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Documento";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducto);
            this.tabControl1.Controls.Add(this.tabDetalleProducto);
            this.tabControl1.Controls.Add(this.tpageIndicaciones);
            this.tabControl1.Controls.Add(this.tpageContraIndicaciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.cmbTipoUnidad);
            this.tabProducto.Controls.Add(this.txtUnidades);
            this.tabProducto.Controls.Add(this.label6);
            this.tabProducto.Controls.Add(this.chkRetirado);
            this.tabProducto.Controls.Add(this.txtPrecio);
            this.tabProducto.Controls.Add(this.label4);
            this.tabProducto.Controls.Add(this.txtDescripcion);
            this.tabProducto.Controls.Add(this.txtDocumento);
            this.tabProducto.Controls.Add(this.label2);
            this.tabProducto.Controls.Add(this.label3);
            this.tabProducto.Controls.Add(this.label1);
            this.tabProducto.Controls.Add(this.label5);
            this.tabProducto.Controls.Add(this.txtPosologia);
            this.tabProducto.Controls.Add(this.cmbLaboratorio);
            this.tabProducto.Location = new System.Drawing.Point(4, 23);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(508, 272);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "General";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // cmbTipoUnidad
            // 
            this.cmbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUnidad.FormattingEnabled = true;
            this.cmbTipoUnidad.Location = new System.Drawing.Point(332, 235);
            this.cmbTipoUnidad.Name = "cmbTipoUnidad";
            this.cmbTipoUnidad.Size = new System.Drawing.Size(133, 22);
            this.cmbTipoUnidad.TabIndex = 35;
            // 
            // txtUnidades
            // 
            this.txtUnidades.ActivateStyle = true;
            this.txtUnidades.BackColor = System.Drawing.Color.White;
            this.txtUnidades.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtUnidades.ColorLeave = System.Drawing.Color.White;
            this.txtUnidades.Location = new System.Drawing.Point(259, 235);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(67, 22);
            this.txtUnidades.TabIndex = 33;
            this.txtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 34;
            this.label6.Text = "Unidades";
            // 
            // chkRetirado
            // 
            this.chkRetirado.AutoSize = true;
            this.chkRetirado.Location = new System.Drawing.Point(394, 15);
            this.chkRetirado.Name = "chkRetirado";
            this.chkRetirado.Size = new System.Drawing.Size(71, 18);
            this.chkRetirado.TabIndex = 32;
            this.chkRetirado.Text = "Retirado";
            this.chkRetirado.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.ActivateStyle = true;
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPrecio.ColorLeave = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(103, 235);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(83, 22);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.Validated += new System.EventHandler(this.txtPrecio_Validated);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "Precio (€)";
            // 
            // tabDetalleProducto
            // 
            this.tabDetalleProducto.Location = new System.Drawing.Point(4, 23);
            this.tabDetalleProducto.Name = "tabDetalleProducto";
            this.tabDetalleProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleProducto.Size = new System.Drawing.Size(508, 272);
            this.tabDetalleProducto.TabIndex = 1;
            this.tabDetalleProducto.Text = "Componentes";
            this.tabDetalleProducto.UseVisualStyleBackColor = true;
            // 
            // tpageIndicaciones
            // 
            this.tpageIndicaciones.Controls.Add(this.btQuitarIndicacion);
            this.tpageIndicaciones.Controls.Add(this.btAñadirIndicacion);
            this.tpageIndicaciones.Controls.Add(this.lboxTargetIndicacion);
            this.tpageIndicaciones.Controls.Add(this.lboxSourceIndicacion);
            this.tpageIndicaciones.Controls.Add(this.panel1);
            this.tpageIndicaciones.Location = new System.Drawing.Point(4, 23);
            this.tpageIndicaciones.Name = "tpageIndicaciones";
            this.tpageIndicaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpageIndicaciones.Size = new System.Drawing.Size(508, 272);
            this.tpageIndicaciones.TabIndex = 2;
            this.tpageIndicaciones.Text = "Indicaciones";
            this.tpageIndicaciones.UseVisualStyleBackColor = true;
            // 
            // btQuitarIndicacion
            // 
            this.btQuitarIndicacion.Image = ((System.Drawing.Image)(resources.GetObject("btQuitarIndicacion.Image")));
            this.btQuitarIndicacion.Location = new System.Drawing.Point(232, 175);
            this.btQuitarIndicacion.Name = "btQuitarIndicacion";
            this.btQuitarIndicacion.Size = new System.Drawing.Size(47, 21);
            this.btQuitarIndicacion.TabIndex = 7;
            this.btQuitarIndicacion.UseVisualStyleBackColor = true;
            this.btQuitarIndicacion.Click += new System.EventHandler(this.btQuitarIndicacion_Click);
            // 
            // btAñadirIndicacion
            // 
            this.btAñadirIndicacion.Image = ((System.Drawing.Image)(resources.GetObject("btAñadirIndicacion.Image")));
            this.btAñadirIndicacion.Location = new System.Drawing.Point(232, 81);
            this.btAñadirIndicacion.Name = "btAñadirIndicacion";
            this.btAñadirIndicacion.Size = new System.Drawing.Size(47, 21);
            this.btAñadirIndicacion.TabIndex = 6;
            this.btAñadirIndicacion.UseVisualStyleBackColor = true;
            this.btAñadirIndicacion.Click += new System.EventHandler(this.btAñadirIndicacion_Click);
            // 
            // lboxTargetIndicacion
            // 
            this.lboxTargetIndicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lboxTargetIndicacion.FormattingEnabled = true;
            this.lboxTargetIndicacion.ItemHeight = 14;
            this.lboxTargetIndicacion.Location = new System.Drawing.Point(285, 35);
            this.lboxTargetIndicacion.Name = "lboxTargetIndicacion";
            this.lboxTargetIndicacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxTargetIndicacion.Size = new System.Drawing.Size(220, 228);
            this.lboxTargetIndicacion.TabIndex = 5;
            // 
            // lboxSourceIndicacion
            // 
            this.lboxSourceIndicacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lboxSourceIndicacion.FormattingEnabled = true;
            this.lboxSourceIndicacion.ItemHeight = 14;
            this.lboxSourceIndicacion.Location = new System.Drawing.Point(3, 35);
            this.lboxSourceIndicacion.Name = "lboxSourceIndicacion";
            this.lboxSourceIndicacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxSourceIndicacion.Size = new System.Drawing.Size(223, 228);
            this.lboxSourceIndicacion.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBuscarIndicacion);
            this.panel1.Controls.Add(this.txtBusquedaIndicacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 32);
            this.panel1.TabIndex = 8;
            // 
            // btBuscarIndicacion
            // 
            this.btBuscarIndicacion.Image = global::gesClinica.app.pc.Properties.Resources.search16x16;
            this.btBuscarIndicacion.Location = new System.Drawing.Point(450, 4);
            this.btBuscarIndicacion.Name = "btBuscarIndicacion";
            this.btBuscarIndicacion.Size = new System.Drawing.Size(47, 21);
            this.btBuscarIndicacion.TabIndex = 20;
            this.btBuscarIndicacion.UseVisualStyleBackColor = true;
            this.btBuscarIndicacion.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBusquedaIndicacion
            // 
            this.txtBusquedaIndicacion.ActivateStyle = true;
            this.txtBusquedaIndicacion.BackColor = System.Drawing.Color.LightYellow;
            this.txtBusquedaIndicacion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtBusquedaIndicacion.ColorLeave = System.Drawing.Color.White;
            this.txtBusquedaIndicacion.Location = new System.Drawing.Point(83, 4);
            this.txtBusquedaIndicacion.Name = "txtBusquedaIndicacion";
            this.txtBusquedaIndicacion.Size = new System.Drawing.Size(361, 22);
            this.txtBusquedaIndicacion.TabIndex = 18;
            this.txtBusquedaIndicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaIndicacion_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Descripcion";
            // 
            // tpageContraIndicaciones
            // 
            this.tpageContraIndicaciones.Controls.Add(this.btQuitarContraindicacion);
            this.tpageContraIndicaciones.Controls.Add(this.btAñadirContraindicacion);
            this.tpageContraIndicaciones.Controls.Add(this.lboxTargetContraindicacion);
            this.tpageContraIndicaciones.Controls.Add(this.lboxSourceContraindicacion);
            this.tpageContraIndicaciones.Controls.Add(this.panel2);
            this.tpageContraIndicaciones.Location = new System.Drawing.Point(4, 23);
            this.tpageContraIndicaciones.Name = "tpageContraIndicaciones";
            this.tpageContraIndicaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpageContraIndicaciones.Size = new System.Drawing.Size(508, 272);
            this.tpageContraIndicaciones.TabIndex = 3;
            this.tpageContraIndicaciones.Text = "Contraindicaciones";
            this.tpageContraIndicaciones.UseVisualStyleBackColor = true;
            // 
            // btQuitarContraindicacion
            // 
            this.btQuitarContraindicacion.Image = ((System.Drawing.Image)(resources.GetObject("btQuitarContraindicacion.Image")));
            this.btQuitarContraindicacion.Location = new System.Drawing.Point(232, 175);
            this.btQuitarContraindicacion.Name = "btQuitarContraindicacion";
            this.btQuitarContraindicacion.Size = new System.Drawing.Size(47, 21);
            this.btQuitarContraindicacion.TabIndex = 7;
            this.btQuitarContraindicacion.UseVisualStyleBackColor = true;
            this.btQuitarContraindicacion.Click += new System.EventHandler(this.btQuitarContraindicacion_Click);
            // 
            // btAñadirContraindicacion
            // 
            this.btAñadirContraindicacion.Image = ((System.Drawing.Image)(resources.GetObject("btAñadirContraindicacion.Image")));
            this.btAñadirContraindicacion.Location = new System.Drawing.Point(232, 77);
            this.btAñadirContraindicacion.Name = "btAñadirContraindicacion";
            this.btAñadirContraindicacion.Size = new System.Drawing.Size(47, 21);
            this.btAñadirContraindicacion.TabIndex = 6;
            this.btAñadirContraindicacion.UseVisualStyleBackColor = true;
            this.btAñadirContraindicacion.Click += new System.EventHandler(this.btAñadirContraindicacion_Click);
            // 
            // lboxTargetContraindicacion
            // 
            this.lboxTargetContraindicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lboxTargetContraindicacion.FormattingEnabled = true;
            this.lboxTargetContraindicacion.ItemHeight = 14;
            this.lboxTargetContraindicacion.Location = new System.Drawing.Point(285, 35);
            this.lboxTargetContraindicacion.Name = "lboxTargetContraindicacion";
            this.lboxTargetContraindicacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxTargetContraindicacion.Size = new System.Drawing.Size(220, 228);
            this.lboxTargetContraindicacion.TabIndex = 5;
            // 
            // lboxSourceContraindicacion
            // 
            this.lboxSourceContraindicacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lboxSourceContraindicacion.FormattingEnabled = true;
            this.lboxSourceContraindicacion.ItemHeight = 14;
            this.lboxSourceContraindicacion.Location = new System.Drawing.Point(3, 35);
            this.lboxSourceContraindicacion.Name = "lboxSourceContraindicacion";
            this.lboxSourceContraindicacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxSourceContraindicacion.Size = new System.Drawing.Size(223, 228);
            this.lboxSourceContraindicacion.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btBuscarContraIndicacion);
            this.panel2.Controls.Add(this.txtBusquedaContraIndicacion);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 32);
            this.panel2.TabIndex = 9;
            // 
            // btBuscarContraIndicacion
            // 
            this.btBuscarContraIndicacion.Image = global::gesClinica.app.pc.Properties.Resources.search16x16;
            this.btBuscarContraIndicacion.Location = new System.Drawing.Point(450, 4);
            this.btBuscarContraIndicacion.Name = "btBuscarContraIndicacion";
            this.btBuscarContraIndicacion.Size = new System.Drawing.Size(47, 21);
            this.btBuscarContraIndicacion.TabIndex = 20;
            this.btBuscarContraIndicacion.UseVisualStyleBackColor = true;
            this.btBuscarContraIndicacion.Click += new System.EventHandler(this.btBuscarContraIndicacion_Click);
            // 
            // txtBusquedaContraIndicacion
            // 
            this.txtBusquedaContraIndicacion.ActivateStyle = true;
            this.txtBusquedaContraIndicacion.BackColor = System.Drawing.Color.LightYellow;
            this.txtBusquedaContraIndicacion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtBusquedaContraIndicacion.ColorLeave = System.Drawing.Color.White;
            this.txtBusquedaContraIndicacion.Location = new System.Drawing.Point(83, 4);
            this.txtBusquedaContraIndicacion.Name = "txtBusquedaContraIndicacion";
            this.txtBusquedaContraIndicacion.Size = new System.Drawing.Size(361, 22);
            this.txtBusquedaContraIndicacion.TabIndex = 18;
            this.txtBusquedaContraIndicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaContraIndicacion_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Descripcion";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 342);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdit";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmproductoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            this.tpageIndicaciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpageContraIndicaciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmproductoEdit_Load(object sender, EventArgs e)
        {

            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
        }

        private void btAñadirIndicacion_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
                ctrl.moverItems(ref lboxSourceIndicacion, ref lboxTargetIndicacion);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btQuitarIndicacion_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
                ctrl.moverItems(ref lboxTargetIndicacion, ref lboxSourceIndicacion);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btAñadirContraindicacion_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
                ctrl.moverItems(ref lboxSourceContraindicacion, ref lboxTargetContraindicacion);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btQuitarContraindicacion_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.producto.ctrl.ctrlEdit();
                ctrl.moverItems(ref lboxTargetContraindicacion, ref lboxSourceContraindicacion);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtPrecio.Text))
                {
                    float precio;
                    if (!float.TryParse(this.txtPrecio.Text, out precio))
                    {
                        e.Cancel = true;
                        template._common.messages.ShowWarning("Formato numérico incorrecto.", "Validación");
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtPrecio.Text))
                    this.txtPrecio.Text = "0";
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
                string text = this.txtBusquedaIndicacion.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    this.lboxSourceIndicacion.SelectedItems.Clear();
                    foreach (Object item in this.lboxSourceIndicacion.Items)
                    {
                        lib.vo.Indicacion indicacion = (lib.vo.Indicacion)item;
                        if (indicacion.Descripcion.ToUpper().Contains(text.ToUpper()))
                        {
                            this.lboxSourceIndicacion.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtBusquedaIndicacion_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                    btBuscar_Click(sender, null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtBusquedaContraIndicacion_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                    btBuscarContraIndicacion_Click(sender, null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btBuscarContraIndicacion_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.txtBusquedaContraIndicacion.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    this.lboxSourceContraindicacion.SelectedItems.Clear();
                    foreach (Object item in this.lboxSourceContraindicacion.Items)
                    {
                        lib.vo.Indicacion indicacion = (lib.vo.Indicacion)item;
                        if (indicacion.Descripcion.ToUpper().Contains(text.ToUpper()))
                        {
                            this.lboxSourceContraindicacion.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
