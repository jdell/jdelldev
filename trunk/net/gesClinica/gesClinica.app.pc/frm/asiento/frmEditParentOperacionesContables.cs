using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEditParentOperacionesContables : frmEditParent
    {
        protected internal System.Windows.Forms.Label labLabelDos;
        protected internal System.Windows.Forms.ComboBox cmbSubcuentaDebe;
        protected internal System.Windows.Forms.Label labLabelUno;
        protected internal System.Windows.Forms.ComboBox cmbSubcuentaHaber;
        protected internal System.Windows.Forms.Label label1;
        protected internal repsol.forms.controls.TextBoxColor txtConcepto;
        protected internal System.Windows.Forms.Label label2;
        protected internal repsol.forms.controls.TextBoxColor txtImporte;
        protected internal System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.DateTimePicker dateFecha;
    
        public frmEditParentOperacionesContables()
            : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labLabelDos = new System.Windows.Forms.Label();
            this.cmbSubcuentaDebe = new System.Windows.Forms.ComboBox();
            this.labLabelUno = new System.Windows.Forms.Label();
            this.cmbSubcuentaHaber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtConcepto = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporte = new repsol.forms.controls.TextBoxColor();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(280, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(360, 11);
            // 
            // panFooter
            // 
            this.panFooter.Size = new System.Drawing.Size(447, 43);
            // 
            // labLabelDos
            // 
            this.labLabelDos.AutoSize = true;
            this.labLabelDos.Location = new System.Drawing.Point(16, 113);
            this.labLabelDos.Name = "labLabelDos";
            this.labLabelDos.Size = new System.Drawing.Size(44, 14);
            this.labLabelDos.TabIndex = 59;
            this.labLabelDos.Text = "Cliente";
            // 
            // cmbSubcuentaDebe
            // 
            this.cmbSubcuentaDebe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubcuentaDebe.FormattingEnabled = true;
            this.cmbSubcuentaDebe.Location = new System.Drawing.Point(90, 110);
            this.cmbSubcuentaDebe.Name = "cmbSubcuentaDebe";
            this.cmbSubcuentaDebe.Size = new System.Drawing.Size(335, 22);
            this.cmbSubcuentaDebe.TabIndex = 56;
            // 
            // labLabelUno
            // 
            this.labLabelUno.AutoSize = true;
            this.labLabelUno.Location = new System.Drawing.Point(16, 85);
            this.labLabelUno.Name = "labLabelUno";
            this.labLabelUno.Size = new System.Drawing.Size(48, 14);
            this.labLabelUno.TabIndex = 58;
            this.labLabelUno.Text = "Servicio";
            // 
            // cmbSubcuentaHaber
            // 
            this.cmbSubcuentaHaber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubcuentaHaber.FormattingEnabled = true;
            this.cmbSubcuentaHaber.Location = new System.Drawing.Point(90, 82);
            this.cmbSubcuentaHaber.Name = "cmbSubcuentaHaber";
            this.cmbSubcuentaHaber.Size = new System.Drawing.Size(335, 22);
            this.cmbSubcuentaHaber.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "Fecha";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(90, 54);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 22);
            this.dateFecha.TabIndex = 54;
            // 
            // txtConcepto
            // 
            this.txtConcepto.ActivateStyle = true;
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtConcepto.ColorLeave = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(90, 138);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(335, 22);
            this.txtConcepto.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 61;
            this.label2.Text = "Concepto";
            // 
            // txtImporte
            // 
            this.txtImporte.ActivateStyle = true;
            this.txtImporte.BackColor = System.Drawing.Color.White;
            this.txtImporte.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtImporte.ColorLeave = System.Drawing.Color.White;
            this.txtImporte.Location = new System.Drawing.Point(322, 54);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(103, 22);
            this.txtImporte.TabIndex = 62;
            this.txtImporte.Text = "0";
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.Validated += new System.EventHandler(this.txtImporte_Validated);
            this.txtImporte.Validating += new System.ComponentModel.CancelEventHandler(this.txtImporte_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 63;
            this.label5.Text = "Importe";
            // 
            // frmEditParentOperacionesContables
            // 
            this.ClientSize = new System.Drawing.Size(447, 241);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labLabelDos);
            this.Controls.Add(this.cmbSubcuentaDebe);
            this.Controls.Add(this.labLabelUno);
            this.Controls.Add(this.cmbSubcuentaHaber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFecha);
            this.Name = "frmEditParentOperacionesContables";
            this.Text = "Asiento - Nuevo registro";
            this.Load += new EventHandler(frmEditParentOperacionesContables_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.dateFecha, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmbSubcuentaHaber, 0);
            this.Controls.SetChildIndex(this.labLabelUno, 0);
            this.Controls.SetChildIndex(this.cmbSubcuentaDebe, 0);
            this.Controls.SetChildIndex(this.labLabelDos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtConcepto, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void frmEditParentOperacionesContables_Load(object sender, EventArgs e)
        {

            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);

            this.cmbSubcuentaDebe.SelectedIndexChanged += new EventHandler(algoCambio);
            this.cmbSubcuentaHaber.SelectedIndexChanged += new EventHandler(algoCambio);


            this.txtImporte.LostFocus += new EventHandler(lostFocus);
            this.txtConcepto.LostFocus +=new EventHandler(lostFocus);
            this.dateFecha.ValueChanged += new EventHandler(dateFecha_ValueChanged);
        }

        void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            habilitarAcepta();
        }

        protected void lostFocus(object sender, EventArgs e)
        {
            habilitarAcepta();
        }

        private void txtImporte_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (String.IsNullOrEmpty(textBox.Text))
                    textBox.Text = "0";
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtImporte_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                if (!String.IsNullOrEmpty(textBox.Text))
                {
                    float importe;
                    if (!float.TryParse(textBox.Text, out importe))
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
    }
}
