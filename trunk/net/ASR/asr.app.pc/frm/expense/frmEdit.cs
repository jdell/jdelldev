using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm.expense
{
    class frmEdit:template.frm.edicion.EditForm
    {
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.DateTimePicker dtpDate;
        protected internal System.Windows.Forms.DataGridView dgDetail;
        internal repsol.forms.controls.TextBoxColor txtComments;
        private System.Windows.Forms.Label label3;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new lib.vo.Invoice());
        }
        public frmEdit(lib.vo.InvoiceDetail invoiceDetail)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            lib.bl.invoice.doGet doget = new asr.lib.bl.invoice.doGet(invoiceDetail.Invoice);
            invoiceDetail.Invoice = (lib.vo.Invoice)doget.execute();
            ctrl.cargarDatos(ref edit, invoiceDetail.Invoice);
        }
        public frmEdit(lib.vo.InvoiceDetail invoiceDetail, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            lib.bl.invoice.doGet doget = new asr.lib.bl.invoice.doGet(invoiceDetail.Invoice);
            invoiceDetail.Invoice = (lib.vo.Invoice)doget.execute();
            ctrl.cargarDatos(ref edit, invoiceDetail.Invoice);
        }

        public frmEdit(lib.vo.Invoice invoice)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, invoice);
        }
        public frmEdit(lib.vo.Invoice invoice, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, invoice);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                base.btAceptar_Click(sender, e);

                //lib.bl._reports.invoice.rptInvoice informe = new asr.lib.bl._reports.invoice.rptInvoice((lib.vo.Invoice)this.InnerVO);
                //template.frm.impresion.PrintForm vVen = new asr.app.pc.template.frm.impresion.PrintForm();
                //Microsoft.Reporting.WinForms.ReportViewer viewer = vVen.viewer;
                //informe.setInformeViewer(ref viewer);
                //vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgDetail = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtComments = new repsol.forms.controls.TextBoxColor();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 537);
            this.panFooter.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // dgDetail
            // 
            this.dgDetail.AllowUserToResizeColumns = false;
            this.dgDetail.AllowUserToResizeRows = false;
            this.dgDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetail.Location = new System.Drawing.Point(3, 18);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.RowHeadersVisible = false;
            this.dgDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetail.Size = new System.Drawing.Size(464, 190);
            this.dgDetail.TabIndex = 0;
            this.dgDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetail_CellValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtComments);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpDate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 122);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General";
            // 
            // txtComments
            // 
            this.txtComments.ActivateStyle = true;
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtComments.ColorLeave = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(84, 59);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(337, 52);
            this.txtComments.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 57;
            this.label3.Text = "Comment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 14);
            this.label11.TabIndex = 54;
            this.label11.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(84, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(98, 22);
            this.dtpDate.TabIndex = 2;
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(470, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmEdit";
            this.Text = "Expense";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.panFooter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.expense.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.loadService(ref frm);
                calcTotal();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void calcTotal()
        {
            try
            {
                Single price = 0;
                Single stateFee = 0;
                Single units = 0;

                //Single.TryParse(this.txtPrice.Text, out price);
                //Single.TryParse(this.txtStateFee.Text, out stateFee);
                //Single.TryParse(this.txtUnits.Value.ToString(), out units);

                //Single total = (price + stateFee )* units;

                //this.txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtUnits_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;
                if (String.IsNullOrEmpty(txt.Text))
                    txt.Text = "0";

                calcTotal();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

                Single numeric = 0;
                e.Cancel = !Single.TryParse(txt.Text, out numeric);
                if (e.Cancel) template._common.messages.ShowWarning("Incorrect format!", this.Text);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgDetail_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                    if (dgv.Columns["Service"] == dgv.Columns[e.ColumnIndex])
                    {
                        lib.vo.Service service = new asr.lib.vo.Service();
                        service.ID = (Int32)dgv[e.ColumnIndex, e.RowIndex].Value;
                        lib.bl.service.doGet doGet = new asr.lib.bl.service.doGet(service);
                        service = (lib.vo.Service)doGet.execute();

                        dgv["Price", e.RowIndex].Value = service.Price;
                        dgv["StateFee", e.RowIndex].Value = service.StateFee;
                        dgv["Amount", e.RowIndex].Value = 1;
                    }
                    if ((!Convert.IsDBNull(dgv["Price",e.RowIndex].Value))
                        &&
                        (!Convert.IsDBNull(dgv["StateFee",e.RowIndex].Value))
                        &&
                        (!Convert.IsDBNull(dgv["Amount",e.RowIndex].Value)))
                            dgv["Total", e.RowIndex].Value = (Convert.ToSingle(dgv["Price", e.RowIndex].Value) + Convert.ToSingle(dgv["StateFee", e.RowIndex].Value)) * Convert.ToSingle(dgv["Amount", e.RowIndex].Value);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
