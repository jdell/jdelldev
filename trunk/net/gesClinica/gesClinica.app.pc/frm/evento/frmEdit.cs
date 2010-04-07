using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.evento
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.NumericUpDown txtDuracion;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.CheckBox chkPublico;
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbEstadoEvento;
        private System.Windows.Forms.Label label3;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.evento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Evento());
        }
        public frmEdit(DateTime fecha)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.evento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Evento());

            this.dateFecha.Value = fecha;
        }
        public frmEdit(DateTime fecha, Sala sala)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.evento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Evento());

            this.dateFecha.Value = fecha;
            if (sala != null) this.cmbSala.SelectedValue = sala.ID;
        }
        public frmEdit(Evento objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.evento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Evento objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();
            
            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.evento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.evento.ctrl.ctrlEdit();
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
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chkPublico = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstadoEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(336, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(416, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 309);
            this.panFooter.Size = new System.Drawing.Size(503, 43);
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(96, 37);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtDuracion.Location = new System.Drawing.Point(96, 232);
            this.txtDuracion.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(120, 22);
            this.txtDuracion.TabIndex = 32;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDuracion.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 33;
            this.label7.Text = "Duración";
            // 
            // chkPublico
            // 
            this.chkPublico.AutoSize = true;
            this.chkPublico.Location = new System.Drawing.Point(408, 40);
            this.chkPublico.Name = "chkPublico";
            this.chkPublico.Size = new System.Drawing.Size(64, 18);
            this.chkPublico.TabIndex = 34;
            this.chkPublico.Text = "Público";
            this.chkPublico.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(96, 120);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(376, 106);
            this.txtDescripcion.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Propietario";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(96, 64);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpleado.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sala";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(96, 92);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(376, 22);
            this.cmbSala.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 42;
            this.label6.Text = "Estado";
            // 
            // cmbEstadoEvento
            // 
            this.cmbEstadoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEvento.FormattingEnabled = true;
            this.cmbEstadoEvento.Location = new System.Drawing.Point(96, 260);
            this.cmbEstadoEvento.Name = "cmbEstadoEvento";
            this.cmbEstadoEvento.Size = new System.Drawing.Size(376, 22);
            this.cmbEstadoEvento.TabIndex = 41;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(503, 352);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEstadoEvento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPublico);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFecha);
            this.Name = "frmEdit";
            this.Text = "Evento";
            this.Controls.SetChildIndex(this.dateFecha, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.chkPublico, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cmbEmpleado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbSala, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbEstadoEvento, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
