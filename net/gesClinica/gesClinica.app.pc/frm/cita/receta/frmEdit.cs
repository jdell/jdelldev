using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReceta;
        internal System.Windows.Forms.TabPage tabDetalleReceta;

        internal recetadetalle.frmQuery _frmDetalle;

        public frmEdit()
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.cita.receta.recetadetalle.frmQuery();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Receta());
        }
        public frmEdit(Receta objVO)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.cita.receta.recetadetalle.frmQuery();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Receta objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.cita.receta.recetadetalle.frmQuery(this.OnlyView);

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEdit();
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
            this.txtObservaciones = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReceta = new System.Windows.Forms.TabPage();
            this.tabDetalleReceta = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btAceptar.Location = new System.Drawing.Point(349, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCancelar.Location = new System.Drawing.Point(429, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 276);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 4;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(11, 20);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(489, 223);
            this.txtObservaciones.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Receta";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReceta);
            this.tabControl1.Controls.Add(this.tabDetalleReceta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 276);
            this.tabControl1.TabIndex = 30;
            // 
            // tabReceta
            // 
            this.tabReceta.Controls.Add(this.txtObservaciones);
            this.tabReceta.Controls.Add(this.label3);
            this.tabReceta.Location = new System.Drawing.Point(4, 23);
            this.tabReceta.Name = "tabReceta";
            this.tabReceta.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceta.Size = new System.Drawing.Size(508, 249);
            this.tabReceta.TabIndex = 0;
            this.tabReceta.Text = "General";
            this.tabReceta.UseVisualStyleBackColor = true;
            // 
            // tabDetalleReceta
            // 
            this.tabDetalleReceta.Location = new System.Drawing.Point(4, 23);
            this.tabDetalleReceta.Name = "tabDetalleReceta";
            this.tabDetalleReceta.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleReceta.Size = new System.Drawing.Size(508, 249);
            this.tabDetalleReceta.TabIndex = 1;
            this.tabDetalleReceta.Text = "Medicamentos";
            this.tabDetalleReceta.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 319);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEdit";
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.frmrecetaEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabReceta.ResumeLayout(false);
            this.tabReceta.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmrecetaEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
