using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.sala
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        internal System.Windows.Forms.PictureBox picColorSample;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbColor;
        internal System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sala.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Sala());
        }
        public frmEdit(Sala objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sala.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Sala objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sala.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.sala.ctrl.ctrlEdit();
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
            this.picColorSample = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.chkActiva = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample)).BeginInit();
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
            this.panFooter.Location = new System.Drawing.Point(0, 109);
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
            this.txtDescripcion.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // picColorSample
            // 
            this.picColorSample.Location = new System.Drawing.Point(419, 75);
            this.picColorSample.Name = "picColorSample";
            this.picColorSample.Size = new System.Drawing.Size(51, 22);
            this.picColorSample.TabIndex = 31;
            this.picColorSample.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(108, 75);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(305, 23);
            this.cmbColor.TabIndex = 29;
            this.cmbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbColor_DrawItem);
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActiva.Location = new System.Drawing.Point(411, 23);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(59, 18);
            this.chkActiva.TabIndex = 36;
            this.chkActiva.Text = "Activa";
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 152);
            this.Controls.Add(this.chkActiva);
            this.Controls.Add(this.picColorSample);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.frmsalaEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cmbColor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.picColorSample, 0);
            this.Controls.SetChildIndex(this.chkActiva, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmsalaEdit_Load(object sender, EventArgs e)
        {

        }

        private void cmbColor_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;

                e.Graphics.DrawImage(repsol.util.image.CreateImage(16, e.Bounds.Height - 2, System.Drawing.Color.FromName(cmb.Items[e.Index].ToString())), e.Bounds.Left, e.Bounds.Top + 1);

                bool estado =
                    (e.State == (System.Windows.Forms.DrawItemState.Selected | System.Windows.Forms.DrawItemState.Focus | System.Windows.Forms.DrawItemState.NoAccelerator | System.Windows.Forms.DrawItemState.NoFocusRect))
                    ||
                    (e.State == (System.Windows.Forms.DrawItemState.Selected | System.Windows.Forms.DrawItemState.Focus | System.Windows.Forms.DrawItemState.NoAccelerator | System.Windows.Forms.DrawItemState.NoFocusRect | System.Windows.Forms.DrawItemState.ComboBoxEdit));
                e.Graphics.DrawString(cmb.Items[e.Index].ToString(), cmb.Font, new System.Drawing.SolidBrush(estado ? cmb.BackColor : cmb.ForeColor), e.Bounds.Left + 16, e.Bounds.Top);
            }
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbColor.SelectedItem != null)
                    this.picColorSample.Image = repsol.util.image.CreateImage(this.picColorSample.Width, this.picColorSample.Height, System.Drawing.Color.FromName(this.cmbColor.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
