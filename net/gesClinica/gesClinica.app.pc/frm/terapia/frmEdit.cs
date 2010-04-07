using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.terapia
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtPrecio;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.NumericUpDown txtDuracion;
        internal System.Windows.Forms.CheckBox chkActivo;
        internal repsol.forms.controls.TextBoxColor txtSubCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbTipoTerapia;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Terapia());
        }
        public frmEdit(Terapia objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Terapia objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.terapia.ctrl.ctrlEdit();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.NumericUpDown();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtSubCuenta = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoTerapia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(441, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(521, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 189);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(108, 47);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(362, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Duración";
            // 
            // txtPrecio
            // 
            this.txtPrecio.ActivateStyle = true;
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtPrecio.ColorLeave = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(349, 75);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 22);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.Validated += new System.EventHandler(this.txtPrecio_Validated);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Precio (€)";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtDuracion.Location = new System.Drawing.Point(108, 75);
            this.txtDuracion.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(120, 22);
            this.txtDuracion.TabIndex = 1;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDuracion.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(394, 23);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(76, 18);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "En activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtSubCuenta
            // 
            this.txtSubCuenta.ActivateStyle = true;
            this.txtSubCuenta.BackColor = System.Drawing.Color.White;
            this.txtSubCuenta.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtSubCuenta.ColorLeave = System.Drawing.Color.White;
            this.txtSubCuenta.Location = new System.Drawing.Point(108, 103);
            this.txtSubCuenta.Name = "txtSubCuenta";
            this.txtSubCuenta.Size = new System.Drawing.Size(103, 22);
            this.txtSubCuenta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "SubCuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo";
            // 
            // cmbTipoTerapia
            // 
            this.cmbTipoTerapia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTerapia.FormattingEnabled = true;
            this.cmbTipoTerapia.Location = new System.Drawing.Point(108, 131);
            this.cmbTipoTerapia.Name = "cmbTipoTerapia";
            this.cmbTipoTerapia.Size = new System.Drawing.Size(376, 22);
            this.cmbTipoTerapia.TabIndex = 28;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 232);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoTerapia);
            this.Controls.Add(this.txtSubCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Actividad";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtDuracion, 0);
            this.Controls.SetChildIndex(this.chkActivo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSubCuenta, 0);
            this.Controls.SetChildIndex(this.cmbTipoTerapia, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void frmEdit_Load(object sender, EventArgs e)
        {

            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
        }
    }
}
