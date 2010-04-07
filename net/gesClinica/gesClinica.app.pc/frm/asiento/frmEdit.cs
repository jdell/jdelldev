using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridView dgApuntes;
        internal System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label2;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Asiento());
        }
        public frmEdit(Asiento objVO)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Asiento objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEdit();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgApuntes = new System.Windows.Forms.DataGridView();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgApuntes)).BeginInit();
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
            this.panFooter.Location = new System.Drawing.Point(0, 425);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ActivateStyle = true;
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtObservaciones.ColorLeave = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(114, 59);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(362, 22);
            this.txtObservaciones.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 113);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgApuntes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 312);
            this.panel2.TabIndex = 21;
            // 
            // dgApuntes
            // 
            this.dgApuntes.AllowUserToAddRows = false;
            this.dgApuntes.AllowUserToDeleteRows = false;
            this.dgApuntes.AllowUserToResizeColumns = false;
            this.dgApuntes.AllowUserToResizeRows = false;
            this.dgApuntes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgApuntes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgApuntes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApuntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgApuntes.Location = new System.Drawing.Point(0, 0);
            this.dgApuntes.Name = "dgApuntes";
            this.dgApuntes.ReadOnly = true;
            this.dgApuntes.RowHeadersVisible = false;
            this.dgApuntes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgApuntes.Size = new System.Drawing.Size(516, 312);
            this.dgApuntes.TabIndex = 2;
            this.dgApuntes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgApuntes_DataError);
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(114, 30);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(114, 22);
            this.dateFecha.TabIndex = 20;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEdit";
            this.Text = "Asiento";
            this.Load += new System.EventHandler(this.frmasientoEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgApuntes)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmasientoEdit_Load(object sender, EventArgs e)
        {

        }

        private void dgApuntes_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlEdit();
                frmEdit edit = (frmEdit)this;
                string msg = "";
                e.Cancel = ctrl.dataError(ref edit,e, out msg);
                if (e.Cancel) template._common.messages.ShowWarning(msg,this.Text);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
