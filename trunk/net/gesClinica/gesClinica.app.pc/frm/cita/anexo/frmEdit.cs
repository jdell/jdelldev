using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.anexo
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtTitulo;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVerFichero;
        internal repsol.forms.controls.TextBoxColor txtRuta;
        private System.Windows.Forms.Button btBuscarFichero;
        private System.Windows.Forms.Button btGuardarFichero;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.anexo.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Anexo());
        }
        public frmEdit(Anexo objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.anexo.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Anexo objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.btBuscarFichero.Enabled = !this.OnlyView;

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.anexo.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.anexo.ctrl.ctrlEdit();
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
            this.txtTitulo = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.btVerFichero = new System.Windows.Forms.Button();
            this.txtRuta = new repsol.forms.controls.TextBoxColor();
            this.btBuscarFichero = new System.Windows.Forms.Button();
            this.btGuardarFichero = new System.Windows.Forms.Button();
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
            this.panFooter.Location = new System.Drawing.Point(0, 214);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtTitulo
            // 
            this.txtTitulo.ActivateStyle = true;
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTitulo.ColorLeave = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(98, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(406, 22);
            this.txtTitulo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ruta";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(98, 91);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(406, 107);
            this.txtDescripcion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripción";
            // 
            // btVerFichero
            // 
            this.btVerFichero.Image = ((System.Drawing.Image)(resources.GetObject("btVerFichero.Image")));
            this.btVerFichero.Location = new System.Drawing.Point(436, 63);
            this.btVerFichero.Name = "btVerFichero";
            this.btVerFichero.Size = new System.Drawing.Size(31, 22);
            this.btVerFichero.TabIndex = 23;
            this.btVerFichero.UseVisualStyleBackColor = true;
            this.btVerFichero.Click += new System.EventHandler(this.btVerFichero_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.ActivateStyle = false;
            this.txtRuta.BackColor = System.Drawing.SystemColors.Control;
            this.txtRuta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtRuta.ColorLeave = System.Drawing.Color.White;
            this.txtRuta.Location = new System.Drawing.Point(98, 63);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(295, 22);
            this.txtRuta.TabIndex = 22;
            this.txtRuta.TabStop = false;
            // 
            // btBuscarFichero
            // 
            this.btBuscarFichero.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarFichero.Image")));
            this.btBuscarFichero.Location = new System.Drawing.Point(399, 62);
            this.btBuscarFichero.Name = "btBuscarFichero";
            this.btBuscarFichero.Size = new System.Drawing.Size(31, 22);
            this.btBuscarFichero.TabIndex = 24;
            this.btBuscarFichero.UseVisualStyleBackColor = true;
            this.btBuscarFichero.Click += new System.EventHandler(this.btBuscarFichero_Click);
            // 
            // btGuardarFichero
            // 
            this.btGuardarFichero.Image = ((System.Drawing.Image)(resources.GetObject("btGuardarFichero.Image")));
            this.btGuardarFichero.Location = new System.Drawing.Point(473, 62);
            this.btGuardarFichero.Name = "btGuardarFichero";
            this.btGuardarFichero.Size = new System.Drawing.Size(31, 22);
            this.btGuardarFichero.TabIndex = 25;
            this.btGuardarFichero.UseVisualStyleBackColor = true;
            this.btGuardarFichero.Click += new System.EventHandler(this.btGuardarFichero_Click);
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.btGuardarFichero);
            this.Controls.Add(this.btBuscarFichero);
            this.Controls.Add(this.btVerFichero);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Componentes del Cita";
            this.Load += new System.EventHandler(this.frmanexoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTitulo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.txtRuta, 0);
            this.Controls.SetChildIndex(this.btVerFichero, 0);
            this.Controls.SetChildIndex(this.btBuscarFichero, 0);
            this.Controls.SetChildIndex(this.btGuardarFichero, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmanexoEdit_Load(object sender, EventArgs e)
        {

        }

        private void btBuscarFichero_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog fopen = new System.Windows.Forms.OpenFileDialog();
                fopen.RestoreDirectory = true;
                fopen.Filter = "Todos los archivos (*.*)| *.*";
                if (fopen.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtRuta.Text = fopen.FileName;
                    if (string.IsNullOrEmpty(this.txtTitulo.Text)) this.txtTitulo.Text = this.txtRuta.Text;
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btVerFichero_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.anexo.ctrl.ctrlEdit();
                frmEdit frm = (frmEdit)this;
                ctrl.verAnexo(frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btGuardarFichero_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.anexo.ctrl.ctrlEdit();
                frmEdit frm = (frmEdit)this;
                ctrl.guardarAnexo(frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
