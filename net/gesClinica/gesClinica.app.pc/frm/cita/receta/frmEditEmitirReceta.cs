using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta
{
    class frmEditEmitirReceta: template.frm.edicion.EditForm
    {
        internal System.Windows.Forms.Button btImprimir;
        internal System.Windows.Forms.GroupBox gboxReceta;
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        internal System.Windows.Forms.GroupBox gboxMedicamentos;

        internal recetadetalle.frmQuery _frmDetalle;

        public frmEditEmitirReceta(Cita cita)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.cita.receta.recetadetalle.frmQuery();

            ctrl.ctrlEditEmitirReceta ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEditEmitirReceta();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Receta(cita));
        }
        public frmEditEmitirReceta(Receta objVO)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.cita.receta.recetadetalle.frmQuery();

            ctrl.ctrlEditEmitirReceta ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEditEmitirReceta();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEditEmitirReceta(Receta objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            _frmDetalle = new gesClinica.app.pc.frm.cita.receta.recetadetalle.frmQuery(this.OnlyView);

            ctrl.ctrlEditEmitirReceta ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEditEmitirReceta();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditEmitirReceta ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlEditEmitirReceta();
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.gboxReceta = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new repsol.forms.controls.TextBoxColor();
            this.gboxMedicamentos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.gboxReceta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(603, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(684, 11);
            // 
            // panFooter
            // 
            this.panFooter.Controls.Add(this.btImprimir);
            this.panFooter.Location = new System.Drawing.Point(0, 522);
            this.panFooter.Size = new System.Drawing.Size(762, 43);
            this.panFooter.TabIndex = 2;
            this.panFooter.Controls.SetChildIndex(this.btCancelar, 0);
            this.panFooter.Controls.SetChildIndex(this.chkCerrar, 0);
            this.panFooter.Controls.SetChildIndex(this.btAceptar, 0);
            this.panFooter.Controls.SetChildIndex(this.btImprimir, 0);
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btImprimir.Location = new System.Drawing.Point(15, 10);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(97, 25);
            this.btImprimir.TabIndex = 8;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // gboxReceta
            // 
            this.gboxReceta.Controls.Add(this.txtObservaciones);
            this.gboxReceta.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxReceta.Location = new System.Drawing.Point(0, 0);
            this.gboxReceta.Name = "gboxReceta";
            this.gboxReceta.Size = new System.Drawing.Size(762, 179);
            this.gboxReceta.TabIndex = 0;
            this.gboxReceta.TabStop = false;
            this.gboxReceta.Text = "Receta (Texto Libre)";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Location = new System.Drawing.Point(3, 18);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(756, 158);
            this.txtObservaciones.TabIndex = 0;
            // 
            // gboxMedicamentos
            // 
            this.gboxMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxMedicamentos.Location = new System.Drawing.Point(0, 179);
            this.gboxMedicamentos.Name = "gboxMedicamentos";
            this.gboxMedicamentos.Size = new System.Drawing.Size(762, 343);
            this.gboxMedicamentos.TabIndex = 1;
            this.gboxMedicamentos.TabStop = false;
            this.gboxMedicamentos.Text = "Medicamentos";
            // 
            // frmEditEmitirReceta
            // 
            this.ClientSize = new System.Drawing.Size(762, 565);
            this.Controls.Add(this.gboxMedicamentos);
            this.Controls.Add(this.gboxReceta);
            this.Name = "frmEditEmitirReceta";
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.frmrecetaEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.gboxReceta, 0);
            this.Controls.SetChildIndex(this.gboxMedicamentos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.gboxReceta.ResumeLayout(false);
            this.gboxReceta.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmrecetaEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Receta";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.receta.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}

                //frmPrint vVen = new frmPrint((lib.vo.Receta)ctrl.getRegistroSeleccionado(ref frm));
                frmPrint vVen = new frmPrint((lib.vo.Receta)this.InnerVO);
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
