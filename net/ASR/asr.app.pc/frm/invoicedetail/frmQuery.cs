using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.invoicedetail
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        private System.Windows.Forms.Label label2;
    
        public frmQuery()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.panInfo.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panDetail
            // 
            this.panDetail.Location = new System.Drawing.Point(0, 152);
            this.panDetail.Size = new System.Drawing.Size(792, 421);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(0, 127);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.txtDescripcion);
            this.panHead.Controls.Add(this.label2);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(170, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(362, 20);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Description";
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Movements";
            this.Load += new System.EventHandler(this.frminvoicedetailQry_Load);
            this.Controls.SetChildIndex(this.panHead, 0);
            this.Controls.SetChildIndex(this.panInfo, 0);
            this.Controls.SetChildIndex(this.panDetail, 0);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void btNuevo_record()
        {
            try
            {
                invoice.frmEdit vVen = new invoice.frmEdit();
                vVen.ShowDialog();
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btModificar_record()
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                lib.vo.InvoiceDetail invd = (InvoiceDetail)ctrl.getRegistroSeleccionado(ref frm);
                if (invd.Invoice.Income)
                {
                    invoice.frmEdit vVen = new invoice.frmEdit(invd, false);
                    vVen.ShowDialog();
                }
                else
                {
                    expense.frmEdit vVen = new expense.frmEdit(invd, false);
                    vVen.ShowDialog();
                }

                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btConsulta_record()
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                lib.vo.InvoiceDetail invd = (InvoiceDetail)ctrl.getRegistroSeleccionado(ref frm);
                if (invd.Invoice.Income)
                {
                    invoice.frmEdit vVen = new invoice.frmEdit(invd, false);
                    vVen.ShowDialog();
                }
                else
                {
                    expense.frmEdit vVen = new expense.frmEdit(invd, false);
                    vVen.ShowDialog();
                }

                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btDuplicar_record()
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                lib.vo.InvoiceDetail invd = (InvoiceDetail)ctrl.getRegistroSeleccionado(ref frm);
                if (invd.Invoice.Income)
                {
                    invoice.frmEdit vVen = new invoice.frmEdit(invd, false);
                    vVen.ShowDialog();
                }
                else
                {
                    expense.frmEdit vVen = new expense.frmEdit(invd, false);
                    vVen.ShowDialog();
                }

                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btBorrar_record()
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if ((bool)ctrl.BorrarRegistro(ref frm))
                        btRefresh_record();
                    else
                        template._common.messages.ShowWarning(_common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public override void btRefresh_record()
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
                this.txtDescripcion.Focus();
            }
            catch (Exception ex)
            {
                //template._common.messages.ShowError(ex);
                this.setError(ex.Message);
            }

        }
        protected override void btSeleccionar_record()
        {
            try
            {
                //ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                //repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                //if (ctrl.getRegistroSeleccionado(ref frm) == null)
                //{
                //    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                //    return;
                //}
                //this.SetSeletectedVO(ctrl.getRegistroSeleccionado(ref frm));

                //base.btSeleccionar_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frminvoicedetailQry_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                this.txtDescripcion.Focus();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void filtrar_Handler(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.invoicedetail.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
